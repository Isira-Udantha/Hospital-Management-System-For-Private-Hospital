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
    public partial class FrmDoctorsRegistration : Form
    {
        private int doctorID;
        private string doctorsName;
        private string NIC;
        private string contactNumber;
        private string speciality;
        private decimal rates;
        private string acNumber;
        private int active;

        
        public FrmDoctorsRegistration()
        {
            InitializeComponent();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            if (btn_New.Text == "New")
            {
                btn_New.Text = "Save";

                txt_DoctorsName.ReadOnly = false;
                txt_NIC.ReadOnly = false;
                txt_Contact.ReadOnly = false;
                txt_Speciality.ReadOnly = false;
                txt_Rates.ReadOnly = false;
                txt_ACNumber.ReadOnly = false;
                btn_FromReset.Enabled = true;

                btn_update.Enabled = false;

                txt_DoctorsName.Text = "";
                txt_NIC.Text = "";
                txt_Contact.Text = "";
                txt_Speciality.Text = "";
                txt_Rates.Text = "";
                txt_ACNumber.Text = "";
            }

            else if(btn_New.Text=="Save")
            {

                try
                {

                    doctorsName=txt_DoctorsName.Text;
                    NIC=txt_NIC.Text;
                    contactNumber=txt_Contact.Text;
                    speciality=txt_Speciality.Text;
                    rates=decimal.Parse(txt_Rates.Text);
                    acNumber=txt_ACNumber.Text;

                    Doctors.AddNewDoctor(doctorsName, NIC, contactNumber, speciality, rates, acNumber, 1);

                    MessageBox.Show("Data Saved Successfully");
                    ResetControls();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Unable to Save Data");
                }
            }
        }

        private void FrmDoctorsRegistration_Load(object sender, EventArgs e)
        {
            ResetControls();
            
        }

        private void ResetControls()
        {
            txt_DoctorsName.ReadOnly = true;
            txt_NIC.ReadOnly = true;
            txt_Contact.ReadOnly = true;
            txt_Speciality.ReadOnly = true;
            txt_Rates.ReadOnly = true;
            txt_ACNumber.ReadOnly = true;


            cmb_Day.Enabled = false;
            cmb_TimeIn.Enabled = false;
            cmb_TimeOut.Enabled = false;
            btn_FromReset.Enabled = false;
            btn_New.Enabled = true;
            btn_update.Enabled = true;
            btn_update.Text = "Update";
            btn_New.Text = "New";

            grd_DoctorsDetails.DataSource = Doctors.GetDoctorsDetails();            

            PopulateTextBoxes();
        }

        private void PopulateTextBoxes()
        {
            int rowIndex = grd_DoctorsDetails.CurrentCell.RowIndex;
            doctorID = int.Parse(grd_DoctorsDetails.Rows[rowIndex].Cells[0].Value.ToString());
            doctorsName = grd_DoctorsDetails.Rows[rowIndex].Cells[1].Value.ToString();
            NIC = grd_DoctorsDetails.Rows[rowIndex].Cells[2].Value.ToString();
            contactNumber = grd_DoctorsDetails.Rows[rowIndex].Cells[3].Value.ToString();
            speciality = grd_DoctorsDetails.Rows[rowIndex].Cells[4].Value.ToString();
            rates = decimal.Parse(grd_DoctorsDetails.Rows[rowIndex].Cells[5].Value.ToString());
            acNumber = grd_DoctorsDetails.Rows[rowIndex].Cells[6].Value.ToString();
            active = int.Parse(grd_DoctorsDetails.Rows[rowIndex].Cells[7].Value.ToString());

            txt_DoctorsName.Text = doctorsName;
            txt_NIC.Text = NIC;
            txt_Contact.Text = contactNumber;
            txt_Speciality.Text = speciality;
            txt_Rates.Text = rates.ToString();
            txt_ACNumber.Text = acNumber;

            grd_availablity.DataSource = Doctors.GetAvailabilityDetails(doctorID);
        }

        private void grd_DoctorsDetails_SelectionChanged(object sender, EventArgs e)
        {
            PopulateTextBoxes();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (btn_update.Text == "Update")
            {
                btn_update.Text = "Commit";
                btn_FromReset.Enabled = true;

                txt_DoctorsName.ReadOnly = false;
                txt_NIC.ReadOnly = false;
                txt_Contact.ReadOnly = false;
                txt_Speciality.ReadOnly = false;
                txt_Rates.ReadOnly = false;
                txt_ACNumber.ReadOnly = false;

            }

            else if (btn_update.Text == "Commit")
            {
                
                int rowIndex = grd_DoctorsDetails.CurrentCell.RowIndex;
                doctorID = int.Parse(grd_DoctorsDetails.Rows[rowIndex].Cells[0].Value.ToString());
                doctorsName = txt_DoctorsName.Text;
                NIC = txt_NIC.Text;
                contactNumber = txt_Contact.Text;
                speciality = txt_Speciality.Text;
                rates = decimal.Parse(txt_Rates.Text);
                acNumber = txt_ACNumber.Text;

                try
                {
                    Doctors.UpdateDoctorsDetails(doctorID, doctorsName, NIC,contactNumber, speciality, rates, acNumber,1);

                    MessageBox.Show("Data Saved Successfully");
                    ResetControls();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Failed");
                    ResetControls();
                }
            }
        }

        private void btn_FromReset_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void btn_deactivate_Click(object sender, EventArgs e)
        {
            if (btn_deactivate.Text == "Deactivate") 
            {
                MessageBox.Show(string.Format("You are going to Deactivate Dr {0} Are you sure??", txt_DoctorsName.Text));
                btn_deactivate.Text = "Confirm";               
            }

            else if (btn_deactivate.Text == "Confirm") 
            {
                int rowIndex = grd_DoctorsDetails.CurrentCell.RowIndex;
                doctorID = int.Parse(grd_DoctorsDetails.Rows[rowIndex].Cells[0].Value.ToString());
                doctorsName = txt_DoctorsName.Text;
                NIC = txt_NIC.Text;
                contactNumber = txt_Contact.Text;
                speciality = txt_Speciality.Text;
                rates = decimal.Parse(txt_Rates.Text);
                acNumber = txt_ACNumber.Text;

                try
                {
                    Doctors.UpdateDoctorsDetails(doctorID, doctorsName, NIC, contactNumber, speciality, rates, acNumber, 0);

                    MessageBox.Show(string.Format("Dr {0} Deactivated", txt_DoctorsName.Text));
                    ResetControls();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Deactivation Failed");
                    ResetControls();
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchParam = txt_Search.Text;
            grd_DoctorsDetails.DataSource = Doctors.SearchDoctors(searchParam);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetControls();
        }


    }
}
