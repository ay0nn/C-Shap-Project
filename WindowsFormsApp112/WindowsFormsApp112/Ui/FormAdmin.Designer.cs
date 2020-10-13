namespace WindowsFormsApp112.Ui
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.paneltop = new System.Windows.Forms.Panel();
            this.pictureBoxclose = new System.Windows.Forms.PictureBox();
            this.lblFormTittle = new System.Windows.Forms.Label();
            this.lblProfileimage = new System.Windows.Forms.Label();
            this.profilepicturebox = new System.Windows.Forms.PictureBox();
            this.btnselim = new System.Windows.Forms.Button();
            this.lblfname = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.lbluserid = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtucontact = new System.Windows.Forms.TextBox();
            this.lblucontact = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndetele = new System.Windows.Forms.Button();
            this.dgvuser = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilepicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).BeginInit();
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
            this.paneltop.TabIndex = 0;
            // 
            // pictureBoxclose
            // 
            this.pictureBoxclose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxclose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxclose.Image")));
            this.pictureBoxclose.Location = new System.Drawing.Point(812, 4);
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
            this.lblFormTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTittle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTittle.ForeColor = System.Drawing.Color.Black;
            this.lblFormTittle.Location = new System.Drawing.Point(359, 9);
            this.lblFormTittle.Name = "lblFormTittle";
            this.lblFormTittle.Size = new System.Drawing.Size(134, 21);
            this.lblFormTittle.TabIndex = 0;
            this.lblFormTittle.Text = "Manage Admins";
            // 
            // lblProfileimage
            // 
            this.lblProfileimage.AutoSize = true;
            this.lblProfileimage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileimage.Location = new System.Drawing.Point(676, 65);
            this.lblProfileimage.Name = "lblProfileimage";
            this.lblProfileimage.Size = new System.Drawing.Size(88, 17);
            this.lblProfileimage.TabIndex = 1;
            this.lblProfileimage.Text = "Profile Image";
            // 
            // profilepicturebox
            // 
            this.profilepicturebox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.profilepicturebox.Location = new System.Drawing.Point(643, 94);
            this.profilepicturebox.Name = "profilepicturebox";
            this.profilepicturebox.Size = new System.Drawing.Size(159, 174);
            this.profilepicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilepicturebox.TabIndex = 2;
            this.profilepicturebox.TabStop = false;
            this.profilepicturebox.Click += new System.EventHandler(this.profilepicturebox_Click);
            // 
            // btnselim
            // 
            this.btnselim.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnselim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselim.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnselim.Location = new System.Drawing.Point(679, 287);
            this.btnselim.Name = "btnselim";
            this.btnselim.Size = new System.Drawing.Size(95, 24);
            this.btnselim.TabIndex = 3;
            this.btnselim.Text = "Select Image";
            this.btnselim.UseVisualStyleBackColor = false;
            this.btnselim.Click += new System.EventHandler(this.btnselim_Click);
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfname.Location = new System.Drawing.Point(170, 106);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(66, 17);
            this.lblfname.TabIndex = 4;
            this.lblfname.Text = "Full Name";
            // 
            // txtFullname
            // 
            this.txtFullname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.Location = new System.Drawing.Point(263, 103);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(351, 25);
            this.txtFullname.TabIndex = 5;
            // 
            // txtuid
            // 
            this.txtuid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuid.Location = new System.Drawing.Point(263, 69);
            this.txtuid.Name = "txtuid";
            this.txtuid.ReadOnly = true;
            this.txtuid.Size = new System.Drawing.Size(351, 25);
            this.txtuid.TabIndex = 7;
            this.txtuid.TextChanged += new System.EventHandler(this.txtuid_TextChanged);
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserid.Location = new System.Drawing.Point(170, 72);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(60, 17);
            this.lbluserid.TabIndex = 6;
            this.lbluserid.Text = "Admin Id";
            this.lbluserid.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(263, 138);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(351, 25);
            this.txtemail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(168, 141);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(263, 204);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(351, 25);
            this.txtpass.TabIndex = 13;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(167, 207);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(64, 17);
            this.lblpass.TabIndex = 12;
            this.lblpass.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(263, 170);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(351, 25);
            this.txtusername.TabIndex = 11;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(167, 173);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(84, 17);
            this.lblusername.TabIndex = 10;
            this.lblusername.Text = "Admin Name";
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(263, 271);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(351, 47);
            this.txtaddress.TabIndex = 17;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(167, 287);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(48, 13);
            this.lbladdress.TabIndex = 16;
            this.lbladdress.Text = "Address";
            // 
            // txtucontact
            // 
            this.txtucontact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtucontact.Location = new System.Drawing.Point(263, 238);
            this.txtucontact.MaxLength = 14;
            this.txtucontact.Name = "txtucontact";
            this.txtucontact.Size = new System.Drawing.Size(351, 25);
            this.txtucontact.TabIndex = 15;
            // 
            // lblucontact
            // 
            this.lblucontact.AutoSize = true;
            this.lblucontact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblucontact.Location = new System.Drawing.Point(168, 241);
            this.lblucontact.Name = "lblucontact";
            this.lblucontact.Size = new System.Drawing.Size(93, 17);
            this.lblucontact.TabIndex = 14;
            this.lblucontact.Text = "Admin Contact";
            this.lblucontact.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Green;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnadd.Location = new System.Drawing.Point(240, 329);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(79, 32);
            this.btnadd.TabIndex = 18;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Teal;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnupdate.Location = new System.Drawing.Point(344, 329);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(79, 32);
            this.btnupdate.TabIndex = 19;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Goldenrod;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnclear.Location = new System.Drawing.Point(546, 329);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(79, 32);
            this.btnclear.TabIndex = 20;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndetele
            // 
            this.btndetele.BackColor = System.Drawing.Color.Red;
            this.btndetele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndetele.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetele.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btndetele.Location = new System.Drawing.Point(445, 329);
            this.btndetele.Name = "btndetele";
            this.btndetele.Size = new System.Drawing.Size(79, 32);
            this.btndetele.TabIndex = 21;
            this.btndetele.Text = "Delete";
            this.btndetele.UseVisualStyleBackColor = false;
            this.btndetele.Click += new System.EventHandler(this.btndetele_Click);
            // 
            // dgvuser
            // 
            this.dgvuser.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuser.Location = new System.Drawing.Point(43, 399);
            this.dgvuser.Name = "dgvuser";
            this.dgvuser.Size = new System.Drawing.Size(759, 125);
            this.dgvuser.TabIndex = 22;
            this.dgvuser.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvuser_RowHeaderMouseClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(125, 368);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(677, 25);
            this.txtsearch.TabIndex = 24;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(40, 371);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(48, 17);
            this.lblsearch.TabIndex = 23;
            this.lblsearch.Text = "Search";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.dgvuser);
            this.Controls.Add(this.btndetele);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtucontact);
            this.Controls.Add(this.lblucontact);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtuid);
            this.Controls.Add(this.lbluserid);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.lblfname);
            this.Controls.Add(this.btnselim);
            this.Controls.Add(this.profilepicturebox);
            this.Controls.Add(this.lblProfileimage);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilepicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label lblFormTittle;
        private System.Windows.Forms.Label lblProfileimage;
        private System.Windows.Forms.PictureBox profilepicturebox;
        private System.Windows.Forms.Button btnselim;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtuid;
        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtucontact;
        private System.Windows.Forms.Label lblucontact;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndetele;
        private System.Windows.Forms.DataGridView dgvuser;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.PictureBox pictureBoxclose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}