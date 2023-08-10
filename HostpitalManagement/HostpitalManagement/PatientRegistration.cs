using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HostpitalManagementBL;


namespace HostpitalManagement
{
    public partial class frm_PatientRegistration : Form
    {
        private int patientID;
        private string patientName;
        private string guardian;
        private string NIC;
        private DateTime DOB;
        private string contactNumber;
        private string emergencyContact;
        private string bloodGroup;
        private string allergyDesc;
        private string generalDesc;
        private string address;

        public frm_PatientRegistration()
        {
            InitializeComponent();
        }

        private void frm_PatientRegistration_Load(object sender, EventArgs e)
        {
            ResetControls();

        }

        private void ResetControls()
        {
            txt_PatientName.ReadOnly = true;
            txt_Guardian.ReadOnly = true;
            txt_NIC.ReadOnly = true;
            txt_DOB.ReadOnly = true;
            txt_Contact.ReadOnly = true;
            txt_EmergencyContatct.ReadOnly = true;
            txt_Allergy.ReadOnly = true;
            txt_General.ReadOnly = true;
            txt_Address.ReadOnly = true;
            Cmb_BloodGroup.Enabled = false;
            btn_New.Text = "New";
            btn_Update.Text = "Update";
            btn_formReset.Enabled = false;

            //populate Data grid view with Pateint Data
            grd_patientDetails.DataSource = Patient.ListPatient();

            PopulateTextBoxes();
        }

        private void PopulateTextBoxes()
        {
            int rowIndex = grd_patientDetails.CurrentCell.RowIndex;

            patientID=int.Parse(grd_patientDetails.Rows[rowIndex].Cells[0].Value.ToString());
            txt_PatientName.Text = grd_patientDetails.Rows[rowIndex].Cells[1].Value.ToString();
            txt_Guardian.Text = grd_patientDetails.Rows[rowIndex].Cells[2].Value.ToString();
            txt_NIC.Text = grd_patientDetails.Rows[rowIndex].Cells[3].Value.ToString();
            txt_Contact.Text = grd_patientDetails.Rows[rowIndex].Cells[4].Value.ToString();
            txt_EmergencyContatct.Text = grd_patientDetails.Rows[rowIndex].Cells[5].Value.ToString();
            txt_DOB.Text = grd_patientDetails.Rows[rowIndex].Cells[6].Value.ToString();
            txt_Address.Text = grd_patientDetails.Rows[rowIndex].Cells[7].Value.ToString();
            Cmb_BloodGroup.Text = grd_patientDetails.Rows[rowIndex].Cells[8].Value.ToString();
            txt_Allergy.Text = grd_patientDetails.Rows[rowIndex].Cells[9].Value.ToString();
            txt_General.Text = grd_patientDetails.Rows[rowIndex].Cells[10].Value.ToString();
        }

        private void grd_patientDetails_SelectionChanged(object sender, EventArgs e)
        {
            PopulateTextBoxes();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {

            if(btn_New.Text=="New")
            {
                txt_PatientName.Text = "";
                txt_Guardian.Text = "";
                txt_NIC.Text = "";
                txt_Contact.Text = "";
                txt_EmergencyContatct.Text = "";
                txt_DOB.Text = "";
                txt_Address.Text = "";
                Cmb_BloodGroup.Text = "";
                txt_Allergy.Text = "";
                txt_General.Text = "";

                btn_New.Text = "Save";
                btn_formReset.Enabled = true;

                txt_PatientName.ReadOnly = false;
                txt_Guardian.ReadOnly = false;
                txt_NIC.ReadOnly = false;
                txt_DOB.ReadOnly = false;
                txt_Contact.ReadOnly = false;
                txt_EmergencyContatct.ReadOnly = false;
                txt_Allergy.ReadOnly = false;
                txt_General.ReadOnly = false;
                txt_Address.ReadOnly = false;
                Cmb_BloodGroup.Enabled = true;
                
            }

            else if (btn_New.Text == "Save") 
            {
                patientName = txt_PatientName.Text;
                guardian = txt_Guardian.Text;
                NIC = txt_NIC.Text;
                DOB = DateTime.Parse(txt_DOB.Text);
                contactNumber = txt_Contact.Text;
                emergencyContact = txt_EmergencyContatct.Text;
                bloodGroup = Cmb_BloodGroup.Text;
                allergyDesc = txt_Allergy.Text;
                generalDesc = txt_General.Text;
                address = txt_Address.Text;


                try 
                {
                    Patient.AddNewPatient(patientName, guardian, NIC, contactNumber, emergencyContact, DOB, address, bloodGroup, allergyDesc, generalDesc);

                    MessageBox.Show("Data Saved Successfully");
                    ResetControls();
                }

                catch(Exception ex)
                {
                    MessageBox.Show("Unable to Save Data");
                }

                
            }

            

            

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (btn_Update.Text == "Update")
            {
                btn_Update.Text = "Commit";
                btn_formReset.Enabled = true;

                txt_PatientName.ReadOnly = false;
                txt_Guardian.ReadOnly = false;
                txt_NIC.ReadOnly = false;
                txt_DOB.ReadOnly = false;
                txt_Contact.ReadOnly = false;
                txt_EmergencyContatct.ReadOnly = false;
                txt_Allergy.ReadOnly = false;
                txt_General.ReadOnly = false;
                txt_Address.ReadOnly = false;
                Cmb_BloodGroup.Enabled = true;

            }
            else if(btn_Update.Text=="Commit")
            {
                patientName = txt_PatientName.Text;
                guardian = txt_Guardian.Text;
                NIC = txt_NIC.Text;
                DOB = DateTime.Parse(txt_DOB.Text);
                contactNumber = txt_Contact.Text;
                emergencyContact = txt_EmergencyContatct.Text;
                bloodGroup = Cmb_BloodGroup.Text;
                allergyDesc = txt_Allergy.Text;
                generalDesc = txt_General.Text;
                address = txt_Address.Text;
                try 
                {
                    Patient.UpdatePateients(patientID, patientName, guardian, NIC, contactNumber, emergencyContact, DOB, address, bloodGroup, allergyDesc, generalDesc);

                    MessageBox.Show("Data Saved Successfully");
                    ResetControls();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Update Failed");
                    ResetControls();
                }

            }
        }

        private void btn_formReset_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchParam = txt_Search.Text;

            grd_patientDetails.DataSource = Patient.SearchPatient(searchParam);
        }

        private void btn_SearchReset_Click(object sender, EventArgs e)
        {
            ResetControls();
        }
    }
}
