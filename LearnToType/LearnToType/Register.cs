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
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices.WindowsRuntime;

namespace LearnToType
{
    public partial class Register : MaterialForm
    {
        DataContext context = new DataContext();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
        }

        private bool CheckData()
        {
            MaterialSingleLineTextField[] textFields = { materialSingleLineTextField1, materialSingleLineTextField2, materialSingleLineTextField3, materialSingleLineTextField4 };
            MaterialSingleLineTextField[] lengthFields = {materialSingleLineTextField2, materialSingleLineTextField3, materialSingleLineTextField4 };

            if (textFields.Any(x => string.IsNullOrWhiteSpace(x.Text)))
                MessageBox.Show("Please make sure to fill everything out");
            else if (!materialSingleLineTextField3.Text.Equals(materialSingleLineTextField4.Text))
                MessageBox.Show("Your passwords do not match");
            else if (lengthFields.All(x => x.TextLength <= 5))
                MessageBox.Show("Make sure your username and password is 5 or more characters");
            else
                return true;

            return false;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                InsertUser(NewUser());
            }
            else
            {
                //Do nothing, they were already informed about their errors.
            }
        }

        private User NewUser()
        {
            string hash = SimpleHash.ComputeHash(materialSingleLineTextField4.Text, "SHA1", null);

            User user = new User();
            user.Name = materialSingleLineTextField1.Text;
            user.Username = materialSingleLineTextField2.Text;
            user.Password = hash;
            context.SaveChangesAsync();
            return user;

        }

        private void InsertUser(User user)
        {
            context.User.Add(user);
            context.SaveChangesAsync();
        }

        private IEnumerable<User> GetUser()
        {
            return from u in context.User
                   select u;
        }
    }
}
