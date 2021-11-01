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
using System.Threading;

namespace SalesCalculatorApp
{
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {
            InitializeComponent();
            //Thread.Sleep(2000);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString, query, name;
            double price;
            int quantity;

            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fff.DESKTOP-8VIVDVN\source\repos\SalesCalculatorApp\SalesCalculatorApp\SalesCalculator.mdf;Integrated Security=True";
            using (cnn = new SqlConnection(connetionString))
            {
                cnn.Open();

                name = textBox1.Text.ToString();
                price = double.Parse(textBox3.Text.ToString());
                quantity = int.Parse(textBox2.Text.ToString());

                query = "insert into Purchasedrecords(name,price,quantity) values('" + name + "'," + price + "," + quantity + ")";

                SqlCommand cmd = new SqlCommand(query, cnn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    label4.Visible = true;
                }

                    
                cnn.Close();
            }

            using (cnn = new SqlConnection(connetionString))
            {
                cnn.Open();

                name = textBox1.Text.ToString();
                price = double.Parse(textBox3.Text.ToString());
                quantity = int.Parse(textBox2.Text.ToString());

                query = "insert into AvailableTable(name,price,quantity) values('" + name + "'," + price + "," + quantity + ")";

                SqlCommand cmd = new SqlCommand(query, cnn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    label4.Visible = true;
                }


                cnn.Close();
            }
        }
    }
}
