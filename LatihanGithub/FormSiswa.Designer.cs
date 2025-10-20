namespace LatihanGithub
{
    partial class FormSiswa
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
            txtAlamat = new Label();
            txtNIS = new Label();
            txtNama = new Label();
            btnSimpan = new Button();
            btnKembali = new Button();
            lblALamat = new TextBox();
            lblNIS = new TextBox();
            lblA = new TextBox();
            SuspendLayout();
            // 
            // txtAlamat
            // 
            txtAlamat.AutoSize = true;
            txtAlamat.Location = new Point(60, 160);
            txtAlamat.Margin = new Padding(2, 0, 2, 0);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(45, 15);
            txtAlamat.TabIndex = 1;
            txtAlamat.Text = "Alamat";
            // 
            // txtNIS
            // 
            txtNIS.AutoSize = true;
            txtNIS.Location = new Point(60, 89);
            txtNIS.Margin = new Padding(2, 0, 2, 0);
            txtNIS.Name = "txtNIS";
            txtNIS.Size = new Size(25, 15);
            txtNIS.TabIndex = 2;
            txtNIS.Text = "NIS";
            // 
            // txtNama
            // 
            txtNama.AutoSize = true;
            txtNama.Location = new Point(60, 127);
            txtNama.Margin = new Padding(2, 0, 2, 0);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(39, 15);
            txtNama.TabIndex = 3;
            txtNama.Text = "Nama";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(335, 217);
            btnSimpan.Margin = new Padding(2, 2, 2, 2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(78, 20);
            btnSimpan.TabIndex = 4;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(113, 217);
            btnKembali.Margin = new Padding(2, 2, 2, 2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(78, 20);
            btnKembali.TabIndex = 5;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // lblALamat
            // 
            lblALamat.Location = new Point(130, 160);
            lblALamat.Margin = new Padding(2, 2, 2, 2);
            lblALamat.Name = "lblALamat";
            lblALamat.Size = new Size(205, 23);
            lblALamat.TabIndex = 7;
            // 
            // lblNIS
            // 
            lblNIS.Location = new Point(130, 89);
            lblNIS.Margin = new Padding(2, 2, 2, 2);
            lblNIS.Name = "lblNIS";
            lblNIS.Size = new Size(205, 23);
            lblNIS.TabIndex = 8;
            // 
            // lblA
            // 
            lblA.Location = new Point(130, 127);
            lblA.Margin = new Padding(2, 2, 2, 2);
            lblA.Name = "lblA";
            lblA.Size = new Size(205, 23);
            lblA.TabIndex = 9;
            // 
            // FormSiswa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(lblA);
            Controls.Add(lblNIS);
            Controls.Add(lblALamat);
            Controls.Add(btnKembali);
            Controls.Add(btnSimpan);
            Controls.Add(txtNama);
            Controls.Add(txtNIS);
            Controls.Add(txtAlamat);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormSiswa";
            Text = "FormSiswa";
            Load += FormSiswa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label txtAlamat;
        private Label txtNIS;
        private Label txtNama;
        private Button btnSimpan;
        private Button btnKembali;
        private TextBox lblALamat;
        private TextBox lblNIS;
        private TextBox lblA;
    }
}