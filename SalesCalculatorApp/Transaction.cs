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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales salesview = new Sales()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            salesview.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(salesview);
            salesview.Show();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            Sales salesview = new Sales()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            salesview.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(salesview);
            salesview.Show();
        }

        private void availableProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Available available = new Available()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            available.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(available);
            available.Show();
        }

        private void purchasedRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Login log = new Login()
            //{
            //    Dock = DockStyle.Fill,
            //    TopLevel = false,
            //    TopMost = true
            //};
            //log.FormBorderStyle = FormBorderStyle.None;
            //this.panel1.Controls.Clear();
            //this.panel1.Controls.Add(log);
            //log.Show();
        }

        private void addNewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesForm salesrecord = new SalesForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true

            };
            salesrecord.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(salesrecord);
            salesrecord.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void viewRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fff.DESKTOP-8VIVDVN\source\repos\SalesCalculatorApp\SalesCalculatorApp\SalesCalculator.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Availabletable", cnn);
            DataTable table = new DataTable();
            sda.Fill(table);

            dataGridView2.Visible = true;
            dataGridView2.DataSource = table;

            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(dataGridView2);
        }

        private void newGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewProduct newProduct = new AddNewProduct() { 
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            newProduct.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(newProduct);
            newProduct.Show();

        }

        private void existingGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExistingProducts exitProduct = new ExistingProducts()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            exitProduct.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(exitProduct);
            exitProduct.Show();
        }
    }
}
