using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LatihanGithub
{
    public partial class FormSiswa : Form
    {
        private string connectionString = "server=localhost;database=db_github;uid=root;pwd=;";

        public FormSiswa()
        {
            InitializeComponent();
        }

        private void FormSiswa_Load(object sender, EventArgs e)
        {
            LoadDataSiswa();
        }

        private void LoadDataSiswa()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_siswa AS 'ID', nis AS 'NIS', nama AS 'Nama', alamat AS 'Alamat' FROM siswa ORDER BY id_siswa DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvSiswa.DataSource = dt;

                        // Atur lebar kolom
                        dgvSiswa.Columns["ID"].Width = 50;
                        dgvSiswa.Columns["NIS"].Width = 100;
                        dgvSiswa.Columns["Nama"].Width = 150;
                        dgvSiswa.Columns["Alamat"].Width = 200;
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
            string nis = lblNIS.Text.Trim();
            string nama = lblA.Text.Trim();
            string alamat = lblALamat.Text.Trim();

            // Validasi input
            if (string.IsNullOrEmpty(nis))
            {
                MessageBox.Show("NIS wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblNIS.Focus();
                return;
            }

            if (string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Nama wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblA.Focus();
                return;
            }

            if (string.IsNullOrEmpty(alamat))
            {
                MessageBox.Show("Alamat wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblALamat.Focus();
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Cek apakah NIS sudah ada
                    string checkQuery = "SELECT COUNT(*) FROM siswa WHERE nis = @nis";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@nis", nis);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("NIS sudah terdaftar!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert data siswa
                    string query = "INSERT INTO siswa (nis, nama, alamat) VALUES (@nis, @nama, @alamat)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nis", nis);
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@alamat", alamat);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Data siswa berhasil disimpan!", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear form
                            ClearForm();

                            // Reload data ke DataGridView
                            LoadDataSiswa();
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

        private void ClearForm()
        {
            lblNIS.Clear();
            lblA.Clear();
            lblALamat.Clear();
            lblNIS.Focus();
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

        private void txtNama_Click(object sender, EventArgs e)
        {
        }

        private void lblNIS_TextChanged(object sender, EventArgs e)
        {
        }
    }
}