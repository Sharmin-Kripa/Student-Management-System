using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Student_Management
{
    public partial class options : Form
    {
        public options()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            courses courses = new courses();
            courses.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            result.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Billing billing = new Billing();
            billing.Show();
            this.Hide();
        }
    }
}
