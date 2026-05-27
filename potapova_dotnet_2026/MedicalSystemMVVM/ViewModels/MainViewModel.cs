using Core.Models;
using MedicalSystemMVVM.Commands;
using MedicalSystemMVVM.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MedicalSystemMVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Doctor> Doctors
        {
            get;
            set;
        }

        private Doctor _selectedDoctor;

        public Doctor SelectedDoctor
        {
            get => _selectedDoctor;

            set
            {
                _selectedDoctor = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddDoctorCommand
        {
            get;
            set;
        }

        public ICommand DeleteDoctorCommand
        {
            get;
            set;
        }

        public MainViewModel()
        {
            Doctors = FileService.Load();

            if (Doctors.Count == 0)
            {
                Doctors.Add(new Doctor(
                    "Іваненко Іван",
                    "Терапевт",
                    10,
                    4.5)
                {
                    IsAvailable = true
                });

                Doctors.Add(new Doctor(
                    "Петренко Ольга",
                    "Кардіолог",
                    15,
                    4.8)
                {
                    IsAvailable = false
                });

                FileService.Save(Doctors);
            }

            AddDoctorCommand =
                new RelayCommand(AddDoctor);

            DeleteDoctorCommand =
                new RelayCommand(DeleteDoctor);
        }

        private void AddDoctor()
        {
            Doctors.Add(new Doctor(
                "Новий лікар",
                "Хірург",
                5,
                4.0)
            {
                IsAvailable = true
            });

            FileService.Save(Doctors);
        }

        private void DeleteDoctor()
        {
            if (SelectedDoctor != null)
            {
                Doctors.Remove(SelectedDoctor);

                FileService.Save(Doctors);
            }
        }
    }
}