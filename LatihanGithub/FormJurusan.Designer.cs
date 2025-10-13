using System;
using System.Drawing;
using System.Windows.Forms;

namespace LatihanGithub
{
    public partial class FormJurusan : Form
    {
        private Label lblNISN;
        private Label lblJurusan;
        private ComboBox cmbJurusan;
        private Button btnSimpan;
        private Button btnKembali;
        private TextBox txtNISN;
        private DataGridView dataGridView1;

        public FormJurusan()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblNISN = new Label();
            this.lblJurusan = new Label();
            this.cmbJurusan = new ComboBox();
            this.btnSimpan = new Button();
            this.btnKembali = new Button();
            this.txtNISN = new TextBox();
            this.dataGridView1 = new DataGridView();

            // 
            // lblNISN
            // 
            this.lblNISN.AutoSize = true;
            this.lblNISN.Location = new Point(232, 89);
            this.lblNISN.Name = "lblNISN";
            this.lblNISN.Size = new Size(34, 15);
            this.lblNISN.TabIndex = 1;
            this.lblNISN.Text = "NISN";

            // 
            // lblJurusan
            // 
            this.lblJurusan.AutoSize = true;
            this.lblJurusan.Location = new Point(232, 143);
            this.lblJurusan.Name = "lblJurusan";
            this.lblJurusan.Size = new Size(47, 15);
            this.lblJurusan.TabIndex = 2;
            this.lblJurusan.Text = "Jurusan";

            // 
            // cmbJurusan
            // 
            this.cmbJurusan.FormattingEnabled = true;
            this.cmbJurusan.Items.AddRange(new object[] {
                "REKAYASA PERANGKAT LUNAK",
                "PERHOTELAN",
                "AKUNTANSI",
                "LAYANAN PARIWISATA",
                "KECANTIKAN",
                "TATA BUSANA",
                "KIMIA INDUSTRI"
            });
            this.cmbJurusan.Location = new Point(314, 140);
            this.cmbJurusan.Name = "cmbJurusan";
            this.cmbJurusan.Size = new Size(211, 23);
            this.cmbJurusan.TabIndex = 0;
            this.cmbJurusan.SelectedIndexChanged += new EventHandler(this.cmbJurusan_SelectedIndexChanged);

            // 
            // txtNISN
            // 
            this.txtNISN.Location = new Point(314, 86);
            this.txtNISN.Name = "txtNISN";
            this.txtNISN.Size = new Size(211, 23);
            this.txtNISN.TabIndex = 5;

            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new Point(276, 225);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new Size(82, 29);
            this.btnSimpan.TabIndex = 3;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new EventHandler(this.btnSimpan_Click);

            // 
            // btnKembali
            // 
            this.btnKembali.Location = new Point(454, 225);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new Size(71, 29);
            this.btnKembali.TabIndex = 4;
            this.btnKembali.Text = "KEMBALI";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new EventHandler(this.btnKembali_Click);

            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new Point(232, 270);
            this.dataGridView1.Size = new Size(293, 150);
            this.dataGridView1.ColumnCount = 2;
            this.dataGridView1.Columns[0].Name = "NISN";
            this.dataGridView1.Columns[1].Name = "Jurusan";

            // 
            // FormJurusan
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(799, 535);
            this.Controls.Add(this.txtNISN);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.lblJurusan);
            this.Controls.Add(this.lblNISN);
            this.Controls.Add(this.cmbJurusan);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormJurusan";
            this.Text = "FormJurusan";
            this.Load += new EventHandler(this.FormJurusan_Load);
        }

        private void FormJurusan_Load(object sender, EventArgs e)
        {
            cmbJurusan.SelectedIndex = -1; // Tidak ada pilihan default
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nisn = txtNISN.Text.Trim();
            string jurusan = cmbJurusan.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nisn) || string.IsNullOrEmpty(jurusan))
            {
                MessageBox.Show("Harap isi NISN dan pilih Jurusan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tambahkan ke DataGridView
            dataGridView1.Rows.Add(nisn, jurusan);

            // Reset input
            txtNISN.Clear();
            cmbJurusan.SelectedIndex = -1;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close(); // Menutup form
        }

        private void cmbJurusan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null && comboBox.SelectedItem != null)
            {
                string selectedJurusan = comboBox.SelectedItem.ToString();
                // Optional: tampilkan notifikasi
                // MessageBox.Show("Jurusan yang dipilih: " + selectedJurusan);
            }
        }
    }
}
