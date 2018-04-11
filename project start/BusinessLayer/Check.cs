using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_start.BusinessLayer
{
  public static  class Check
    {
      public static string a;
      public static string crick1;
      public static string ches1;
      public static string footbal1;
      public static string badmention1;
      public static string tabletaness1;
      public static string ludo1;

      public static bool validregNo(string val)
      {
          for (char i = 'A'; i <= 'Z'; i++)
          {
              if (val.Contains(i.ToString()))
              {
                  return false;
              }
          }
          for (char i = 'a'; i <= 'z'; i++)
          {
              if (val.Contains(i.ToString()))
              {
                  return false;
              }
          }
          if (val.Contains("+"))
              return false;
          if (val.Contains("!"))
              return false;
          if (val.Contains("@"))
              return false;
          if (val.Contains("#"))
              return false;
          if (val.Contains("$"))
              return false;
          if (val.Contains("%"))
              return false;
          if (val.Contains("^"))
              return false;
          if (val.Contains("&"))
              return false;
          if (val.Contains("*"))
              return false;
          if (val.Contains("("))
              return false;
          if (val.Contains(")"))
              return false;
          if (val.Contains("-"))
              return false;
          if (val.Contains("_"))
              return false;
          if (val.Contains("="))
              return false;
          if (val.Contains("`"))
              return false;
          if (val.Contains("~"))
              return false;
          if (val.Contains("|"))
              return false;
          if (val.Contains("}"))
              return false;
          if (val.Contains("\""))
              return false;
          if (val.Contains("/"))
              return false;
          if (val.Contains("?"))
              return false;
          if (val.Contains("]"))
              return false;
          if (val.Contains("["))
              return false;
          if (val.Contains("'"))
              return false;
          if (val.Contains(";"))
              return false;
          if (val.Contains(":"))
              return false;
          if (val.Contains("."))
              return false;
          if (val.Contains(","))
              return false;



          return true;



      }
      public static bool validname(string val) //Function For Check Alphabets
      {
          for (int i = 0; i <= 9; i++)
          {
              if (val.Contains(i.ToString()))
              {
                  return false;
              }
          }

          if (val.Contains("+"))
              return false;
          if (val.Contains("!"))
              return false;
          if (val.Contains("@"))
              return false;
          if (val.Contains("#"))
              return false;
          if (val.Contains("$"))
              return false;
          if (val.Contains("%"))
              return false;
          if (val.Contains("^"))
              return false;
          if (val.Contains("&"))
              return false;
          if (val.Contains("*"))
              return false;
          if (val.Contains("("))
              return false;
          if (val.Contains(")"))
              return false;
          if (val.Contains("-"))
              return false;
          if (val.Contains("_"))
              return false;
          if (val.Contains("="))
              return false;
          if (val.Contains("`"))
              return false;
          if (val.Contains("~"))
              return false;
          if (val.Contains("|"))
              return false;
          if (val.Contains("}"))
              return false;
          if (val.Contains("\""))
              return false;
          if (val.Contains("/"))
              return false;
          if (val.Contains("?"))
              return false;
          if (val.Contains("]"))
              return false;
          if (val.Contains("["))
              return false;
          if (val.Contains("'"))
              return false;
          if (val.Contains(";"))
              return false;
          if (val.Contains(":"))
              return false;
          if (val.Contains("."))
              return false;
          if (val.Contains(","))
              return false;



          return true;
      }
      
      





    }
}
