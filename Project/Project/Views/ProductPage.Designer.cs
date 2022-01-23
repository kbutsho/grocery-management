
namespace Project.Views
{
    partial class ProductPage
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
            this.label7 = new System.Windows.Forms.Label();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.HomePageBtn111 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ProNameBox211 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ProPriceBox211 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ProQuantityBox211 = new System.Windows.Forms.TextBox();
            this.ProPriceCateGoryBox211 = new System.Windows.Forms.TextBox();
            this.BuyNowBtn = new System.Windows.Forms.Button();
            this.SearchButtonForProducts = new System.Windows.Forms.Button();
            this.ProducBox222 = new System.Windows.Forms.ComboBox();
            this.CdashBoard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 39);
            this.label7.TabIndex = 57;
            this.label7.Text = "Available Products";
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Location = new System.Drawing.Point(0, 82);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.Size = new System.Drawing.Size(335, 304);
            this.ProductDataGridView.TabIndex = 58;
            this.ProductDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataGridView_CellContentClick);
            // 
            // HomePageBtn111
            // 
            this.HomePageBtn111.BackColor = System.Drawing.Color.Blue;
            this.HomePageBtn111.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePageBtn111.ForeColor = System.Drawing.Color.White;
            this.HomePageBtn111.Location = new System.Drawing.Point(214, 334);
            this.HomePageBtn111.Name = "HomePageBtn111";
            this.HomePageBtn111.Padding = new System.Windows.Forms.Padding(5);
            this.HomePageBtn111.Size = new System.Drawing.Size(87, 34);
            this.HomePageBtn111.TabIndex = 59;
            this.HomePageBtn111.Text = "Log Out";
            this.HomePageBtn111.UseVisualStyleBackColor = false;
            this.HomePageBtn111.Click += new System.EventHandler(this.HomePageBtn111_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(48, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 87;
            this.label4.Text = "Product Name";
            // 
            // ProNameBox211
            // 
            this.ProNameBox211.Enabled = false;
            this.ProNameBox211.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProNameBox211.Location = new System.Drawing.Point(187, 130);
            this.ProNameBox211.Name = "ProNameBox211";
            this.ProNameBox211.Size = new System.Drawing.Size(114, 22);
            this.ProNameBox211.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(51, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 84;
            this.label8.Text = "ADD Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(48, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 83;
            this.label9.Text = "Product Price";
            // 
            // ProPriceBox211
            // 
            this.ProPriceBox211.Enabled = false;
            this.ProPriceBox211.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProPriceBox211.Location = new System.Drawing.Point(187, 165);
            this.ProPriceBox211.Name = "ProPriceBox211";
            this.ProPriceBox211.Size = new System.Drawing.Size(114, 22);
            this.ProPriceBox211.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(47, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 16);
            this.label10.TabIndex = 85;
            this.label10.Text = "Product Category";
            // 
            // ProQuantityBox211
            // 
            this.ProQuantityBox211.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProQuantityBox211.Location = new System.Drawing.Point(187, 239);
            this.ProQuantityBox211.Name = "ProQuantityBox211";
            this.ProQuantityBox211.Size = new System.Drawing.Size(114, 22);
            this.ProQuantityBox211.TabIndex = 88;
            // 
            // ProPriceCateGoryBox211
            // 
            this.ProPriceCateGoryBox211.Enabled = false;
            this.ProPriceCateGoryBox211.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProPriceCateGoryBox211.Location = new System.Drawing.Point(187, 202);
            this.ProPriceCateGoryBox211.Name = "ProPriceCateGoryBox211";
            this.ProPriceCateGoryBox211.Size = new System.Drawing.Size(114, 22);
            this.ProPriceCateGoryBox211.TabIndex = 86;
            // 
            // BuyNowBtn
            // 
            this.BuyNowBtn.BackColor = System.Drawing.Color.Red;
            this.BuyNowBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyNowBtn.ForeColor = System.Drawing.Color.White;
            this.BuyNowBtn.Location = new System.Drawing.Point(214, 276);
            this.BuyNowBtn.Name = "BuyNowBtn";
            this.BuyNowBtn.Size = new System.Drawing.Size(87, 29);
            this.BuyNowBtn.TabIndex = 82;
            this.BuyNowBtn.Text = "Order";
            this.BuyNowBtn.UseVisualStyleBackColor = false;
            this.BuyNowBtn.Click += new System.EventHandler(this.BuyNowBtn_Click);
            // 
            // SearchButtonForProducts
            // 
            this.SearchButtonForProducts.BackColor = System.Drawing.Color.Red;
            this.SearchButtonForProducts.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButtonForProducts.ForeColor = System.Drawing.Color.White;
            this.SearchButtonForProducts.Location = new System.Drawing.Point(224, 82);
            this.SearchButtonForProducts.Name = "SearchButtonForProducts";
            this.SearchButtonForProducts.Size = new System.Drawing.Size(77, 29);
            this.SearchButtonForProducts.TabIndex = 80;
            this.SearchButtonForProducts.Text = "Choose";
            this.SearchButtonForProducts.UseVisualStyleBackColor = false;
            this.SearchButtonForProducts.Click += new System.EventHandler(this.SearchButtonForProducts_Click);
            // 
            // ProducBox222
            // 
            this.ProducBox222.FormattingEnabled = true;
            this.ProducBox222.Items.AddRange(new object[] {
            "Iphpne 12 Pro",
            "OnePlus 8 Pro",
            "Samsung S20 Plus",
            "Xiaomi Mi 10 Pro"});
            this.ProducBox222.Location = new System.Drawing.Point(48, 87);
            this.ProducBox222.Name = "ProducBox222";
            this.ProducBox222.Size = new System.Drawing.Size(170, 21);
            this.ProducBox222.TabIndex = 91;
            // 
            // CdashBoard
            // 
            this.CdashBoard.BackColor = System.Drawing.Color.Red;
            this.CdashBoard.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CdashBoard.ForeColor = System.Drawing.Color.White;
            this.CdashBoard.Location = new System.Drawing.Point(54, 334);
            this.CdashBoard.Name = "CdashBoard";
            this.CdashBoard.Padding = new System.Windows.Forms.Padding(5);
            this.CdashBoard.Size = new System.Drawing.Size(122, 34);
            this.CdashBoard.TabIndex = 92;
            this.CdashBoard.Text = "C:DashBoard";
            this.CdashBoard.UseVisualStyleBackColor = false;
            this.CdashBoard.Click += new System.EventHandler(this.CdashBoard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.ProductDataGridView);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(40, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 386);
            this.panel1.TabIndex = 93;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(47, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 16);
            this.label11.TabIndex = 82;
            this.label11.Text = "Select Product From This List )";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.CdashBoard);
            this.panel2.Controls.Add(this.HomePageBtn111);
            this.panel2.Controls.Add(this.ProducBox222);
            this.panel2.Controls.Add(this.SearchButtonForProducts);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BuyNowBtn);
            this.panel2.Controls.Add(this.ProNameBox211);
            this.panel2.Controls.Add(this.ProPriceCateGoryBox211);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.ProQuantityBox211);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.ProPriceBox211);
            this.panel2.Location = new System.Drawing.Point(411, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 386);
            this.panel2.TabIndex = 59;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 50);
            this.panel3.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 39);
            this.label2.TabIndex = 93;
            this.label2.Text = "Choose Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 16);
            this.label1.TabIndex = 94;
            this.label1.Text = "(Search From Available Products)";
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProductPage";
            this.Text = "jkl";
            this.Load += new System.EventHandler(this.ProductPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.Button HomePageBtn111;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProNameBox211;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ProPriceBox211;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ProQuantityBox211;
        private System.Windows.Forms.TextBox ProPriceCateGoryBox211;
        private System.Windows.Forms.Button BuyNowBtn;
        private System.Windows.Forms.Button SearchButtonForProducts;
        private System.Windows.Forms.ComboBox ProducBox222;
        private System.Windows.Forms.Button CdashBoard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
    }
}