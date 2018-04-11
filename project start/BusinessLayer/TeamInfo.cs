using System;
using System.Data;
using project_start.DataAccessLayer;

namespace project_start.BusinessLayer
{
 public class TeamInfo
    {
     private string _teamName;
     private string _teasemester;
     private string _depart;
     private int _teamid; 
     private PlayerInfo _playerifo;
     public int Teamid
     {
         set
         {
             _teamid = value;
         }
         get
         {
             return _teamid;

         }

     }

     public PlayerInfo Playerifo
     {
         set
         {
             _playerifo = value;
         }
         get
         {
             return _playerifo;

         }

     }
     public string TeamName {
         set
         {
             _teamName = value;
         }
         get {

             return _teamName;
         }
     
     }
     public string Teasemester
     {
         set
         {
             _teasemester = value;
         }
         get
         {

             return _teasemester;
         }

     }

     public string Depart
     {
         set
         {
             _depart = value;
         }
         get
         {

             return _depart;
         }

     }

     public TeamInfo()
     {

         _teamName = " ";
         _depart = " ";
         _teasemester = " ";
         _teamid = 0;
         
         _playerifo = new PlayerInfo();
     }

     public static bool validtaemData(TeamInfo val) //Function For Check Alphabets
     {
         for (int i = 0; i <= 9; i++)
         {
             if (val._depart.Contains(i.ToString()) || val._teamName.Contains(i.ToString()))
             {
                 return false;
             }
         }

        
         if (val._teamName.Contains("+"))
             return false;
         if (val._teamName.Contains("!"))
             return false;
         if (val._teamName.Contains("@"))
             return false;
         if (val._teamName.Contains("#"))
             return false;
         if (val._teamName.Contains("$"))
             return false;
         if (val._teamName.Contains("%"))
             return false;
         if (val._teamName.Contains("^"))
             return false;
         if (val._teamName.Contains("&"))
             return false;
         if (val._teamName.Contains("*"))
             return false;
         if (val._teamName.Contains("("))
             return false;
         if (val._teamName.Contains(")"))
             return false;
         if (val._teamName.Contains("-"))
             return false;
         if (val._teamName.Contains("_"))
             return false;
         if (val._teamName.Contains("="))
             return false;
         if (val._teamName.Contains("`"))
             return false;
         if (val._teamName.Contains("~"))
             return false;
         if (val._teamName.Contains("|"))
             return false;
         if (val._teamName.Contains("}"))
             return false;
         if (val._teamName.Contains("\""))
             return false;
         if (val._teamName.Contains("/"))
             return false;
         if (val._teamName.Contains("?"))
             return false;
         if (val._teamName.Contains("]"))
             return false;
         if (val._teamName.Contains("["))
             return false;
         if (val._teamName.Contains("'"))
             return false;
         if (val._teamName.Contains(";"))
             return false;
         if (val._teamName.Contains(":"))
             return false;
         if (val._teamName.Contains("."))
             return false;
         if (val._teamName.Contains(","))
             return false;
         if (val._teasemester == "None")
             return false;
         if (val._depart == "None")
             return false;

         return true;
     }

     //validation from databases




        
     }



    

     }

    