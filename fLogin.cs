using System;
using System.Windows.Forms;

namespace PasswordManagerV2
{
    public partial class fLogin : Form
    {
        private const string Password = "123";

        public fLogin()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "123")
            {
                fMain MainForm = new fMain();
                MainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Пароль введен неверно попробуйте ещё раз");
            }
        }
    }
}
