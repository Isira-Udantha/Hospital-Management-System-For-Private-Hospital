namespace HostpitalManagement
{
    partial class frm_PatientRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pnl_PatientTop = new System.Windows.Forms.Panel();
            this.Cmb_BloodGroup = new System.Windows.Forms.ComboBox();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txt_General = new System.Windows.Forms.TextBox();
            this.txt_Allergy = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_DOB = new System.Windows.Forms.TextBox();
            this.txt_EmergencyContatct = new System.Windows.Forms.TextBox();
            this.txt_Contact = new System.Windows.Forms.TextBox();
            this.txt_NIC = new System.Windows.Forms.TextBox();
            this.txt_Guardian = new System.Windows.Forms.TextBox();
            this.txt_PatientName = new System.Windows.Forms.TextBox();
            this.lbl_Allergy = new System.Windows.Forms.Label();
            this.lbl_EmergencyContact = new System.Windows.Forms.Label();
            this.lbl_Guardian = new System.Windows.Forms.Label();
            this.lbl_NIC = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_ContactNumber = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_BloodGroup = new System.Windows.Forms.Label();
            this.lbl_general = new System.Windows.Forms.Label();
            this.lbl_PatientName = new System.Windows.Forms.Label();
            this.lbl_patientRegistration = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grd_patientDetails = new System.Windows.Forms.DataGridView();
            this.btn_SearchReset = new System.Windows.Forms.Button();
            this.lbl_SearchNIC = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_formReset = new System.Windows.Forms.Button();
            this.Pnl_PatientTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_patientDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_PatientTop
            // 
            this.Pnl_PatientTop.Controls.Add(this.btn_formReset);
            this.Pnl_PatientTop.Controls.Add(this.Cmb_BloodGroup);
            this.Pnl_PatientTop.Controls.Add(this.btn_New);
            this.Pnl_PatientTop.Controls.Add(this.btn_Update);
            this.Pnl_PatientTop.Controls.Add(this.txt_General);
            this.Pnl_PatientTop.Controls.Add(this.txt_Allergy);
            this.Pnl_PatientTop.Controls.Add(this.txt_Address);
            this.Pnl_PatientTop.Controls.Add(this.txt_DOB);
            this.Pnl_PatientTop.Controls.Add(this.txt_EmergencyContatct);
            this.Pnl_PatientTop.Controls.Add(this.txt_Contact);
            this.Pnl_PatientTop.Controls.Add(this.txt_NIC);
            this.Pnl_PatientTop.Controls.Add(this.txt_Guardian);
            this.Pnl_PatientTop.Controls.Add(this.txt_PatientName);
            this.Pnl_PatientTop.Controls.Add(this.lbl_Allergy);
            this.Pnl_PatientTop.Controls.Add(this.lbl_EmergencyContact);
            this.Pnl_PatientTop.Controls.Add(this.lbl_Guardian);
            this.Pnl_PatientTop.Controls.Add(this.lbl_NIC);
            this.Pnl_PatientTop.Controls.Add(this.lbl_DOB);
            this.Pnl_PatientTop.Controls.Add(this.lbl_ContactNumber);
            this.Pnl_PatientTop.Controls.Add(this.lbl_address);
            this.Pnl_PatientTop.Controls.Add(this.lbl_BloodGroup);
            this.Pnl_PatientTop.Controls.Add(this.lbl_general);
            this.Pnl_PatientTop.Controls.Add(this.lbl_PatientName);
            this.Pnl_PatientTop.Location = new System.Drawing.Point(-1, 24);
            this.Pnl_PatientTop.Name = "Pnl_PatientTop";
            this.Pnl_PatientTop.Size = new System.Drawing.Size(711, 270);
            this.Pnl_PatientTop.TabIndex = 23;
            // 
            // Cmb_BloodGroup
            // 
            this.Cmb_BloodGroup.FormattingEnabled = true;
            this.Cmb_BloodGroup.Location = new System.Drawing.Point(116, 189);
            this.Cmb_BloodGroup.Name = "Cmb_BloodGroup";
            this.Cmb_BloodGroup.Size = new System.Drawing.Size(218, 21);
            this.Cmb_BloodGroup.TabIndex = 46;
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(343, 218);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(97, 47);
            this.btn_New.TabIndex = 44;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(467, 218);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(97, 47);
            this.btn_Update.TabIndex = 43;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_General
            // 
            this.txt_General.Location = new System.Drawing.Point(343, 132);
            this.txt_General.Multiline = true;
            this.txt_General.Name = "txt_General";
            this.txt_General.Size = new System.Drawing.Size(347, 73);
            this.txt_General.TabIndex = 42;
            // 
            // txt_Allergy
            // 
            this.txt_Allergy.Location = new System.Drawing.Point(343, 45);
            this.txt_Allergy.Multiline = true;
            this.txt_Allergy.Name = "txt_Allergy";
            this.txt_Allergy.Size = new System.Drawing.Size(347, 65);
            this.txt_Allergy.TabIndex = 41;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(116, 218);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(218, 47);
            this.txt_Address.TabIndex = 40;
            // 
            // txt_DOB
            // 
            this.txt_DOB.Location = new System.Drawing.Point(116, 158);
            this.txt_DOB.Name = "txt_DOB";
            this.txt_DOB.Size = new System.Drawing.Size(218, 20);
            this.txt_DOB.TabIndex = 38;
            // 
            // txt_EmergencyContatct
            // 
            this.txt_EmergencyContatct.Location = new System.Drawing.Point(116, 129);
            this.txt_EmergencyContatct.Name = "txt_EmergencyContatct";
            this.txt_EmergencyContatct.Size = new System.Drawing.Size(218, 20);
            this.txt_EmergencyContatct.TabIndex = 37;
            // 
            // txt_Contact
            // 
            this.txt_Contact.Location = new System.Drawing.Point(116, 100);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(218, 20);
            this.txt_Contact.TabIndex = 36;
            // 
            // txt_NIC
            // 
            this.txt_NIC.Location = new System.Drawing.Point(116, 71);
            this.txt_NIC.Name = "txt_NIC";
            this.txt_NIC.Size = new System.Drawing.Size(218, 20);
            this.txt_NIC.TabIndex = 35;
            // 
            // txt_Guardian
            // 
            this.txt_Guardian.Location = new System.Drawing.Point(116, 45);
            this.txt_Guardian.Name = "txt_Guardian";
            this.txt_Guardian.Size = new System.Drawing.Size(218, 20);
            this.txt_Guardian.TabIndex = 34;
            // 
            // txt_PatientName
            // 
            this.txt_PatientName.Location = new System.Drawing.Point(116, 19);
            this.txt_PatientName.Name = "txt_PatientName";
            this.txt_PatientName.Size = new System.Drawing.Size(218, 20);
            this.txt_PatientName.TabIndex = 33;
            // 
            // lbl_Allergy
            // 
            this.lbl_Allergy.AutoSize = true;
            this.lbl_Allergy.Location = new System.Drawing.Point(340, 22);
            this.lbl_Allergy.Name = "lbl_Allergy";
            this.lbl_Allergy.Size = new System.Drawing.Size(94, 13);
            this.lbl_Allergy.TabIndex = 32;
            this.lbl_Allergy.Text = "Allergy Description";
            // 
            // lbl_EmergencyContact
            // 
            this.lbl_EmergencyContact.AutoSize = true;
            this.lbl_EmergencyContact.Location = new System.Drawing.Point(10, 132);
            this.lbl_EmergencyContact.Name = "lbl_EmergencyContact";
            this.lbl_EmergencyContact.Size = new System.Drawing.Size(100, 13);
            this.lbl_EmergencyContact.TabIndex = 31;
            this.lbl_EmergencyContact.Text = "Emergency Contact";
            // 
            // lbl_Guardian
            // 
            this.lbl_Guardian.AutoSize = true;
            this.lbl_Guardian.Location = new System.Drawing.Point(10, 54);
            this.lbl_Guardian.Name = "lbl_Guardian";
            this.lbl_Guardian.Size = new System.Drawing.Size(81, 13);
            this.lbl_Guardian.TabIndex = 30;
            this.lbl_Guardian.Text = "Guardian Name";
            // 
            // lbl_NIC
            // 
            this.lbl_NIC.AutoSize = true;
            this.lbl_NIC.Location = new System.Drawing.Point(10, 76);
            this.lbl_NIC.Name = "lbl_NIC";
            this.lbl_NIC.Size = new System.Drawing.Size(25, 13);
            this.lbl_NIC.TabIndex = 29;
            this.lbl_NIC.Text = "NIC";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Location = new System.Drawing.Point(10, 161);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(66, 13);
            this.lbl_DOB.TabIndex = 28;
            this.lbl_DOB.Text = "Date of Birth";
            // 
            // lbl_ContactNumber
            // 
            this.lbl_ContactNumber.AutoSize = true;
            this.lbl_ContactNumber.Location = new System.Drawing.Point(10, 103);
            this.lbl_ContactNumber.Name = "lbl_ContactNumber";
            this.lbl_ContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lbl_ContactNumber.TabIndex = 27;
            this.lbl_ContactNumber.Text = "Contact Number";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(10, 218);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(48, 13);
            this.lbl_address.TabIndex = 26;
            this.lbl_address.Text = "Address ";
            // 
            // lbl_BloodGroup
            // 
            this.lbl_BloodGroup.AutoSize = true;
            this.lbl_BloodGroup.Location = new System.Drawing.Point(10, 192);
            this.lbl_BloodGroup.Name = "lbl_BloodGroup";
            this.lbl_BloodGroup.Size = new System.Drawing.Size(66, 13);
            this.lbl_BloodGroup.TabIndex = 25;
            this.lbl_BloodGroup.Text = "Blood Group";
            // 
            // lbl_general
            // 
            this.lbl_general.AutoSize = true;
            this.lbl_general.Location = new System.Drawing.Point(340, 113);
            this.lbl_general.Name = "lbl_general";
            this.lbl_general.Size = new System.Drawing.Size(100, 13);
            this.lbl_general.TabIndex = 24;
            this.lbl_general.Text = "General Description";
            // 
            // lbl_PatientName
            // 
            this.lbl_PatientName.AutoSize = true;
            this.lbl_PatientName.Location = new System.Drawing.Point(10, 26);
            this.lbl_PatientName.Name = "lbl_PatientName";
            this.lbl_PatientName.Size = new System.Drawing.Size(71, 13);
            this.lbl_PatientName.TabIndex = 23;
            this.lbl_PatientName.Text = "Patient Name";
            // 
            // lbl_patientRegistration
            // 
            this.lbl_patientRegistration.AutoSize = true;
            this.lbl_patientRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patientRegistration.Location = new System.Drawing.Point(262, -3);
            this.lbl_patientRegistration.Name = "lbl_patientRegistration";
            this.lbl_patientRegistration.Size = new System.Drawing.Size(189, 24);
            this.lbl_patientRegistration.TabIndex = 24;
            this.lbl_patientRegistration.Text = "Patient Registration";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grd_patientDetails);
            this.panel2.Controls.Add(this.btn_SearchReset);
            this.panel2.Controls.Add(this.lbl_SearchNIC);
            this.panel2.Controls.Add(this.txt_Search);
            this.panel2.Controls.Add(this.btn_Search);
            this.panel2.Location = new System.Drawing.Point(3, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 298);
            this.panel2.TabIndex = 25;
            // 
            // grd_patientDetails
            // 
            this.grd_patientDetails.AllowUserToAddRows = false;
            this.grd_patientDetails.AllowUserToDeleteRows = false;
            this.grd_patientDetails.BackgroundColor = System.Drawing.Color.Honeydew;
            this.grd_patientDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_patientDetails.Location = new System.Drawing.Point(3, 39);
            this.grd_patientDetails.MultiSelect = false;
            this.grd_patientDetails.Name = "grd_patientDetails";
            this.grd_patientDetails.ReadOnly = true;
            this.grd_patientDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_patientDetails.Size = new System.Drawing.Size(704, 256);
            this.grd_patientDetails.TabIndex = 40;
            this.grd_patientDetails.SelectionChanged += new System.EventHandler(this.grd_patientDetails_SelectionChanged);
            // 
            // btn_SearchReset
            // 
            this.btn_SearchReset.Location = new System.Drawing.Point(527, 10);
            this.btn_SearchReset.Name = "btn_SearchReset";
            this.btn_SearchReset.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchReset.TabIndex = 39;
            this.btn_SearchReset.Text = "Reset";
            this.btn_SearchReset.UseVisualStyleBackColor = true;
            this.btn_SearchReset.Click += new System.EventHandler(this.btn_SearchReset_Click);
            // 
            // lbl_SearchNIC
            // 
            this.lbl_SearchNIC.AutoSize = true;
            this.lbl_SearchNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchNIC.Location = new System.Drawing.Point(9, 13);
            this.lbl_SearchNIC.Name = "lbl_SearchNIC";
            this.lbl_SearchNIC.Size = new System.Drawing.Size(79, 15);
            this.lbl_SearchNIC.TabIndex = 38;
            this.lbl_SearchNIC.Text = "Search NIC";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(94, 12);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(346, 20);
            this.txt_Search.TabIndex = 37;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(446, 10);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_formReset
            // 
            this.btn_formReset.Enabled = false;
            this.btn_formReset.Location = new System.Drawing.Point(593, 218);
            this.btn_formReset.Name = "btn_formReset";
            this.btn_formReset.Size = new System.Drawing.Size(97, 47);
            this.btn_formReset.TabIndex = 47;
            this.btn_formReset.Text = "Form Reset";
            this.btn_formReset.UseVisualStyleBackColor = true;
            this.btn_formReset.Click += new System.EventHandler(this.btn_formReset_Click);
            // 
            // frm_PatientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_patientRegistration);
            this.Controls.Add(this.Pnl_PatientTop);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(730, 638);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(730, 638);
            this.Name = "frm_PatientRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Registration";
            this.Load += new System.EventHandler(this.frm_PatientRegistration_Load);
            this.Pnl_PatientTop.ResumeLayout(false);
            this.Pnl_PatientTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_patientDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_PatientTop;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txt_General;
        private System.Windows.Forms.TextBox txt_Allergy;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_DOB;
        private System.Windows.Forms.TextBox txt_EmergencyContatct;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.TextBox txt_NIC;
        private System.Windows.Forms.TextBox txt_Guardian;
        private System.Windows.Forms.TextBox txt_PatientName;
        private System.Windows.Forms.Label lbl_Allergy;
        private System.Windows.Forms.Label lbl_EmergencyContact;
        private System.Windows.Forms.Label lbl_Guardian;
        private System.Windows.Forms.Label lbl_NIC;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_ContactNumber;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_BloodGroup;
        private System.Windows.Forms.Label lbl_general;
        private System.Windows.Forms.Label lbl_PatientName;
        private System.Windows.Forms.Label lbl_patientRegistration;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grd_patientDetails;
        private System.Windows.Forms.Button btn_SearchReset;
        private System.Windows.Forms.Label lbl_SearchNIC;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox Cmb_BloodGroup;
        private System.Windows.Forms.Button btn_formReset;

    }
}