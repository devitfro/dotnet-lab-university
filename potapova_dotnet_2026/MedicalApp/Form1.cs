using Core.Models;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;
using Core.Services;
using System.IO;

namespace MedicalApp
{
    public partial class Form1 : Form
    {
        private List<Doctor> doctors = new List<Doctor>();
        private BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            dataGridView1.BorderStyle = BorderStyle.None;

            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 192);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 224, 192);

            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridView1.RowTemplate.Height = 30;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 128, 255);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            LoadData();

            bs.DataSource = doctors;
            dataGridView1.DataSource = bs;

            dataGridView1.AutoGenerateColumns = true;
        }

        private void LoadData()
        {
            doctors.Add(new Doctor("Іваненко Іван", "Терапевт", 10, 4.5));
            doctors.Add(new Doctor("Петренко Ольга", "Кардіолог", 15, 4.8));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new DoctorForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                doctors.Add(form.Doctor);
                RefreshGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var doctor = (Doctor)dataGridView1.CurrentRow.DataBoundItem;

                var result = MessageBox.Show(
                    "Видалити лікаря?",
                    "Підтвердження",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    doctors.Remove(doctor);
                    RefreshGrid();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "JSON files (*.json)|*.json";
            saveFileDialog.Title = "Зберегти дані";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                JsonService.SaveToFile(doctors, saveFileDialog.FileName);

                MessageBox.Show("Дані збережено!");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "JSON files (*.json)|*.json";
            openFileDialog.Title = "Завантажити дані";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                doctors = JsonService.LoadFromFile<Doctor>(openFileDialog.FileName);

                RefreshGrid();

                MessageBox.Show("Дані завантажено!");
            }
        }

        private void RefreshGrid()
        {
            bs.ResetBindings(false);
            bs.DataSource = null;
            bs.DataSource = doctors;
        }
      
    }
}