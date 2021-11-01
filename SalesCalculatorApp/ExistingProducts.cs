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
    public partial class ExistingProducts : Form
    {
        public ExistingProducts()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string value = textBox4.Text;

            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fff.DESKTOP-8VIVDVN\source\repos\SalesCalculatorApp\SalesCalculatorApp\SalesCalculator.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select name from AvailableTable where name like '" + value + "%'", cnn);
            cnn.Close();
            DataTable table = new DataTable();
            sda.Fill(table);
            dataGridView1.DataSource = table;

            if (dataGridView1.Columns.Count == 1)
            {
                DataGridViewCheckBoxColumn checkcolumn = new DataGridViewCheckBoxColumn();
                checkcolumn.HeaderText = "";
                checkcolumn.Name = "checkbox";
                dataGridView1.Columns.Add(checkcolumn);
            }
        }

        private void ExistingProducts_Load(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fff.DESKTOP-8VIVDVN\source\repos\SalesCalculatorApp\SalesCalculatorApp\SalesCalculator.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select name from AvailableTable", cnn);
            cnn.Close();
            DataTable table = new DataTable();
            sda.Fill(table);
            dataGridView1.DataSource = table;

            if (dataGridView1.Columns.Count == 1)
            {
                DataGridViewCheckBoxColumn checkcolumn = new DataGridViewCheckBoxColumn();
                checkcolumn.HeaderText = "";
                checkcolumn.Name = "checkbox";
                dataGridView1.Columns.Add(checkcolumn);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkbox"].Value);
                if (isSelected)
                {
                    message = "" + row.Cells["Name"].Value.ToString();
                }
            }
            textBox1.Text = message;
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
                price = double.Parse(textBox2.Text.ToString());
                quantity = int.Parse(textBox3.Text.ToString());

                query = "insert into Purchasedrecords(name,price,quantity) values('" + name + "'," + price + "," + quantity + ")";

                SqlCommand cmd = new SqlCommand(query, cnn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    label4.Visible = true;
                }


                cnn.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            AddNewProduct add = new AddNewProduct();
            //{
            //    Dock = DockStyle.Fill,
            //    TopLevel = false,
            //    TopMost = true
            //};
            //add.FormBorderStyle = FormBorderStyle.None;
            

            this.Hide();
            
            add.Show();
           
        }
    }
}
