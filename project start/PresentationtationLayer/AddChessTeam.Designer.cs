namespace project_start.PresentationtationLayer
{
    partial class AddChessTeam
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
            if (!isBack)
            ParentttFormReference.Dispose();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TeamNametextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeprtcomboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.Label();
            this.PlayerNametextBox2 = new System.Windows.Forms.TextBox();
            this.Donebutton1 = new System.Windows.Forms.Button();
            this.Cancelbutton1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.PlayerRegNotextBox8 = new System.Windows.Forms.TextBox();
            this.SymestercomboBox1 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the Name of Team";
            // 
            // TeamNametextBox1
            // 
            this.TeamNametextBox1.Location = new System.Drawing.Point(242, 128);
            this.TeamNametextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.TeamNametextBox1.Name = "TeamNametextBox1";
            this.TeamNametextBox1.Size = new System.Drawing.Size(229, 20);
            this.TeamNametextBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Department";
            // 
            // DeprtcomboBox2
            // 
            this.DeprtcomboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeprtcomboBox2.FormattingEnabled = true;
            this.DeprtcomboBox2.Items.AddRange(new object[] {
            "BS(CS)",
            "BS(CE)",
            "BBA",
            "B.com",
            "BEEE",
            "Pharmachy",
            ""});
            this.DeprtcomboBox2.Location = new System.Drawing.Point(242, 213);
            this.DeprtcomboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.DeprtcomboBox2.Name = "DeprtcomboBox2";
            this.DeprtcomboBox2.Size = new System.Drawing.Size(160, 21);
            this.DeprtcomboBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Players Info";
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Location = new System.Drawing.Point(47, 299);
            this.PlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(67, 13);
            this.PlayerName.TabIndex = 37;
            this.PlayerName.Text = "Player Name";
            // 
            // PlayerNametextBox2
            // 
            this.PlayerNametextBox2.Location = new System.Drawing.Point(242, 292);
            this.PlayerNametextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerNametextBox2.Name = "PlayerNametextBox2";
            this.PlayerNametextBox2.Size = new System.Drawing.Size(229, 20);
            this.PlayerNametextBox2.TabIndex = 4;
            // 
            // Donebutton1
            // 
            this.Donebutton1.Location = new System.Drawing.Point(526, 327);
            this.Donebutton1.Name = "Donebutton1";
            this.Donebutton1.Size = new System.Drawing.Size(75, 23);
            this.Donebutton1.TabIndex = 7;
            this.Donebutton1.Text = "Done";
            this.Donebutton1.UseVisualStyleBackColor = true;
            this.Donebutton1.Click += new System.EventHandler(this.Donebutton1_Click);
            // 
            // Cancelbutton1
            // 
            this.Cancelbutton1.Location = new System.Drawing.Point(431, 327);
            this.Cancelbutton1.Name = "Cancelbutton1";
            this.Cancelbutton1.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton1.TabIndex = 6;
            this.Cancelbutton1.Text = "Cancel";
            this.Cancelbutton1.UseVisualStyleBackColor = true;
            this.Cancelbutton1.Click += new System.EventHandler(this.Cancelbutton1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(479, 292);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 90;
            this.label12.Text = "Reg No";
            // 
            // PlayerRegNotextBox8
            // 
            this.PlayerRegNotextBox8.Location = new System.Drawing.Point(542, 291);
            this.PlayerRegNotextBox8.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerRegNotextBox8.Name = "PlayerRegNotextBox8";
            this.PlayerRegNotextBox8.Size = new System.Drawing.Size(59, 20);
            this.PlayerRegNotextBox8.TabIndex = 5;
            // 
            // SymestercomboBox1
            // 
            this.SymestercomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SymestercomboBox1.FormattingEnabled = true;
            this.SymestercomboBox1.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.SymestercomboBox1.Location = new System.Drawing.Point(242, 169);
            this.SymestercomboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.SymestercomboBox1.MaxLength = 9;
            this.SymestercomboBox1.Name = "SymestercomboBox1";
            this.SymestercomboBox1.Size = new System.Drawing.Size(160, 21);
            this.SymestercomboBox1.TabIndex = 2;
            this.SymestercomboBox1.Tag = "";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.OrangeRed;
            this.label24.Location = new System.Drawing.Point(320, 386);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(307, 16);
            this.label24.TabIndex = 157;
            this.label24.Text = "!!!!!!!   0nce team enterd Cannot be Changed";
            // 
            // AddChessTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_start.Properties.Resources._13224281_1885740328319567_1050654075_o;
            this.ClientSize = new System.Drawing.Size(980, 472);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.SymestercomboBox1);
            this.Controls.Add(this.PlayerRegNotextBox8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Cancelbutton1);
            this.Controls.Add(this.Donebutton1);
            this.Controls.Add(this.PlayerNametextBox2);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeprtcomboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TeamNametextBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddChessTeam";
            this.Text = "AddChessTeam";
            this.Load += new System.EventHandler(this.AddChessTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TeamNametextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DeprtcomboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.TextBox PlayerNametextBox2;
        private System.Windows.Forms.Button Donebutton1;
        private System.Windows.Forms.Button Cancelbutton1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PlayerRegNotextBox8;
        private System.Windows.Forms.ComboBox SymestercomboBox1;
        private System.Windows.Forms.Label label24;
    }
}