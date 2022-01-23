
namespace Project.Views
{
    partial class EmployeesLoginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.EPEmailBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EPUserNameBox = new System.Windows.Forms.RichTextBox();
            this.EPLoginBtn = new System.Windows.Forms.Button();
            this.EPPassWordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(186, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 57);
            this.label2.TabIndex = 22;
            this.label2.Text = "Employee Login Form";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EPEmailBox
            // 
            this.EPEmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPEmailBox.Location = new System.Drawing.Point(348, 192);
            this.EPEmailBox.Name = "EPEmailBox";
            this.EPEmailBox.Size = new System.Drawing.Size(218, 36);
            this.EPEmailBox.TabIndex = 20;
            this.EPEmailBox.Text = "";
            this.EPEmailBox.TextChanged += new System.EventHandler(this.EPEmailBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(191, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "PassWord";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(191, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "UserName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EPUserNameBox
            // 
            this.EPUserNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPUserNameBox.Location = new System.Drawing.Point(348, 142);
            this.EPUserNameBox.Name = "EPUserNameBox";
            this.EPUserNameBox.Size = new System.Drawing.Size(218, 36);
            this.EPUserNameBox.TabIndex = 15;
            this.EPUserNameBox.Text = "";
            this.EPUserNameBox.TextChanged += new System.EventHandler(this.EPUserNameBox_TextChanged);
            // 
            // EPLoginBtn
            // 
            this.EPLoginBtn.BackColor = System.Drawing.Color.Red;
            this.EPLoginBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPLoginBtn.ForeColor = System.Drawing.Color.White;
            this.EPLoginBtn.Location = new System.Drawing.Point(467, 294);
            this.EPLoginBtn.Name = "EPLoginBtn";
            this.EPLoginBtn.Size = new System.Drawing.Size(99, 44);
            this.EPLoginBtn.TabIndex = 14;
            this.EPLoginBtn.Text = "Login ";
            this.EPLoginBtn.UseVisualStyleBackColor = false;
            this.EPLoginBtn.Click += new System.EventHandler(this.EPLoginBtn_Click);
            // 
            // EPPassWordBox
            // 
            this.EPPassWordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPPassWordBox.Location = new System.Drawing.Point(348, 243);
            this.EPPassWordBox.Name = "EPPassWordBox";
            this.EPPassWordBox.Size = new System.Drawing.Size(218, 35);
            this.EPPassWordBox.TabIndex = 32;
            this.EPPassWordBox.UseSystemPasswordChar = true;
            this.EPPassWordBox.TextChanged += new System.EventHandler(this.EPPassWordBox_TextChanged);
            // 
            // EmployeesLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EPPassWordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EPEmailBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EPUserNameBox);
            this.Controls.Add(this.EPLoginBtn);
            this.Name = "EmployeesLoginForm";
            this.Text = "EmployeesLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox EPEmailBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox EPUserNameBox;
        private System.Windows.Forms.Button EPLoginBtn;
        private System.Windows.Forms.TextBox EPPassWordBox;
    }
}