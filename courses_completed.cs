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
    public partial class courses_completed : Form
    {
        public courses_completed()
        {
            InitializeComponent();
        }

        private void courses_completed_Load(object sender, EventArgs e)
        {
            connection connection = new connection();
            connection.thisConnection.Open();

            OracleCommand thisCommand = connection.thisConnection.CreateCommand();

            thisCommand.CommandText = "SELECT * from courses_completed order by course_code";

            OracleDataReader thisReader = thisCommand.ExecuteReader();

            while (thisReader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.Text = thisReader["course_code"].ToString();
                listViewItem.SubItems.Add(thisReader["credits"].ToString());
                listViewItem.SubItems.Add(thisReader["grade"].ToString());

                listView1.Items.Add(listViewItem);
            }

            connection.thisConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            courses courses = new courses();
            courses.Show();
            this.Hide();
        }
    }
}
