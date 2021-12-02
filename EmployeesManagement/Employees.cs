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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }
SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\MyEmployeesDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEid.Text == "" || txtEname.Text == "" || cmbGender.Text == "" || cmbPosition.Text == "" || dateDOB.Text == "" || txtEphone.Text == "" || txtEaddress.Text == "" || cmbEducation.Text == "")
            {
                MessageBox.Show("Please fill all the information?");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into EmployeeTbl values('" + txtEid.Text + "','" + txtEname.Text + "','" + cmbGender.SelectedItem.ToString() + "','" + cmbPosition.SelectedItem.ToString() + "','" + dateDOB.Value.Date + "','" + txtEphone.Text + "','" + txtEaddress.Text + "','" + cmbEducation.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Saved Sucessfully");

                    Con.Close();
                    populate_data();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }
private void populate_data()
        {
            Con.Open();
            string query = "select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            GridEmployeeDB.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Employees_Load(object sender, EventArgs e)
        {
            populate_data();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtEid.Text == "")
            {
                MessageBox.Show("Enter a employee ID");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from EmployeeTbl where EmpID='"+txtEid.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted Sucessfully");
                    Con.Close();
                    populate_data();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void GridEmployeeDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEid.Text = GridEmployeeDB.SelectedRows[0].Cells[0].Value.ToString();
            txtEname.Text = GridEmployeeDB.SelectedRows[0].Cells[1].Value.ToString();
            cmbGender.Text = GridEmployeeDB.SelectedRows[0].Cells[2].Value.ToString();
            cmbPosition.Text = GridEmployeeDB.SelectedRows[0].Cells[4].Value.ToString();
            
            txtEphone.Text = GridEmployeeDB.SelectedRows[0].Cells[5].Value.ToString(); 
            txtEaddress.Text = GridEmployeeDB.SelectedRows[0].Cells[6].Value.ToString();
            cmbEducation.Text = GridEmployeeDB.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtEid.Text == "" || txtEname.Text == "" || cmbGender.Text == "" || cmbPosition.Text == "" || dateDOB.Text == "" || txtEphone.Text == "" || txtEaddress.Text == "" || cmbEducation.Text == "")
            {
                MessageBox.Show("Please fill all the information before EDIT?");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update EmployeeTbl set EmpName='" + txtEname.Text + "',EmpGender='" + cmbGender.SelectedItem.ToString() + "',EmpPosition='" + cmbPosition.SelectedItem.ToString() + "',EmpDOB='" + dateDOB.Value.Date + "',EmpPhone='" + txtEphone.Text + "',EmpAddress='" + txtEaddress.Text + "',EmpEducation='" + cmbEducation.SelectedItem.ToString() + "' where EmpID='"+txtEid.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated Sucessfully");
                    Con.Close();
                    populate_data();

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            home hm = new home();
            hm.Show();
            this.Hide();
        }
    }
}
