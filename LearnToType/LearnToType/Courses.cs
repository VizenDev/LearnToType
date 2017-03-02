using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace LearnToType
{
    public partial class Courses : MaterialForm
    {
        public Courses()
        {
            InitializeComponent();
        }

        private void Courses_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Account accountForm = new Account();
            accountForm.Show();
        }
    }
}
