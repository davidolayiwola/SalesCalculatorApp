
namespace SalesCalculatorApp
{
    partial class Transaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availableProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasedRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existingGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 411);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.availableProductsToolStripMenuItem,
            this.purchasedRecordsToolStripMenuItem,
            this.salesRecordToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // availableProductsToolStripMenuItem
            // 
            this.availableProductsToolStripMenuItem.Name = "availableProductsToolStripMenuItem";
            this.availableProductsToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.availableProductsToolStripMenuItem.Text = "Available Products";
            this.availableProductsToolStripMenuItem.Click += new System.EventHandler(this.availableProductsToolStripMenuItem_Click);
            // 
            // purchasedRecordsToolStripMenuItem
            // 
            this.purchasedRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductsToolStripMenuItem,
            this.viewRecordsToolStripMenuItem});
            this.purchasedRecordsToolStripMenuItem.Name = "purchasedRecordsToolStripMenuItem";
            this.purchasedRecordsToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.purchasedRecordsToolStripMenuItem.Text = "Purchased Records";
            this.purchasedRecordsToolStripMenuItem.Click += new System.EventHandler(this.purchasedRecordsToolStripMenuItem_Click);
            // 
            // addNewProductsToolStripMenuItem
            // 
            this.addNewProductsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.existingGoodsToolStripMenuItem,
            this.newGoodsToolStripMenuItem});
            this.addNewProductsToolStripMenuItem.Name = "addNewProductsToolStripMenuItem";
            this.addNewProductsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewProductsToolStripMenuItem.Text = "Add New Purchases";
            this.addNewProductsToolStripMenuItem.Click += new System.EventHandler(this.addNewProductsToolStripMenuItem_Click);
            // 
            // existingGoodsToolStripMenuItem
            // 
            this.existingGoodsToolStripMenuItem.Name = "existingGoodsToolStripMenuItem";
            this.existingGoodsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.existingGoodsToolStripMenuItem.Text = "Existing Goods";
            this.existingGoodsToolStripMenuItem.Click += new System.EventHandler(this.existingGoodsToolStripMenuItem_Click);
            // 
            // newGoodsToolStripMenuItem
            // 
            this.newGoodsToolStripMenuItem.Name = "newGoodsToolStripMenuItem";
            this.newGoodsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGoodsToolStripMenuItem.Text = "New Goods";
            this.newGoodsToolStripMenuItem.Click += new System.EventHandler(this.newGoodsToolStripMenuItem_Click);
            // 
            // viewRecordsToolStripMenuItem
            // 
            this.viewRecordsToolStripMenuItem.Name = "viewRecordsToolStripMenuItem";
            this.viewRecordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewRecordsToolStripMenuItem.Text = "View Records";
            this.viewRecordsToolStripMenuItem.Click += new System.EventHandler(this.viewRecordsToolStripMenuItem_Click);
            // 
            // salesRecordToolStripMenuItem
            // 
            this.salesRecordToolStripMenuItem.Name = "salesRecordToolStripMenuItem";
            this.salesRecordToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.salesRecordToolStripMenuItem.Text = "Sales Record";
            this.salesRecordToolStripMenuItem.Click += new System.EventHandler(this.salesRecordToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(668, 411);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.Visible = false;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Transaction";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availableProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasedRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existingGoodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGoodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;

       
    }
}