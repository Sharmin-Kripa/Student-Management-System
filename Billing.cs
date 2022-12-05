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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            connection connection = new connection();
            connection.thisConnection.Open();

            OracleCommand thisCommand = connection.thisConnection.CreateCommand();

            thisCommand.CommandText = "SELECT * from billing";
            OracleDataReader thisReader1 = thisCommand.ExecuteReader();

            while (thisReader1.Read())
            {
                ListViewItem listViewItem1 = new ListViewItem();

                listViewItem1.Text = thisReader1["total_paid"].ToString();
                listViewItem1.SubItems.Add(thisReader1["total_payable"].ToString());
                listViewItem1.SubItems.Add(thisReader1["due_amount"].ToString());

                listView1.Items.Add(listViewItem1);
            }

            thisCommand.CommandText = "SELECT * from billing_history";
            OracleDataReader thisReader2 = thisCommand.ExecuteReader();

            while (thisReader2.Read())
            {
                ListViewItem listViewItem2 = new ListViewItem();

                listViewItem2.Text = thisReader2["total_paid"].ToString();
                listViewItem2.SubItems.Add(thisReader2["total_payable"].ToString());
                listViewItem2.SubItems.Add(thisReader2["due_amount"].ToString());

                listView2.Items.Add(listViewItem2);
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
