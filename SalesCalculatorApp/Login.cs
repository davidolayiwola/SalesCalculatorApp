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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;

            string connetionString;
            string testval = "";
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fff.DESKTOP-8VIVDVN\source\repos\SalesCalculatorApp\SalesCalculatorApp\SalesCalculator.mdf;Integrated Security=True";
            DataTable table = new DataTable();
            using (cnn = new SqlConnection(connetionString))
            {

                cnn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from logindetails where username = '" + user + "'and password = '" + pass + "'", cnn);
                sda.Fill(table);
            }

            if (table.Rows.Count == 1)
            {
                using (cnn = new SqlConnection(connetionString))
                {
                    cnn.Open();
                    SqlCommand cmd1 = new SqlCommand("select role from logindetails where password ='" + pass + "'", cnn);
                    SqlDataReader reader;
                    reader = cmd1.ExecuteReader();
                    if (reader.Read())
                    {
                        testval = reader.GetString(0);

                        if (testval == "admin")
                        {
                            this.Hide();
                            Transaction mainform = new Transaction();
                            mainform.Show();
                        }
                        else
                        {
                            this.Hide();
                            Transaction mainform = new Transaction();
                            mainform.Show();
                        }
                    }
                    cnn.Close();
                }
                //this.Hide();
                //Transaction mainform = new Transaction();
                //mainform.Show();
            }
            else
            {
                label4.Visible = true;
            }


            cnn.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.Show();
        }
    }
}
