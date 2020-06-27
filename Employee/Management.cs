using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Bộ_Phận form = new Bộ_Phận();
            form.ShowDialog();
            //this.Close();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            Account form = new Account();
            form.ShowDialog();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Attendance form = new Attendance();
            form.ShowDialog();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            Salary form = new Salary();
            form.ShowDialog();
        }
    }
}
