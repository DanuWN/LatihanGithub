using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LatihanGithub
{
    public partial class FormLogin : Form
    {
        // Connection string untuk MySQL
        private string connectionString = "server=localhost;database=db_github;uid=root;pwd=;";

        public FormLogin()
        {
            InitializeComponent();

            // Set Enter key untuk pindah ke kontrol berikutnya
            this.txtUsername.KeyPress += TxtUsername_KeyPress;
            this.txtPassword.KeyPress += TxtPassword_KeyPress;
        }

        private void TxtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPassword.Focus();
                e.Handled = true;
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Validasi input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = "Username dan Password wajib diisi.";
                return;
            }

            // Disable button saat proses login
            btnLogin.Enabled = false;
            lblStatus.ForeColor = System.Drawing.Color.Blue;
            lblStatus.Text = "Memproses login...";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query untuk mengecek login
                    string query = "SELECT COUNT(*) FROM login WHERE username = @username AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        if (result > 0)
                        {
                            lblStatus.ForeColor = System.Drawing.Color.Green;
                            lblStatus.Text = "Login berhasil!";

                            // Beri sedikit delay sebelum berpindah form
                            System.Threading.Thread.Sleep(500);

                            // Lanjut ke form berikutnya
                            this.Hide();
                            FormMenu mainForm = new FormMenu();
                            mainForm.Show();
                        }
                        else
                        {
                            lblStatus.ForeColor = System.Drawing.Color.Red;
                            lblStatus.Text = "Username atau Password salah.";
                            txtPassword.Clear();
                            txtPassword.Focus();
                        }
                    }
                }
                catch (MySqlException sqlEx)
                {
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    lblStatus.Text = "Error Database: " + sqlEx.Message;
                    MessageBox.Show("Gagal terhubung ke database MySQL.\n" + sqlEx.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    lblStatus.Text = "Error: " + ex.Message;
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnLogin.Enabled = true;
                }
            }
        }
    }
}