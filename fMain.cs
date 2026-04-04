using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace PasswordManagerV2
{
    public partial class fMain : Form
    {
        private const string _connectionString = "Server=localhost;Port=5432;database=Password_manager;userid=postgres;password=admin;";
        private static readonly byte[] _key = Encoding.UTF8.GetBytes("1234567890123456");
        private static readonly byte[] _iv = Encoding.UTF8.GetBytes("1234567890123456");

        public fMain()
        {
            InitializeComponent();
            btnTogglePasswordVisibility.Image = Properties.Resources.PCharEyeShow;
            LoadPasswords();
        }

        public void LoadPasswords()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"SELECT T.""NAME"" FROM public.""Passwords"" T ORDER BY ""ID"" ASC";

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable data = new DataTable();
                        data.Load(reader);
                        dgvNames.DataSource = data;
                    }
                }
            }
        }

        private void dgvNames_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNames.CurrentRow == null) return;

            string selectedName = dgvNames.CurrentRow.Cells["NAME"].Value?.ToString();
            if (string.IsNullOrEmpty(selectedName)) return;

            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmdPassword = new NpgsqlCommand())
                {
                    cmdPassword.Connection = connection;
                    cmdPassword.CommandType = CommandType.Text;
                    cmdPassword.CommandText = @"SELECT t.""PASSWORD"" FROM ""Passwords"" t WHERE t.""NAME"" = @name";
                    cmdPassword.Parameters.AddWithValue("@name", selectedName);

                    string encryptedPassword = cmdPassword.ExecuteScalar()?.ToString();
                    string decryptedPassword = AES.Decrypt(encryptedPassword);
                    txtPassword.Text = decryptedPassword ?? "Не найден";
                }

                using (NpgsqlCommand cmdLogin = new NpgsqlCommand())
                {
                    cmdLogin.Connection = connection;
                    cmdLogin.CommandType = CommandType.Text;
                    cmdLogin.CommandText = @"SELECT t.""LOGIN"" FROM ""Passwords"" t WHERE t.""NAME"" = @name";
                    cmdLogin.Parameters.AddWithValue("@name", selectedName);

                    string encryptedLogin = cmdLogin.ExecuteScalar()?.ToString();
                    string decryptedLogin = AES.Decrypt(encryptedLogin);
                    txtLogin.Text = decryptedLogin ?? "Не найден";
                }
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
            pnlMain.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNames.CurrentRow == null) return;

            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string selectedName = dgvNames.CurrentRow.Cells["NAME"].Value?.ToString();
                if (string.IsNullOrEmpty(selectedName)) return;

                string sql = @"DELETE FROM ""Passwords"" WHERE ""NAME"" = @name";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@name", selectedName);
                    command.ExecuteNonQuery();
                    LoadPasswords();
                }
            }
        }

        private static class AES
        {
            public static string Encrypt(string plainText)
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = _key;
                    aes.IV = _iv;
                    ICryptoTransform encryptor = aes.CreateEncryptor();

                    byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                    byte[] encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);

                    return Convert.ToBase64String(encryptedBytes);
                }
            }

            public static string Decrypt(string cipherText)
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = _key;
                    aes.IV = _iv;

                    ICryptoTransform decryptor = aes.CreateDecryptor();

                    byte[] cipherBytes = Convert.FromBase64String(cipherText);
                    byte[] decryptedBytes = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);

                    return Encoding.UTF8.GetString(decryptedBytes);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNewLogin.Text) ||
                    string.IsNullOrWhiteSpace(txtNewPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtNewName.Text))
                {
                    MessageBox.Show("Заполните все поля!");
                    return;
                }

                using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();

                    string sql = @"INSERT INTO ""Passwords"" VALUES (nextval('seqPasswordsID'), @name, @password, @login)";

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", txtNewName.Text);
                        command.Parameters.AddWithValue("@password", AES.Encrypt(txtNewPassword.Text));
                        command.Parameters.AddWithValue("@login", AES.Encrypt(txtNewLogin.Text));
                        command.ExecuteNonQuery();
                        LoadPasswords();
                    }

                    pnlAdd.Visible = false;
                    pnlMain.Visible = true;
                }
            }
            finally
            {
                txtNewLogin.Text = null;
                txtNewPassword.Text = null;
                txtNewName.Text = null;
            }
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
            pnlMain.Visible = true;
            txtNewLogin.Text = null;
            txtNewPassword.Text = null;
            txtNewName.Text = null;
        }

        private void btnTogglePasswordVisibility_Click(object sender, EventArgs e)
        {
            if (btnTogglePasswordVisibility.Tag?.ToString() == "active")
            {
                btnTogglePasswordVisibility.Image = Properties.Resources.PCharEyeHide;
                btnTogglePasswordVisibility.Tag = "inactive";
                txtLogin.PasswordChar = '\0';
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                btnTogglePasswordVisibility.Image = Properties.Resources.PCharEyeShow;
                btnTogglePasswordVisibility.Tag = "active";
                txtLogin.PasswordChar = '*';
                txtPassword.PasswordChar = '*';
            }
        }

        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}