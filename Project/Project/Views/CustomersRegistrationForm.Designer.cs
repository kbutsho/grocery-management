
namespace Project.Views
{
    partial class CustomersRegistrationForm
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
            this.CMPassWordBoxReg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CMEmailRegInput = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CMUserNameRegBox = new System.Windows.Forms.RichTextBox();
            this.CMRegBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CMRegNameInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CMPassWordBoxReg
            // 
            this.CMPassWordBoxReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMPassWordBoxReg.Location = new System.Drawing.Point(352, 278);
            this.CMPassWordBoxReg.Name = "CMPassWordBoxReg";
            this.CMPassWordBoxReg.Size = new System.Drawing.Size(218, 35);
            this.CMPassWordBoxReg.TabIndex = 40;
            this.CMPassWordBoxReg.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(128, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(544, 57);
            this.label2.TabIndex = 39;
            this.label2.Text = "Customers Registration Form";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CMEmailRegInput
            // 
            this.CMEmailRegInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMEmailRegInput.Location = new System.Drawing.Point(352, 227);
            this.CMEmailRegInput.Name = "CMEmailRegInput";
            this.CMEmailRegInput.Size = new System.Drawing.Size(218, 36);
            this.CMEmailRegInput.TabIndex = 38;
            this.CMEmailRegInput.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(195, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 29);
            this.label5.TabIndex = 37;
            this.label5.Text = "PassWord";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(195, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 36;
            this.label4.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(195, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "UserName";
            // 
            // CMUserNameRegBox
            // 
            this.CMUserNameRegBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMUserNameRegBox.Location = new System.Drawing.Point(352, 177);
            this.CMUserNameRegBox.Name = "CMUserNameRegBox";
            this.CMUserNameRegBox.Size = new System.Drawing.Size(218, 36);
            this.CMUserNameRegBox.TabIndex = 34;
            this.CMUserNameRegBox.Text = "";
            // 
            // CMRegBtn
            // 
            this.CMRegBtn.BackColor = System.Drawing.Color.Red;
            this.CMRegBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMRegBtn.ForeColor = System.Drawing.Color.White;
            this.CMRegBtn.Location = new System.Drawing.Point(444, 335);
            this.CMRegBtn.Name = "CMRegBtn";
            this.CMRegBtn.Size = new System.Drawing.Size(126, 45);
            this.CMRegBtn.TabIndex = 33;
            this.CMRegBtn.Text = "Submit";
            this.CMRegBtn.UseVisualStyleBackColor = false;
            this.CMRegBtn.Click += new System.EventHandler(this.CMRegBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(195, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 42;
            this.label3.Text = "Name";
            // 
            // CMRegNameInput
            // 
            this.CMRegNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMRegNameInput.Location = new System.Drawing.Point(352, 124);
            this.CMRegNameInput.Name = "CMRegNameInput";
            this.CMRegNameInput.Size = new System.Drawing.Size(218, 36);
            this.CMRegNameInput.TabIndex = 41;
            this.CMRegNameInput.Text = "";
            // 
            // CustomersRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CMRegNameInput);
            this.Controls.Add(this.CMPassWordBoxReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMEmailRegInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMUserNameRegBox);
            this.Controls.Add(this.CMRegBtn);
            this.Name = "CustomersRegistrationForm";
            this.Text = "CustomersRegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CMPassWordBoxReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox CMEmailRegInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox CMUserNameRegBox;
        private System.Windows.Forms.Button CMRegBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox CMRegNameInput;
    }
}