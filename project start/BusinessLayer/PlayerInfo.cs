using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_start.BusinessLayer
{
  public   class PlayerInfo
    {

      private string _playrName;
      private string _playerRegno;
      private string  _playerteamname;
      private string _playerdepart;
      private string _playersemester;
      public string Playersemester
      {
          set
          {
              _playersemester = value;
          }
          get
          {

              return _playersemester;
          }

      }

      public string Playerdepart
      {
          set
          {
              _playerdepart = value;
          }
          get
          {

              return _playerdepart;
          }

      }

      public string  Playerteamname
      {
          set
          {
              _playerteamname = value;
          }
          get
          {

              return _playerteamname;
          }

      }
      public string PlayrName
      {
          set
          {
              _playrName = value;
          }
          get
          {

              return _playrName;
          }

      }
      public string PlayerRegno
      {
          set
          {
              _playerRegno = value;
          }
          get
          {

              return _playerRegno;
          }

      }

      public PlayerInfo()
      {
          _playerRegno = " ";
          _playrName = " ";
          _playerdepart = " ";
          _playersemester = " ";
          _playerteamname = " ";
      }

     
      public static bool validplayer(PlayerInfo val)
      {

          for (int i = 0; i <= 9; i++)
          {
              if (val._playrName.Contains(i.ToString()))
              {
                  return false;
              }
          }

          if (val._playrName.Contains("+"))
              return false;
          if (val._playrName.Contains("!"))
              return false;
          if (val._playrName.Contains("@"))
              return false;
          if (val._playrName.Contains("#"))
              return false;
          if (val._playrName.Contains("$"))
              return false;
          if (val._playrName.Contains("%"))
              return false;
          if (val._playrName.Contains("^"))
              return false;
          if (val._playrName.Contains("&"))
              return false;
          if (val._playrName.Contains("*"))
              return false;
          if (val._playrName.Contains("("))
              return false;
          if (val._playrName.Contains(")"))
              return false;
          if (val._playrName.Contains("-"))
              return false;
          if (val._playrName.Contains("_"))
              return false;
          if (val._playrName.Contains("="))
              return false;
          if (val._playrName.Contains("`"))
              return false;
          if (val._playrName.Contains("~"))
              return false;
          if (val._playrName.Contains("|"))
              return false;
          if (val._playrName.Contains("}"))
              return false;
          if (val._playrName.Contains("\""))
              return false;
          if (val._playrName.Contains("/"))
              return false;
          if (val._playrName.Contains("?"))
              return false;
          if (val._playrName.Contains("]"))
              return false;
          if (val._playrName.Contains("["))
              return false;
          if (val._playrName.Contains("'"))
              return false;
          if (val._playrName.Contains(";"))
              return false;
          if (val._playrName.Contains(":"))
              return false;
          if (val._playrName.Contains("."))
              return false;
          if (val._playrName.Contains(","))
              return false;

          for (char i = 'A'; i <= 'Z'; i++)
          {
              if (val._playerRegno.Contains(i.ToString()))
              {
                  return false;
              }
          }
          for (char i = 'a'; i <= 'z'; i++)
          {
              if (val._playerRegno.Contains(i.ToString()))
              {
                  return false;
              }
          }
          if (val._playerRegno.Contains("+"))
              return false;
          if (val._playerRegno.Contains("!"))
              return false;
          if (val._playerRegno.Contains("@"))
              return false;
          if (val._playerRegno.Contains("#"))
              return false;
          if (val._playerRegno.Contains("$"))
              return false;
          if (val._playerRegno.Contains("%"))
              return false;
          if (val._playerRegno.Contains("^"))
              return false;
          if (val._playerRegno.Contains("&"))
              return false;
          if (val._playerRegno.Contains("*"))
              return false;
          if (val._playerRegno.Contains("("))
              return false;
          if (val._playerRegno.Contains(")"))
              return false;
          if (val._playerRegno.Contains("-"))
              return false;
          if (val._playerRegno.Contains("_"))
              return false;
          if (val._playerRegno.Contains("="))
              return false;
          if (val._playerRegno.Contains("`"))
              return false;
          if (val._playerRegno.Contains("~"))
              return false;
          if (val._playerRegno.Contains("|"))
              return false;
          if (val._playerRegno.Contains("}"))
              return false;
          if (val._playerRegno.Contains("\""))
              return false;
          if (val._playerRegno.Contains("/"))
              return false;
          if (val._playerRegno.Contains("?"))
              return false;
          if (val._playerRegno.Contains("]"))
              return false;
          if (val._playerRegno.Contains("["))
              return false;
          if (val._playerRegno.Contains("'"))
              return false;
          if (val._playerRegno.Contains(";"))
              return false;
          if (val._playerRegno.Contains(":"))
              return false;
          if (val._playerRegno.Contains("."))
              return false;
          if (val._playerRegno.Contains(","))
              return false;
          return true;
      }

      //validitin from uni databases
     

     



    }
}
