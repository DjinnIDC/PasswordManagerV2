
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace PasswordManagerV2
{
    public partial class fMain : Form
    {
        string Sql = "Server=localhost;Port=5432;database=Password_manager;userid=postgres;password=admin;";
        public fMain()
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
            cmd.CommandText = "SELECT T.\"NAME\" FROM public.\"Passwords\" T\r\nORDER BY \"ID\" ASC ";
            NpgsqlDataReader reader = cmd.ExecuteReader();

            DataTable data = new DataTable();
            data.Load(reader);
            dataGridView1.DataSource = data;

            cmd.Dispose();
            sqlconnection.Close();
        }
    }
}


