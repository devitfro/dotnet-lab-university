namespace MedicalApp
{
    partial class DoctorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtSpec = new TextBox();
            label1 = new Label();
            label2 = new Label();
            numExp = new NumericUpDown();
            numRating = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            btnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)numExp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Times New Roman", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtName.Location = new Point(74, 143);
            txtName.Name = "txtName";
            txtName.Size = new Size(375, 35);
            txtName.TabIndex = 0;
            // 
            // txtSpec
            // 
            txtSpec.Font = new Font("Times New Roman", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtSpec.Location = new Point(74, 236);
            txtSpec.Name = "txtSpec";
            txtSpec.Size = new Size(375, 35);
            txtSpec.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(74, 100);
            label1.Name = "label1";
            label1.Size = new Size(253, 31);
            label1.TabIndex = 2;
            label1.Text = "Введіть ім'я лікаря";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(74, 202);
            label2.Name = "label2";
            label2.Size = new Size(375, 31);
            label2.TabIndex = 3;
            label2.Text = "Введіть спеціалізацію лікаря";
            // 
            // numExp
            // 
            numExp.BackColor = Color.FromArgb(192, 192, 255);
            numExp.ForeColor = SystemColors.InfoText;
            numExp.Location = new Point(509, 143);
            numExp.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numExp.Name = "numExp";
            numExp.Size = new Size(132, 25);
            numExp.TabIndex = 4;
            // 
            // numRating
            // 
            numRating.BackColor = Color.FromArgb(192, 192, 255);
            numRating.ForeColor = SystemColors.InfoText;
            numRating.Location = new Point(509, 236);
            numRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numRating.Name = "numRating";
            numRating.Size = new Size(132, 25);
            numRating.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(509, 100);
            label3.Name = "label3";
            label3.Size = new Size(170, 31);
            label3.TabIndex = 6;
            label3.Text = "Стаж лікаря";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(509, 202);
            label4.Name = "label4";
            label4.Size = new Size(115, 31);
            label4.TabIndex = 7;
            label4.Text = "Рейтинг";
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(128, 128, 255);
            btnOk.Font = new Font("Times New Roman", 16.3018875F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnOk.ForeColor = SystemColors.ButtonHighlight;
            btnOk.Location = new Point(345, 344);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(104, 51);
            btnOk.TabIndex = 8;
            btnOk.Text = "ok";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnOk);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numRating);
            Controls.Add(numExp);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSpec);
            Controls.Add(txtName);
            Name = "DoctorForm";
            Text = "DoctorForm";
            Load += DoctorForm_Load;
            ((System.ComponentModel.ISupportInitialize)numExp).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtSpec;
        private Label label1;
        private Label label2;
        private NumericUpDown numExp;
        private NumericUpDown numRating;
        private Label label3;
        private Label label4;
        private Button btnOk;
    }
}