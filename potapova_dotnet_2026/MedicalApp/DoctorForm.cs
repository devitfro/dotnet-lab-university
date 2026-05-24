using System;
using System.Windows.Forms;
using Core.Models;

namespace MedicalApp
{
    public partial class DoctorForm : Form
    {
        public Doctor Doctor { get; private set; }

        private readonly Doctor editingDoctor;

        public DoctorForm()
        {
            InitializeComponent();
        }

        public DoctorForm(Doctor doctor)
        {
            InitializeComponent();

            editingDoctor = doctor;

            txtName.Text = doctor.Name;
            txtSpec.Text = doctor.Specialization;
            numExp.Value = doctor.ExperienceYears;
            numRating.Value = (decimal)doctor.Rating;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text.Length < 2)
            {
                MessageBox.Show("Ім'я має бути мінімум 2 символи");
                return;
            }

            if (numRating.Value < 0 || numRating.Value > 5)
            {
                MessageBox.Show("Рейтинг має бути від 0 до 5");
                return;
            }

            if (editingDoctor == null)
            {
                Doctor = new Doctor(
                    txtName.Text,
                    txtSpec.Text,
                    (int)numExp.Value,
                    (double)numRating.Value
                );
            }
            else
            {
                editingDoctor.Name = txtName.Text;
                editingDoctor.Specialization = txtSpec.Text;
                editingDoctor.ExperienceYears = (int)numExp.Value;
                editingDoctor.Rating = (double)numRating.Value;

                Doctor = editingDoctor;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {

        }
    }
}