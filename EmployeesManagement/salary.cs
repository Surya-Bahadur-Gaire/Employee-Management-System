using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeesManagement
{
    public partial class salary : Form
    {
        public salary()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\MyEmployeesDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void fetchempdata()
        {
            if(Sempid.Text == "")
            {
                MessageBox.Show("Please enter a Employee ID to fetch data.");

            }
            else
            {
                Con.Open();
                string query = "select * from EmployeeTbl where EmpID='" + Sempid.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    //Sempid.Text = dr["EmpID"].ToString();
                    Sempname.Text = dr["EmpName"].ToString();
                    Sempposition.Text = dr["EmpPosition"].ToString();


                }
                Con.Close();


            }
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            home hm = new home();
            hm.Show();
            this.Hide();
        }

        private void salary_Load(object sender, EventArgs e)
        {

        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }
        int dailybase, total;
        private void btnView_Click(object sender, EventArgs e)
        {
            if(Sempposition.Text == "")
            {
                MessageBox.Show("First Select an Employee");
            }
            else if(Swd.Text == "" || Convert.ToInt32(Swd.Text) > 28)
            {
                MessageBox.Show("Enter a Valid Number of Days Worked");

            }
            else
            {
                if(Sempposition.Text == "Manager")
                {
                    dailybase = 350;

                }else if (Sempposition.Text == "Senior Developer")
                {
                    dailybase = 330;
                }
                else if (Sempposition.Text == "Junior Developer")
                {
                    dailybase = 300;
                }
                else if (Sempposition.Text == "Supervisor")
                {
                    dailybase = 400;
                }
                else if (Sempposition.Text == "Intern")
                {
                    dailybase = 75;
                }
                else if (Sempposition.Text == "Vice President")
                {
                    dailybase = 900;
                }
                else if (Sempposition.Text == "President")
                {
                    dailybase = 1000;
                }
                else if (Sempposition.Text == "Director")
                {
                    dailybase = 800;
                }
                else if (Sempposition.Text == "Accountant")
                {
                    dailybase = 275;
                }
                else if (Sempposition.Text == "Receptionist")
                {
                    dailybase = 200;
                }
                total = dailybase * Convert.ToInt32(Swd.Text);
                salarySlip.Text = "Employee ID: "+Sempid.Text + "\n"+"Employee Name:    " + Sempname.Text + "\n" + "Employee Position:    " + Sempposition.Text + "\n" + "Working Days:    " + Swd.Text + "\n" + "Daily Base:    " + dailybase + "\n" +"---------------------------------------------" +"\n" + "Total Salary:    " + total;
            }
        }
    }
}
