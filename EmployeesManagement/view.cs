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
    public partial class view : Form
    {
        public view()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\MyEmployeesDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void fetchempdata()
        {
            Con.Open();
            string query = "select * from EmployeeTbl where EmpID='"+vsearch.Text+"'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                vid.Text = dr["EmpID"].ToString();
                vname.Text = dr["EmpName"].ToString();
                vgender.Text = dr["EmpGender"].ToString();
                vposition.Text = dr["EmpPosition"].ToString();
                vdob.Text = dr["EmpDOB"].ToString();
                vphone.Text = dr["EmpPhone"].ToString();
                vaddress.Text = dr["EmpAddress"].ToString();
                veducation.Text = dr["EmpEducation"].ToString();
            }
            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            home hm = new home();
            hm.Show();
            this.Hide();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.Show();
            this.Hide();
        }

        private void view_Load(object sender, EventArgs e)
        {

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }
    }
}
