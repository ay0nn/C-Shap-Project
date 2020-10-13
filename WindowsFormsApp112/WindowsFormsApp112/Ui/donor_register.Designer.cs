namespace WindowsFormsApp112.Ui
{
    partial class donor_register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(donor_register));
            this.txtage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpld = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbbg = new System.Windows.Forms.ComboBox();
            this.lblbg = new System.Windows.Forms.Label();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.btnclear = new System.Windows.Forms.Button();
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
            this.pictureBoxclose = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(356, 202);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(127, 23);
            this.txtage.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 87;
            this.label1.Text = "Age";
            // 
            // dtpld
            // 
            this.dtpld.Location = new System.Drawing.Point(126, 239);
            this.dtpld.Name = "dtpld";
            this.dtpld.Size = new System.Drawing.Size(196, 20);
            this.dtpld.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 85;
            this.label2.Text = "Last Donated";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(541, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.cbbg.Location = new System.Drawing.Point(126, 204);
            this.cbbg.Name = "cbbg";
            this.cbbg.Size = new System.Drawing.Size(174, 25);
            this.cbbg.TabIndex = 83;
            // 
            // lblbg
            // 
            this.lblbg.AutoSize = true;
            this.lblbg.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbg.Location = new System.Drawing.Point(39, 207);
            this.lblbg.Name = "lblbg";
            this.lblbg.Size = new System.Drawing.Size(74, 15);
            this.lblbg.TabIndex = 82;
            this.lblbg.Text = "Blood Group";
            // 
            // cbgender
            // 
            this.cbgender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbgender.Location = new System.Drawing.Point(392, 237);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(91, 25);
            this.cbgender.TabIndex = 81;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Goldenrod;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnclear.Location = new System.Drawing.Point(284, 385);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(79, 32);
            this.btnclear.TabIndex = 79;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Green;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnadd.Location = new System.Drawing.Point(171, 385);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(79, 32);
            this.btnadd.TabIndex = 77;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtaddressdonor
            // 
            this.txtaddressdonor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddressdonor.Location = new System.Drawing.Point(126, 329);
            this.txtaddressdonor.Multiline = true;
            this.txtaddressdonor.Name = "txtaddressdonor";
            this.txtaddressdonor.Size = new System.Drawing.Size(357, 42);
            this.txtaddressdonor.TabIndex = 76;
            // 
            // lbladdressdonor
            // 
            this.lbladdressdonor.AutoSize = true;
            this.lbladdressdonor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdressdonor.Location = new System.Drawing.Point(39, 341);
            this.lbladdressdonor.Name = "lbladdressdonor";
            this.lbladdressdonor.Size = new System.Drawing.Size(49, 15);
            this.lbladdressdonor.TabIndex = 75;
            this.lbladdressdonor.Text = "Address";
            // 
            // txtucontactdonor
            // 
            this.txtucontactdonor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtucontactdonor.Location = new System.Drawing.Point(126, 269);
            this.txtucontactdonor.MaxLength = 14;
            this.txtucontactdonor.Name = "txtucontactdonor";
            this.txtucontactdonor.Size = new System.Drawing.Size(357, 23);
            this.txtucontactdonor.TabIndex = 74;
            // 
            // lblucontact
            // 
            this.lblucontact.AutoSize = true;
            this.lblucontact.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblucontact.Location = new System.Drawing.Point(39, 272);
            this.lblucontact.Name = "lblucontact";
            this.lblucontact.Size = new System.Drawing.Size(48, 15);
            this.lblucontact.TabIndex = 73;
            this.lblucontact.Text = "Contact";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(332, 242);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 15);
            this.lblGender.TabIndex = 72;
            this.lblGender.Text = "Gender";
            // 
            // txtlastname
            // 
            this.txtlastname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.Location = new System.Drawing.Point(126, 173);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(357, 23);
            this.txtlastname.TabIndex = 71;
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(39, 176);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(63, 15);
            this.lbllastname.TabIndex = 70;
            this.lbllastname.Text = "Last Name";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(126, 298);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(357, 23);
            this.txtemail.TabIndex = 69;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(39, 301);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 68;
            this.lblEmail.Text = "Email";
            // 
            // txtdid
            // 
            this.txtdid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdid.Location = new System.Drawing.Point(126, 113);
            this.txtdid.Name = "txtdid";
            this.txtdid.ReadOnly = true;
            this.txtdid.Size = new System.Drawing.Size(357, 23);
            this.txtdid.TabIndex = 67;
            // 
            // lbldonorid
            // 
            this.lbldonorid.AutoSize = true;
            this.lbldonorid.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldonorid.Location = new System.Drawing.Point(39, 113);
            this.lbldonorid.Name = "lbldonorid";
            this.lbldonorid.Size = new System.Drawing.Size(55, 15);
            this.lbldonorid.TabIndex = 66;
            this.lbldonorid.Text = "Donor Id";
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(126, 143);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(357, 23);
            this.txtfname.TabIndex = 65;
            // 
            // lblfirstn
            // 
            this.lblfirstn.AutoSize = true;
            this.lblfirstn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstn.Location = new System.Drawing.Point(39, 146);
            this.lblfirstn.Name = "lblfirstn";
            this.lblfirstn.Size = new System.Drawing.Size(64, 15);
            this.lblfirstn.TabIndex = 64;
            this.lblfirstn.Text = "First Name";
            // 
            // pictureBoxclose
            // 
            this.pictureBoxclose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxclose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxclose.Image")));
            this.pictureBoxclose.Location = new System.Drawing.Point(759, 12);
            this.pictureBoxclose.Name = "pictureBoxclose";
            this.pictureBoxclose.Size = new System.Drawing.Size(29, 28);
            this.pictureBoxclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxclose.TabIndex = 89;
            this.pictureBoxclose.TabStop = false;
            this.pictureBoxclose.Click += new System.EventHandler(this.pictureBoxclose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(144, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 21);
            this.label3.TabIndex = 90;
            this.label3.Text = "Fill all the blank boxes with valid information";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // donor_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxclose);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbbg);
            this.Controls.Add(this.lblbg);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.btnclear);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "donor_register";
            this.Text = "donor_register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbbg;
        private System.Windows.Forms.Label lblbg;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.Button btnclear;
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
        private System.Windows.Forms.PictureBox pictureBoxclose;
        private System.Windows.Forms.Label label3;
    }
}