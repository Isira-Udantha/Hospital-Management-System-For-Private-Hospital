using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Hospital_ManagementBL
{
    public static class Patient
    {
        //List Patient
        public static DataTable ListPatient()
        {
            //create Db command object using generic dataaccess create command methode
            DbCommand command = GenericDataAccess.CreateDbCommand();
            //providing the store procedure name
            command.CommandText = "ListPatient";

            //create dataase object to populate results
            DataTable table = new DataTable();
            table = GenericDataAccess.ExecuteQuery(command);

            return table;
        }

        public static DataTable SearchPatient(string NIC) 
        {
            //create Db command object using generic dataaccess create command methode
            DbCommand command = GenericDataAccess.CreateDbCommand();
            //providing the store procedure name
            command.CommandText = "SearchPatient";

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

        public static bool AddNewPatient (string name,string gurdians,string NIC,string contact,string emergancycontact,DateTime DOB,string address,string bloodgroup,string alergydesc,string generaldesc)
        {
            //Create Dbcommand object 
        DbCommand command = GenericDataAccess.CreateDbCommand();
            //define store procedure
        command.CommandText = "AddNewPatient";
            //define parameters required

        DbParameter param = command.CreateParameter();
        param.ParameterName = "@PatientName";
        param.Value =  name;
        param.DbType = DbType.String;
        command.Parameters.Add(param);

        param = command.CreateParameter();
        param.ParameterName = "@GuardiansName";
        param.Value = gurdians;
        param.DbType = DbType.String;
        command.Parameters.Add(param);

        param = command.CreateParameter();
        param.ParameterName = "@NIC";
        param.Value =  NIC;
        param.DbType = DbType.String;
        command.Parameters.Add(param);


        param = command.CreateParameter();
        param.ParameterName = "@ContactNumber";
        param.Value =  contact;
        param.DbType = DbType.String;
        command.Parameters.Add(param);

        param = command.CreateParameter();
        param.ParameterName = "@EmergencyContact";
        param.Value = emergancycontact;
        param.DbType = DbType.String;
        command.Parameters.Add(param);


        param = command.CreateParameter();
        param.ParameterName = "@DOB";
        param.Value = DOB ;
        param.DbType = DbType.DateTime;
        command.Parameters.Add(param);


        param = command.CreateParameter();
        param.ParameterName = "@Address";
        param.Value =  address;
        param.DbType = DbType.String;
        command.Parameters.Add(param);


        param = command.CreateParameter();
        param.ParameterName = "@BloodGroup";
        param.Value = bloodgroup;
        param.DbType = DbType.String;
        command.Parameters.Add(param);


        param = command.CreateParameter();
        param.ParameterName = "@AllergyDesc";
        param.Value = alergydesc;
        param.DbType = DbType.String;
        command.Parameters.Add(param);


        param = command.CreateParameter();
        param.ParameterName = "@GenaralDesc";
        param.Value = generaldesc;
        param.DbType = DbType.String;
        command.Parameters.Add(param);

            int success = -1;
            //call execute nonquery
            try
            {
                success = GenericDataAccess.ExecuteNonQuery(command);

            }
            catch(Exception e)
            {
                throw;
            }

            return (success != -1);
         }

        public static bool UpdatePatient(int patientID,string name, string gurdians, string NIC, string contact, string emergancycontact, DateTime DOB, string address, string bloodgroup, string alergydesc, string generaldesc)
        {
            //Create Dbcommand object 
            DbCommand command = GenericDataAccess.CreateDbCommand();
            //define store procedure
            command.CommandText = "UpdatePatient";
            //define parameters required

            DbParameter param = command.CreateParameter();
            param.ParameterName = "@PatientID";
            param.Value = patientID;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@PatientName";
            param.Value = name;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@GuardiansName";
            param.Value = gurdians;
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
            param.ParameterName = "@EmergencyContact";
            param.Value = emergancycontact;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@DOB";
            param.Value = DOB;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@Address";
            param.Value = address;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@BloodGroup";
            param.Value = bloodgroup;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@AllergyDesc";
            param.Value = alergydesc;
            param.DbType = DbType.String;
            command.Parameters.Add(param);


            param = command.CreateParameter();
            param.ParameterName = "@GenaralDesc";
            param.Value = generaldesc;
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


        public static void UpdatePatient(string patientID, string patientName, string gurdiansName, string NIC, string contactNumber, string emergancyContact, DateTime DOB, string address, string bloodgroup, string alergyDesc, string generalDesc)
        {
            throw new NotImplementedException();
        }

        public static void UpdatePatient(string patientName, string gurdiansName, string NIC, string contactNumber, string emergancyContact, DateTime DOB, string address, string bloodgroup, string alergyDesc, string generalDesc)
        {
            throw new NotImplementedException();
        }
    }
}
