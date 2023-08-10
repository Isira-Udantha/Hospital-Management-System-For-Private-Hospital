namespace Hospital_Management_System
{
    partial class frm_DoctorsRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_doctorTop = new System.Windows.Forms.Panel();
            this.Grd_DocAvailability = new System.Windows.Forms.DataGridView();
            this.btn_remember = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_TimeOut = new System.Windows.Forms.Label();
            this.lbl_TimeIn = new System.Windows.Forms.Label();
            this.lbl_day = new System.Windows.Forms.Label();
            this.cmb_timeOut = new System.Windows.Forms.ComboBox();
            this.cmb_timeIn = new System.Windows.Forms.ComboBox();
            this.cmb_day = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.txt_docAccount = new System.Windows.Forms.TextBox();
            this.txt_docRates = new System.Windows.Forms.TextBox();
            this.txt_docSpeciality = new System.Windows.Forms.TextBox();
            this.txt_docContact = new System.Windows.Forms.TextBox();
            this.txt_docNIC = new System.Windows.Forms.TextBox();
            this.txt_docName = new System.Windows.Forms.TextBox();
            this.lbl_accountNumber = new System.Windows.Forms.Label();
            this.lbl_rates = new System.Windows.Forms.Label();
            this.lbl_speciality = new System.Windows.Forms.Label();
            this.lbl_contactnumber = new System.Windows.Forms.Label();
            this.lbl_NIC = new System.Windows.Forms.Label();
            this.lbl_doctorName = new System.Windows.Forms.Label();
            this.pnl_doctorBottom = new System.Windows.Forms.Panel();
            this.Grd_Doctors = new System.Windows.Forms.DataGridView();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_docSearch = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.pnl_doctorTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_DocAvailability)).BeginInit();
            this.pnl_doctorBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Doctors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctors Details";
            // 
            // pnl_doctorTop
            // 
            this.pnl_doctorTop.Controls.Add(this.Grd_DocAvailability);
            this.pnl_doctorTop.Controls.Add(this.btn_remember);
            this.pnl_doctorTop.Controls.Add(this.btn_add);
            this.pnl_doctorTop.Controls.Add(this.lbl_TimeOut);
            this.pnl_doctorTop.Controls.Add(this.lbl_TimeIn);
            this.pnl_doctorTop.Controls.Add(this.lbl_day);
            this.pnl_doctorTop.Controls.Add(this.cmb_timeOut);
            this.pnl_doctorTop.Controls.Add(this.cmb_timeIn);
            this.pnl_doctorTop.Controls.Add(this.cmb_day);
            this.pnl_doctorTop.Controls.Add(this.btn_save);
            this.pnl_doctorTop.Controls.Add(this.btn_update);
            this.pnl_doctorTop.Controls.Add(this.btn_addNew);
            this.pnl_doctorTop.Controls.Add(this.txt_docAccount);
            this.pnl_doctorTop.Controls.Add(this.txt_docRates);
            this.pnl_doctorTop.Controls.Add(this.txt_docSpeciality);
            this.pnl_doctorTop.Controls.Add(this.txt_docContact);
            this.pnl_doctorTop.Controls.Add(this.txt_docNIC);
            this.pnl_doctorTop.Controls.Add(this.txt_docName);
            this.pnl_doctorTop.Controls.Add(this.lbl_accountNumber);
            this.pnl_doctorTop.Controls.Add(this.lbl_rates);
            this.pnl_doctorTop.Controls.Add(this.lbl_speciality);
            this.pnl_doctorTop.Controls.Add(this.lbl_contactnumber);
            this.pnl_doctorTop.Controls.Add(this.lbl_NIC);
            this.pnl_doctorTop.Controls.Add(this.lbl_doctorName);
            this.pnl_doctorTop.Location = new System.Drawing.Point(12, 52);
            this.pnl_doctorTop.Name = "pnl_doctorTop";
            this.pnl_doctorTop.Size = new System.Drawing.Size(900, 355);
            this.pnl_doctorTop.TabIndex = 1;
            // 
            // Grd_DocAvailability
            // 
            this.Grd_DocAvailability.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.Grd_DocAvailability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_DocAvailability.Location = new System.Drawing.Point(436, 79);
            this.Grd_DocAvailability.Name = "Grd_DocAvailability";
            this.Grd_DocAvailability.Size = new System.Drawing.Size(460, 272);
            this.Grd_DocAvailability.TabIndex = 25;
            // 
            // btn_remember
            // 
            this.btn_remember.BackColor = System.Drawing.Color.Crimson;
            this.btn_remember.Location = new System.Drawing.Point(859, 48);
            this.btn_remember.Name = "btn_remember";
            this.btn_remember.Size = new System.Drawing.Size(38, 25);
            this.btn_remember.TabIndex = 24;
            this.btn_remember.Text = "Rem";
            this.btn_remember.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Orchid;
            this.btn_add.Location = new System.Drawing.Point(817, 48);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(38, 25);
            this.btn_add.TabIndex = 23;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // lbl_TimeOut
            // 
            this.lbl_TimeOut.AutoSize = true;
            this.lbl_TimeOut.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeOut.Location = new System.Drawing.Point(686, 15);
            this.lbl_TimeOut.Name = "lbl_TimeOut";
            this.lbl_TimeOut.Size = new System.Drawing.Size(77, 19);
            this.lbl_TimeOut.TabIndex = 22;
            this.lbl_TimeOut.Text = "Time Out";
            // 
            // lbl_TimeIn
            // 
            this.lbl_TimeIn.AutoSize = true;
            this.lbl_TimeIn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeIn.Location = new System.Drawing.Point(559, 15);
            this.lbl_TimeIn.Name = "lbl_TimeIn";
            this.lbl_TimeIn.Size = new System.Drawing.Size(66, 19);
            this.lbl_TimeIn.TabIndex = 21;
            this.lbl_TimeIn.Text = "Time In";
            // 
            // lbl_day
            // 
            this.lbl_day.AutoSize = true;
            this.lbl_day.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day.Location = new System.Drawing.Point(432, 15);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(36, 19);
            this.lbl_day.TabIndex = 20;
            this.lbl_day.Text = "Day";
            // 
            // cmb_timeOut
            // 
            this.cmb_timeOut.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_timeOut.FormattingEnabled = true;
            this.cmb_timeOut.Location = new System.Drawing.Point(690, 48);
            this.cmb_timeOut.Name = "cmb_timeOut";
            this.cmb_timeOut.Size = new System.Drawing.Size(121, 25);
            this.cmb_timeOut.TabIndex = 19;
            // 
            // cmb_timeIn
            // 
            this.cmb_timeIn.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_timeIn.FormattingEnabled = true;
            this.cmb_timeIn.Location = new System.Drawing.Point(563, 48);
            this.cmb_timeIn.Name = "cmb_timeIn";
            this.cmb_timeIn.Size = new System.Drawing.Size(121, 25);
            this.cmb_timeIn.TabIndex = 18;
            // 
            // cmb_day
            // 
            this.cmb_day.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_day.FormattingEnabled = true;
            this.cmb_day.Location = new System.Drawing.Point(436, 48);
            this.cmb_day.Name = "cmb_day";
            this.cmb_day.Size = new System.Drawing.Size(121, 25);
            this.cmb_day.TabIndex = 17;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Gold;
            this.btn_save.Location = new System.Drawing.Point(345, 323);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 29);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Gold;
            this.btn_update.Location = new System.Drawing.Point(256, 323);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 29);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_addNew
            // 
            this.btn_addNew.BackColor = System.Drawing.Color.Gold;
            this.btn_addNew.Location = new System.Drawing.Point(169, 323);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.Size = new System.Drawing.Size(75, 29);
            this.btn_addNew.TabIndex = 14;
            this.btn_addNew.Text = "Add New";
            this.btn_addNew.UseVisualStyleBackColor = false;
            // 
            // txt_docAccount
            // 
            this.txt_docAccount.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_docAccount.Location = new System.Drawing.Point(169, 275);
            this.txt_docAccount.Name = "txt_docAccount";
            this.txt_docAccount.Size = new System.Drawing.Size(251, 25);
            this.txt_docAccount.TabIndex = 13;
            // 
            // txt_docRates
            // 
            this.txt_docRates.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_docRates.Location = new System.Drawing.Point(169, 235);
            this.txt_docRates.Name = "txt_docRates";
            this.txt_docRates.Size = new System.Drawing.Size(251, 25);
            this.txt_docRates.TabIndex = 12;
            // 
            // txt_docSpeciality
            // 
            this.txt_docSpeciality.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_docSpeciality.Location = new System.Drawing.Point(169, 158);
            this.txt_docSpeciality.Multiline = true;
            this.txt_docSpeciality.Name = "txt_docSpeciality";
            this.txt_docSpeciality.Size = new System.Drawing.Size(251, 64);
            this.txt_docSpeciality.TabIndex = 11;
            // 
            // txt_docContact
            // 
            this.txt_docContact.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_docContact.Location = new System.Drawing.Point(169, 111);
            this.txt_docContact.Name = "txt_docContact";
            this.txt_docContact.Size = new System.Drawing.Size(251, 25);
            this.txt_docContact.TabIndex = 10;
            // 
            // txt_docNIC
            // 
            this.txt_docNIC.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_docNIC.Location = new System.Drawing.Point(169, 70);
            this.txt_docNIC.Name = "txt_docNIC";
            this.txt_docNIC.Size = new System.Drawing.Size(251, 25);
            this.txt_docNIC.TabIndex = 9;
            // 
            // txt_docName
            // 
            this.txt_docName.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_docName.Location = new System.Drawing.Point(169, 26);
            this.txt_docName.Name = "txt_docName";
            this.txt_docName.Size = new System.Drawing.Size(251, 25);
            this.txt_docName.TabIndex = 8;
            // 
            // lbl_accountNumber
            // 
            this.lbl_accountNumber.AutoSize = true;
            this.lbl_accountNumber.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accountNumber.Location = new System.Drawing.Point(16, 277);
            this.lbl_accountNumber.Name = "lbl_accountNumber";
            this.lbl_accountNumber.Size = new System.Drawing.Size(133, 19);
            this.lbl_accountNumber.TabIndex = 7;
            this.lbl_accountNumber.Text = "Account Number";
            // 
            // lbl_rates
            // 
            this.lbl_rates.AutoSize = true;
            this.lbl_rates.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rates.Location = new System.Drawing.Point(16, 237);
            this.lbl_rates.Name = "lbl_rates";
            this.lbl_rates.Size = new System.Drawing.Size(50, 19);
            this.lbl_rates.TabIndex = 6;
            this.lbl_rates.Text = "Rates";
            // 
            // lbl_speciality
            // 
            this.lbl_speciality.AutoSize = true;
            this.lbl_speciality.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_speciality.Location = new System.Drawing.Point(16, 158);
            this.lbl_speciality.Name = "lbl_speciality";
            this.lbl_speciality.Size = new System.Drawing.Size(81, 19);
            this.lbl_speciality.TabIndex = 5;
            this.lbl_speciality.Text = "Speciality";
            // 
            // lbl_contactnumber
            // 
            this.lbl_contactnumber.AutoSize = true;
            this.lbl_contactnumber.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contactnumber.Location = new System.Drawing.Point(16, 113);
            this.lbl_contactnumber.Name = "lbl_contactnumber";
            this.lbl_contactnumber.Size = new System.Drawing.Size(129, 19);
            this.lbl_contactnumber.TabIndex = 4;
            this.lbl_contactnumber.Text = "Contact Number";
            // 
            // lbl_NIC
            // 
            this.lbl_NIC.AutoSize = true;
            this.lbl_NIC.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NIC.Location = new System.Drawing.Point(16, 72);
            this.lbl_NIC.Name = "lbl_NIC";
            this.lbl_NIC.Size = new System.Drawing.Size(35, 19);
            this.lbl_NIC.TabIndex = 3;
            this.lbl_NIC.Text = "NIC";
            // 
            // lbl_doctorName
            // 
            this.lbl_doctorName.AutoSize = true;
            this.lbl_doctorName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctorName.Location = new System.Drawing.Point(16, 28);
            this.lbl_doctorName.Name = "lbl_doctorName";
            this.lbl_doctorName.Size = new System.Drawing.Size(105, 19);
            this.lbl_doctorName.TabIndex = 2;
            this.lbl_doctorName.Text = "Doctor Name";
            // 
            // pnl_doctorBottom
            // 
            this.pnl_doctorBottom.Controls.Add(this.Grd_Doctors);
            this.pnl_doctorBottom.Controls.Add(this.btn_reset);
            this.pnl_doctorBottom.Controls.Add(this.btn_search);
            this.pnl_doctorBottom.Controls.Add(this.txt_docSearch);
            this.pnl_doctorBottom.Controls.Add(this.lbl_search);
            this.pnl_doctorBottom.Location = new System.Drawing.Point(11, 414);
            this.pnl_doctorBottom.Name = "pnl_doctorBottom";
            this.pnl_doctorBottom.Size = new System.Drawing.Size(898, 273);
            this.pnl_doctorBottom.TabIndex = 2;
            // 
            // Grd_Doctors
            // 
            this.Grd_Doctors.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.Grd_Doctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Doctors.Location = new System.Drawing.Point(3, 41);
            this.Grd_Doctors.Name = "Grd_Doctors";
            this.Grd_Doctors.Size = new System.Drawing.Size(892, 224);
            this.Grd_Doctors.TabIndex = 28;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Red;
            this.btn_reset.Location = new System.Drawing.Point(603, 10);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 25);
            this.btn_reset.TabIndex = 27;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_search.Location = new System.Drawing.Point(522, 10);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 25);
            this.btn_search.TabIndex = 26;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // txt_docSearch
            // 
            this.txt_docSearch.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_docSearch.Location = new System.Drawing.Point(100, 10);
            this.txt_docSearch.Name = "txt_docSearch";
            this.txt_docSearch.Size = new System.Drawing.Size(400, 25);
            this.txt_docSearch.TabIndex = 26;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.Location = new System.Drawing.Point(17, 12);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(59, 19);
            this.lbl_search.TabIndex = 26;
            this.lbl_search.Text = "Search";
            // 
            // frm_DoctorsRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(919, 691);
            this.Controls.Add(this.pnl_doctorBottom);
            this.Controls.Add(this.pnl_doctorTop);
            this.Controls.Add(this.label1);
            this.Name = "frm_DoctorsRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorsRegistration";
            this.pnl_doctorTop.ResumeLayout(false);
            this.pnl_doctorTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_DocAvailability)).EndInit();
            this.pnl_doctorBottom.ResumeLayout(false);
            this.pnl_doctorBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Doctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_doctorTop;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_addNew;
        private System.Windows.Forms.TextBox txt_docAccount;
        private System.Windows.Forms.TextBox txt_docRates;
        private System.Windows.Forms.TextBox txt_docSpeciality;
        private System.Windows.Forms.TextBox txt_docContact;
        private System.Windows.Forms.TextBox txt_docNIC;
        private System.Windows.Forms.TextBox txt_docName;
        private System.Windows.Forms.Label lbl_accountNumber;
        private System.Windows.Forms.Label lbl_rates;
        private System.Windows.Forms.Label lbl_speciality;
        private System.Windows.Forms.Label lbl_contactnumber;
        private System.Windows.Forms.Label lbl_NIC;
        private System.Windows.Forms.Label lbl_doctorName;
        private System.Windows.Forms.Button btn_remember;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_TimeOut;
        private System.Windows.Forms.Label lbl_TimeIn;
        private System.Windows.Forms.Label lbl_day;
        private System.Windows.Forms.ComboBox cmb_timeOut;
        private System.Windows.Forms.ComboBox cmb_timeIn;
        private System.Windows.Forms.ComboBox cmb_day;
        private System.Windows.Forms.DataGridView Grd_DocAvailability;
        private System.Windows.Forms.Panel pnl_doctorBottom;
        private System.Windows.Forms.DataGridView Grd_Doctors;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_docSearch;
        private System.Windows.Forms.Label lbl_search;
    }
}