using project_start.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace project_start.BusinessLayer
{
    public class LoginLlogic
    {
        public static string val = "";

        private static DataSet _dataSet = new DataSet();
      
        
        //login validtion ...

        public static bool ValidateUser(UserInfo _user)
        {

            string query = "Select * From LoginData Where Username='" + _user.Username + "' and Password='" + _user.Password + "'  ";

            try
            {
                DataAcesslogic.ReadDataFromDb(_dataSet, query, "LoginData");


                if (_dataSet.Tables["LoginData"].Rows.Count > 0)
                {


                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            { throw ex; }

 }




     public static bool validdteam(TeamInfo nwteam){



         bool vtm = TeamInfo.validtaemData(nwteam);
         if(vtm)
         {
             if (!validationDb(nwteam))//this validation is changed only for in all games
             {
                 return true;


             }

             return false;

         }

       return false;
     }

     public static bool validplayer(PlayerInfo nwplayer)
     {
         bool vldpler = PlayerInfo.validplayer(nwplayer);
         if (!validationDb(nwplayer))//validationDb(PlayerInfo nwplayr)
         {
             if (vldpler)
             {
                 if (validtionDbUni(nwplayer))
                 {
                     if (!validtionDbplr(nwplayer))//changed in all games only this
                     {

                         return true;
                     }
                     
                 }
                 
             }
            
         }
         return false;
     }
     

     public static bool validtionDbplr(PlayerInfo newplayer)//validation from playrsDb
     {

         string query = "Select * From PlayerdataTable Where  Name='" + newplayer.PlayrName + "' and RegNo='" + newplayer.PlayerRegno + "'  ";

         try
         {
             DataAcesslogic.ReadDataFromDb(_dataSet, query, "PlayerdataTable");


             if (_dataSet.Tables["PlayerdataTable"].Rows.Count > 0)
             {
                 return true;
             }
             else
             {
                 return false;
             }



         }
         catch (Exception ex)
         { throw ex; }



     }


     public static bool validtionDbUni(PlayerInfo newplayer)//unidata validation
     {

         string query = "Select * From UniData Where  StudentName='" + newplayer.PlayrName.ToLower()+ "' and StudentRegNO='" + newplayer.PlayerRegno + "'  ";

         try
         {
             DataAcesslogic.ReadDataFromDb(_dataSet, query, "UniData");


             if (_dataSet.Tables["UniData"].Rows.Count > 0)
             {
                 return true;
             }
             else
             {
                 return false;
             }



         }
         catch (Exception ex)
         { throw ex; }


       
     }
   

     public static bool validationDb(TeamInfo nwteam)//team validition from regstrd teams
     {
         string query = "Select * From TeamdataTable Where  Teamname='" + nwteam.TeamName.ToUpper() +"'";
         
         try
         {
             DataAcesslogic.ReadDataFromDb(_dataSet, query, "TeamdataTable");


             if (_dataSet.Tables["TeamdataTable"].Rows.Count > 0)
             {
                 return true;
             }
             else
             {
                 return false;
             }



         }
         catch (Exception ex)
         { throw ex; }


     }
 








     public static List<Departments> GetDeptNames()//list for combox departs
     {
         try
         {
             string query = "Select * From DepartdataTable";
             string tblName = "DepartdataTable";
             List<Departments> deptList = new List<Departments>();


             if (_dataSet.Tables.Contains(tblName))
             { }
             else
             {
                 DataAcesslogic.ReadDataFromDb(_dataSet, query, tblName);
             }


             for (int i = 0; i < _dataSet.Tables[tblName].Rows.Count; i++)
             {
                 DataRow row = _dataSet.Tables[tblName].Rows[i];

                 Departments dpt = new Departments();


                 dpt.DepartmentName = row["Departmant"].ToString();

                 deptList.Add(dpt);

             } // end of loop

             return deptList;
         }
         catch (Exception ex)
         { throw ex; }

     }
     private static string tblName;


     public static bool InsertData(TeamInfo nwteam, string tblName)//insert in team table
     {

         //tblName = "TeamdataTable";
         string query = "INSERT INTO " + tblName + "(TeamName,TeamSemester,TeamDepart) VALUES('" + nwteam.TeamName.ToUpper() + "','" + nwteam.Teasemester + "','" + nwteam.Depart.ToUpper() + "');";
         
         try
         {


             DataAcesslogic.ReadDataFromDb(_dataSet, query, tblName);
             return true;

         }
         catch (Exception ex)
         {
             throw ex;
         }


     }
     public static bool InsertDataa(PlayerInfo nwplayer, string tblName)//insert in Players table
     {

         //tblName = "PlayerdataTable";
         string query = "INSERT INTO " + tblName + "(Name,Semester,RegNo,Teamdepart,Depart) VALUES('" + nwplayer.PlayrName.ToUpper() + "','" + nwplayer.Playersemester +"','" +nwplayer.PlayerRegno.ToUpper()+"','"+nwplayer.Playerteamname.ToUpper()+"','" +nwplayer.Playerdepart.ToUpper() + "');";

         try
         {


             DataAcesslogic.ReadDataFromDb(_dataSet, query, tblName);
            return true;

         }
         catch (Exception ex)
         {
             throw ex;
         }


     }
     public static bool ReadData()
     {
         tblName = "chkTable";

         string query = "Select * From chkTable ";
         try
         {

             DataAcesslogic.ReadDataFromDb(_dataSet, query, tblName);
             if (_dataSet.Tables[tblName].Rows.Count > 0)
             {
                 return true;
             }

             return false;
         }
         catch (Exception ex)
         { throw ex; }

     }


     public static bool deletdata(PlayerInfo nwplyr)//clear check data
     {
         tblName = "chkTable";



         string query = "Delete From chkTable  Where teamname='" + nwplyr.Playerteamname.ToUpper() + "'";

         try
         {

             DataAcesslogic.ReadDataFromDb(_dataSet, query, tblName);
             ReadData();
             return true;


         }
         catch (Exception ex)
         { throw ex; }

     }

     public static bool InsertData(PlayerInfo newplyr)//insert in check table
     {

         tblName = "chkTable";
         string query = "INSERT INTO " + tblName + "(Name,RegNo,teamname) VALUES('" + newplyr.PlayrName.ToUpper() + "','" + newplyr.PlayerRegno + "','" +newplyr.Playerteamname + "');";

         try
         {


             DataAcesslogic.ReadDataFromDb(_dataSet, query, tblName);
             return true;

         }
         catch (Exception ex)
         {
             throw ex;
         }


     }

     public static bool validationDb(PlayerInfo nwplayr)//validition from checktable
     {
         string query = "Select * From chkTable Where  Name='" + nwplayr.PlayrName.ToUpper() + "' and RegNo='" + nwplayr.PlayerRegno.ToUpper() + "' and teamname='" + nwplayr.Playerteamname.ToUpper() + "'";

         try
         {
             DataAcesslogic.ReadDataFromDb(_dataSet, query, "chkTable");


             if (_dataSet.Tables["chkTable"].Rows.Count > 0)
             {
                 
                 return true;
             }
             else
             {
                 return false;
             }



         }
         catch (Exception ex)
         { throw ex; }


     }


        /*Football all
         data validation */
     public static bool validdFootballteam(TeamInfo nwteam)
     {



         bool vtm = TeamInfo.validtaemData(nwteam);
         if (vtm)
         {
             if (!validationballfootDb(nwteam))//this validation is changed only for in all games
             {
                 return true;


             }

             return false;

         }

         return false;
     }
     public static bool validationballfootDb(TeamInfo nwteam)//team validition from regstrd teams Footall
     {
         string query = "Select * From FootbalteamdataTable Where  Teamname='" + nwteam.TeamName.ToUpper() + "'";

         try
         {
             DataAcesslogic.ReadDataFromDb(_dataSet, query, "FootbalteamdataTable");                                //football


             if (_dataSet.Tables["FootbalteamdataTable"].Rows.Count > 0)
             {
                 return true;
             }
             else
             {
                 return false;
             }



         }
         catch (Exception ex)
         { throw ex; }


     }
     public static bool validfootballplayer(PlayerInfo nwplayer)//footbalplayer validation
     {
         bool vldpler = PlayerInfo.validplayer(nwplayer);
         if (!validationDb(nwplayer))//validationDb(PlayerInfo nwplayr)
         {
             if (vldpler)
             {
                 if (validtionDbUni(nwplayer))
                 {
                     if (!validtionfootballDbplr(nwplayer))//changed in all games only this
                     {

                         return true;
                     }

                 }

             }

         }
         return false;
     }

     public static bool validtionfootballDbplr(PlayerInfo newplayer)// football player validation from playrsDb
     {

         string query = "Select * From footbalplayerdataTable Where  Name='" + newplayer.PlayrName + "' and RegNo='" + newplayer.PlayerRegno + "'  ";

         try
         {
             DataAcesslogic.ReadDataFromDb(_dataSet, query, "footbalplayerdataTable");


             if (_dataSet.Tables["footbalplayerdataTable"].Rows.Count > 0)
             {
                 return true;
             }
             else
             {
                 return false;
             }



         }
         catch (Exception ex)
         { throw ex; }



     }


//End of football data validation




        // chess team
        //validation
     public static bool validdchessteam(TeamInfo nwteam)
     {



         bool vtm = TeamInfo.validtaemData(nwteam);
         if (vtm)
         {
             if (!validationChessDb(nwteam))//this validation is changed only for in all games
             {
                 return true;


             }

             return false;

         }

         return false;
     }
     public static bool validationChessDb(TeamInfo nwteam)//team validition from regstrd teams Footall
     {
         string query = "Select * From ChesteamdataTable Where  Teamname='" + nwteam.TeamName.ToUpper() + "'";

         try
         {
             DataAcesslogic.ReadDataFromDb(_dataSet, query, "ChesteamdataTable");                                //football


             if (_dataSet.Tables["ChesteamdataTable"].Rows.Count > 0)
             {
                 return true;
             }
             else
             {
                 return false;
             }



         }
         catch (Exception ex)
         { throw ex; }


     }
     public static bool validchessplayer(PlayerInfo nwplayer)//footbalplayer validation
     {
         bool vldpler = PlayerInfo.validplayer(nwplayer);
       //  if (!validationDb(nwplayer))//validationDb(PlayerInfo nwplayr)
        // {
             if (vldpler)
             {
                 if (validtionDbUni(nwplayer))
                 {
                     if (!validtionchessDbplr(nwplayer))//changed in all games only this
                     {

                         return true;
                     }

                 }

//             }

         }
         return false;
     }

     public static bool validtionchessDbplr(PlayerInfo newplayer)// football player validation from playrsDb
     {

         string query = "Select * From ChessplayerdataTable Where  Name='" + newplayer.PlayrName + "' and RegNo='" + newplayer.PlayerRegno + "'  ";

         try
         {
             DataAcesslogic.ReadDataFromDb(_dataSet, query, "ChessplayerdataTable");


             if (_dataSet.Tables["ChessplayerdataTable"].Rows.Count > 0)
             {
                 return true;
             }
             else
             {
                 return false;
             }



         }
         catch (Exception ex)
         { throw ex; }



     }

//ludo validation

        //asdasdaw
     public static bool validdludoteam(TeamInfo nwteam)
     {



         bool vtm = TeamInfo.validtaemData(nwteam);
         if (vtm)
         {
             if (!validationLudoDb(nwteam))//this validation is changed only for in all games
             {
                 return true;


             }

             return false;

         }

         return false;
     }
     public static bool validationLudoDb(TeamInfo nwteam)//team validition from regstrd teams 
     {
         string query = "Select * From LudoteamdataTable Where  Teamname='" + nwteam.TeamName.ToUpper() + "'";

         try
         {
             DataAcesslogic.ReadDataFromDb(_dataSet, query, "LudoteamdataTable");                                //football


             if (_dataSet.Tables["LudoteamdataTable"].Rows.Count > 0)
             {
                 return true;
             }
             else
             {
                 return false;
             }



         }
         catch (Exception ex)
         { throw ex; }


     }
     public static bool validLudoplayer(PlayerInfo nwplayer)//footbalplayer validation
     {
         bool vldpler = PlayerInfo.validplayer(nwplayer);
         if (!validationDb(nwplayer))//validationDb(PlayerInfo nwplayr)
         {
             if (vldpler)
             {
                 if (validtionDbUni(nwplayer))
                 {
                     if (!validtionDbplr(nwplayer))//changed in all games only this
                     {

                         return true;
                     }

                 }

             }

         }
         return false;
     }

     public static bool validtionDLudobplr(PlayerInfo newplayer)// football player validation from playrsDb
     {

         string query = "Select * From LudoplayrdataTable Where  Name='" + newplayer.PlayrName + "' and RegNo='" + newplayer.PlayerRegno + "'  ";

         try
         {
             DataAcesslogic.ReadDataFromDb(_dataSet, query, "LudoplayrdataTable");


             if (_dataSet.Tables["LudoplayrdataTable"].Rows.Count > 0)
             {
                 return true;
             }
             else
             {
                 return false;
             }



         }
         catch (Exception ex)
         { throw ex; }



     }


        
        //table taniss

     public static bool validtabletanessteam(TeamInfo nwteam)
     {



         bool vtm = TeamInfo.validtaemData(nwteam);
         if (vtm)
         {
             if (!validationtabletanessDb(nwteam))//this validation is changed only for in all games
             {
                 return true;


             }

             return false;

         }

         return false;
     }
     public static bool validationtabletanessDb(TeamInfo nwteam)//team validition from regstrd teams 
     {
         string query = "Select * From TAbletennisteamTable Where  Teamname='" + nwteam.TeamName.ToUpper() + "'";

         try
         {
             DataAcesslogic.ReadDataFromDb(_dataSet, query, "TAbletennisteamTable");                                //football


             if (_dataSet.Tables["TAbletennisteamTable"].Rows.Count > 0)
             {
                 return true;
             }
             else
             {
                 return false;
             }



         }
         catch (Exception ex)
         { throw ex; }


     }
     public static bool validtabletanesplayer(PlayerInfo nwplayer)//footbalplayer validation
     {
         bool vldpler = PlayerInfo.validplayer(nwplayer);
         if (!validationDb(nwplayer))//validationDb(PlayerInfo nwplayr)
         {
             if (vldpler)
             {
                 if (validtionDbUni(nwplayer))
                 {
                     if (!validtionDbtabletanesplr(nwplayer))//changed in all games only this
                     {

                         return true;
                     }

                 }

             }

         }
         return false;
     }

     public static bool validtionDbtabletanesplr(PlayerInfo newplayer)// tabletaness player validation from playrsDb
     {

         string query = "Select * From tabletennisplayerTable Where  Name='" + newplayer.PlayrName + "' and RegNo='" + newplayer.PlayerRegno + "'  ";

         try
         {
             DataAcesslogic.ReadDataFromDb(_dataSet, query, "tabletennisplayerTable");


             if (_dataSet.Tables["tabletennisplayerTable"].Rows.Count > 0)
             {
                 return true;
             }
             else
             {
                 return false;
             }



         }
         catch (Exception ex)
         { throw ex; }



     }



     /*   //teamname validition ///
        public static List<TeamInfo> GetyteamNames()
        {
            try
            {
                string query = "Select * From TeamdataTable";
                string tblName = "TeamdataTable";
                List<TeamInfo> teamList = new List<TeamInfo>();


                if (_dataSet.Tables.Contains(tblName))
                { 
                
                
                
                
                }
                else
                {
                    DataAcesslogic.ReadDataFromDb(_dataSet, query, tblName);
                }


                for (int i = 0; i < _dataSet.Tables[tblName].Rows.Count; i++)
                {
                    DataRow row = _dataSet.Tables[tblName].Rows[i];

                    TeamInfo team = new TeamInfo();
                    team.Teamid = Convert.ToInt32(row["ID"].ToString());
                    team.Depart =row["TeamDepart"].ToString();
                    team.Teasemester = row["TeamSemeser"].ToString();
                    team.TeamName = row["Teamname"].ToString();
                   
                    teamList.Add(team);

                } // end of loop

                return teamList;
            }
            catch (Exception ex)
            { throw ex; }

        } // end of GetDeptNames



       


       public static bool validcrickteamname(TeamInfo nwteam)
        {
            string query = "Select * From TeamdataTable Where  Teamname='" + nwteam.TeamName.ToUpper() + "' and TeamSemester='" + nwteam.Teasemester.ToUpper() + "' and teamdepart='" + nwteam.Depart.ToUpper() + "'  ";

            try
            {
               DataAcesslogic.ReadDataFromDb(_dataSet, query, "TeamdataTable");


                if (_dataSet.Tables["TeamdataTable"].Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }



            }
            catch (Exception ex)
            { throw ex; }
        }
       public static bool validpalyer(PlayerInfo newpalyer)
       {
           bool validplayr = PlayerInfo.validplayer(newpalyer);
           if (validplayr)
           { 
           if (validunistudent(newpalyer))
           {
               if (!validplyrfrmtmdatA(newpalyer))
               {

                   return true;
               }

           }
       }
           return false;

         
       }
        //uni record validtion....
        public static bool validplyrfrmtmdatA(PlayerInfo unistu)
        {

            string query = "Select * From PlayerdataTable Where  StudentName='" + unistu.PlayrName + "' and StudentRegNO='" + unistu.PlayerRegno + "'  ";//"' and Teamid ='" + unistu.Playerteamid + "' and Depart ='" + unistu.Playerdepart +

            try
            {
                DataAcesslogic.ReadDataFromDb(_dataSet, query, "PlayerdataTable");


                if (_dataSet.Tables["PlayerdataTable"].Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            { throw ex; }


        }
        //Validition form other teeamsdata

        public static bool validunistudent(PlayerInfo unistu)
        {

            string query = "Select * From UniData Where  StudentName='" + unistu.PlayrName + "' and StudentRegNO='" + unistu.PlayerRegno + "'  ";

            try
            {
                DataAcesslogic.ReadDataFromDb(_dataSet, query, "UniData");


                if (_dataSet.Tables["UniData"].Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            { throw ex; }


        }


        /*
        //check nt the player of any other team 
        public static bool validteampalyer(PlayerInfo valid)
        {

            string query = "Select * From PlayerdataTable Where  Name='" + valid.PlayrName + "'RegNo='" + valid.PlayerRegno + "'  ";

            try
            {
                DataTable _dTable = null;

                _dTable = DataAcesslogic.ReadDataFromDb(query);

                if (_dTable.Rows.Count > 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            { throw ex; }


        }





        
        //Function Of Insert
        public static void InsertData(TeamInfo newteam)
        {

            string query = "INSERT INTO TeamdataTable VALUES('" + newteam.TeamName + "','" + newteam.Teasemester + "','" + newteam.Depart + "','" + "');";

            try
            {
                DataTable _dTable = null;

                _dTable = DataAcesslogic.ReadDataFromDb(query);




            }
            catch (Exception ex)
            { throw ex; }

        } //End Of Insert Function


        */
        public  static bool team(TeamInfo nwteam){




            return true;

        }
            




    }
    }