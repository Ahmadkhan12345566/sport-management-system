namespace project_start.PresentationtationLayer
{
    partial class Add2PlayersTeamcs
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
            this.Player1textBox8 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Cancelbutton1 = new System.Windows.Forms.Button();
            this.Donebutton1 = new System.Windows.Forms.Button();
            this.PlayerNametextBox2 = new System.Windows.Forms.TextBox();
            this.PlayerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeprtcomboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TeamNametextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Player2textBox2 = new System.Windows.Forms.TextBox();
            this.SymestercomboBox1 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Player1textBox8
            // 
            this.Player1textBox8.Location = new System.Drawing.Point(569, 279);
            this.Player1textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.Player1textBox8.Name = "Player1textBox8";
            this.Player1textBox8.Size = new System.Drawing.Size(59, 20);
            this.Player1textBox8.TabIndex = 5;
            this.Player1textBox8.TextChanged += new System.EventHandler(this.Player1textBox8_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(488, 280);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 103;
            this.label12.Text = "Reg No";
            // 
            // Cancelbutton1
            // 
            this.Cancelbutton1.Location = new System.Drawing.Point(468, 371);
            this.Cancelbutton1.Name = "Cancelbutton1";
            this.Cancelbutton1.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton1.TabIndex = 8;
            this.Cancelbutton1.Text = "Cancel";
            this.Cancelbutton1.UseVisualStyleBackColor = true;
            this.Cancelbutton1.Click += new System.EventHandler(this.Cancelbutton1_Click);
            // 
            // Donebutton1
            // 
            this.Donebutton1.Location = new System.Drawing.Point(569, 371);
            this.Donebutton1.Name = "Donebutton1";
            this.Donebutton1.Size = new System.Drawing.Size(75, 23);
            this.Donebutton1.TabIndex = 9;
            this.Donebutton1.Text = "Done";
            this.Donebutton1.UseVisualStyleBackColor = true;
            this.Donebutton1.Click += new System.EventHandler(this.Donebutton1_Click);
            // 
            // PlayerNametextBox2
            // 
            this.PlayerNametextBox2.Location = new System.Drawing.Point(251, 280);
            this.PlayerNametextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerNametextBox2.Name = "PlayerNametextBox2";
            this.PlayerNametextBox2.Size = new System.Drawing.Size(229, 20);
            this.PlayerNametextBox2.TabIndex = 4;
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Location = new System.Drawing.Point(56, 287);
            this.PlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(73, 13);
            this.PlayerName.TabIndex = 99;
            this.PlayerName.Text = "Player1 Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 98;
            this.label4.Text = "Players Info";
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
            this.DeprtcomboBox2.Location = new System.Drawing.Point(240, 193);
            this.DeprtcomboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.DeprtcomboBox2.Name = "DeprtcomboBox2";
            this.DeprtcomboBox2.Size = new System.Drawing.Size(160, 21);
            this.DeprtcomboBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 96;
            this.label3.Text = "Depart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = "Semester";
            // 
            // TeamNametextBox1
            // 
            this.TeamNametextBox1.Location = new System.Drawing.Point(239, 110);
            this.TeamNametextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.TeamNametextBox1.Name = "TeamNametextBox1";
            this.TeamNametextBox1.Size = new System.Drawing.Size(229, 20);
            this.TeamNametextBox1.TabIndex = 1;
            this.TeamNametextBox1.TextChanged += new System.EventHandler(this.TeamNametextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 16);
            this.label1.TabIndex = 92;
            this.label1.Text = "Enter the Name of Team";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 322);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 105;
            this.label5.Text = "Player2 Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 315);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, 315);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 107;
            this.label6.Text = "Reg No";
            // 
            // Player2textBox2
            // 
            this.Player2textBox2.Location = new System.Drawing.Point(569, 314);
            this.Player2textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.Player2textBox2.Name = "Player2textBox2";
            this.Player2textBox2.Size = new System.Drawing.Size(59, 20);
            this.Player2textBox2.TabIndex = 7;
            // 
            // SymestercomboBox1
            // 
            this.SymestercomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SymestercomboBox1.FormattingEnabled = true;
            this.SymestercomboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.SymestercomboBox1.Location = new System.Drawing.Point(240, 156);
            this.SymestercomboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.SymestercomboBox1.Name = "SymestercomboBox1";
            this.SymestercomboBox1.Size = new System.Drawing.Size(160, 21);
            this.SymestercomboBox1.TabIndex = 2;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.OrangeRed;
            this.label24.Location = new System.Drawing.Point(348, 425);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(307, 16);
            this.label24.TabIndex = 157;
            this.label24.Text = "!!!!!!!   0nce team enterd Cannot be Changed";
            // 
            // Add2PlayersTeamcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 472);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.SymestercomboBox1);
            this.Controls.Add(this.Player2textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Player1textBox8);
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
            this.Name = "Add2PlayersTeamcs";
            this.Text = "Add2PlayersTeams";
            this.Load += new System.EventHandler(this.Add2PlayersTeamcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Player1textBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Cancelbutton1;
        private System.Windows.Forms.Button Donebutton1;
        private System.Windows.Forms.TextBox PlayerNametextBox2;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DeprtcomboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TeamNametextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Player2textBox2;
        private System.Windows.Forms.ComboBox SymestercomboBox1;
        private System.Windows.Forms.Label label24;
    }
}