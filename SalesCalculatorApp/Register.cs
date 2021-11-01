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

namespace SalesCalculatorApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password, role, query;

            SqlConnection cnn;
            string connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fff.DESKTOP-8VIVDVN\source\repos\SalesCalculatorApp\SalesCalculatorApp\SalesCalculator.mdf;Integrated Security=True";

            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.SelectedItem.ToString() != "")
            {
                username = textBox1.Text.ToString();
                password = textBox2.Text.ToString();
                role = comboBox1.SelectedItem.ToString();

                query = "insert into logindetails(username,password,role) values('" + username + "','" + password + "','" + role + "')";

                using (cnn = new SqlConnection(connetionString))
                {
                    cnn.Open();
                    SqlCommand cmd1 = new SqlCommand(query, cnn);
                    if (cmd1.ExecuteNonQuery() > 0)
                    {
                        label4.Visible = true;
                        button2.Visible = true;

                        textBox1.Text = "";
                        textBox2.Text = "";
                        comboBox1.SelectedItem = "";
                    }
                    else
                    {

                        //}
                        cnn.Close();
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
