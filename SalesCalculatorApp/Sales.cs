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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                double sum = 0;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells["Quantity"].Value != null)
                    {
                        sum += int.Parse(row.Cells["Price"].Value.ToString()) * int.Parse(row.Cells["Quantity"].Value.ToString());
                        textBox2.Text = "#" + sum + ".00";
                    }
                    else
                    {
                        MessageBox.Show("Please Fill Quantity Column Correctly");
                    }
                }
                string connetionString, query, name;
                double price;
                int quantity;

                SqlConnection cnn;
                connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fff.DESKTOP-8VIVDVN\source\repos\SalesCalculatorApp\SalesCalculatorApp\SalesCalculator.mdf;Integrated Security=True";
                using (cnn = new SqlConnection(connetionString))
                {
                    cnn.Open();

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (row.Cells["Quantity"].Value != null)
                        {
                            name = row.Cells["Goods"].Value.ToString();
                            price = double.Parse(row.Cells["Price"].Value.ToString());
                            quantity = int.Parse(row.Cells["quantity"].Value.ToString());

                            query = "insert into SalesTable(name,price,quantity) values('" + name + "'," + price + "," + quantity + ")";

                            SqlCommand cmd = new SqlCommand(query, cnn);
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                label2.Visible = true;
                                label2.Text = "Your Sales was recorded";
                            }
                        }

                    }
                    cnn.Close();
                }



                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells["Quantity"].Value != null)
                    {
                        int quantity1, quantitynew;
                        int quantity2 = 0;
                        name = row.Cells["Goods"].Value.ToString();

                        using (cnn = new SqlConnection(connetionString))
                        {
                            cnn.Open();
                            SqlCommand cmd1 = new SqlCommand("select quantity from AvailableTable where Name ='" + name + "'", cnn);
                            SqlDataReader reader;
                            reader = cmd1.ExecuteReader();
                            if (reader.Read())
                            {
                                quantity2 = int.Parse(reader.GetInt32(0).ToString());
                            }

                            quantity1 = int.Parse(row.Cells["quantity"].Value.ToString());

                            quantitynew = quantity2 - quantity1;

                            query = "update AvailableTable set Quantity =" + quantitynew + "where name = '" + name + "'";
                            cnn.Close();
                        }

                        query = "update AvailableTable set Quantity =" + quantitynew + "where name = '" + name + "'";

                        using (cnn = new SqlConnection(connetionString))
                        {
                            cnn.Open();
                            SqlCommand cmd2 = new SqlCommand(query, cnn);
                            cmd2.ExecuteNonQuery();
                        }

                    }
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string value = textBox1.Text;

            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fff.DESKTOP-8VIVDVN\source\repos\SalesCalculatorApp\SalesCalculatorApp\SalesCalculator.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select name from PurchasedRecords where name like '" + value + "%'", cnn);
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
            string queryvalue = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkbox"].Value);
                if (isSelected)
                {
                    message += "'" + row.Cells[1].Value.ToString() + "',";
                }
            }
            if (message != "")
            {
                queryvalue = message.Remove(message.Length - 1);

                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fff.DESKTOP-8VIVDVN\source\repos\SalesCalculatorApp\SalesCalculatorApp\SalesCalculator.mdf;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select name,price from PurchasedRecords where name  in (" + queryvalue + ")", cnn);
                DataTable table = new DataTable();
                sda.Fill(table);

                foreach (DataRow rows in table.Rows)
                {
                    dataGridView2.Rows.Add(rows.ItemArray);
                }
            }
            else
            {
                MessageBox.Show("You Have Not Made Any Selection");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fff.DESKTOP-8VIVDVN\source\repos\SalesCalculatorApp\SalesCalculatorApp\SalesCalculator.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select name from PurchasedRecords", cnn);
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
    }
}
