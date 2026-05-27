using Core.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace MedicalSystem
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Doctor> doctors;

        public MainWindow()
        {
            InitializeComponent();

            doctors = new ObservableCollection<Doctor>();


            doctors.Add(new Doctor("Іваненко Іван", "Терапевт", 10, 4.5)
            {
                IsAvailable = true
            });

            doctors.Add(new Doctor("Петренко Ольга", "Кардіолог", 15, 4.8)
            {
                IsAvailable = false
            });

            DoctorsDataGrid.ItemsSource = doctors;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            DoctorWindow window = new DoctorWindow();

            if (window.ShowDialog() == true)
            {
                doctors.Add(window.Doctor);
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Doctor selectedDoctor =
                DoctorsDataGrid.SelectedItem as Doctor;

            if (selectedDoctor == null)
            {
                MessageBox.Show("Оберіть лікаря");
                return;
            }

            DoctorWindow window =
                new DoctorWindow(selectedDoctor);

            if (window.ShowDialog() == true)
            {
                DoctorsDataGrid.Items.Refresh();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Doctor selectedDoctor =
                DoctorsDataGrid.SelectedItem as Doctor;

            if (selectedDoctor != null)
            {
                doctors.Remove(selectedDoctor);
            }
        }
    }
}
