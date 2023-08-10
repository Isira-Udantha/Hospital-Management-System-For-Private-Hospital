namespace HostpitalManagement
{
    partial class FrmDoctorsRegistration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_DateAdd = new System.Windows.Forms.Button();
            this.grd_availablity = new System.Windows.Forms.DataGridView();
            this.cmb_TimeOut = new System.Windows.Forms.ComboBox();
            this.cmb_TimeIn = new System.Windows.Forms.ComboBox();
            this.cmb_Day = new System.Windows.Forms.ComboBox();
            this.lbl_TimeOut = new System.Windows.Forms.Label();
            this.lbl_timeIn = new System.Windows.Forms.Label();
            this.lbl_day = new System.Windows.Forms.Label();
            this.txt_ACNumber = new System.Windows.Forms.TextBox();
            this.btn_FromReset = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_Rates = new System.Windows.Forms.TextBox();
            this.txt_Speciality = new System.Windows.Forms.TextBox();
            this.txt_Contact = new System.Windows.Forms.TextBox();
            this.txt_NIC = new System.Windows.Forms.TextBox();
            this.txt_DoctorsName = new System.Windows.Forms.TextBox();
            this.lbl_Speciality = new System.Windows.Forms.Label();
            this.lbl_NIC = new System.Windows.Forms.Label();
            this.lbl_Rates = new System.Windows.Forms.Label();
            this.lbl_ContactNumber = new System.Windows.Forms.Label();
            this.lbl_ACNumber = new System.Windows.Forms.Label();
            this.lbl_DoctorsName = new System.Windows.Forms.Label();
            this.lbl_DoctorsRegistration = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grd_DoctorsDetails = new System.Windows.Forms.DataGridView();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_SearchNIC = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_deactivate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_availablity)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_DoctorsDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_deactivate);
            this.panel1.Controls.Add(this.btn_Remove);
            this.panel1.Controls.Add(this.btn_DateAdd);
            this.panel1.Controls.Add(this.grd_availablity);
            this.panel1.Controls.Add(this.cmb_TimeOut);
            this.panel1.Controls.Add(this.cmb_TimeIn);
            this.panel1.Controls.Add(this.cmb_Day);
            this.panel1.Controls.Add(this.lbl_TimeOut);
            this.panel1.Controls.Add(this.lbl_timeIn);
            this.panel1.Controls.Add(this.lbl_day);
            this.panel1.Controls.Add(this.txt_ACNumber);
            this.panel1.Controls.Add(this.btn_FromReset);
            this.panel1.Controls.Add(this.btn_New);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.txt_Rates);
            this.panel1.Controls.Add(this.txt_Speciality);
            this.panel1.Controls.Add(this.txt_Contact);
            this.panel1.Controls.Add(this.txt_NIC);
            this.panel1.Controls.Add(this.txt_DoctorsName);
            this.panel1.Controls.Add(this.lbl_Speciality);
            this.panel1.Controls.Add(this.lbl_NIC);
            this.panel1.Controls.Add(this.lbl_Rates);
            this.panel1.Controls.Add(this.lbl_ContactNumber);
            this.panel1.Controls.Add(this.lbl_ACNumber);
            this.panel1.Controls.Add(this.lbl_DoctorsName);
            this.panel1.Location = new System.Drawing.Point(3, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 270);
            this.panel1.TabIndex = 24;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(640, 17);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(38, 23);
            this.btn_Remove.TabIndex = 55;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            // 
            // btn_DateAdd
            // 
            this.btn_DateAdd.Location = new System.Drawing.Point(596, 17);
            this.btn_DateAdd.Name = "btn_DateAdd";
            this.btn_DateAdd.Size = new System.Drawing.Size(38, 23);
            this.btn_DateAdd.TabIndex = 54;
            this.btn_DateAdd.Text = "Add";
            this.btn_DateAdd.UseVisualStyleBackColor = true;
            // 
            // grd_availablity
            // 
            this.grd_availablity.AllowUserToAddRows = false;
            this.grd_availablity.AllowUserToDeleteRows = false;
            this.grd_availablity.BackgroundColor = System.Drawing.Color.Honeydew;
            this.grd_availablity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_availablity.GridColor = System.Drawing.Color.Honeydew;
            this.grd_availablity.Location = new System.Drawing.Point(350, 46);
            this.grd_availablity.MultiSelect = false;
            this.grd_availablity.Name = "grd_availablity";
            this.grd_availablity.ReadOnly = true;
            this.grd_availablity.Size = new System.Drawing.Size(358, 209);
            this.grd_availablity.TabIndex = 53;
            // 
            // cmb_TimeOut
            // 
            this.cmb_TimeOut.FormattingEnabled = true;
            this.cmb_TimeOut.Location = new System.Drawing.Point(514, 18);
            this.cmb_TimeOut.Name = "cmb_TimeOut";
            this.cmb_TimeOut.Size = new System.Drawing.Size(76, 21);
            this.cmb_TimeOut.TabIndex = 52;
            // 
            // cmb_TimeIn
            // 
            this.cmb_TimeIn.FormattingEnabled = true;
            this.cmb_TimeIn.Location = new System.Drawing.Point(431, 18);
            this.cmb_TimeIn.Name = "cmb_TimeIn";
            this.cmb_TimeIn.Size = new System.Drawing.Size(76, 21);
            this.cmb_TimeIn.TabIndex = 51;
            // 
            // cmb_Day
            // 
            this.cmb_Day.FormattingEnabled = true;
            this.cmb_Day.Location = new System.Drawing.Point(350, 18);
            this.cmb_Day.Name = "cmb_Day";
            this.cmb_Day.Size = new System.Drawing.Size(76, 21);
            this.cmb_Day.TabIndex = 50;
            // 
            // lbl_TimeOut
            // 
            this.lbl_TimeOut.AutoSize = true;
            this.lbl_TimeOut.Location = new System.Drawing.Point(510, 0);
            this.lbl_TimeOut.Name = "lbl_TimeOut";
            this.lbl_TimeOut.Size = new System.Drawing.Size(50, 13);
            this.lbl_TimeOut.TabIndex = 49;
            this.lbl_TimeOut.Text = "Time Out";
            // 
            // lbl_timeIn
            // 
            this.lbl_timeIn.AutoSize = true;
            this.lbl_timeIn.Location = new System.Drawing.Point(428, 0);
            this.lbl_timeIn.Name = "lbl_timeIn";
            this.lbl_timeIn.Size = new System.Drawing.Size(42, 13);
            this.lbl_timeIn.TabIndex = 48;
            this.lbl_timeIn.Text = "Time In";
            // 
            // lbl_day
            // 
            this.lbl_day.AutoSize = true;
            this.lbl_day.Location = new System.Drawing.Point(366, 0);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(26, 13);
            this.lbl_day.TabIndex = 47;
            this.lbl_day.Text = "Day";
            // 
            // txt_ACNumber
            // 
            this.txt_ACNumber.Location = new System.Drawing.Point(116, 192);
            this.txt_ACNumber.Name = "txt_ACNumber";
            this.txt_ACNumber.Size = new System.Drawing.Size(218, 20);
            this.txt_ACNumber.TabIndex = 46;
            // 
            // btn_FromReset
            // 
            this.btn_FromReset.Location = new System.Drawing.Point(171, 229);
            this.btn_FromReset.Name = "btn_FromReset";
            this.btn_FromReset.Size = new System.Drawing.Size(68, 26);
            this.btn_FromReset.TabIndex = 45;
            this.btn_FromReset.Text = "Reset";
            this.btn_FromReset.UseVisualStyleBackColor = true;
            this.btn_FromReset.Click += new System.EventHandler(this.btn_FromReset_Click);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(13, 228);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(72, 27);
            this.btn_New.TabIndex = 44;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(91, 228);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(74, 27);
            this.btn_update.TabIndex = 43;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_Rates
            // 
            this.txt_Rates.Location = new System.Drawing.Point(116, 158);
            this.txt_Rates.Name = "txt_Rates";
            this.txt_Rates.Size = new System.Drawing.Size(218, 20);
            this.txt_Rates.TabIndex = 38;
            // 
            // txt_Speciality
            // 
            this.txt_Speciality.Location = new System.Drawing.Point(116, 110);
            this.txt_Speciality.Multiline = true;
            this.txt_Speciality.Name = "txt_Speciality";
            this.txt_Speciality.Size = new System.Drawing.Size(218, 42);
            this.txt_Speciality.TabIndex = 37;
            // 
            // txt_Contact
            // 
            this.txt_Contact.Location = new System.Drawing.Point(116, 76);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(218, 20);
            this.txt_Contact.TabIndex = 36;
            // 
            // txt_NIC
            // 
            this.txt_NIC.Location = new System.Drawing.Point(116, 50);
            this.txt_NIC.Name = "txt_NIC";
            this.txt_NIC.Size = new System.Drawing.Size(218, 20);
            this.txt_NIC.TabIndex = 35;
            // 
            // txt_DoctorsName
            // 
            this.txt_DoctorsName.Location = new System.Drawing.Point(116, 19);
            this.txt_DoctorsName.Name = "txt_DoctorsName";
            this.txt_DoctorsName.Size = new System.Drawing.Size(218, 20);
            this.txt_DoctorsName.TabIndex = 33;
            // 
            // lbl_Speciality
            // 
            this.lbl_Speciality.AutoSize = true;
            this.lbl_Speciality.Location = new System.Drawing.Point(10, 113);
            this.lbl_Speciality.Name = "lbl_Speciality";
            this.lbl_Speciality.Size = new System.Drawing.Size(52, 13);
            this.lbl_Speciality.TabIndex = 31;
            this.lbl_Speciality.Text = "Speciality";
            // 
            // lbl_NIC
            // 
            this.lbl_NIC.AutoSize = true;
            this.lbl_NIC.Location = new System.Drawing.Point(10, 53);
            this.lbl_NIC.Name = "lbl_NIC";
            this.lbl_NIC.Size = new System.Drawing.Size(25, 13);
            this.lbl_NIC.TabIndex = 29;
            this.lbl_NIC.Text = "NIC";
            // 
            // lbl_Rates
            // 
            this.lbl_Rates.AutoSize = true;
            this.lbl_Rates.Location = new System.Drawing.Point(10, 161);
            this.lbl_Rates.Name = "lbl_Rates";
            this.lbl_Rates.Size = new System.Drawing.Size(35, 13);
            this.lbl_Rates.TabIndex = 28;
            this.lbl_Rates.Text = "Rates";
            // 
            // lbl_ContactNumber
            // 
            this.lbl_ContactNumber.AutoSize = true;
            this.lbl_ContactNumber.Location = new System.Drawing.Point(10, 78);
            this.lbl_ContactNumber.Name = "lbl_ContactNumber";
            this.lbl_ContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lbl_ContactNumber.TabIndex = 27;
            this.lbl_ContactNumber.Text = "Contact Number";
            // 
            // lbl_ACNumber
            // 
            this.lbl_ACNumber.AutoSize = true;
            this.lbl_ACNumber.Location = new System.Drawing.Point(10, 192);
            this.lbl_ACNumber.Name = "lbl_ACNumber";
            this.lbl_ACNumber.Size = new System.Drawing.Size(61, 13);
            this.lbl_ACNumber.TabIndex = 25;
            this.lbl_ACNumber.Text = "AC Number";
            // 
            // lbl_DoctorsName
            // 
            this.lbl_DoctorsName.AutoSize = true;
            this.lbl_DoctorsName.Location = new System.Drawing.Point(10, 26);
            this.lbl_DoctorsName.Name = "lbl_DoctorsName";
            this.lbl_DoctorsName.Size = new System.Drawing.Size(75, 13);
            this.lbl_DoctorsName.TabIndex = 23;
            this.lbl_DoctorsName.Text = "Doctors Name";
            // 
            // lbl_DoctorsRegistration
            // 
            this.lbl_DoctorsRegistration.AutoSize = true;
            this.lbl_DoctorsRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoctorsRegistration.Location = new System.Drawing.Point(232, 9);
            this.lbl_DoctorsRegistration.Name = "lbl_DoctorsRegistration";
            this.lbl_DoctorsRegistration.Size = new System.Drawing.Size(197, 24);
            this.lbl_DoctorsRegistration.TabIndex = 25;
            this.lbl_DoctorsRegistration.Text = "Doctors Registration";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grd_DoctorsDetails);
            this.panel2.Controls.Add(this.btn_Reset);
            this.panel2.Controls.Add(this.lbl_SearchNIC);
            this.panel2.Controls.Add(this.txt_Search);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Location = new System.Drawing.Point(3, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 285);
            this.panel2.TabIndex = 26;
            // 
            // grd_DoctorsDetails
            // 
            this.grd_DoctorsDetails.AllowUserToAddRows = false;
            this.grd_DoctorsDetails.AllowUserToDeleteRows = false;
            this.grd_DoctorsDetails.BackgroundColor = System.Drawing.Color.Honeydew;
            this.grd_DoctorsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_DoctorsDetails.Location = new System.Drawing.Point(3, 39);
            this.grd_DoctorsDetails.MultiSelect = false;
            this.grd_DoctorsDetails.Name = "grd_DoctorsDetails";
            this.grd_DoctorsDetails.ReadOnly = true;
            this.grd_DoctorsDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_DoctorsDetails.Size = new System.Drawing.Size(704, 243);
            this.grd_DoctorsDetails.TabIndex = 40;
            this.grd_DoctorsDetails.SelectionChanged += new System.EventHandler(this.grd_DoctorsDetails_SelectionChanged);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(527, 10);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 39;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
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
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(446, 10);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_deactivate
            // 
            this.btn_deactivate.Location = new System.Drawing.Point(246, 231);
            this.btn_deactivate.Name = "btn_deactivate";
            this.btn_deactivate.Size = new System.Drawing.Size(68, 23);
            this.btn_deactivate.TabIndex = 56;
            this.btn_deactivate.Text = "Deactivate";
            this.btn_deactivate.UseVisualStyleBackColor = true;
            this.btn_deactivate.Click += new System.EventHandler(this.btn_deactivate_Click);
            // 
            // FrmDoctorsRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_DoctorsRegistration);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(730, 638);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(730, 638);
            this.Name = "FrmDoctorsRegistration";
            this.Text = "Doctors Registration";
            this.Load += new System.EventHandler(this.FrmDoctorsRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_availablity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_DoctorsDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_FromReset;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_Rates;
        private System.Windows.Forms.TextBox txt_Speciality;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.TextBox txt_NIC;
        private System.Windows.Forms.TextBox txt_DoctorsName;
        private System.Windows.Forms.Label lbl_Speciality;
        private System.Windows.Forms.Label lbl_NIC;
        private System.Windows.Forms.Label lbl_Rates;
        private System.Windows.Forms.Label lbl_ContactNumber;
        private System.Windows.Forms.Label lbl_ACNumber;
        private System.Windows.Forms.Label lbl_DoctorsName;
        private System.Windows.Forms.Label lbl_DoctorsRegistration;
        private System.Windows.Forms.TextBox txt_ACNumber;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_DateAdd;
        private System.Windows.Forms.DataGridView grd_availablity;
        private System.Windows.Forms.ComboBox cmb_TimeOut;
        private System.Windows.Forms.ComboBox cmb_TimeIn;
        private System.Windows.Forms.ComboBox cmb_Day;
        private System.Windows.Forms.Label lbl_TimeOut;
        private System.Windows.Forms.Label lbl_timeIn;
        private System.Windows.Forms.Label lbl_day;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grd_DoctorsDetails;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_SearchNIC;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_deactivate;
    }
}