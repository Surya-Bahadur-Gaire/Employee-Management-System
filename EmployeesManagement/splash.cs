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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }
        int startpoint = 0;

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            
            MyProgress.Value = startpoint;
            if(MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                this.Hide();
                login log = new login();
                log.Show();

            }
        }

        private void MyProgress_Click(object sender, EventArgs e)
        {

        }
    }
}
