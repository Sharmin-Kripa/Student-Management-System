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
    public partial class courses : Form
    {
        public courses()
        {
            InitializeComponent();
        }

        private void courses_Load(object sender, EventArgs e)
        {
            connection connection = new connection();
            connection.thisConnection.Open();

            OracleCommand thisCommand = connection.thisConnection.CreateCommand();

            thisCommand.CommandText = "SELECT * from courses order by course_code";
            OracleDataReader thisReader = thisCommand.ExecuteReader();

            while (thisReader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.Text = thisReader["course_code"].ToString();
                listViewItem.SubItems.Add(thisReader["course_teacher"].ToString());
                listViewItem.SubItems.Add(thisReader["class_time"].ToString());
                listViewItem.SubItems.Add(thisReader["grade"].ToString());

                listView1.Items.Add(listViewItem);
            }

            connection.thisConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            courses_completed cc = new courses_completed();
            cc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            options op = new options();
            op.Show();
            this.Hide();
        }
    }

    
}
