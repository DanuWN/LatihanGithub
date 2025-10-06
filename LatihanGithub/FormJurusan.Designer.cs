namespace LatihanGithub
{
    partial class FormJurusan
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
            lblIDjurusan = new Label();
            lblJurusan = new Label();
            cmbJurusan = new ComboBox();
            btnSimpan = new Button();
            btnKembali = new Button();
            txtIDJurusan = new TextBox();
            SuspendLayout();
            // 
            // lblIDjurusan
            // 
            lblIDjurusan.AutoSize = true;
            lblIDjurusan.Location = new Point(232, 89);
            lblIDjurusan.Name = "lblIDjurusan";
            lblIDjurusan.Size = new Size(60, 15);
            lblIDjurusan.TabIndex = 1;
            lblIDjurusan.Text = "Id Jurusan";
            lblIDjurusan.Click += label1_Click;
            // 
            // lblJurusan
            // 
            lblJurusan.AutoSize = true;
            lblJurusan.Location = new Point(232, 143);
            lblJurusan.Name = "lblJurusan";
            lblJurusan.Size = new Size(47, 15);
            lblJurusan.TabIndex = 2;
            lblJurusan.Text = "Jurusan";
            lblJurusan.Click += lblJurusan_Click;
            // 
            // cmbJurusan
            // 
            cmbJurusan.FormattingEnabled = true;
            cmbJurusan.Items.AddRange(new object[] { "REKAYASA PERANGKAT LUNAK", "PERHOTELAN", "AKUTANSI", "LAYANAN PARIWISATA", "KECANTIKAN", "TATA BUSANA", "KIMIA INDUSTRI" });
            cmbJurusan.Location = new Point(314, 140);
            cmbJurusan.Name = "cmbJurusan";
            cmbJurusan.Size = new Size(211, 23);
            cmbJurusan.TabIndex = 0;
            cmbJurusan.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(276, 225);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(82, 29);
            btnSimpan.TabIndex = 3;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(428, 225);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(71, 29);
            btnKembali.TabIndex = 4;
            btnKembali.Text = "KEMBALI";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // txtIDJurusan
            // 
            txtIDJurusan.Location = new Point(314, 86);
            txtIDJurusan.Name = "txtIDJurusan";
            txtIDJurusan.Size = new Size(211, 23);
            txtIDJurusan.TabIndex = 5;
            // 
            // FormJurusan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 535);
            Controls.Add(txtIDJurusan);
            Controls.Add(btnKembali);
            Controls.Add(btnSimpan);
            Controls.Add(lblJurusan);
            Controls.Add(lblIDjurusan);
            Controls.Add(cmbJurusan);
            Name = "FormJurusan";
            Text = "FormJurusan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblIDjurusan;
        private Label lblJurusan;
        private ComboBox cmbJurusan;
        private Button btnSimpan;
        private Button btnKembali;
        private TextBox txtIDJurusan;
    }
}