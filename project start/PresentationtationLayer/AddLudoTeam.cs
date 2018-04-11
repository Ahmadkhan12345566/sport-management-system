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
    public partial class Add2PlayersTeamcs : Form
    {
        public Menu ParentttFormReference
        { get; set; }
        public Add2PlayersTeamcs()
        {
            InitializeComponent();
        }
        bool isBack = false;
        private TeamInfo nwtm = new TeamInfo();

        private PlayerInfo palyer1 = new PlayerInfo();
        private PlayerInfo palyer2 = new PlayerInfo();
        private bool valid()
        {
            if((string.IsNullOrEmpty(TeamNametextBox1.Text.Trim())|| string.IsNullOrEmpty(SymestercomboBox1.Text.Trim()) || string.IsNullOrEmpty(DeprtcomboBox2.Text.Trim()))
                || string.IsNullOrEmpty(PlayerNametextBox2.Text.Trim()) || string.IsNullOrEmpty(Player1textBox8.Text.Trim()) ||
                string.IsNullOrEmpty(textBox1.Text.Trim()) || string.IsNullOrEmpty(Player2textBox2.Text.Trim()))
            {
                MessageBox.Show("Fill all boxes..", "Error");
            return false;
            
            }

            return true;
        }
             

        private void Add2PlayersTeamcs_Load(object sender, EventArgs e)
        {

        }

        private void TeamNametextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Donebutton1_Click(object sender, EventArgs e)
        {
            if (valid()) {
                nwtm.TeamName = TeamNametextBox1.Text.Trim();
                nwtm.Teasemester = SymestercomboBox1.SelectedItem.ToString();
                nwtm.Depart = DeprtcomboBox2.SelectedItem.ToString();
                palyer1.PlayrName = PlayerNametextBox2.Text.Trim();
                palyer1.PlayerRegno = Player1textBox8.Text.Trim();
                palyer1.Playerdepart = DeprtcomboBox2.SelectedItem.ToString();
                palyer1.Playersemester = SymestercomboBox1.SelectedItem.ToString();
                palyer1.Playerteamname = TeamNametextBox1.Text.Trim();

                palyer2.PlayrName = textBox1.Text.Trim();
                palyer2.PlayerRegno = Player2textBox2.Text.Trim();

                palyer2.Playerdepart = DeprtcomboBox2.SelectedItem.ToString();
                palyer2.Playersemester = SymestercomboBox1.SelectedItem.ToString();
                palyer2.Playerteamname = TeamNametextBox1.Text.Trim();

                string table2team = "LudoteamdataTable";
                string table3player = "LudoplayrdataTable";
            
            bool vt = LoginLlogic.validdludoteam(nwtm);

                if (vt)//team name validation
                {

                    bool vp1 = LoginLlogic.validLudoplayer(palyer1);
                    


                    if (vp1)
                    {
                         LoginLlogic.InsertData(palyer1);

                         bool vp2 = LoginLlogic.validLudoplayer(palyer2);
                        if(vp2){
                            LoginLlogic.InsertData(palyer1);
                            LoginLlogic.deletdata(palyer1);

                        LoginLlogic.InsertData(nwtm, table2team);
                        LoginLlogic.InsertDataa(palyer1, table3player);
                            LoginLlogic.InsertDataa(palyer2,table3player);
                            MessageBox.Show("Team Enterd");
                            isBack = true;
                            ParentttFormReference.Show();
                            this.Close();
                        }
                        else 
                              
                    {
                        MessageBox.Show("player data is not valid or used befor..", "Error");
                    }

                    }
                    else
                    {
                        MessageBox.Show("player data is not valid or used befor..", "Error");
                    }





                }
                else
                MessageBox.Show("team name is not valid..", "Error");
              
            }
            
            
            }
       

        private void Cancelbutton1_Click(object sender, EventArgs e)
        {
            ParentttFormReference.Show();
            isBack = true;
            this.Close();
        }

        private void Player1textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
