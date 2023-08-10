using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace HostpitalManagementBL
{
    public static class Doctors
    {
        public static DataTable GetDoctorsDetails() 
        {
            //Create Db command object using generic dataaccess Create command method 
            DbCommand command = GenericDataAccess.CreateDbCommand();
            //Providing the stored procedure name 
            command.CommandText = "ListDoctors";

            //Create Datatable object to populate results
            DataTable table = new DataTable();

            table = GenericDataAccess.ExecuteQuery(command);

            return table;
        }

        public static DataTable SearchDoctors(string NIC)
        {
            DbCommand command = GenericDataAccess.CreateDbCommand();
            //Providing the stored procedure name 
            command.CommandText = "SearchDoctors";

            DbParameter param = command.CreateParameter();
            param.ParameterName = "@NIC";
            param.Value = NIC;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            //Create Datatable object to populate results
            DataTable table = new DataTable();

            table = GenericDataAccess.ExecuteQuery(command);
            return table;
        }

        public static bool AddNewDoctor(string name,string NIC,string contactNumber,string speciality,decimal rates,string ACNumber,int active) 
        {
            //Create Dbcommand object
            DbCommand command = GenericDataAccess.CreateDbCommand();
            //Define stored procedure 
            command.CommandText = "AddNewDoctor";
            //Define parameters required 

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
            param.Value = contactNumber;
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
            param.DbType = DbType.Decimal;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@ACNumber";
            param.Value = ACNumber;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@Active";
            param.Value = active;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);


            int success = -1;
            //Call execute nonQuey method
            try
            {
                success = GenericDataAccess.ExecuteNonQuery(command);
            }
            catch (Exception e)
            {
                throw;
            }

            //return
            return (success != -1);
        }

        public static bool UpdateDoctorsDetails(int doctorID, string name, string NIC, string contactNumber, string speciality, decimal rates, string ACNumber, int active) 
        {
            //Create Dbcommand object
            DbCommand command = GenericDataAccess.CreateDbCommand();
            //Define stored procedure 
            command.CommandText = "UpdateDoctorsDetails";
            //Define parameters required 

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
            param.Value = contactNumber;
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
            param.DbType = DbType.Decimal;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@ACNumber";
            param.Value = ACNumber;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@Active";
            param.Value = active;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);


            int success = -1;
            //Call execute nonQuey method
            try
            {
                success = GenericDataAccess.ExecuteNonQuery(command);
            }
            catch (Exception e)
            {
                throw;
            }

            //return
            return (success != -1);
        }

        public static DataTable GetAvailabilityDetails(int doctorID) 
        {
            DbCommand command = GenericDataAccess.CreateDbCommand();
            //Providing the stored procedure name 
            command.CommandText = "GetAvailabilityDetails";

            DbParameter param = command.CreateParameter();
            param.ParameterName = "@DoctorID";
            param.Value = doctorID;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            //Create Datatable object to populate results
            DataTable table = new DataTable();

            table = GenericDataAccess.ExecuteQuery(command);
            return table;

        }

        public static bool AddAvailability(int doctorID,string day,string timeIn,string timeOut,float hours) 
        {
            //Create Dbcommand object
            DbCommand command = GenericDataAccess.CreateDbCommand();
            //Define stored procedure 
            command.CommandText = "AddTimeSlot";
            //Define parameters required 

            DbParameter param = command.CreateParameter();
            param.ParameterName = "@DoctorID";
            param.Value = doctorID;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@Day";
            param.Value = day;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@InTime";
            param.Value = timeIn;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@OutTime";
            param.Value = timeOut;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@NumberOfHours";
            param.Value = hours;
            param.DbType = DbType.Decimal;
            command.Parameters.Add(param);

            int success = -1;
            //Call execute nonQuey method
            try
            {
                success = GenericDataAccess.ExecuteNonQuery(command);
            }
            catch (Exception e)
            {
                throw;
            }

            //return
            return (success != -1);
        }
    
    
    }
}
