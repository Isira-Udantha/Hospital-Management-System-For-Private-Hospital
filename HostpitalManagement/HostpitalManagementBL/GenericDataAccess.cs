using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;


namespace HostpitalManagementBL
{
    static class GenericDataAccess
    {
        //Declare Database connection string 
        static string connectionString="Data Source=THILINA-PC\\THILINA;Initial Catalog=Hostpital;Integrated Security=True";
        //Declare database type
        static string providerType = "System.Data.SqlClient";



        /// <summary>
        /// Class to create vendor specific Database command object 
        /// and encode connectionstring ,provider name and command type
        /// </summary>
        /// <returns>SQL Specific Db command object</returns>
        /// <Author>Thilina Wanshathilaka</Author>
        /// <DateCreated>2019-12-14</DateCreated>
        public static DbCommand CreateDbCommand()
        {
            //Create new data provider factory
            DbProviderFactory factory = DbProviderFactories.GetFactory(providerType);

            //Obtain a database specific Dbconnection object 
            DbConnection conn = factory.CreateConnection();
            //Setup Database connection string in Dbconnection object
            conn.ConnectionString = connectionString;
            //create database specific command object 
            DbCommand comm = conn.CreateCommand();
            //setup command type for the stored procedure
            comm.CommandType = CommandType.StoredProcedure;
            //return initialize command object 
            return comm;
        }

        public static DataTable ExecuteQuery(DbCommand command) 
        {
            //create Data table to populate result
            DataTable tbl = new DataTable();

            //Execute the commad object 
            try
            {
                //Open data connection 
                command.Connection.Open();
                //execute stored proc and save the result set to data reader
                DbDataReader reader = command.ExecuteReader();
                //fill the reader to data table 
                tbl.Load(reader);
                //colse the data rader
            }
            catch (Exception e)
            {
                //Log that error useing relevent class
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
                //Open connection 
                command.Connection.Open();
                //execute Non query and get the number of affected rows
                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception e)
            {
                //log the error and retrow it 
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
