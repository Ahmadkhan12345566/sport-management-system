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
    public partial class Add11palyerteam : Form
    {
        public Menu ParentttFormReference
        { get; set; }
        bool isBack = false;
        private List<Departments> dptList = null;
        private TeamInfo nwtm=new TeamInfo();
        
       

      
        private PlayerInfo palyer1 = new PlayerInfo();
        private PlayerInfo palyer2 = new PlayerInfo();
        private PlayerInfo palyer3 = new PlayerInfo();
        private PlayerInfo palyer4 = new PlayerInfo();
        private PlayerInfo palyer5 = new PlayerInfo();
        private PlayerInfo palyer6 = new PlayerInfo();
        private PlayerInfo palyer7 = new PlayerInfo();
        private PlayerInfo palyer8 = new PlayerInfo();
        private PlayerInfo palyer9 = new PlayerInfo();
        private PlayerInfo palyer10 = new PlayerInfo();
        private PlayerInfo palyer11 = new PlayerInfo();
        public Add11palyerteam()
        {
            InitializeComponent();
        }

        private bool Validate()
        {
            if (string.IsNullOrEmpty(TeamtextBox1.Text.Trim()) || string.IsNullOrEmpty(SymestercomboBox1.Text.Trim()) || string.IsNullOrEmpty(DeprtcomboBox2.Text.Trim())
                || string.IsNullOrEmpty(CaptiontextBox2.Text.Trim()) || string.IsNullOrEmpty(CaptiontextBox8.Text.Trim())
                 || string.IsNullOrEmpty(VoiceCaptiontextBox2.Text.Trim()) || string.IsNullOrEmpty(VoiceCaptiontextBox6.Text.Trim())
                || string.IsNullOrEmpty(PalyerNametextBox2.Text.Trim()) || string.IsNullOrEmpty(PalyertextBox3.Text.Trim())
                || string.IsNullOrEmpty(textBox2.Text.Trim()) || string.IsNullOrEmpty(PalyertextBox4.Text.Trim())
                || string.IsNullOrEmpty(PalyerNametextBox3.Text.Trim()) || string.IsNullOrEmpty(PalyertextBox5.Text.Trim())
                || string.IsNullOrEmpty(PlayertextBox3.Text.Trim()) || string.IsNullOrEmpty(PlayertextBox.Text.Trim())
                || string.IsNullOrEmpty(PlayertextBox4.Text.Trim()) || string.IsNullOrEmpty(PlayertextBx4.Text.Trim())
                || string.IsNullOrEmpty(PlayertextBox5.Text.Trim()) || string.IsNullOrEmpty(PlayertxtBox5.Text.Trim())
                || string.IsNullOrEmpty(PlayertextBox6.Text.Trim()) || string.IsNullOrEmpty(PlayertetBox6.Text.Trim())
                || string.IsNullOrEmpty(PlayertxtBox3.Text.Trim()) || string.IsNullOrEmpty(PlayertexBox5.Text.Trim())
                || string.IsNullOrEmpty(PlayetextBox4.Text.Trim()) || string.IsNullOrEmpty(PlayertextBx6.Text.Trim()))
            {
                MessageBox.Show("Fill all boxes..", "Error");
                return false;
            }
            return true;
        }




        /*
               */








        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void Add11palyerteam_Load(object sender, EventArgs e)
        {
            try
            {


                dptList = LoginLlogic.GetDeptNames();

                // show these names into ComboBox

                DeprtcomboBox2.Items.Add("None");

                foreach (Departments dpt in dptList)
                {
                    DeprtcomboBox2.Items.Add(dpt.DepartmentName);
                }

                DeprtcomboBox2.SelectedIndex = 0;
                SymestercomboBox1.SelectedIndex = 0;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }



        private void Donebutton1_Click_1(object sender, EventArgs e)        {
            if (Validate())
            {
                string table2team = "TeamdataTable";
                string table3player = "PlayerdataTable";
                nwtm.TeamName = TeamtextBox1.Text;
                nwtm.Depart =(string) DeprtcomboBox2.SelectedItem;
                nwtm.Teasemester = (string)SymestercomboBox1.SelectedItem;

                
                bool vt = LoginLlogic.validdteam(nwtm);//team name validation 
               
                if (vt)//team name validation
                {
                    //input team hear


              //      string table1check = "chkTable";
                    
                 palyer1.PlayrName = CaptiontextBox2.Text;
                 palyer1.PlayerRegno = CaptiontextBox8.Text;
                 palyer1.Playerteamname = TeamtextBox1.Text;
                 palyer1.Playersemester = (string)SymestercomboBox1.SelectedItem;
                 palyer1.Playerdepart = (string)DeprtcomboBox2.SelectedItem;
                 palyer2.PlayrName =    VoiceCaptiontextBox2.Text;
                 palyer2.PlayerRegno=    VoiceCaptiontextBox6.Text;
                 palyer2.Playerteamname = TeamtextBox1.Text;
                 palyer2.Playersemester = (string)SymestercomboBox1.SelectedItem; ;
                 palyer2.Playerdepart = (string)DeprtcomboBox2.SelectedItem;
                 palyer3.PlayrName = PalyerNametextBox2.Text;
                 palyer3.PlayerRegno = PalyertextBox3.Text;
                 palyer3.Playerteamname = TeamtextBox1.Text;
                 palyer3.Playersemester = (string)SymestercomboBox1.SelectedItem; ;
                 palyer3.Playerdepart = (string)DeprtcomboBox2.SelectedItem;
                    palyer4.PlayrName = textBox2.Text;
                 palyer4.PlayerRegno = PalyertextBox4.Text;
                 palyer4.Playerteamname = TeamtextBox1.Text;
                 palyer4.Playersemester = (string)SymestercomboBox1.SelectedItem; ;
                 palyer4.Playerdepart = (string)DeprtcomboBox2.SelectedItem;
                    palyer5.PlayrName = PalyerNametextBox3.Text;
                 palyer5.PlayerRegno = PalyertextBox5.Text;
                 palyer5.Playerteamname = TeamtextBox1.Text;
                 palyer5.Playersemester = (string)SymestercomboBox1.SelectedItem;
                 palyer5.Playerdepart = (string)DeprtcomboBox2.SelectedItem;
                 palyer6.PlayrName = PlayertextBox3.Text;
                 palyer6.PlayerRegno = PlayertextBox.Text;
                 palyer6.Playerteamname = TeamtextBox1.Text;
                 palyer6.Playersemester = (string)SymestercomboBox1.SelectedItem;
                 palyer6.Playerdepart = (string)DeprtcomboBox2.SelectedItem;
                    palyer7.PlayrName = PlayertextBox4.Text;
                 palyer7.PlayerRegno = PlayertextBx4.Text;
                 palyer7.Playerteamname = TeamtextBox1.Text;
                 palyer7.Playersemester = (string)SymestercomboBox1.SelectedItem;
                 palyer7.Playerdepart = (string)DeprtcomboBox2.SelectedItem;
                 palyer8.PlayrName = PlayertextBox5.Text;
                 palyer8.PlayerRegno=     PlayertxtBox5.Text;
                 palyer8.Playersemester = (string)SymestercomboBox1.SelectedItem;
                 palyer8.Playerdepart = (string)DeprtcomboBox2.SelectedItem;
                    palyer8.Playerteamname = TeamtextBox1.Text;
                 palyer9.PlayrName=PlayertextBox6.Text;
                
                    palyer9.PlayerRegno= PlayertetBox6.Text;
                    palyer9.Playerteamname = TeamtextBox1.Text;
                    palyer9.Playersemester = (string)SymestercomboBox1.SelectedItem;
                    palyer9.Playerdepart = (string)DeprtcomboBox2.SelectedItem;
                    palyer10.PlayrName=PlayertxtBox3.Text;
                 palyer10.PlayerRegno=PlayertexBox5.Text;
                 palyer10.Playerteamname = TeamtextBox1.Text;
                 palyer10.Playersemester = (string)SymestercomboBox1.SelectedItem;
                 palyer10.Playerdepart = (string)DeprtcomboBox2.SelectedItem;
                 palyer11.PlayrName=PlayetextBox4.Text;
                 palyer11.PlayerRegno=PlayertextBx6.Text;
                 palyer11.Playerteamname = TeamtextBox1.Text;
                 palyer11.Playersemester = (string)SymestercomboBox1.SelectedItem;
                 palyer11.Playerdepart = (string)DeprtcomboBox2.SelectedItem;
                    bool vp1 = LoginLlogic.validplayer(palyer1);

                   
                    
                    
                   
                    
                   
                 
                    if (vp1)//player1 validation
                    {
                        LoginLlogic.InsertData(palyer1);
                        bool vp2 = LoginLlogic.validplayer(palyer2);
                        //insert player1
                        if (vp2)//player2 validation
                        {
                          
                            //insert player2
                            LoginLlogic.InsertData(palyer2);
                            bool vp3 = LoginLlogic.validplayer(palyer3);
                            if (vp3)//player3 validation
                            {
                              

                                //insert player3
                                LoginLlogic.InsertData(palyer3);
                                bool vp4 = LoginLlogic.validplayer(palyer4);
                                if (vp4)//player4 validation
                                {
                                   
                                    //insert player4
                                    LoginLlogic.InsertData(palyer4);
                                    bool vp5 = LoginLlogic.validplayer(palyer5);
                                    if (vp5)//player5 validation
                                    {
                                        //insert player5
                                        LoginLlogic.InsertData(palyer5);
                                        bool vp6 = LoginLlogic.validplayer(palyer6);
                                        if (vp6)//player6 validation
                                        {
                                            //insert player6
                                            LoginLlogic.InsertData(palyer6);
                                            bool vp7 = LoginLlogic.validplayer(palyer7);
                                           
                                            if (vp7)//player7 validation
                                            {
                                                //insert player
                                                LoginLlogic.InsertData(palyer7);
                                                bool vp8 = LoginLlogic.validplayer(palyer8);
                                                if (vp8)//player8 validation
                                                {
                                                    //insert player8
                                                    LoginLlogic.InsertData(palyer8);
                                                    bool vp9 = LoginLlogic.validplayer(palyer9);
                                                    if (vp9)//player9 validation
                                                    {
                                                       
                                                        //insert player9
                                                        LoginLlogic.InsertData(palyer9);
                                                        bool vp10 = LoginLlogic.validplayer(palyer10);
                                                        if (vp10)//player10 validation
                                                        {
                                                            //insert player10
                                                            LoginLlogic.InsertData(palyer10);
                                                            bool vp11 = LoginLlogic.validplayer(palyer11);
                                                            if (vp11)//player11 validation
                                                            {
                                                                //insert player11
                                                                LoginLlogic.deletdata(palyer1);
                                                                LoginLlogic.InsertData(palyer11);
                                                                
                                                                LoginLlogic.InsertData(nwtm,table2team);
                                                                LoginLlogic.InsertDataa(palyer1,table3player);
                                                                LoginLlogic.InsertDataa(palyer2,table3player);
                                                                LoginLlogic.InsertDataa(palyer3,table3player);
                                                                LoginLlogic.InsertDataa(palyer4,table3player);
                                                                LoginLlogic.InsertDataa(palyer5,table3player);
                                                                LoginLlogic.InsertDataa(palyer6,table3player);
                                                                LoginLlogic.InsertDataa(palyer7,table3player);
                                                                LoginLlogic.InsertDataa(palyer8,table3player);
                                                                LoginLlogic.InsertDataa(palyer9,table3player);
                                                                LoginLlogic.InsertDataa(palyer10,table3player);
                                                                LoginLlogic.InsertDataa(palyer11,table3player);

                                                                MessageBox.Show("Team Enterd");
                                                                isBack = true;
                                                                ParentttFormReference.Show();
                                                                this.Close();
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("player name or registration number is not valid or register in other team");
                                                            }


                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("player name or registration number is not valid or register in other team");
                                                        }


                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("player name or registration number is not valid or register in other team");
                                                    }



                                                }
                                                else
                                                {
                                                    MessageBox.Show("player name or registration number is not valid or register in other team");
                                                }



                                            }
                                            else
                                            {
                                                MessageBox.Show("player name or registration number is not valid or register in other team");
                                            }


                                        }
                                        else
                                        {
                                            MessageBox.Show("player name or registration number is not valid or register in other team");
                                        }


                                    }
                                    else
                                    {
                                        MessageBox.Show("player name or registration number is not valid or register in other team");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("player name or registration number is not valid or register in other team");
                                }

                            }
                            else
                            {
                                MessageBox.Show("player name or registration number is not valid or register in other team");
                            }
                            

                        }
                        else
                        {
                            MessageBox.Show("player name or registration number is not valid or register in other team");
                        }
                       


                    }
                    else
                    {
                        MessageBox.Show("player name or registration number is not valid or register in other team");
                    }



                  
                }
                else
                    MessageBox.Show("not valid name 0r name used bfore ", "Error");
            }

        }


        private bool vlaidplayers()
        {





            return false;
        }

        private void Cancelbutton1_Click(object sender, EventArgs e)
        {
            ParentttFormReference.Show();
            isBack = true;
            this.Close();


        }







        /*   */



    }
}

      

       
   
