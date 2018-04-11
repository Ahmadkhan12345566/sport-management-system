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
    public partial class AddChessTeam : Form
    {
        public Menu ParentttFormReference
        { get; set; }
        bool isBack = false;
    
        public AddChessTeam()
        {
            InitializeComponent();
        }

        private bool Validate()
        {
            if (string.IsNullOrEmpty(TeamNametextBox1.Text.Trim()) || string.IsNullOrEmpty(SymestercomboBox1.Text.Trim()) || string.IsNullOrEmpty(DeprtcomboBox2.Text.Trim())||string.IsNullOrEmpty(PlayerNametextBox2.Text.Trim()) || string.IsNullOrEmpty(PlayerRegNotextBox8.Text.Trim()))
            {
                MessageBox.Show("Fill all boxes..", "Error");
                return false;
            }
            return true;
        }
   //         if (string.IsNullOrEmpty(TeamNametextBox1.Text.Trim()) || string.IsNullOrEmpty(SymestercomboBox1.Text.Trim()) || string.IsNullOrEmpty(DeprtcomboBox2.Text.Trim())||string.IsNullOrEmpty(PlayerNametextBox2.Text.Trim()) || string.IsNullOrEmpty(PlayerRegNotextBox8.Text.Trim()))
        private TeamInfo nwtm = new TeamInfo();
       
        private PlayerInfo palyer1 = new PlayerInfo();



        private void Donebutton1_Click(object sender, EventArgs e)
        {
            if (Validate())
            {


                nwtm.TeamName=TeamNametextBox1.Text.Trim();
                nwtm.Teasemester = SymestercomboBox1.SelectedItem.ToString();
                nwtm.Depart = DeprtcomboBox2.SelectedItem.ToString();
                palyer1.PlayrName = PlayerNametextBox2.Text.Trim();
                palyer1.PlayerRegno = PlayerRegNotextBox8.Text.Trim();
                palyer1.Playerdepart = DeprtcomboBox2.SelectedItem.ToString();
                palyer1.Playersemester = SymestercomboBox1.SelectedItem.ToString();
                palyer1.Playerteamname = TeamNametextBox1.Text.Trim();
                string table2team = "ChesteamdataTable";
                string table3player = "ChessplayerdataTable";
                
                bool vt = LoginLlogic.validdchessteam(nwtm);

                if (vt)//team name validation
                {

                    bool vp = LoginLlogic.validchessplayer(palyer1);
                    if (vp)
                    {



                        LoginLlogic.InsertData(nwtm, table2team);
                        LoginLlogic.InsertDataa(palyer1, table3player);
                        MessageBox.Show("Team Enterd");
                        isBack = true;
                        ParentttFormReference.Show();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("player data is not valid..", "Error");
                    }





                }
                else
                MessageBox.Show("team name is not valid..", "Error");
              
            }
            else
            MessageBox.Show("Fill all boxes..", "Error");
               
        
        }

        private void AddChessTeam_Load(object sender, EventArgs e)
        {

        }

        private void Cancelbutton1_Click(object sender, EventArgs e)
        {
            ParentttFormReference.Show();
            isBack = true;
            this.Close();
        }
    }
}
