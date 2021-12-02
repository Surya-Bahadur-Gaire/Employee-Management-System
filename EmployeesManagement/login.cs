using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagement
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(txtname.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Please enter username and password");

            }else if(txtname.Text == "admin" && txtpass.Text == "admin123")
            {
                home hm = new home();
               hm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter correct username or password");
            }
        }
    }
}
