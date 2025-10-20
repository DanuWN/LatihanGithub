using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LatihanGithub
{
    public partial class FormJurusan : Form
    {
        private string connectionString = "server=localhost;database=db_github;uid=root;pwd=;";

        private Label lblNISN;
        private Label lblJurusan;
        private ComboBox cmbNISN;
        private ComboBox cmbJurusan;
        private Button btnSimpan;
        private Button btnKembali;
        private DataGridView dgvJurusan;

        public FormJurusan()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblNISN = new Label();
            this.lblJurusan = new Label();
            this.cmbNISN = new ComboBox();
            this.cmbJurusan = new ComboBox();
            this.btnSimpan = new Button();
            this.btnKembali = new Button();
            this.dgvJurusan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJurusan)).BeginInit();
            this.SuspendLayout();

            // 
            // lblNISN
            // 
            this.lblNISN.AutoSize = true;
            this.lblNISN.Location = new Point(30, 30);
            this.lblNISN.Name = "lblNISN";
            this.lblNISN.Size = new Size(34, 15);
            this.lblNISN.TabIndex = 0;
            this.lblNISN.Text = "NISN";

            // 
            // lblJurusan
            // 
            this.lblJurusan.AutoSize = true;
            this.lblJurusan.Location = new Point(30, 70);
            this.lblJurusan.Name = "lblJurusan";
            this.lblJurusan.Size = new Size(47, 15);
            this.lblJurusan.TabIndex = 1;
            this.lblJurusan.Text = "Jurusan";

            // 
            // cmbNISN
            // 
            this.cmbNISN.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbNISN.FormattingEnabled = true;
            this.cmbNISN.Location = new Point(120, 27);
            this.cmbNISN.Name = "cmbNISN";
            this.cmbNISN.Size = new Size(400, 23);
            this.cmbNISN.TabIndex = 2;

            // 
            // cmbJurusan
            // 
            this.cmbJurusan.DropDownStyle = ComboBoxStyle.DropDownList;
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
            this.cmbJurusan.Location = new Point(120, 67);
            this.cmbJurusan.Name = "cmbJurusan";
            this.cmbJurusan.Size = new Size(400, 23);
            this.cmbJurusan.TabIndex = 3;

            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new Point(540, 27);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new Size(100, 30);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new EventHandler(this.btnSimpan_Click);

            // 
            // btnKembali
            // 
            this.btnKembali.Location = new Point(540, 67);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new Size(100, 30);
            this.btnKembali.TabIndex = 5;
            this.btnKembali.Text = "KEMBALI";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new EventHandler(this.btnKembali_Click);

            // 
            // dgvJurusan
            // 
            this.dgvJurusan.AllowUserToAddRows = false;
            this.dgvJurusan.AllowUserToDeleteRows = false;
            this.dgvJurusan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJurusan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJurusan.Location = new Point(30, 120);
            this.dgvJurusan.Name = "dgvJurusan";
            this.dgvJurusan.ReadOnly = true;
            this.dgvJurusan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvJurusan.Size = new Size(610, 300);
            this.dgvJurusan.TabIndex = 6;

            // 
            // FormJurusan
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(670, 450);
            this.Controls.Add(this.dgvJurusan);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.cmbJurusan);
            this.Controls.Add(this.cmbNISN);
            this.Controls.Add(this.lblJurusan);
            this.Controls.Add(this.lblNISN);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormJurusan";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Form Jurusan Siswa";
            this.Load += new EventHandler(this.FormJurusan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJurusan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void FormJurusan_Load(object sender, EventArgs e)
        {
            LoadNISNComboBox();
            LoadDataJurusan();
        }

        private void LoadNISNComboBox()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nis, nama FROM siswa ORDER BY nama ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            cmbNISN.Items.Clear();

                            while (reader.Read())
                            {
                                string nis = reader["nis"].ToString();
                                string nama = reader["nama"].ToString();

                                // Format: NIS - Nama
                                cmbNISN.Items.Add(new ComboBoxItem
                                {
                                    Text = $"{nis} - {nama}",
                                    NIS = nis,
                                    Nama = nama
                                });
                            }
                        }
                    }

                    if (cmbNISN.Items.Count > 0)
                    {
                        cmbNISN.DisplayMember = "Text";
                    }
                    else
                    {
                        MessageBox.Show("Belum ada data siswa. Silakan tambahkan data siswa terlebih dahulu.",
                            "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show("Error Database: " + sqlEx.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadDataJurusan()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT j.id_jurusan AS 'ID', 
                                           s.nis AS 'NISN', 
                                           s.nama AS 'Nama Siswa', 
                                           j.jurusan AS 'Jurusan'
                                    FROM jurusan_siswa j
                                    INNER JOIN siswa s ON j.nis = s.nis
                                    ORDER BY j.id_jurusan DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvJurusan.DataSource = dt;

                        if (dgvJurusan.Columns.Count > 0)
                        {
                            dgvJurusan.Columns["ID"].Width = 50;
                            dgvJurusan.Columns["NISN"].Width = 120;
                            dgvJurusan.Columns["Nama Siswa"].Width = 200;
                            dgvJurusan.Columns["Jurusan"].Width = 240;
                        }
                    }
                }
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show("Error Database: " + sqlEx.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cmbNISN.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih NISN siswa!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbNISN.Focus();
                return;
            }

            if (cmbJurusan.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih Jurusan!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbJurusan.Focus();
                return;
            }

            ComboBoxItem selectedSiswa = (ComboBoxItem)cmbNISN.SelectedItem;
            string nis = selectedSiswa.NIS;
            string jurusan = cmbJurusan.SelectedItem.ToString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Cek apakah siswa sudah memiliki jurusan
                    string checkQuery = "SELECT COUNT(*) FROM jurusan_siswa WHERE nis = @nis";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@nis", nis);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            DialogResult result = MessageBox.Show(
                                "Siswa ini sudah memiliki jurusan. Apakah ingin mengupdate jurusan?",
                                "Konfirmasi",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                // Update jurusan
                                string updateQuery = "UPDATE jurusan_siswa SET jurusan = @jurusan WHERE nis = @nis";
                                using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                                {
                                    updateCmd.Parameters.AddWithValue("@jurusan", jurusan);
                                    updateCmd.Parameters.AddWithValue("@nis", nis);
                                    updateCmd.ExecuteNonQuery();

                                    MessageBox.Show("Jurusan berhasil diupdate!", "Sukses",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            // Insert jurusan baru
                            string insertQuery = "INSERT INTO jurusan_siswa (nis, jurusan) VALUES (@nis, @jurusan)";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@nis", nis);
                                insertCmd.Parameters.AddWithValue("@jurusan", jurusan);
                                insertCmd.ExecuteNonQuery();

                                MessageBox.Show("Jurusan siswa berhasil disimpan!", "Sukses",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }

                    // Reset form
                    cmbNISN.SelectedIndex = -1;
                    cmbJurusan.SelectedIndex = -1;

                    // Reload data
                    LoadDataJurusan();
                }
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show("Error Database: " + sqlEx.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin kembali?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Class untuk ComboBox Item
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public string NIS { get; set; }
            public string Nama { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}