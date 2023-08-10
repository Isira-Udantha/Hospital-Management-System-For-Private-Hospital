using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;


namespace Hospital_ManagementBL
{
   static class GenericDataAccess
    {
       //Declare Database Connection string
       static string connectionString = "Data Source=(local);Initial Catalog=Hospital1;Integrated Security=True";
       //Declare Database Type
       static string providerType = "System.Data.SqlClient";

       /// <summary>
       /// Class to create vendor specific Database command object
       /// and encode connectionString ,Provider name and command type
       /// </summary>
       /// <Author>Dinesh Wayaman</Author>
       /// <DateCreated>2019-12-14</DateCreated>
       /// <returns>SQL Specific Db command object</returns>

       public static DbCommand CreateDbCommand()
       {
           //create new data provider factory
           DbProviderFactory factory = DbProviderFactories.GetFactory(providerType);
           //obtain a database specific Dbconnection object
           DbConnection conn = factory.CreateConnection();
           //setup database connection string in Dbconnection object
           conn.ConnectionString = connectionString;
           //create database specific command object
           DbCommand comm = conn.CreateCommand();
           //setup command type for the store procedure
           comm.CommandType = CommandType.StoredProcedure;
           //return initialize command object
           return comm;
       }

       public static DataTable ExecuteQuery(DbCommand command) 
       { 
           //create Data table to populate result
           DataTable tbl = new DataTable();

           //execute the command object
           try
           {
               //open data connection
               command.Connection.Open();
               //execute stored proc and save the result set data reader
               DbDataReader reader = command.ExecuteReader();
               //fill the reader to data table
               tbl.Load(reader);
               //close the data reader
           }
           catch (Exception e)
           {
               //Log that error using relevent class
               throw;
           }
           finally
           {
               //close the database connection
               command.Connection.Close();
           }

           return tbl;
       }

       public static int ExecuteNonQuery(DbCommand command)
       {
           int rowsAffected = -1;
           //execute command object
           try
           {
               //open connection
               command.Connection.Open();
               //execute Non quwry and get the number of affected rows
               rowsAffected = command.ExecuteNonQuery();
           }
           catch (Exception e)
           {
               //log the error and rethrow it
               throw;
           }
           finally 
           {
               //close the connection
               command.Connection.Close();
           }
           return rowsAffected;
       }

    }
}
