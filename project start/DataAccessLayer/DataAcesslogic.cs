using System;
using System.Data;
using System.Data.SqlClient;

namespace project_start.DataAccessLayer
{
   public class DataAcesslogic
    {
        private static string _connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ahmad\documents\visual studio 2013\Projects\project start\project start\LoginData.mdf;Integrated Security=True";//login atble logic
        private static SqlConnection _dbConnection = null;
        private static SqlDataAdapter _dbAdapter = null;
        private static SqlCommand _dbCommand = null;
        
        //login connection
         private static void CreateConnection()
        {
            try
            {
                _dbConnection = new SqlConnection();
                _dbConnection.ConnectionString = _connectionString;

                // establish connection with database
                _dbConnection.Open(); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //team data connction  ... , , ,
       

     private static void CloseConnection()
        {
            try
            {
                _dbConnection.Close();
            }
            catch (Exception ex)
            { throw ex; }
        }
       //login table logic
        //logic to database of teamdata
   
     public static void ReadDataFromDb(DataSet dset,
                    string query,
                    string tableName)
     {
         try
         {
             CreateConnection();

             _dbCommand = new SqlCommand();
             _dbCommand.CommandText = query;
             _dbCommand.Connection = _dbConnection;

             _dbAdapter = new SqlDataAdapter();
             _dbAdapter.SelectCommand = _dbCommand;


             //DataTable _dataTable = new DataTable();
             _dbAdapter.Fill(dset, tableName);

             CloseConnection();

             //return _dataTable;

         }
         catch (Exception ex)
         {
             throw ex;
         }

     } // end of ReadDataFromDb
       //BeginExecuteNonQuery;
        //login logic is ended

        //logic to check data from team data db
     public static void InsertDataFromDb(string query )
     {
         try
         {
             CreateConnection();

             _dbCommand = new SqlCommand();
             _dbCommand.CommandText = query;
             _dbCommand.Connection = _dbConnection;

             _dbCommand.BeginExecuteNonQuery();

             

             CloseConnection();


         }
         catch (Exception ex)
         {
             throw ex;
         }

     }

       
    }
}
