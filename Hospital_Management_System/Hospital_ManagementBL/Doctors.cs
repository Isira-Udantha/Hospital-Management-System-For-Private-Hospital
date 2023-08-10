using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Hospital_ManagementBL
{
    public static class Doctors
    {
        public static DataTable ListDoctor()
        {
            //create Db command object using generic dataaccess create command methode
            DbCommand command = GenericDataAccess.CreateDbCommand();
            //providing the store doctor name
            command.CommandText = "ListDoctor";

            //create dataase object to populate results
            DataTable table = new DataTable();
            table = GenericDataAccess.ExecuteQuery(command);

            return table;
        }

        public static DataTable SearchDoctor(string NIC)
        {
            //create Db command object using generic dataaccess create command methode
            DbCommand command = GenericDataAccess.CreateDbCommand();
            //providing the store procedure name
            command.CommandText = "SearchDoctor";

            DbParameter param = command.CreateParameter();
            param.ParameterName = "@NIC";
            param.Value = NIC;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //create dataase object to populate results
            DataTable table = new DataTable();
            table = GenericDataAccess.ExecuteQuery(command);

            return table;
        }

        public static bool AddNewDoctor(string name, string NIC, string contact, string speciality, string rates, string accountnumber, string active)
        {
            //Create Dbcommand object 
            DbCommand command = GenericDataAccess.CreateDbCommand();
            //define store procedure
            command.CommandText = "AddNewDoctor";
            //define parameters required

            DbParameter param = command.CreateParameter();
            param.ParameterName = "@DoctorName";
            param.Value = name;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

        
            param = command.CreateParameter();
            param.ParameterName = "@NIC";
            param.Value = NIC;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@ContactNumber";
            param.Value = contact;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@Speciality";
            param.Value = speciality;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@Rates";
            param.Value = rates;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@AccountNumber";
            param.Value = accountnumber;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@Active";
            param.Value = active;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            
            int success = -1;
            //call execute nonquery
            try
            {
                success = GenericDataAccess.ExecuteNonQuery(command);

            }
            catch (Exception e)
            {
                throw;
            }

            return (success != -1);
        }

        public static bool UpdateDoctor(int doctorID, string name, string NIC, string contact, string speciality, string rates, string accountnumber, string active)
        {
            //Create Dbcommand object 
            DbCommand command = GenericDataAccess.CreateDbCommand();
            //define store procedure
            command.CommandText = "UpdateDoctor";
            //define parameters required

            DbParameter param = command.CreateParameter();
            param.ParameterName = "@DoctorID";
            param.Value = doctorID;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@DoctorName";
            param.Value = name;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@NIC";
            param.Value = NIC;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@ContactNumber";
            param.Value = contact;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@Speciality";
            param.Value = speciality;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@Rates";
            param.Value = rates;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@AccountNumber";
            param.Value = accountnumber;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@Active";
            param.Value = active;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

           

            int success = -1;
            //call execute nonquery
            try
            {
                success = GenericDataAccess.ExecuteNonQuery(command);

            }
            catch (Exception e)
            {
                throw;
            }

            return (success != -1);
        }




    }
}
