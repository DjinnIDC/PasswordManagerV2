using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagerV2
{
    public partial class fLogin : Form
    {
        string Sql = "Server=localhost;Port=5432;database=Password_manager;userid=postgres;password=admin;";
        public fLogin()
        {
            InitializeComponent();
            SqlConnectionReader();
        }

        public void SqlConnectionReader()
        {
            NpgsqlConnection sqlconnection = new NpgsqlConnection(Sql);
            sqlconnection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = sqlconnection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM public.\"Passwords\"";
            NpgsqlDataReader reader = cmd.ExecuteReader();

            DataTable data = new DataTable();
            data.Load(reader);
            dataGridView1.DataSource = data;

            cmd.Dispose();
            sqlconnection.Close();
        }
    }
}
