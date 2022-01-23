
namespace Project.Views
{
    partial class HomePageForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomePagePanel = new System.Windows.Forms.Panel();
            this.HomepageAdminBtn = new System.Windows.Forms.Button();
            this.HomePageManagerBtn = new System.Windows.Forms.Button();
            this.HomePage_EP_Btn = new System.Windows.Forms.Button();
            this.HomePageCMBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HomePageBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HomePagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.shop;
            this.pictureBox1.Location = new System.Drawing.Point(105, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(696, 449);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HomePagePanel
            // 
            this.HomePagePanel.BackColor = System.Drawing.Color.Blue;
            this.HomePagePanel.Controls.Add(this.HomepageAdminBtn);
            this.HomePagePanel.Controls.Add(this.HomePageManagerBtn);
            this.HomePagePanel.Controls.Add(this.HomePage_EP_Btn);
            this.HomePagePanel.Controls.Add(this.HomePageCMBtn);
            this.HomePagePanel.Controls.Add(this.HomePageBtn);
            this.HomePagePanel.Controls.Add(this.label1);
            this.HomePagePanel.Location = new System.Drawing.Point(1, -1);
            this.HomePagePanel.Name = "HomePagePanel";
            this.HomePagePanel.Size = new System.Drawing.Size(152, 452);
            this.HomePagePanel.TabIndex = 1;
            // 
            // HomepageAdminBtn
            // 
            this.HomepageAdminBtn.BackColor = System.Drawing.Color.Red;
            this.HomepageAdminBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomepageAdminBtn.ForeColor = System.Drawing.Color.White;
            this.HomepageAdminBtn.Location = new System.Drawing.Point(14, 343);
            this.HomepageAdminBtn.Name = "HomepageAdminBtn";
            this.HomepageAdminBtn.Padding = new System.Windows.Forms.Padding(5);
            this.HomepageAdminBtn.Size = new System.Drawing.Size(126, 36);
            this.HomepageAdminBtn.TabIndex = 10;
            this.HomepageAdminBtn.Text = "Admin";
            this.HomepageAdminBtn.UseVisualStyleBackColor = false;
            this.HomepageAdminBtn.Click += new System.EventHandler(this.HomepageAdminBtn_Click);
            // 
            // HomePageManagerBtn
            // 
            this.HomePageManagerBtn.BackColor = System.Drawing.Color.Red;
            this.HomePageManagerBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePageManagerBtn.ForeColor = System.Drawing.Color.White;
            this.HomePageManagerBtn.Location = new System.Drawing.Point(14, 282);
            this.HomePageManagerBtn.Name = "HomePageManagerBtn";
            this.HomePageManagerBtn.Padding = new System.Windows.Forms.Padding(5);
            this.HomePageManagerBtn.Size = new System.Drawing.Size(126, 36);
            this.HomePageManagerBtn.TabIndex = 9;
            this.HomePageManagerBtn.Text = "Manager";
            this.HomePageManagerBtn.UseVisualStyleBackColor = false;
            this.HomePageManagerBtn.Click += new System.EventHandler(this.HomePageManagerBtn_Click);
            // 
            // HomePage_EP_Btn
            // 
            this.HomePage_EP_Btn.BackColor = System.Drawing.Color.Red;
            this.HomePage_EP_Btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePage_EP_Btn.ForeColor = System.Drawing.Color.White;
            this.HomePage_EP_Btn.Location = new System.Drawing.Point(14, 220);
            this.HomePage_EP_Btn.Name = "HomePage_EP_Btn";
            this.HomePage_EP_Btn.Padding = new System.Windows.Forms.Padding(5);
            this.HomePage_EP_Btn.Size = new System.Drawing.Size(126, 36);
            this.HomePage_EP_Btn.TabIndex = 8;
            this.HomePage_EP_Btn.Text = "Employee";
            this.HomePage_EP_Btn.UseVisualStyleBackColor = false;
            this.HomePage_EP_Btn.Click += new System.EventHandler(this.HomePage_EP_Btn_Click);
            // 
            // HomePageCMBtn
            // 
            this.HomePageCMBtn.BackColor = System.Drawing.Color.Red;
            this.HomePageCMBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePageCMBtn.ForeColor = System.Drawing.Color.White;
            this.HomePageCMBtn.Location = new System.Drawing.Point(14, 156);
            this.HomePageCMBtn.Name = "HomePageCMBtn";
            this.HomePageCMBtn.Padding = new System.Windows.Forms.Padding(5);
            this.HomePageCMBtn.Size = new System.Drawing.Size(126, 36);
            this.HomePageCMBtn.TabIndex = 7;
            this.HomePageCMBtn.Text = "Customer";
            this.HomePageCMBtn.UseVisualStyleBackColor = false;
            this.HomePageCMBtn.Click += new System.EventHandler(this.HomePageCMBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // HomePageBtn
            // 
            this.HomePageBtn.BackColor = System.Drawing.Color.Red;
            this.HomePageBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePageBtn.ForeColor = System.Drawing.Color.White;
            this.HomePageBtn.Location = new System.Drawing.Point(14, 89);
            this.HomePageBtn.Name = "HomePageBtn";
            this.HomePageBtn.Padding = new System.Windows.Forms.Padding(5);
            this.HomePageBtn.Size = new System.Drawing.Size(126, 36);
            this.HomePageBtn.TabIndex = 2;
            this.HomePageBtn.Text = "HomePage";
            this.HomePageBtn.UseVisualStyleBackColor = false;
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomePagePanel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HomePageForm";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HomePagePanel.ResumeLayout(false);
            this.HomePagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel HomePagePanel;
        private System.Windows.Forms.Button HomepageAdminBtn;
        private System.Windows.Forms.Button HomePageManagerBtn;
        private System.Windows.Forms.Button HomePage_EP_Btn;
        private System.Windows.Forms.Button HomePageCMBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HomePageBtn;
    }
}