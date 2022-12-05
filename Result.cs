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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            connection connection = new connection();
            connection.thisConnection.Open();

            OracleCommand thisCommand = connection.thisConnection.CreateCommand();

            thisCommand.CommandText = "SELECT * from course_1_result";
            OracleDataReader thisReader1 = thisCommand.ExecuteReader();

            while (thisReader1.Read())
            {
                ListViewItem listViewItem1 = new ListViewItem();

                listViewItem1.Text = thisReader1["quiz_1"].ToString();
                listViewItem1.SubItems.Add(thisReader1["quiz_2"].ToString());
                listViewItem1.SubItems.Add(thisReader1["assignment"].ToString());
                listViewItem1.SubItems.Add(thisReader1["mid"].ToString());
                listViewItem1.SubItems.Add(thisReader1["final"].ToString());

                listView1.Items.Add(listViewItem1);
            }

            thisCommand.CommandText = "SELECT * from course_2_result";
            OracleDataReader thisReader2 = thisCommand.ExecuteReader();

            while (thisReader2.Read())
            {

                ListViewItem listViewItem2 = new ListViewItem();

                listViewItem2.Text = thisReader2["quiz_1"].ToString();
                listViewItem2.SubItems.Add(thisReader2["quiz_2"].ToString());
                listViewItem2.SubItems.Add(thisReader2["assignment"].ToString());
                listViewItem2.SubItems.Add(thisReader2["mid"].ToString());
                listViewItem2.SubItems.Add(thisReader2["final"].ToString());

                listView2.Items.Add(listViewItem2);
            }

            thisCommand.CommandText = "SELECT * from course_3_result";
            OracleDataReader thisReader3 = thisCommand.ExecuteReader();

            while (thisReader3.Read())
            {
                ListViewItem listViewItem3 = new ListViewItem();

                listViewItem3.Text = thisReader3["quiz_1"].ToString();
                listViewItem3.SubItems.Add(thisReader3["quiz_2"].ToString());
                listViewItem3.SubItems.Add(thisReader3["assignment"].ToString());
                listViewItem3.SubItems.Add(thisReader3["mid"].ToString());
                listViewItem3.SubItems.Add(thisReader3["final"].ToString());

                listView3.Items.Add(listViewItem3);
            }

            connection.thisConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            options op = new options();
            op.Show();
            this.Hide();
        }
    }
}
