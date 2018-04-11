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
    public partial class Menu : Form
    {
        public MainForm ParenttFormReference
        { get; set; }

        bool isBack = false;

        public Menu()
        {
            InitializeComponent();
        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;



            dataGridView6.Visible = false;



            dataGridView2.Visible = false;



            dataGridView3.Visible = false;




            dataGridView5.Visible = false;



            dataGridView4.Visible = false;
            
        
            
            //string res = LoginLlogic.open(Check.a);
            if (Check.a == "cricket")
            {
                Add11palyerteam Cr = new Add11palyerteam();
                Cr.ParentttFormReference = this;
                Cr.Show();
                this.Hide();
            }
            else if (Check.a == "chess")
            {
                AddChessTeam ch = new AddChessTeam();
                ch.Show();
                ch.ParentttFormReference = this;
                this.Hide();
            }
            else if (Check.a == "football")
            {
                AddFootballTeam ch = new AddFootballTeam();
                ch.Show();
                ch.ParentttFormReference = this;
                this.Hide();
            }
            else if (Check.a == "bedminton")
            {
                Addbadmentionteam ch = new Addbadmentionteam();
                ch.Show();
                ch.ParentttFormReference = this;
                this.Hide();
            }

            else if (Check.a == "ludo")
            {
                Add2PlayersTeamcs ch = new Add2PlayersTeamcs();
                ch.Show();
                ch.ParentttFormReference = this;
                this.Hide();
            }
            else if (Check.a == "tabletennis")
            {
                Addtabletanessteam ch = new Addtabletanessteam();
                ch.Show();
                ch.ParentttFormReference = this;
                this.Hide();
            }
        }
        private void Backbutton1_Click(object sender, EventArgs e)
        {


            
            
                dataGridView1.Visible = false;
            
            
            
                dataGridView6.Visible = false;
            
            
            
                dataGridView2.Visible = false;
            
            
            
                dataGridView3.Visible = false;
            

           
            
                dataGridView5.Visible = false;
            
            
            
                dataGridView4.Visible = false;
            
        
            
            //MainForm mn = new MainForm();
            //mn.Show();

            ParenttFormReference.Show();

            isBack = true;

            this.Close();           
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDataDataSet7.ChesteamdataTable' table. You can move, or remove it, as needed.
            this.chesteamdataTableTableAdapter.Fill(this.loginDataDataSet7.ChesteamdataTable);
            // TODO: This line of code loads data into the 'loginDataDataSet6.TAbletennisteamTable' table. You can move, or remove it, as needed.
            this.tAbletennisteamTableTableAdapter.Fill(this.loginDataDataSet6.TAbletennisteamTable);
            // TODO: This line of code loads data into the 'loginDataDataSet5.LudoteamdataTable' table. You can move, or remove it, as needed.
            this.ludoteamdataTableTableAdapter1.Fill(this.loginDataDataSet5.LudoteamdataTable);
            // TODO: This line of code loads data into the 'loginDataDataSet4.LudoteamdataTable' table. You can move, or remove it, as needed.
            this.ludoteamdataTableTableAdapter.Fill(this.loginDataDataSet4.LudoteamdataTable);
            // TODO: This line of code loads data into the 'loginDataDataSet3.BadmentionteamdataTable' table. You can move, or remove it, as needed.
            this.badmentionteamdataTableTableAdapter.Fill(this.loginDataDataSet3.BadmentionteamdataTable);
            // TODO: This line of code loads data into the 'loginDataDataSet2.FootbalteamdataTable' table. You can move, or remove it, as needed.
            this.footbalteamdataTableTableAdapter.Fill(this.loginDataDataSet2.FootbalteamdataTable);
            // TODO: This line of code loads data into the 'loginDataDataSet1.TeamdataTable' table. You can move, or remove it, as needed.
            this.teamdataTableTableAdapter.Fill(this.loginDataDataSet1.TeamdataTable);
            // TODO: This line of code loads data into the 'loginDataDataSet.DepartdataTable' table. You can move, or remove it, as needed.
            this.departdataTableTableAdapter.Fill(this.loginDataDataSet.DepartdataTable);

        }

       

        private void Removebutton2_Click(object sender, EventArgs e)
        {
            
        }

        private void Viewallbutton4_Click(object sender, EventArgs e)
        {
            if (Check.a == "cricket")
            {
                dataGridView1.Visible = true;
            }
            else if (Check.a == "chess")
            {
                dataGridView6.Visible = true;
            }
            else if (Check.a == "football")
            {
                dataGridView2.Visible = true;
            }
            else if (Check.a == "bedminton")
            { 
                dataGridView3.Visible = true; }

            else if (Check.a == "ludo")
            {
                dataGridView5.Visible = true;
            }
            else if (Check.a == "tabletennis")
            {
                dataGridView4.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
