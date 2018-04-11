namespace project_start.PresentationtationLayer
{
    partial class MainForm
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
            ParentFormReference.Dispose();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListOfGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabletensbutton7 = new System.Windows.Forms.Button();
            this.Chessbutton4 = new System.Windows.Forms.Button();
            this.Ludobutton6 = new System.Windows.Forms.Button();
            this.Footbalbutton5 = new System.Windows.Forms.Button();
            this.BAdmentonbutton3 = new System.Windows.Forms.Button();
            this.AddGamepanel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Backbutton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FootbalcheckBox6 = new System.Windows.Forms.CheckBox();
            this.ChesscheckBox5 = new System.Windows.Forms.CheckBox();
            this.BadmentioncheckBox4 = new System.Windows.Forms.CheckBox();
            this.LudocheckBox3 = new System.Windows.Forms.CheckBox();
            this.TAbletenesscheckBox2 = new System.Windows.Forms.CheckBox();
            this.CricketcheckBox1 = new System.Windows.Forms.CheckBox();
            this.Removegamepanel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.footbalcheckBox1 = new System.Windows.Forms.CheckBox();
            this.chesscheckBox2 = new System.Windows.Forms.CheckBox();
            this.badcheckBox3 = new System.Windows.Forms.CheckBox();
            this.ludocheckBox4 = new System.Windows.Forms.CheckBox();
            this.taablecheckBox5 = new System.Windows.Forms.CheckBox();
            this.cricketcheckBox6 = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Addteampanel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.GamecomboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cricketbutton2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.AddGamepanel2.SuspendLayout();
            this.Removegamepanel2.SuspendLayout();
            this.Addteampanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.teamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(192, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lockToolStripMenuItem.Text = "&Logout";
            this.lockToolStripMenuItem.Click += new System.EventHandler(this.lockToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGameToolStripMenuItem,
            this.removeGameToolStripMenuItem,
            this.viewListOfGamesToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.gameToolStripMenuItem.Text = "Games";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.gameToolStripMenuItem_Click);
            // 
            // addGameToolStripMenuItem
            // 
            this.addGameToolStripMenuItem.Name = "addGameToolStripMenuItem";
            this.addGameToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addGameToolStripMenuItem.Text = "Add Game";
            this.addGameToolStripMenuItem.Click += new System.EventHandler(this.addGameToolStripMenuItem_Click);
            // 
            // removeGameToolStripMenuItem
            // 
            this.removeGameToolStripMenuItem.Name = "removeGameToolStripMenuItem";
            this.removeGameToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.removeGameToolStripMenuItem.Text = "Remove Game";
            this.removeGameToolStripMenuItem.Click += new System.EventHandler(this.removeGameToolStripMenuItem_Click);
            // 
            // viewListOfGamesToolStripMenuItem
            // 
            this.viewListOfGamesToolStripMenuItem.Name = "viewListOfGamesToolStripMenuItem";
            this.viewListOfGamesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.viewListOfGamesToolStripMenuItem.Text = "View List of Games";
            this.viewListOfGamesToolStripMenuItem.Click += new System.EventHandler(this.viewListOfGamesToolStripMenuItem_Click);
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeamToolStripMenuItem,
            this.removeTeamToolStripMenuItem});
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.teamToolStripMenuItem.Text = "Team";
            this.teamToolStripMenuItem.Click += new System.EventHandler(this.teamToolStripMenuItem_Click);
            // 
            // addTeamToolStripMenuItem
            // 
            this.addTeamToolStripMenuItem.Name = "addTeamToolStripMenuItem";
            this.addTeamToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addTeamToolStripMenuItem.Text = "Add Team";
            this.addTeamToolStripMenuItem.Click += new System.EventHandler(this.addTeamToolStripMenuItem_Click);
            // 
            // removeTeamToolStripMenuItem
            // 
            this.removeTeamToolStripMenuItem.Name = "removeTeamToolStripMenuItem";
            this.removeTeamToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.removeTeamToolStripMenuItem.Text = "Remove Team";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // tabletensbutton7
            // 
            this.tabletensbutton7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabletensbutton7.BackgroundImage = global::project_start.Properties.Resources.Tennis_Ping_Pong_Table_Clipart_9LG;
            this.tabletensbutton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabletensbutton7.Location = new System.Drawing.Point(667, 266);
            this.tabletensbutton7.Name = "tabletensbutton7";
            this.tabletensbutton7.Size = new System.Drawing.Size(307, 186);
            this.tabletensbutton7.TabIndex = 5;
            this.tabletensbutton7.UseVisualStyleBackColor = false;
            this.tabletensbutton7.Visible = false;
            this.tabletensbutton7.Click += new System.EventHandler(this.tabletensbutton7_Click);
            // 
            // Chessbutton4
            // 
            this.Chessbutton4.BackgroundImage = global::project_start.Properties.Resources._1301577_110121115855_100_0888;
            this.Chessbutton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Chessbutton4.Location = new System.Drawing.Point(340, 269);
            this.Chessbutton4.Name = "Chessbutton4";
            this.Chessbutton4.Size = new System.Drawing.Size(315, 186);
            this.Chessbutton4.TabIndex = 2;
            this.Chessbutton4.UseVisualStyleBackColor = true;
            this.Chessbutton4.Visible = false;
            this.Chessbutton4.Click += new System.EventHandler(this.Chessbutton4_Click);
            // 
            // Ludobutton6
            // 
            this.Ludobutton6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ludobutton6.BackgroundImage = global::project_start.Properties.Resources.board_game_ludo_mensch;
            this.Ludobutton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ludobutton6.Location = new System.Drawing.Point(340, 56);
            this.Ludobutton6.Name = "Ludobutton6";
            this.Ludobutton6.Size = new System.Drawing.Size(315, 196);
            this.Ludobutton6.TabIndex = 4;
            this.Ludobutton6.UseVisualStyleBackColor = false;
            this.Ludobutton6.Visible = false;
            this.Ludobutton6.Click += new System.EventHandler(this.Ludobutton6_Click);
            // 
            // Footbalbutton5
            // 
            this.Footbalbutton5.BackgroundImage = global::project_start.Properties.Resources.images__1_1;
            this.Footbalbutton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Footbalbutton5.Location = new System.Drawing.Point(12, 266);
            this.Footbalbutton5.Name = "Footbalbutton5";
            this.Footbalbutton5.Size = new System.Drawing.Size(316, 186);
            this.Footbalbutton5.TabIndex = 3;
            this.Footbalbutton5.UseVisualStyleBackColor = true;
            this.Footbalbutton5.Visible = false;
            this.Footbalbutton5.Click += new System.EventHandler(this.Footbalbutton5_Click);
            // 
            // BAdmentonbutton3
            // 
            this.BAdmentonbutton3.BackgroundImage = global::project_start.Properties.Resources.badminton_08;
            this.BAdmentonbutton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BAdmentonbutton3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BAdmentonbutton3.Location = new System.Drawing.Point(667, 59);
            this.BAdmentonbutton3.Name = "BAdmentonbutton3";
            this.BAdmentonbutton3.Size = new System.Drawing.Size(307, 191);
            this.BAdmentonbutton3.TabIndex = 1;
            this.BAdmentonbutton3.UseVisualStyleBackColor = true;
            this.BAdmentonbutton3.Visible = false;
            this.BAdmentonbutton3.Click += new System.EventHandler(this.BAdmentonbutton3_Click);
            // 
            // AddGamepanel2
            // 
            this.AddGamepanel2.BackgroundImage = global::project_start.Properties.Resources._13162476_1884624068431193_812734873_n;
            this.AddGamepanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddGamepanel2.Controls.Add(this.button7);
            this.AddGamepanel2.Controls.Add(this.button5);
            this.AddGamepanel2.Controls.Add(this.button1);
            this.AddGamepanel2.Controls.Add(this.Backbutton1);
            this.AddGamepanel2.Controls.Add(this.label1);
            this.AddGamepanel2.Controls.Add(this.FootbalcheckBox6);
            this.AddGamepanel2.Controls.Add(this.ChesscheckBox5);
            this.AddGamepanel2.Controls.Add(this.BadmentioncheckBox4);
            this.AddGamepanel2.Controls.Add(this.LudocheckBox3);
            this.AddGamepanel2.Controls.Add(this.TAbletenesscheckBox2);
            this.AddGamepanel2.Controls.Add(this.CricketcheckBox1);
            this.AddGamepanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGamepanel2.Location = new System.Drawing.Point(279, 12);
            this.AddGamepanel2.Name = "AddGamepanel2";
            this.AddGamepanel2.Size = new System.Drawing.Size(432, 328);
            this.AddGamepanel2.TabIndex = 3;
            this.AddGamepanel2.Visible = false;
            this.AddGamepanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.AddGamepanel2_Paint);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Info;
            this.button7.Location = new System.Drawing.Point(320, 54);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 20;
            this.button7.Text = "Reset";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Info;
            this.button5.Location = new System.Drawing.Point(35, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Select All";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(322, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Backbutton1
            // 
            this.Backbutton1.BackColor = System.Drawing.SystemColors.Info;
            this.Backbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton1.Location = new System.Drawing.Point(35, 284);
            this.Backbutton1.Name = "Backbutton1";
            this.Backbutton1.Size = new System.Drawing.Size(122, 32);
            this.Backbutton1.TabIndex = 17;
            this.Backbutton1.Text = "Back to MainMenu";
            this.Backbutton1.UseVisualStyleBackColor = false;
            this.Backbutton1.Click += new System.EventHandler(this.Backbutton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select the Games to Perform Operation";
            // 
            // FootbalcheckBox6
            // 
            this.FootbalcheckBox6.AutoSize = true;
            this.FootbalcheckBox6.BackColor = System.Drawing.SystemColors.Info;
            this.FootbalcheckBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FootbalcheckBox6.Location = new System.Drawing.Point(155, 105);
            this.FootbalcheckBox6.Name = "FootbalcheckBox6";
            this.FootbalcheckBox6.Size = new System.Drawing.Size(108, 29);
            this.FootbalcheckBox6.TabIndex = 15;
            this.FootbalcheckBox6.Text = "Football";
            this.FootbalcheckBox6.UseVisualStyleBackColor = false;
            // 
            // ChesscheckBox5
            // 
            this.ChesscheckBox5.AutoSize = true;
            this.ChesscheckBox5.BackColor = System.Drawing.SystemColors.Info;
            this.ChesscheckBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChesscheckBox5.Location = new System.Drawing.Point(155, 140);
            this.ChesscheckBox5.Name = "ChesscheckBox5";
            this.ChesscheckBox5.Size = new System.Drawing.Size(92, 29);
            this.ChesscheckBox5.TabIndex = 14;
            this.ChesscheckBox5.Text = "Chess";
            this.ChesscheckBox5.UseVisualStyleBackColor = false;
            // 
            // BadmentioncheckBox4
            // 
            this.BadmentioncheckBox4.AutoSize = true;
            this.BadmentioncheckBox4.BackColor = System.Drawing.SystemColors.Info;
            this.BadmentioncheckBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BadmentioncheckBox4.Location = new System.Drawing.Point(155, 175);
            this.BadmentioncheckBox4.Name = "BadmentioncheckBox4";
            this.BadmentioncheckBox4.Size = new System.Drawing.Size(145, 29);
            this.BadmentioncheckBox4.TabIndex = 13;
            this.BadmentioncheckBox4.Text = "Badmention";
            this.BadmentioncheckBox4.UseVisualStyleBackColor = false;
            // 
            // LudocheckBox3
            // 
            this.LudocheckBox3.AutoSize = true;
            this.LudocheckBox3.BackColor = System.Drawing.SystemColors.Info;
            this.LudocheckBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LudocheckBox3.Location = new System.Drawing.Point(155, 210);
            this.LudocheckBox3.Name = "LudocheckBox3";
            this.LudocheckBox3.Size = new System.Drawing.Size(79, 29);
            this.LudocheckBox3.TabIndex = 12;
            this.LudocheckBox3.Text = "Ludo";
            this.LudocheckBox3.UseVisualStyleBackColor = false;
            // 
            // TAbletenesscheckBox2
            // 
            this.TAbletenesscheckBox2.AutoSize = true;
            this.TAbletenesscheckBox2.BackColor = System.Drawing.SystemColors.Info;
            this.TAbletenesscheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAbletenesscheckBox2.Location = new System.Drawing.Point(155, 242);
            this.TAbletenesscheckBox2.Name = "TAbletenesscheckBox2";
            this.TAbletenesscheckBox2.Size = new System.Drawing.Size(155, 29);
            this.TAbletenesscheckBox2.TabIndex = 11;
            this.TAbletenesscheckBox2.Text = "Table Teniss";
            this.TAbletenesscheckBox2.UseVisualStyleBackColor = false;
            // 
            // CricketcheckBox1
            // 
            this.CricketcheckBox1.AutoSize = true;
            this.CricketcheckBox1.BackColor = System.Drawing.SystemColors.Info;
            this.CricketcheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CricketcheckBox1.Location = new System.Drawing.Point(155, 70);
            this.CricketcheckBox1.Name = "CricketcheckBox1";
            this.CricketcheckBox1.Size = new System.Drawing.Size(98, 29);
            this.CricketcheckBox1.TabIndex = 10;
            this.CricketcheckBox1.Text = "Cricket";
            this.CricketcheckBox1.UseVisualStyleBackColor = false;
            // 
            // Removegamepanel2
            // 
            this.Removegamepanel2.BackgroundImage = global::project_start.Properties.Resources._13153351_1884624065097860_1471330303_n;
            this.Removegamepanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Removegamepanel2.Controls.Add(this.button6);
            this.Removegamepanel2.Controls.Add(this.button4);
            this.Removegamepanel2.Controls.Add(this.button2);
            this.Removegamepanel2.Controls.Add(this.button3);
            this.Removegamepanel2.Controls.Add(this.label2);
            this.Removegamepanel2.Controls.Add(this.footbalcheckBox1);
            this.Removegamepanel2.Controls.Add(this.chesscheckBox2);
            this.Removegamepanel2.Controls.Add(this.badcheckBox3);
            this.Removegamepanel2.Controls.Add(this.ludocheckBox4);
            this.Removegamepanel2.Controls.Add(this.taablecheckBox5);
            this.Removegamepanel2.Controls.Add(this.cricketcheckBox6);
            this.Removegamepanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removegamepanel2.Location = new System.Drawing.Point(261, 12);
            this.Removegamepanel2.Name = "Removegamepanel2";
            this.Removegamepanel2.Size = new System.Drawing.Size(462, 350);
            this.Removegamepanel2.TabIndex = 4;
            this.Removegamepanel2.Visible = false;
            this.Removegamepanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Removegamepanel2_Paint);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Info;
            this.button6.Location = new System.Drawing.Point(348, 52);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "Reset";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.Location = new System.Drawing.Point(45, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Select All";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(326, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 32);
            this.button2.TabIndex = 18;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(49, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 32);
            this.button3.TabIndex = 17;
            this.button3.Text = "Back to MainMenu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select the Games to Perform Operation";
            // 
            // footbalcheckBox1
            // 
            this.footbalcheckBox1.AutoSize = true;
            this.footbalcheckBox1.BackColor = System.Drawing.SystemColors.Info;
            this.footbalcheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footbalcheckBox1.Location = new System.Drawing.Point(165, 104);
            this.footbalcheckBox1.Name = "footbalcheckBox1";
            this.footbalcheckBox1.Size = new System.Drawing.Size(108, 29);
            this.footbalcheckBox1.TabIndex = 15;
            this.footbalcheckBox1.Text = "Football";
            this.footbalcheckBox1.UseVisualStyleBackColor = false;
            this.footbalcheckBox1.Visible = false;
            // 
            // chesscheckBox2
            // 
            this.chesscheckBox2.AutoSize = true;
            this.chesscheckBox2.BackColor = System.Drawing.SystemColors.Info;
            this.chesscheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chesscheckBox2.Location = new System.Drawing.Point(165, 140);
            this.chesscheckBox2.Name = "chesscheckBox2";
            this.chesscheckBox2.Size = new System.Drawing.Size(92, 29);
            this.chesscheckBox2.TabIndex = 14;
            this.chesscheckBox2.Text = "Chess";
            this.chesscheckBox2.UseVisualStyleBackColor = false;
            this.chesscheckBox2.Visible = false;
            // 
            // badcheckBox3
            // 
            this.badcheckBox3.AutoSize = true;
            this.badcheckBox3.BackColor = System.Drawing.SystemColors.Info;
            this.badcheckBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badcheckBox3.Location = new System.Drawing.Point(165, 175);
            this.badcheckBox3.Name = "badcheckBox3";
            this.badcheckBox3.Size = new System.Drawing.Size(145, 29);
            this.badcheckBox3.TabIndex = 13;
            this.badcheckBox3.Text = "Badmention";
            this.badcheckBox3.UseVisualStyleBackColor = false;
            this.badcheckBox3.Visible = false;
            // 
            // ludocheckBox4
            // 
            this.ludocheckBox4.AutoSize = true;
            this.ludocheckBox4.BackColor = System.Drawing.SystemColors.Info;
            this.ludocheckBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ludocheckBox4.Location = new System.Drawing.Point(165, 210);
            this.ludocheckBox4.Name = "ludocheckBox4";
            this.ludocheckBox4.Size = new System.Drawing.Size(79, 29);
            this.ludocheckBox4.TabIndex = 12;
            this.ludocheckBox4.Text = "Ludo";
            this.ludocheckBox4.UseVisualStyleBackColor = false;
            this.ludocheckBox4.Visible = false;
            // 
            // taablecheckBox5
            // 
            this.taablecheckBox5.AutoSize = true;
            this.taablecheckBox5.BackColor = System.Drawing.SystemColors.Info;
            this.taablecheckBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taablecheckBox5.Location = new System.Drawing.Point(165, 245);
            this.taablecheckBox5.Name = "taablecheckBox5";
            this.taablecheckBox5.Size = new System.Drawing.Size(155, 29);
            this.taablecheckBox5.TabIndex = 11;
            this.taablecheckBox5.Text = "Table Teniss";
            this.taablecheckBox5.UseVisualStyleBackColor = false;
            this.taablecheckBox5.Visible = false;
            // 
            // cricketcheckBox6
            // 
            this.cricketcheckBox6.AutoSize = true;
            this.cricketcheckBox6.BackColor = System.Drawing.SystemColors.Info;
            this.cricketcheckBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cricketcheckBox6.Location = new System.Drawing.Point(165, 69);
            this.cricketcheckBox6.Name = "cricketcheckBox6";
            this.cricketcheckBox6.Size = new System.Drawing.Size(98, 29);
            this.cricketcheckBox6.TabIndex = 10;
            this.cricketcheckBox6.Text = "Cricket";
            this.cricketcheckBox6.UseVisualStyleBackColor = false;
            this.cricketcheckBox6.Visible = false;
            // 
            // Addteampanel2
            // 
            this.Addteampanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Addteampanel2.Controls.Add(this.button8);
            this.Addteampanel2.Controls.Add(this.Nextbutton);
            this.Addteampanel2.Controls.Add(this.GamecomboBox1);
            this.Addteampanel2.Controls.Add(this.label3);
            this.Addteampanel2.Location = new System.Drawing.Point(823, 12);
            this.Addteampanel2.Name = "Addteampanel2";
            this.Addteampanel2.Size = new System.Drawing.Size(103, 10);
            this.Addteampanel2.TabIndex = 5;
            this.Addteampanel2.Visible = false;
            this.Addteampanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Addteampanel2_Paint_1);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(56, 76);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "Back";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Nextbutton
            // 
            this.Nextbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nextbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nextbutton.Location = new System.Drawing.Point(221, 75);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(75, 23);
            this.Nextbutton.TabIndex = 5;
            this.Nextbutton.Text = "Next";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
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
            this.GamecomboBox1.Location = new System.Drawing.Point(146, 25);
            this.GamecomboBox1.Name = "GamecomboBox1";
            this.GamecomboBox1.Size = new System.Drawing.Size(121, 21);
            this.GamecomboBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seletct the game";
            // 
            // Cricketbutton2
            // 
            this.Cricketbutton2.BackgroundImage = global::project_start.Properties.Resources.cricket_Challenge_game_for_all_play_live_Cricket_Game_watch_live_Cricket;
            this.Cricketbutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cricketbutton2.Location = new System.Drawing.Point(12, 58);
            this.Cricketbutton2.Name = "Cricketbutton2";
            this.Cricketbutton2.Size = new System.Drawing.Size(316, 192);
            this.Cricketbutton2.TabIndex = 0;
            this.Cricketbutton2.UseVisualStyleBackColor = true;
            this.Cricketbutton2.Visible = false;
            this.Cricketbutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_start.Properties.Resources.P5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 472);
            this.Controls.Add(this.Removegamepanel2);
            this.Controls.Add(this.Ludobutton6);
            this.Controls.Add(this.BAdmentonbutton3);
            this.Controls.Add(this.tabletensbutton7);
            this.Controls.Add(this.Chessbutton4);
            this.Controls.Add(this.Footbalbutton5);
            this.Controls.Add(this.Cricketbutton2);
            this.Controls.Add(this.AddGamepanel2);
            this.Controls.Add(this.Addteampanel2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AddGamepanel2.ResumeLayout(false);
            this.AddGamepanel2.PerformLayout();
            this.Removegamepanel2.ResumeLayout(false);
            this.Removegamepanel2.PerformLayout();
            this.Addteampanel2.ResumeLayout(false);
            this.Addteampanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewListOfGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Button BAdmentonbutton3;
        private System.Windows.Forms.Button tabletensbutton7;
        private System.Windows.Forms.Button Ludobutton6;
        private System.Windows.Forms.Button Footbalbutton5;
        private System.Windows.Forms.Button Chessbutton4;
        private System.Windows.Forms.Panel AddGamepanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Backbutton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox FootbalcheckBox6;
        private System.Windows.Forms.CheckBox ChesscheckBox5;
        private System.Windows.Forms.CheckBox BadmentioncheckBox4;
        private System.Windows.Forms.CheckBox LudocheckBox3;
        private System.Windows.Forms.CheckBox TAbletenesscheckBox2;
        private System.Windows.Forms.CheckBox CricketcheckBox1;
        private System.Windows.Forms.Panel Removegamepanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox footbalcheckBox1;
        private System.Windows.Forms.CheckBox chesscheckBox2;
        private System.Windows.Forms.CheckBox badcheckBox3;
        private System.Windows.Forms.CheckBox ludocheckBox4;
        private System.Windows.Forms.CheckBox taablecheckBox5;
        private System.Windows.Forms.CheckBox cricketcheckBox6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel Addteampanel2;
        private System.Windows.Forms.Button Nextbutton;
        private System.Windows.Forms.ComboBox GamecomboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cricketbutton2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
    }
}