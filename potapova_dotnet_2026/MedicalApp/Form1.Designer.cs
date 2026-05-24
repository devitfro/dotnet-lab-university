namespace MedicalApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            panelTop = new Panel();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 192);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.Info;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.Size = new Size(789, 559);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnAdd.Font = new Font("Times New Roman", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAdd.ForeColor = SystemColors.ControlDarkDark;
            btnAdd.Location = new Point(12, 13);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 50);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "додати";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Font = new Font("Times New Roman", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDelete.ForeColor = SystemColors.ControlDarkDark;
            btnDelete.Location = new Point(212, 13);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 50);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "видалити";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.BackColor = Color.FromArgb(192, 255, 255);
            btnSave.Font = new Font("Times New Roman", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSave.ForeColor = SystemColors.ControlDarkDark;
            btnSave.Location = new Point(409, 13);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 50);
            btnSave.TabIndex = 3;
            btnSave.Text = "зберегти";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(192, 192, 255);
            panelTop.Controls.Add(btnLoad);
            panelTop.Controls.Add(btnSave);
            panelTop.Controls.Add(btnAdd);
            panelTop.Controls.Add(btnDelete);
            panelTop.Dock = DockStyle.Bottom;
            panelTop.Location = new Point(0, 559);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(789, 75);
            panelTop.TabIndex = 4;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(255, 255, 192);
            btnLoad.Font = new Font("Times New Roman", 18.3396225F, FontStyle.Bold);
            btnLoad.ForeColor = SystemColors.ControlDarkDark;
            btnLoad.Location = new Point(589, 13);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(188, 50);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "завантажити";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 634);
            Controls.Add(dataGridView1);
            Controls.Add(panelTop);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSave;
        private Panel panelTop;
        private Button btnLoad;
    }
}
