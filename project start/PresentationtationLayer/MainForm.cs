using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_start.BusinessLayer;

namespace project_start.PresentationtationLayer
{
    public partial class MainForm : Form
    {
       
        public LoginForm ParentFormReference
        { get; set; }

        
     
       
        
        public MainForm()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
          Check.a = "cricket";
          Menu mn = new Menu();
          mn.ParenttFormReference = this;
         mn.Show();
         this.Hide();
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void addGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addteampanel2.Visible = true;
            Removegamepanel2.Visible = true;
            AddGamepanel2.Visible = true;
            Removegamepanel2.Visible = false;

            Addteampanel2.Visible = false;
            /*
            RegGames rg = new RegGames();
            rg.Show();
            if (Check.crick1 == "crick")
            {
                Crickpanel2.Visible = true;

            }
            this.Refresh();
            */

        }
        

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParentFormReference.Show();
           this.Hide();
        }

        private void Chessbutton4_Click(object sender, EventArgs e)
        {
            Check.a = "chess";
            Menu mn = new Menu();
            mn.ParenttFormReference = this;
            mn.Show();
            this.Hide();
        }

        private void Footbalbutton5_Click(object sender, EventArgs e)
        {
            Check.a = "football";
            Menu mn = new Menu();
            mn.ParenttFormReference = this;
            mn.Show();
            this.Hide();

        }

        private void BAdmentonbutton3_Click(object sender, EventArgs e)
        {
            Check.a = "bedminton";
            Menu mn = new Menu();
            mn.ParenttFormReference = this;
            mn.Show();
            this.Hide();
        }

        private void Ludobutton6_Click(object sender, EventArgs e)
        {
            Check.a = "ludo";
            Menu mn = new Menu();
            mn.ParenttFormReference = this;
            mn.Show();
            this.Hide();
        }

        private void tabletensbutton7_Click(object sender, EventArgs e)
        {
            Check.a = "tabletennis";
            Menu mn = new Menu();
            mn.ParenttFormReference = this;
            mn.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Chesspanel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Crickpanel2_Paint(object sender, PaintEventArgs e)
        {
         
        
        }

        private void Footbalpanel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Badmentionpanel4_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void pastTournamentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void curentTournamentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CricketcheckBox1.Checked)
            {
                Cricketbutton2.Visible = true;
                cricketcheckBox6.Visible = true;

            }

      /*      CricketcheckBox1.Checked
ChesscheckBox5.Checked

    BadmentioncheckBox4.Checked
FootbalcheckBox6.Checked
    LudocheckBox3.Checked
        TAbletenesscheckBox2.Checked*/


            if (ChesscheckBox5.Checked)
            {
                Chessbutton4.Visible = true;
                chesscheckBox2.Visible = true;
            }
            if (BadmentioncheckBox4.Checked) 
            {
                BAdmentonbutton3.Visible = true;
                badcheckBox3.Visible = true;
               
            }
            if (FootbalcheckBox6.Checked)
            {
                Footbalbutton5.Visible = true;
                footbalcheckBox1.Visible = true;
            
            
            }
            if (LudocheckBox3.Checked)
            {
                Ludobutton6.Visible = true;
                ludocheckBox4.Visible = true;
            }
            if (TAbletenesscheckBox2.Checked)
            {
                tabletensbutton7.Visible = true;
              
                taablecheckBox5.Visible = true;
            }
            AddGamepanel2.Visible = false;
            
        }

        private void Backbutton1_Click(object sender, EventArgs e)
        {
            AddGamepanel2.Visible = false;
        }

        private void removeGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Removegamepanel2.Visible = true;
           // Removegamepanel2.Top=Top;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (cricketcheckBox6.Checked)
            {
                Cricketbutton2.Visible = false;
                

            }
           
            if (chesscheckBox2.Checked)
            {
                
                Chessbutton4.Visible = false;
            }
            if (badcheckBox3.Checked)
            {
                BAdmentonbutton3.Visible = false;
               

            }
            if (footbalcheckBox1.Checked)
            {
                Footbalbutton5.Visible = false;

                

            }
            if (ludocheckBox4.Checked)
            {
                Ludobutton6.Visible = false;
            
            }
            if (taablecheckBox5.Checked)
            {
                tabletensbutton7.Visible = false;
                
            }
            chesscheckBox2.Visible = false;
            badcheckBox3.Visible = false;
            cricketcheckBox6.Visible = false;
            taablecheckBox5.Visible = false;
            ludocheckBox4.Visible = false;
            footbalcheckBox1.Visible = false;
            Removegamepanel2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Removegamepanel2.Visible = false;
        }

        private void tabletanespanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Removegamepanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewListOfGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addteampanel2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Addteampanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {

            if (GamecomboBox1.SelectedIndex == 0)
            {
                Add11palyerteam newteam = new Add11palyerteam();
                newteam.Show();
                this.Hide();
            }
            else if (GamecomboBox1.SelectedIndex == 1)
            {
                AddFootballTeam newteam = new AddFootballTeam();
                newteam.Show();
                this.Hide();
            }
            else if (GamecomboBox1.SelectedIndex == 2)
            {
                Add2PlayersTeamcs newteam = new Add2PlayersTeamcs();
                newteam.Show();
                this.Hide();
            }
            else if (GamecomboBox1.SelectedIndex == 3)
            {
                AddChessTeam newteam = new AddChessTeam();
                newteam.Show();
                this.Hide();
            }
            else if (GamecomboBox1.SelectedIndex == 4)
            {
                Add2PlayersTeamcs newteam = new Add2PlayersTeamcs();
                newteam.Show();
                this.Hide();
            }
            else if (GamecomboBox1.SelectedIndex == 5)
            {
                Add2PlayersTeamcs newteam = new Add2PlayersTeamcs();
                newteam.Show();
                this.Hide();
            }

        }

        private void AddGamepanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Addteampanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            chesscheckBox2.Checked = true;
            badcheckBox3.Checked = true;
            cricketcheckBox6.Checked = true;
            taablecheckBox5.Checked = true;
            ludocheckBox4.Checked = true;
            footbalcheckBox1.Checked = true;
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
CricketcheckBox1.Checked=true;
ChesscheckBox5.Checked=true;

BadmentioncheckBox4.Checked=true;
FootbalcheckBox6.Checked=true;

LudocheckBox3.Checked=true;
TAbletenesscheckBox2.Checked = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CricketcheckBox1.Checked = false;
            ChesscheckBox5.Checked = false;

            BadmentioncheckBox4.Checked = false;
            FootbalcheckBox6.Checked = false;

            LudocheckBox3.Checked = false;
            TAbletenesscheckBox2.Checked = false;

        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //
            chesscheckBox2.Checked = false;
            badcheckBox3.Checked = false;
            cricketcheckBox6.Checked = false;
            taablecheckBox5.Checked = false;
            ludocheckBox4.Checked = false;
            footbalcheckBox1.Checked = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }
    }
}
