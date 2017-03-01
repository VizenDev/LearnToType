using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wpm;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;

namespace LearnToType
{
    public partial class Login : MaterialForm
    {
        WPM _wpm = new WPM();
        DataContext context = new DataContext();
        public Login()
        {
            InitializeComponent();
            context.Database.Migrate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            TryLogin();
        }

        private void TryLogin()
        {
            User user = UserFromName(UsernameField.Text);
            bool testPassword = SimpleHash.VerifyHash(PasswordField.Text, "SHA1", user.Password);
            if (user.Username == UsernameField.Text && testPassword == true)
            {
                MessageBox.Show("Logging in...");
                LoggedUser.UserLogged = user.Username;
                Courses courseForm = new Courses();
                this.Hide();
                courseForm.Show();
            }
            else
            {
                MessageBox.Show("Please check your fields and make sure they are correct.");
            }
        }

        private User UserFromName(string uName)
        {
            User user = context.User.Where(x=> x.Username == uName).First();
            return user;
        }

        private IEnumerable<User> GetUser()
        {
            return from u in context.User
                   where u.Username == PasswordField.Text
                   select u;
        }

        private void materialCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckBox4.CheckState == CheckState.Checked)
                PasswordField.UseSystemPasswordChar = false;
            else
                PasswordField.UseSystemPasswordChar = true;
        }
    }
}
