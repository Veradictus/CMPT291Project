using System;
using System.Windows.Forms;

namespace _291CarProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void username_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Register registerForm = new Register();

            registerForm.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            /**
             * get_user_from database
             * verify user_password == database_user_password -> if fails display error
             * else -> show main menu
             */

            this.Hide();

            MainMenu mainMenuForm = new MainMenu();

            mainMenuForm.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            _291CarProject.Static.Database.CreateConnection();
        }
    }
}
