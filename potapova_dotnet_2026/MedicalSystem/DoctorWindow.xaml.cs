using Core.Models;
using System.Windows;

namespace MedicalSystem
{
    public partial class DoctorWindow : Window
    {
        public Doctor Doctor { get; set; }

        public DoctorWindow()
        {
            InitializeComponent();

            Doctor = new Doctor();
        }

        public DoctorWindow(Doctor doctor)
        {
            InitializeComponent();

            Doctor = doctor;

            NameTextBox.Text = doctor.Name;
            SpecializationTextBox.Text = doctor.Specialization;
            ExperienceTextBox.Text =
                doctor.ExperienceYears.ToString();

            RatingTextBox.Text =
                doctor.Rating.ToString();

            AvailableCheckBox.IsChecked =
                doctor.IsAvailable;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Doctor.Name = NameTextBox.Text;
            Doctor.Specialization =
                SpecializationTextBox.Text;

            Doctor.ExperienceYears =
                int.Parse(ExperienceTextBox.Text);

            Doctor.Rating =
                double.Parse(RatingTextBox.Text);

            Doctor.IsAvailable =
                AvailableCheckBox.IsChecked == true;

            DialogResult = true;
            Close();
        }
    }
}