
namespace Project.Views
{
    partial class CustomersLoginForm
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
            this.CMLoginBtn = new System.Windows.Forms.Button();
            this.CMUserNameBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CMEmailBox = new System.Windows.Forms.RichTextBox();
            this.CMRegBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CMPassWordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CMLoginBtn
            // 
            this.CMLoginBtn.BackColor = System.Drawing.Color.Red;
            this.CMLoginBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMLoginBtn.ForeColor = System.Drawing.Color.White;
            this.CMLoginBtn.Location = new System.Drawing.Point(456, 295);
            this.CMLoginBtn.Name = "CMLoginBtn";
            this.CMLoginBtn.Size = new System.Drawing.Size(99, 44);
            this.CMLoginBtn.TabIndex = 0;
            this.CMLoginBtn.Text = "Login ";
            this.CMLoginBtn.UseVisualStyleBackColor = false;
            this.CMLoginBtn.Click += new System.EventHandler(this.CMLoginBtn_Click);
            // 
            // CMUserNameBox
            // 
            this.CMUserNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMUserNameBox.Location = new System.Drawing.Point(337, 118);
            this.CMUserNameBox.Name = "CMUserNameBox";
            this.CMUserNameBox.Size = new System.Drawing.Size(218, 36);
            this.CMUserNameBox.TabIndex = 4;
            this.CMUserNameBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(180, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(180, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(180, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "PassWord";
            // 
            // CMEmailBox
            // 
            this.CMEmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMEmailBox.Location = new System.Drawing.Point(337, 168);
            this.CMEmailBox.Name = "CMEmailBox";
            this.CMEmailBox.Size = new System.Drawing.Size(218, 36);
            this.CMEmailBox.TabIndex = 11;
            this.CMEmailBox.Text = "";
            // 
            // CMRegBtn
            // 
            this.CMRegBtn.BackColor = System.Drawing.Color.White;
            this.CMRegBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMRegBtn.ForeColor = System.Drawing.Color.Red;
            this.CMRegBtn.Location = new System.Drawing.Point(185, 295);
            this.CMRegBtn.Name = "CMRegBtn";
            this.CMRegBtn.Size = new System.Drawing.Size(212, 44);
            this.CMRegBtn.TabIndex = 12;
            this.CMRegBtn.Text = "Not Registered?";
            this.CMRegBtn.UseVisualStyleBackColor = false;
            this.CMRegBtn.Click += new System.EventHandler(this.CMRegBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(175, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 57);
            this.label2.TabIndex = 13;
            this.label2.Text = "Customer Login Form";
            // 
            // CMPassWordBox
            // 
            this.CMPassWordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMPassWordBox.Location = new System.Drawing.Point(337, 223);
            this.CMPassWordBox.Name = "CMPassWordBox";
            this.CMPassWordBox.Size = new System.Drawing.Size(218, 35);
            this.CMPassWordBox.TabIndex = 33;
            this.CMPassWordBox.UseSystemPasswordChar = true;
            // 
            // CustomersLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CMPassWordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMRegBtn);
            this.Controls.Add(this.CMEmailBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMUserNameBox);
            this.Controls.Add(this.CMLoginBtn);
            this.Name = "CustomersLoginForm";
            this.Text = "CustomersLoginForm";
            this.Load += new System.EventHandler(this.CustomersLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CMLoginBtn;
        private System.Windows.Forms.RichTextBox CMUserNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox CMEmailBox;
        private System.Windows.Forms.Button CMRegBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CMPassWordBox;
    }
}