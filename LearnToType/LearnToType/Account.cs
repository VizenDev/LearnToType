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
    public partial class Account : MaterialForm
    {
        public Account()
        {
            InitializeComponent();
            namePanel.Hide();
        }
        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            namePanel.Show();
            namePanel.BringToFront();
        }
    }
}
