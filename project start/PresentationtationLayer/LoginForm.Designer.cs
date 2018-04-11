namespace project_start.PresentationtationLayer
{
    partial class LoginForm
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
            this.usernametextBox1 = new System.Windows.Forms.TextBox();
            this.Loginbutton1 = new System.Windows.Forms.Button();
            this.PasswordtextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernametextBox1
            // 
            this.usernametextBox1.Location = new System.Drawing.Point(510, 234);
            this.usernametextBox1.Name = "usernametextBox1";
            this.usernametextBox1.Size = new System.Drawing.Size(100, 20);
            this.usernametextBox1.TabIndex = 1;
            // 
            // Loginbutton1
            // 
            this.Loginbutton1.Location = new System.Drawing.Point(556, 308);
            this.Loginbutton1.Name = "Loginbutton1";
            this.Loginbutton1.Size = new System.Drawing.Size(75, 23);
            this.Loginbutton1.TabIndex = 3;
            this.Loginbutton1.Text = "Login";
            this.Loginbutton1.UseVisualStyleBackColor = true;
            this.Loginbutton1.Click += new System.EventHandler(this.Loginbutton1_Click);
            // 
            // PasswordtextBox1
            // 
            this.PasswordtextBox1.Location = new System.Drawing.Point(510, 266);
            this.PasswordtextBox1.Name = "PasswordtextBox1";
            this.PasswordtextBox1.PasswordChar = '#';
            this.PasswordtextBox1.Size = new System.Drawing.Size(100, 20);
            this.PasswordtextBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_start.Properties.Resources._13181122_1885738188319781_369118288_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 472);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordtextBox1);
            this.Controls.Add(this.Loginbutton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernametextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernametextBox1;
        private System.Windows.Forms.Button Loginbutton1;
        private System.Windows.Forms.TextBox PasswordtextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

