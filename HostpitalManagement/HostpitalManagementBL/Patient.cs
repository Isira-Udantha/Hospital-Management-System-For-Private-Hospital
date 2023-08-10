using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace HostpitalManagementBL
{
    public static class Patient
    {

        public static DataTable ListPatient() 
        {
            //Create Db command object using generic dataaccess Create command method 
            DbCommand command = GenericDataAccess.CreateDbCommand();
            //Providing the stored procedure name 
            command.CommandText = "ListPatient";

            //Create Datatable object to populate results
            DataTable table = new DataTable();

            table = GenericDataAccess.ExecuteQuery(command);

            return table;
        }

        public static DataTable SearchPatient(string NIC)
        {
            DbCommand command = GenericDataAccess.CreateDbCommand();
            //Providing the stored procedure name 
            command.CommandText = "SearchPatient";

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

        public static bool AddNewPatient(string name,string gurdian,string NIC,string contactNumber,string emergency,DateTime DOB,string Address,string bloodGroup,string allergyDes,string generalDes)
        {

            //Create Dbcommand object
            DbCommand command = GenericDataAccess.CreateDbCommand();
            //Define stored procedure 
            command.CommandText = "AddNewPatient";
            //Define parameters required 

            DbParameter param = command.CreateParameter();
            param.ParameterName = "@PatientName";
            param.Value = name;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@GuardianName";
            param.Value = gurdian;
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
            param.ParameterName = "@EmergencyContact";
            param.Value = emergency;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@DOB";
            param.Value = DOB;
            param.DbType = DbType.Date;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@Address";
            param.Value = Address;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@BloodGroup";
            param.Value = bloodGroup;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@AllergyDescription";
            param.Value = allergyDes;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@GeneralDescription";
            param.Value = generalDes;
            param.DbType = DbType.String;
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
        

        public static bool UpdatePateients(int patientId, string name,string gurdian,string NIC,string contactNumber,string emergency,DateTime DOB,string Address,string bloodGroup,string allergyDes,string generalDes)
        {
                        //Create Dbcommand object
            DbCommand command = GenericDataAccess.CreateDbCommand();
            //Define stored procedure 
            command.CommandText = "UpdatePatientDetails";
            //Define parameters required 

            DbParameter param = command.CreateParameter();
            param.ParameterName = "@PatientID";
            param.Value = patientId;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@PatientName";
            param.Value = name;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@GuardianName";
            param.Value = gurdian;
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
            param.ParameterName = "@EmergencyContact";
            param.Value = emergency;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@DOB";
            param.Value = DOB;
            param.DbType = DbType.Date;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@Address";
            param.Value = Address;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@BloodGroup";
            param.Value = bloodGroup;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@AllergyDescription";
            param.Value = allergyDes;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@GeneralDescription";
            param.Value = generalDes;
            param.DbType = DbType.String;
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
