namespace project_start.PresentationtationLayer
{
    partial class AddTeamm
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
            this.label1 = new System.Windows.Forms.Label();
            this.GamecomboBox1 = new System.Windows.Forms.ComboBox();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seletct the game";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GamecomboBox1
            // 
            this.GamecomboBox1.FormattingEnabled = true;
            this.GamecomboBox1.Items.AddRange(new object[] {
            "Crikect",
            "Football",
            "Ludo",
            "Chess",
            "Badmention",
            "Tabletaness"});
            this.GamecomboBox1.Location = new System.Drawing.Point(155, 31);
            this.GamecomboBox1.Name = "GamecomboBox1";
            this.GamecomboBox1.Size = new System.Drawing.Size(121, 21);
            this.GamecomboBox1.TabIndex = 1;
            this.GamecomboBox1.SelectedIndexChanged += new System.EventHandler(this.GamecomboBox1_SelectedIndexChanged);
            // 
            // Nextbutton
            // 
            this.Nextbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nextbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nextbutton.Location = new System.Drawing.Point(265, 69);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(75, 23);
            this.Nextbutton.TabIndex = 2;
            this.Nextbutton.Text = "Next";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // AddTeamm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 473);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.GamecomboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddTeamm";
            this.Text = "AddTeamm";
            this.Load += new System.EventHandler(this.AddTeamm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GamecomboBox1;
        private System.Windows.Forms.Button Nextbutton;
    }
}