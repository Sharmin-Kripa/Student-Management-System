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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void logincheck()
        {
            try
            {
                connection connection = new connection();
                connection.thisConnection.Open();

                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.Connection = connection.thisConnection;

                oracleCommand.CommandText = "SELECT student_id, password from students where student_id = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'";
                OracleDataReader thisReader = oracleCommand.ExecuteReader();

                if (thisReader.Read())
                {
                    options op = new options();
                    op.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ID or Password incorrect.");
                }

                connection.thisConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logincheck();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logincheck();
            }
        }
    }
}
