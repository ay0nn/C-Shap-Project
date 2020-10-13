namespace WindowsFormsApp112.Ui
{
    partial class FormDonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDonor));
            this.paneltop = new System.Windows.Forms.Panel();
            this.pictureBoxclose = new System.Windows.Forms.PictureBox();
            this.lblFormTittle = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.dgvdonor = new System.Windows.Forms.DataGridView();
            this.btndetele = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtaddressdonor = new System.Windows.Forms.TextBox();
            this.lbladdressdonor = new System.Windows.Forms.Label();
            this.txtucontactdonor = new System.Windows.Forms.TextBox();
            this.lblucontact = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.lbllastname = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtdid = new System.Windows.Forms.TextBox();
            this.lbldonorid = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.lblfirstn = new System.Windows.Forms.Label();
            this.btnselim = new System.Windows.Forms.Button();
            this.profilepicturebox = new System.Windows.Forms.PictureBox();
            this.lblProfileimage = new System.Windows.Forms.Label();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.cbbg = new System.Windows.Forms.ComboBox();
            this.lblbg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpld = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdonor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilepicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.Teal;
            this.paneltop.Controls.Add(this.pictureBoxclose);
            this.paneltop.Controls.Add(this.lblFormTittle);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(850, 39);
            this.paneltop.TabIndex = 1;
            // 
            // pictureBoxclose
            // 
            this.pictureBoxclose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxclose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxclose.Image")));
            this.pictureBoxclose.Location = new System.Drawing.Point(812, 5);
            this.pictureBoxclose.Name = "pictureBoxclose";
            this.pictureBoxclose.Size = new System.Drawing.Size(29, 28);
            this.pictureBoxclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxclose.TabIndex = 25;
            this.pictureBoxclose.TabStop = false;
            this.pictureBoxclose.Click += new System.EventHandler(this.pictureBoxclose_Click);
            // 
            // lblFormTittle
            // 
            this.lblFormTittle.AutoSize = true;
            this.lblFormTittle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTittle.ForeColor = System.Drawing.Color.Black;
            this.lblFormTittle.Location = new System.Drawing.Point(341, 6);
            this.lblFormTittle.Name = "lblFormTittle";
            this.lblFormTittle.Size = new System.Drawing.Size(131, 21);
            this.lblFormTittle.TabIndex = 0;
            this.lblFormTittle.Text = "Manage Donors";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(109, 379);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(692, 25);
            this.txtsearch.TabIndex = 48;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(50, 384);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(45, 15);
            this.lblsearch.TabIndex = 47;
            this.lblsearch.Text = "Search";
            // 
            // dgvdonor
            // 
            this.dgvdonor.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvdonor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdonor.Location = new System.Drawing.Point(50, 410);
            this.dgvdonor.Name = "dgvdonor";
            this.dgvdonor.Size = new System.Drawing.Size(752, 149);
            this.dgvdonor.TabIndex = 46;
            this.dgvdonor.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvdonor_RowHeaderMouseClick);
            // 
            // btndetele
            // 
            this.btndetele.BackColor = System.Drawing.Color.Red;
            this.btndetele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndetele.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetele.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btndetele.Location = new System.Drawing.Point(435, 335);
            this.btndetele.Name = "btndetele";
            this.btndetele.Size = new System.Drawing.Size(79, 32);
            this.btndetele.TabIndex = 45;
            this.btndetele.Text = "Delete";
            this.btndetele.UseVisualStyleBackColor = false;
            this.btndetele.Click += new System.EventHandler(this.btndetele_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Goldenrod;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnclear.Location = new System.Drawing.Point(536, 335);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(79, 32);
            this.btnclear.TabIndex = 44;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Teal;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnupdate.Location = new System.Drawing.Point(334, 335);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(79, 32);
            this.btnupdate.TabIndex = 43;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Green;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnadd.Location = new System.Drawing.Point(233, 335);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(79, 32);
            this.btnadd.TabIndex = 42;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtaddressdonor
            // 
            this.txtaddressdonor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddressdonor.Location = new System.Drawing.Point(258, 279);
            this.txtaddressdonor.Multiline = true;
            this.txtaddressdonor.Name = "txtaddressdonor";
            this.txtaddressdonor.Size = new System.Drawing.Size(357, 42);
            this.txtaddressdonor.TabIndex = 41;
            // 
            // lbladdressdonor
            // 
            this.lbladdressdonor.AutoSize = true;
            this.lbladdressdonor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdressdonor.Location = new System.Drawing.Point(171, 291);
            this.lbladdressdonor.Name = "lbladdressdonor";
            this.lbladdressdonor.Size = new System.Drawing.Size(49, 15);
            this.lbladdressdonor.TabIndex = 40;
            this.lbladdressdonor.Text = "Address";
            // 
            // txtucontactdonor
            // 
            this.txtucontactdonor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtucontactdonor.Location = new System.Drawing.Point(258, 219);
            this.txtucontactdonor.MaxLength = 14;
            this.txtucontactdonor.Name = "txtucontactdonor";
            this.txtucontactdonor.Size = new System.Drawing.Size(357, 23);
            this.txtucontactdonor.TabIndex = 39;
            // 
            // lblucontact
            // 
            this.lblucontact.AutoSize = true;
            this.lblucontact.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblucontact.Location = new System.Drawing.Point(171, 222);
            this.lblucontact.Name = "lblucontact";
            this.lblucontact.Size = new System.Drawing.Size(48, 15);
            this.lblucontact.TabIndex = 38;
            this.lblucontact.Text = "Contact";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(464, 192);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 15);
            this.lblGender.TabIndex = 36;
            this.lblGender.Text = "Gender";
            // 
            // txtlastname
            // 
            this.txtlastname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.Location = new System.Drawing.Point(258, 123);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(357, 23);
            this.txtlastname.TabIndex = 35;
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(171, 126);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(63, 15);
            this.lbllastname.TabIndex = 34;
            this.lbllastname.Text = "Last Name";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(258, 248);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(357, 23);
            this.txtemail.TabIndex = 33;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(171, 251);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Email";
            // 
            // txtdid
            // 
            this.txtdid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdid.Location = new System.Drawing.Point(258, 63);
            this.txtdid.Name = "txtdid";
            this.txtdid.ReadOnly = true;
            this.txtdid.Size = new System.Drawing.Size(357, 23);
            this.txtdid.TabIndex = 31;
            // 
            // lbldonorid
            // 
            this.lbldonorid.AutoSize = true;
            this.lbldonorid.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldonorid.Location = new System.Drawing.Point(171, 63);
            this.lbldonorid.Name = "lbldonorid";
            this.lbldonorid.Size = new System.Drawing.Size(55, 15);
            this.lbldonorid.TabIndex = 30;
            this.lbldonorid.Text = "Donor Id";
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(258, 93);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(357, 23);
            this.txtfname.TabIndex = 29;
            // 
            // lblfirstn
            // 
            this.lblfirstn.AutoSize = true;
            this.lblfirstn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstn.Location = new System.Drawing.Point(171, 96);
            this.lblfirstn.Name = "lblfirstn";
            this.lblfirstn.Size = new System.Drawing.Size(64, 15);
            this.lblfirstn.TabIndex = 28;
            this.lblfirstn.Text = "First Name";
            // 
            // btnselim
            // 
            this.btnselim.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnselim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselim.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselim.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnselim.Location = new System.Drawing.Point(675, 269);
            this.btnselim.Name = "btnselim";
            this.btnselim.Size = new System.Drawing.Size(95, 24);
            this.btnselim.TabIndex = 27;
            this.btnselim.Text = "Select Image";
            this.btnselim.UseVisualStyleBackColor = false;
            this.btnselim.Click += new System.EventHandler(this.btnselim_Click);
            // 
            // profilepicturebox
            // 
            this.profilepicturebox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.profilepicturebox.Location = new System.Drawing.Point(642, 75);
            this.profilepicturebox.Name = "profilepicturebox";
            this.profilepicturebox.Size = new System.Drawing.Size(160, 185);
            this.profilepicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilepicturebox.TabIndex = 26;
            this.profilepicturebox.TabStop = false;
            // 
            // lblProfileimage
            // 
            this.lblProfileimage.AutoSize = true;
            this.lblProfileimage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileimage.Location = new System.Drawing.Point(684, 57);
            this.lblProfileimage.Name = "lblProfileimage";
            this.lblProfileimage.Size = new System.Drawing.Size(78, 15);
            this.lblProfileimage.TabIndex = 25;
            this.lblProfileimage.Text = "Profile Image";
            // 
            // cbgender
            // 
            this.cbgender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbgender.Location = new System.Drawing.Point(524, 187);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(91, 25);
            this.cbgender.TabIndex = 49;
            // 
            // cbbg
            // 
            this.cbbg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbg.FormattingEnabled = true;
            this.cbbg.Items.AddRange(new object[] {
            "A+ve",
            "A-ve",
            "AB+ve",
            "AB-ve",
            "B+ve",
            "B-ve",
            "O+ve",
            "O-ve"});
            this.cbbg.Location = new System.Drawing.Point(258, 154);
            this.cbbg.Name = "cbbg";
            this.cbbg.Size = new System.Drawing.Size(174, 25);
            this.cbbg.TabIndex = 51;
            this.cbbg.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblbg
            // 
            this.lblbg.AutoSize = true;
            this.lblbg.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbg.Location = new System.Drawing.Point(171, 157);
            this.lblbg.Name = "lblbg";
            this.lblbg.Size = new System.Drawing.Size(74, 15);
            this.lblbg.TabIndex = 50;
            this.lblbg.Text = "Blood Group";
            this.lblbg.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // dtpld
            // 
            this.dtpld.Location = new System.Drawing.Point(258, 189);
            this.dtpld.Name = "dtpld";
            this.dtpld.Size = new System.Drawing.Size(196, 20);
            this.dtpld.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 57;
            this.label2.Text = "Last Donated";
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(488, 152);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(127, 23);
            this.txtage.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 59;
            this.label1.Text = "Age";
            // 
            // FormDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbbg);
            this.Controls.Add(this.lblbg);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.dgvdonor);
            this.Controls.Add(this.btndetele);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtaddressdonor);
            this.Controls.Add(this.lbladdressdonor);
            this.Controls.Add(this.txtucontactdonor);
            this.Controls.Add(this.lblucontact);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtdid);
            this.Controls.Add(this.lbldonorid);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.lblfirstn);
            this.Controls.Add(this.btnselim);
            this.Controls.Add(this.profilepicturebox);
            this.Controls.Add(this.lblProfileimage);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDonor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donor";
            this.Load += new System.EventHandler(this.FormDonor_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdonor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilepicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.PictureBox pictureBoxclose;
        private System.Windows.Forms.Label lblFormTittle;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.DataGridView dgvdonor;
        private System.Windows.Forms.Button btndetele;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtaddressdonor;
        private System.Windows.Forms.Label lbladdressdonor;
        private System.Windows.Forms.TextBox txtucontactdonor;
        private System.Windows.Forms.Label lblucontact;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtdid;
        private System.Windows.Forms.Label lbldonorid;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label lblfirstn;
        private System.Windows.Forms.Button btnselim;
        private System.Windows.Forms.PictureBox profilepicturebox;
        private System.Windows.Forms.Label lblProfileimage;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.ComboBox cbbg;
        private System.Windows.Forms.Label lblbg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label1;
    }
}