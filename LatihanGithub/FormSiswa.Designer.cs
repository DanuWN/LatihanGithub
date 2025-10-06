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
            txtSiswa = new Label();
            txtAlamat = new Label();
            txtNIS = new Label();
            txtNama = new Label();
            btnSimpan = new Button();
            btnKembali = new Button();
            lblNama = new TextBox();
            lblALamat = new TextBox();
            lblNIS = new TextBox();
            lblA = new TextBox();
            SuspendLayout();
            // 
            // txtSiswa
            // 
            txtSiswa.AutoSize = true;
            txtSiswa.Location = new Point(85, 93);
            txtSiswa.Name = "txtSiswa";
            txtSiswa.Size = new Size(76, 25);
            txtSiswa.TabIndex = 0;
            txtSiswa.Text = "id_siswa";
            txtSiswa.Click += txtNama_Click;
            // 
            // txtAlamat
            // 
            txtAlamat.AutoSize = true;
            txtAlamat.Location = new Point(85, 267);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(68, 25);
            txtAlamat.TabIndex = 1;
            txtAlamat.Text = "Alamat";
            // 
            // txtNIS
            // 
            txtNIS.AutoSize = true;
            txtNIS.Location = new Point(85, 148);
            txtNIS.Name = "txtNIS";
            txtNIS.Size = new Size(40, 25);
            txtNIS.TabIndex = 2;
            txtNIS.Text = "NIS";
            // 
            // txtNama
            // 
            txtNama.AutoSize = true;
            txtNama.Location = new Point(85, 211);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(59, 25);
            txtNama.TabIndex = 3;
            txtNama.Text = "Nama";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(478, 361);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 4;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(161, 361);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 34);
            btnKembali.TabIndex = 5;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // lblNama
            // 
            lblNama.Location = new Point(186, 93);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(291, 31);
            lblNama.TabIndex = 6;
            // 
            // lblALamat
            // 
            lblALamat.Location = new Point(186, 267);
            lblALamat.Name = "lblALamat";
            lblALamat.Size = new Size(291, 31);
            lblALamat.TabIndex = 7;
            // 
            // lblNIS
            // 
            lblNIS.Location = new Point(186, 148);
            lblNIS.Name = "lblNIS";
            lblNIS.Size = new Size(291, 31);
            lblNIS.TabIndex = 8;
            // 
            // lblA
            // 
            lblA.Location = new Point(186, 211);
            lblA.Name = "lblA";
            lblA.Size = new Size(291, 31);
            lblA.TabIndex = 9;
            // 
            // FormSiswa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblA);
            Controls.Add(lblNIS);
            Controls.Add(lblALamat);
            Controls.Add(lblNama);
            Controls.Add(btnKembali);
            Controls.Add(btnSimpan);
            Controls.Add(txtNama);
            Controls.Add(txtNIS);
            Controls.Add(txtAlamat);
            Controls.Add(txtSiswa);
            Name = "FormSiswa";
            Text = "FormSiswa";
            Load += FormSiswa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtSiswa;
        private Label txtAlamat;
        private Label txtNIS;
        private Label txtNama;
        private Button btnSimpan;
        private Button btnKembali;
        private TextBox lblNama;
        private TextBox lblALamat;
        private TextBox lblNIS;
        private TextBox lblA;
    }
}