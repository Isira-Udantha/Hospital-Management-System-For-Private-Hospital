using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//add hospital managementBl go references-add references-project-select project
using Hospital_ManagementBL;

namespace Hospital_Management_System
{
    public partial class frm_PatientRegistration : Form
    {
        public frm_PatientRegistration()
        {
            InitializeComponent();
        }

        private void Grd_Patient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_PatientRegistration_Load(object sender, EventArgs e)
        {
            //what should do when form load
            //All textboxes and combo boxes read only
            //Save Button Disable
            txt_PatientName.ReadOnly = true;
            txt_Guardians.ReadOnly = true;
            txt_NIC.ReadOnly = true;
            txt_contact.ReadOnly = true;
            txt_emergcontact.ReadOnly = true;
            txt_DOB.ReadOnly = true;
            txt_address.ReadOnly = true;
            txt_Alergy.ReadOnly = true;
            txt_general.ReadOnly = true;
            //btn_save.Enabled = false;
            cmb_bloodgroup.Enabled = false;


            //add database to gride view using methodes(Classes)(allready created in Hospital ManagementBL)

            //populate Data to data grideView
            Grd_Patient.DataSource = Patient.ListPatient();

            PopulateTextBoxes();


        }

        private void PopulateTextBoxes()
        {
            int rowIndex = Grd_Patient.CurrentCell.RowIndex;
            txt_PatientName.Text = Grd_Patient.Rows[rowIndex].Cells[1].Value.ToString();
            txt_Guardians.Text = Grd_Patient.Rows[rowIndex].Cells[2].Value.ToString();
            txt_NIC.Text = Grd_Patient.Rows[rowIndex].Cells[3].Value.ToString();
            txt_contact.Text = Grd_Patient.Rows[rowIndex].Cells[4].Value.ToString();
            txt_emergcontact.Text = Grd_Patient.Rows[rowIndex].Cells[5].Value.ToString();
            txt_DOB.Text = Grd_Patient.Rows[rowIndex].Cells[6].Value.ToString();
            txt_address.Text = Grd_Patient.Rows[rowIndex].Cells[7].Value.ToString();
            cmb_bloodgroup.Text = Grd_Patient.Rows[rowIndex].Cells[8].Value.ToString();
            txt_Alergy.Text = Grd_Patient.Rows[rowIndex].Cells[9].Value.ToString();
            txt_general.Text = Grd_Patient.Rows[rowIndex].Cells[10].Value.ToString();
        }

        private void Grd_Patient_SelectionChanged(object sender, EventArgs e)
        {
            PopulateTextBoxes();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (btn_add.Text == "Add New")
            {
                //empty all text box when press Add new
                txt_PatientName.Text = "";
                txt_Guardians.Text = "";
                txt_NIC.Text = "";
                txt_contact.Text = "";
                txt_emergcontact.Text = "";
                txt_DOB.Text = "";
                txt_address.Text = "";
                txt_Alergy.Text = "";
                txt_general.Text = "";
                cmb_bloodgroup.Text = "";
                btn_add.Text = "Save";

                txt_PatientName.ReadOnly = false;
                txt_Guardians.ReadOnly = false;
                txt_NIC.ReadOnly = false;
                txt_contact.ReadOnly = false;
                txt_emergcontact.ReadOnly = false;
                txt_DOB.ReadOnly = false;
                txt_address.ReadOnly = false;
                txt_Alergy.ReadOnly = false;
                txt_general.ReadOnly = false;
                cmb_bloodgroup.Enabled = true;
            }
            else if (btn_add.Text == "Save")
            {
                string patientName = txt_PatientName.Text;
                string gurdiansName = txt_Guardians.Text;
                string NIC = txt_NIC.Text;
                string contactNumber = txt_contact.Text;
                string emergancyContact = txt_emergcontact.Text;
                DateTime DOB = DateTime.Parse(txt_DOB.Text);
                string address = txt_address.Text;
                string alergyDesc = txt_Alergy.Text;
                string generalDesc = txt_general.Text;
                string bloodgroup = cmb_bloodgroup.Text;

                try
                {
                    Patient.AddNewPatient(patientName, gurdiansName, NIC, contactNumber, emergancyContact, DOB, address, bloodgroup, alergyDesc, generalDesc);
                    MessageBox.Show("Data Save Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed Try Again");
                }



            }


        }


        private void btn_update_Click(object sender, EventArgs e)
        {
          /*  if (btn_add.Text == "Update")
            {
                //empty all text box when press Add new
                txt_PatientName.Text = "";
                txt_Guardians.Text = "";
                txt_NIC.Text = "";
                txt_contact.Text = "";
                txt_emergcontact.Text = "";
                txt_DOB.Text = "";
                txt_address.Text = "";
                txt_Alergy.Text = "";
                txt_general.Text = "";
                cmb_bloodgroup.Text = "";
                btn_add.Text = "Save";

                txt_PatientName.ReadOnly = false;
                txt_Guardians.ReadOnly = false;
                txt_NIC.ReadOnly = false;
                txt_contact.ReadOnly = false;
                txt_emergcontact.ReadOnly = false;
                txt_DOB.ReadOnly = false;
                txt_address.ReadOnly = false;
                txt_Alergy.ReadOnly = false;
                txt_general.ReadOnly = false;
                cmb_bloodgroup.Enabled = true;
            }
            else if (btn_add.Text == "Save")
            {
                int rowIndex = Grd_Patient.CurrentCell.RowIndex;


                string patientID = Grd_Patient.Rows[rowIndex].Cells[0].Value.ToString();
                string patientName = txt_PatientName.Text;
                string gurdiansName = txt_Guardians.Text;
                string NIC = txt_NIC.Text;
                string contactNumber = txt_contact.Text;
                string emergancyContact = txt_emergcontact.Text;
                DateTime DOB = DateTime.Parse(txt_DOB.Text);
                string address = txt_address.Text;
                string alergyDesc = txt_Alergy.Text;
                string generalDesc = txt_general.Text;
                string bloodgroup = cmb_bloodgroup.Text;

                try
                {
                    Patient.UpdatePatient(patientName, gurdiansName, NIC, contactNumber, emergancyContact, DOB, address, bloodgroup, alergyDesc, generalDesc);
                    MessageBox.Show("Data Save Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed Try Again");
                }
            }



*/

        }
         
    }
}