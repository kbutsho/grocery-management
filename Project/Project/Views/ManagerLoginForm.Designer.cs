
namespace Project.Views
{
    partial class ManagerLoginForm
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
            this.MLoginBtn = new System.Windows.Forms.Button();
            this.MUserNameBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MEmailBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MPassWordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MLoginBtn
            // 
            this.MLoginBtn.BackColor = System.Drawing.Color.Red;
            this.MLoginBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLoginBtn.ForeColor = System.Drawing.Color.White;
            this.MLoginBtn.Location = new System.Drawing.Point(472, 290);
            this.MLoginBtn.Name = "MLoginBtn";
            this.MLoginBtn.Size = new System.Drawing.Size(99, 44);
            this.MLoginBtn.TabIndex = 14;
            this.MLoginBtn.Text = "Login ";
            this.MLoginBtn.UseVisualStyleBackColor = false;
            this.MLoginBtn.Click += new System.EventHandler(this.MLoginBtn_Click);
            // 
            // MUserNameBox
            // 
            this.MUserNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MUserNameBox.Location = new System.Drawing.Point(353, 131);
            this.MUserNameBox.Name = "MUserNameBox";
            this.MUserNameBox.Size = new System.Drawing.Size(218, 36);
            this.MUserNameBox.TabIndex = 15;
            this.MUserNameBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(196, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(196, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(196, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "PassWord";
            // 
            // MEmailBox
            // 
            this.MEmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MEmailBox.Location = new System.Drawing.Point(353, 181);
            this.MEmailBox.Name = "MEmailBox";
            this.MEmailBox.Size = new System.Drawing.Size(218, 36);
            this.MEmailBox.TabIndex = 20;
            this.MEmailBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(191, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 57);
            this.label2.TabIndex = 22;
            this.label2.Text = "Manager Login Form";
            // 
            // MPassWordBox
            // 
            this.MPassWordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MPassWordBox.Location = new System.Drawing.Point(353, 232);
            this.MPassWordBox.Name = "MPassWordBox";
            this.MPassWordBox.Size = new System.Drawing.Size(218, 35);
            this.MPassWordBox.TabIndex = 23;
            this.MPassWordBox.UseSystemPasswordChar = true;
            // 
            // ManagerLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MPassWordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MEmailBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MUserNameBox);
            this.Controls.Add(this.MLoginBtn);
            this.Name = "ManagerLoginForm";
            this.Text = "ManagerLoginForm";
            this.Load += new System.EventHandler(this.ManagerLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MLoginBtn;
        private System.Windows.Forms.RichTextBox MUserNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox MEmailBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MPassWordBox;
    }
}