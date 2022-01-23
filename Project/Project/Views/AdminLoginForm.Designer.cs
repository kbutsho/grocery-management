
namespace Project.Views
{
    partial class AdminLoginForm
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
            this.A_EmailBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.A_UserNameBox = new System.Windows.Forms.RichTextBox();
            this.A_LoginBtn = new System.Windows.Forms.Button();
            this.A_PassWordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(195, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 57);
            this.label2.TabIndex = 30;
            this.label2.Text = "Admin Login Form";
            // 
            // A_EmailBox
            // 
            this.A_EmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_EmailBox.Location = new System.Drawing.Point(357, 193);
            this.A_EmailBox.Name = "A_EmailBox";
            this.A_EmailBox.Size = new System.Drawing.Size(218, 36);
            this.A_EmailBox.TabIndex = 29;
            this.A_EmailBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(200, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "PassWord";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(200, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(200, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "UserName";
            // 
            // A_UserNameBox
            // 
            this.A_UserNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_UserNameBox.Location = new System.Drawing.Point(357, 143);
            this.A_UserNameBox.Name = "A_UserNameBox";
            this.A_UserNameBox.Size = new System.Drawing.Size(218, 36);
            this.A_UserNameBox.TabIndex = 24;
            this.A_UserNameBox.Text = "";
            // 
            // A_LoginBtn
            // 
            this.A_LoginBtn.BackColor = System.Drawing.Color.Red;
            this.A_LoginBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_LoginBtn.ForeColor = System.Drawing.Color.White;
            this.A_LoginBtn.Location = new System.Drawing.Point(476, 302);
            this.A_LoginBtn.Name = "A_LoginBtn";
            this.A_LoginBtn.Size = new System.Drawing.Size(99, 44);
            this.A_LoginBtn.TabIndex = 23;
            this.A_LoginBtn.Text = "Login ";
            this.A_LoginBtn.UseVisualStyleBackColor = false;
            this.A_LoginBtn.Click += new System.EventHandler(this.A_LoginBtn_Click);
            // 
            // A_PassWordBox
            // 
            this.A_PassWordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_PassWordBox.Location = new System.Drawing.Point(357, 248);
            this.A_PassWordBox.Name = "A_PassWordBox";
            this.A_PassWordBox.Size = new System.Drawing.Size(218, 35);
            this.A_PassWordBox.TabIndex = 31;
            this.A_PassWordBox.UseSystemPasswordChar = true;
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.A_PassWordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.A_EmailBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.A_UserNameBox);
            this.Controls.Add(this.A_LoginBtn);
            this.Name = "AdminLoginForm";
            this.Text = "AdminLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox A_EmailBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox A_UserNameBox;
        private System.Windows.Forms.Button A_LoginBtn;
        private System.Windows.Forms.TextBox A_PassWordBox;
    }
}