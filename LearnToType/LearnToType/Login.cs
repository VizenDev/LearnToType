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

namespace LearnToType
{
    public partial class Login : MaterialForm
    {
        WPM _wpm = new WPM();
        DataContext dc = new DataContext();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            registerForm.TopMost = true;
        }
    }
}
