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
            dgvSiswa = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSiswa).BeginInit();
            SuspendLayout();
            // 
            // txtAlamat
            // 
            txtAlamat.AutoSize = true;
            txtAlamat.Location = new Point(30, 90);
            txtAlamat.Margin = new Padding(2, 0, 2, 0);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(45, 15);
            txtAlamat.TabIndex = 1;
            txtAlamat.Text = "Alamat";
            // 
            // txtNIS
            // 
            txtNIS.AutoSize = true;
            txtNIS.Location = new Point(30, 30);
            txtNIS.Margin = new Padding(2, 0, 2, 0);
            txtNIS.Name = "txtNIS";
            txtNIS.Size = new Size(25, 15);
            txtNIS.TabIndex = 2;
            txtNIS.Text = "NIS";
            // 
            // txtNama
            // 
            txtNama.AutoSize = true;
            txtNama.Location = new Point(30, 60);
            txtNama.Margin = new Padding(2, 0, 2, 0);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(39, 15);
            txtNama.TabIndex = 3;
            txtNama.Text = "Nama";
            txtNama.Click += txtNama_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(530, 30);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(100, 30);
            btnSimpan.TabIndex = 4;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(530, 70);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(100, 30);
            btnKembali.TabIndex = 5;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // lblALamat
            // 
            lblALamat.Location = new Point(100, 87);
            lblALamat.Margin = new Padding(2);
            lblALamat.Multiline = true;
            lblALamat.Name = "lblALamat";
            lblALamat.Size = new Size(400, 50);
            lblALamat.TabIndex = 3;
            // 
            // lblNIS
            // 
            lblNIS.Location = new Point(100, 27);
            lblNIS.Margin = new Padding(2);
            lblNIS.Name = "lblNIS";
            lblNIS.Size = new Size(400, 23);
            lblNIS.TabIndex = 1;
            lblNIS.TextChanged += lblNIS_TextChanged;
            // 
            // lblA
            // 
            lblA.Location = new Point(100, 57);
            lblA.Margin = new Padding(2);
            lblA.Name = "lblA";
            lblA.Size = new Size(400, 23);
            lblA.TabIndex = 2;
            // 
            // dgvSiswa
            // 
            dgvSiswa.AllowUserToAddRows = false;
            dgvSiswa.AllowUserToDeleteRows = false;
            dgvSiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiswa.Location = new Point(30, 160);
            dgvSiswa.Name = "dgvSiswa";
            dgvSiswa.ReadOnly = true;
            dgvSiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSiswa.Size = new Size(600, 250);
            dgvSiswa.TabIndex = 6;
            // 
            // FormSiswa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 430);
            Controls.Add(dgvSiswa);
            Controls.Add(lblA);
            Controls.Add(lblNIS);
            Controls.Add(lblALamat);
            Controls.Add(btnKembali);
            Controls.Add(btnSimpan);
            Controls.Add(txtNama);
            Controls.Add(txtNIS);
            Controls.Add(txtAlamat);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "FormSiswa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Siswa";
            Load += FormSiswa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSiswa).EndInit();
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
        private DataGridView dgvSiswa;
    }
}