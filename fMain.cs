
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PasswordManagerV2
{
    public partial class fMain : Form
    {
        const string connSql = "Server=localhost;Port=5432;database=Password_manager;userid=postgres;password=admin;";
        public fMain()
        {
            InitializeComponent();
            btnShowHide.Image = Properties.Resources.PCharEyeShow;
            SqlConnectionReader();
        }

        public void SqlConnectionReader()
        {
            NpgsqlConnection sqlconnection = new NpgsqlConnection(connSql);
            sqlconnection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = sqlconnection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT T.""NAME"" FROM public.""Passwords"" T ORDER BY ""ID"" ASC"; ;
            NpgsqlDataReader reader = cmd.ExecuteReader();

            DataTable data = new DataTable();
            data.Load(reader);
            dgvNames.DataSource = data;

            cmd.Dispose();
            sqlconnection.Close();
        }

        private void dgvNames_SelectionChanged(object sender, System.EventArgs e)
        {

            if (dgvNames.CurrentRow == null) return;

            string selectedName = dgvNames.CurrentRow.Cells["NAME"].Value?.ToString();
            if (string.IsNullOrEmpty(selectedName)) return;

            using (NpgsqlConnection sqlconnection = new NpgsqlConnection(connSql))
            {
                sqlconnection.Open();

                using (NpgsqlCommand cmd1 = new NpgsqlCommand())
                {
                    cmd1.Connection = sqlconnection;
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = @"SELECT t.""PASSWORD"" FROM ""Passwords"" t WHERE t.""NAME"" = @NAME";
                    cmd1.Parameters.AddWithValue("@NAME", selectedName);

                    string inPassword = cmd1.ExecuteScalar()?.ToString();
                    tbPassword.Text = inPassword ?? "Не найден";
                }

                using (NpgsqlCommand cmd2 = new NpgsqlCommand())
                {
                    cmd2.Connection = sqlconnection;
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = @"SELECT t.""LOGIN"" FROM ""Passwords"" t WHERE t.""NAME"" = @NAME";
                    cmd2.Parameters.AddWithValue("@NAME", selectedName);

                    string inLogin = cmd2.ExecuteScalar()?.ToString();
                    tbLogin.Text = inLogin ?? "Не найден";
                }
            }
        }

        private void btnPChar_Click(object sender, EventArgs e)
        {
            if (btnShowHide.Tag?.ToString() == "active")
            {
                btnShowHide.Image = Properties.Resources.PCharEyeHide;
                btnShowHide.Tag = 2;
                tbLogin.PasswordChar = '\0';
                tbPassword.PasswordChar = '\0';
                btnShowHide.Tag = "inactive";
            }
            else
            {

                btnShowHide.Image = Properties.Resources.PCharEyeShow;
                btnShowHide.Tag = 1;
                tbLogin.PasswordChar = '*';
                tbPassword.PasswordChar = '*';
                btnShowHide.Tag = "active";
            }
        }

        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
            pnlMain.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
            pnlMain.Visible = true;

            if (string.IsNullOrWhiteSpace(tbNewLogin.Text) ||
                string.IsNullOrWhiteSpace(tbNewPassword.Text) ||
                string.IsNullOrWhiteSpace(tbNewName.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            else 
            { 

                using (NpgsqlConnection conn = new NpgsqlConnection(connSql))
                {
                    conn.Open();

                    string sql = @"insert into ""Passwords"" 
                                    values (nextval('seqPasswordsID'),@name,@password,@login)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {

                        cmd.Parameters.AddWithValue("@name", tbNewName.Text);
                        cmd.Parameters.AddWithValue("@password", tbNewPassword.Text);
                        cmd.Parameters.AddWithValue("@login", tbNewLogin.Text);

                        cmd.ExecuteNonQuery();
                        SqlConnectionReader();
                    }

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNames.CurrentRow == null) return;


            using (NpgsqlConnection conn = new NpgsqlConnection(connSql))
            {
                conn.Open();
                string selectedName = dgvNames.CurrentRow.Cells["NAME"].Value?.ToString();
                if (string.IsNullOrEmpty(selectedName)) return;

                string sql = @"delete from ""Passwords"" t where t.""NAME"" = @name";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {

                    cmd.Parameters.AddWithValue("@name", selectedName);

                    cmd.ExecuteNonQuery();
                    SqlConnectionReader();
                }
            }
        }
    }
}


