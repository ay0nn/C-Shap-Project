namespace WindowsFormsApp112
{
    partial class homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1apos = new System.Windows.Forms.Panel();
            this.lblname = new System.Windows.Forms.Label();
            this.labelaposcount = new System.Windows.Forms.Label();
            this.lablodgr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblbdonoraneg = new System.Windows.Forms.Label();
            this.labelanegcount = new System.Windows.Forms.Label();
            this.lbloneg = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.donorOneg = new System.Windows.Forms.Label();
            this.labelonegcount = new System.Windows.Forms.Label();
            this.laboneg = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.oposdonor = new System.Windows.Forms.Label();
            this.labeloposcount = new System.Windows.Forms.Label();
            this.lblopos = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Abnegdonor = new System.Windows.Forms.Label();
            this.labelabnegcount = new System.Windows.Forms.Label();
            this.Abneg = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Abposdonor = new System.Windows.Forms.Label();
            this.labelabposcount = new System.Windows.Forms.Label();
            this.ABpos = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Bnegdonor = new System.Windows.Forms.Label();
            this.labelbnegcount = new System.Windows.Forms.Label();
            this.Bneg = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BposDono = new System.Windows.Forms.Label();
            this.labelbposcount = new System.Windows.Forms.Label();
            this.Bpos = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxclose = new System.Windows.Forms.PictureBox();
            this.lblun = new System.Windows.Forms.Label();
            this.appname = new System.Windows.Forms.Label();
            this.lblu = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1apos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.donorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 10, 0, 10);
            this.menuStrip1.Size = new System.Drawing.Size(850, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripTop";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.usersToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.usersToolStripMenuItem.Text = "Admin";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // donorsToolStripMenuItem
            // 
            this.donorsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.donorsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            this.donorsToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.donorsToolStripMenuItem.Text = "Donors";
            this.donorsToolStripMenuItem.Click += new System.EventHandler(this.donorsToolStripMenuItem_Click);
            // 
            // panel1apos
            // 
            this.panel1apos.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1apos.Controls.Add(this.lblname);
            this.panel1apos.Controls.Add(this.labelaposcount);
            this.panel1apos.Controls.Add(this.lablodgr);
            this.panel1apos.ForeColor = System.Drawing.Color.Red;
            this.panel1apos.Location = new System.Drawing.Point(33, 70);
            this.panel1apos.Name = "panel1apos";
            this.panel1apos.Size = new System.Drawing.Size(175, 93);
            this.panel1apos.TabIndex = 2;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblname.Location = new System.Drawing.Point(89, 57);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(67, 23);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Donors";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // labelaposcount
            // 
            this.labelaposcount.AutoSize = true;
            this.labelaposcount.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaposcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(99)))));
            this.labelaposcount.Location = new System.Drawing.Point(84, 10);
            this.labelaposcount.Name = "labelaposcount";
            this.labelaposcount.Size = new System.Drawing.Size(79, 50);
            this.labelaposcount.TabIndex = 1;
            this.labelaposcount.Text = "100";
            this.labelaposcount.Click += new System.EventHandler(this.labelaposcount_Click);
            // 
            // lablodgr
            // 
            this.lablodgr.AutoSize = true;
            this.lablodgr.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablodgr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.lablodgr.Location = new System.Drawing.Point(3, 8);
            this.lablodgr.Name = "lablodgr";
            this.lablodgr.Size = new System.Drawing.Size(93, 65);
            this.lablodgr.TabIndex = 0;
            this.lablodgr.Text = "A+";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblbdonoraneg);
            this.panel1.Controls.Add(this.labelanegcount);
            this.panel1.Controls.Add(this.lbloneg);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(240, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 93);
            this.panel1.TabIndex = 3;
            // 
            // lblbdonoraneg
            // 
            this.lblbdonoraneg.AutoSize = true;
            this.lblbdonoraneg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbdonoraneg.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblbdonoraneg.Location = new System.Drawing.Point(89, 57);
            this.lblbdonoraneg.Name = "lblbdonoraneg";
            this.lblbdonoraneg.Size = new System.Drawing.Size(67, 23);
            this.lblbdonoraneg.TabIndex = 2;
            this.lblbdonoraneg.Text = "Donors";
            // 
            // labelanegcount
            // 
            this.labelanegcount.AutoSize = true;
            this.labelanegcount.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelanegcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(99)))));
            this.labelanegcount.Location = new System.Drawing.Point(84, 10);
            this.labelanegcount.Name = "labelanegcount";
            this.labelanegcount.Size = new System.Drawing.Size(79, 50);
            this.labelanegcount.TabIndex = 1;
            this.labelanegcount.Text = "100";
            // 
            // lbloneg
            // 
            this.lbloneg.AutoSize = true;
            this.lbloneg.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloneg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.lbloneg.Location = new System.Drawing.Point(3, 10);
            this.lbloneg.Name = "lbloneg";
            this.lbloneg.Size = new System.Drawing.Size(79, 65);
            this.lbloneg.TabIndex = 0;
            this.lbloneg.Text = "A-";
            this.lbloneg.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.donorOneg);
            this.panel2.Controls.Add(this.labelonegcount);
            this.panel2.Controls.Add(this.laboneg);
            this.panel2.ForeColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(644, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 93);
            this.panel2.TabIndex = 5;
            // 
            // donorOneg
            // 
            this.donorOneg.AutoSize = true;
            this.donorOneg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorOneg.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.donorOneg.Location = new System.Drawing.Point(93, 53);
            this.donorOneg.Name = "donorOneg";
            this.donorOneg.Size = new System.Drawing.Size(67, 23);
            this.donorOneg.TabIndex = 2;
            this.donorOneg.Text = "Donors";
            // 
            // labelonegcount
            // 
            this.labelonegcount.AutoSize = true;
            this.labelonegcount.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelonegcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(99)))));
            this.labelonegcount.Location = new System.Drawing.Point(88, 8);
            this.labelonegcount.Name = "labelonegcount";
            this.labelonegcount.Size = new System.Drawing.Size(79, 50);
            this.labelonegcount.TabIndex = 1;
            this.labelonegcount.Text = "100";
            // 
            // laboneg
            // 
            this.laboneg.AutoSize = true;
            this.laboneg.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laboneg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.laboneg.Location = new System.Drawing.Point(3, 11);
            this.laboneg.Name = "laboneg";
            this.laboneg.Size = new System.Drawing.Size(83, 65);
            this.laboneg.TabIndex = 0;
            this.laboneg.Text = "O-";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.oposdonor);
            this.panel3.Controls.Add(this.labeloposcount);
            this.panel3.Controls.Add(this.lblopos);
            this.panel3.ForeColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(441, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 93);
            this.panel3.TabIndex = 4;
            // 
            // oposdonor
            // 
            this.oposdonor.AutoSize = true;
            this.oposdonor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oposdonor.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.oposdonor.Location = new System.Drawing.Point(89, 53);
            this.oposdonor.Name = "oposdonor";
            this.oposdonor.Size = new System.Drawing.Size(67, 23);
            this.oposdonor.TabIndex = 2;
            this.oposdonor.Text = "Donors";
            // 
            // labeloposcount
            // 
            this.labeloposcount.AutoSize = true;
            this.labeloposcount.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeloposcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(99)))));
            this.labeloposcount.Location = new System.Drawing.Point(86, 8);
            this.labeloposcount.Name = "labeloposcount";
            this.labeloposcount.Size = new System.Drawing.Size(79, 50);
            this.labeloposcount.TabIndex = 1;
            this.labeloposcount.Text = "100";
            // 
            // lblopos
            // 
            this.lblopos.AutoSize = true;
            this.lblopos.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblopos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.lblopos.Location = new System.Drawing.Point(7, 11);
            this.lblopos.Name = "lblopos";
            this.lblopos.Size = new System.Drawing.Size(97, 65);
            this.lblopos.TabIndex = 0;
            this.lblopos.Text = "O+";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.Abnegdonor);
            this.panel4.Controls.Add(this.labelabnegcount);
            this.panel4.Controls.Add(this.Abneg);
            this.panel4.ForeColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(644, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 93);
            this.panel4.TabIndex = 9;
            // 
            // Abnegdonor
            // 
            this.Abnegdonor.AutoSize = true;
            this.Abnegdonor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abnegdonor.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Abnegdonor.Location = new System.Drawing.Point(93, 57);
            this.Abnegdonor.Name = "Abnegdonor";
            this.Abnegdonor.Size = new System.Drawing.Size(67, 23);
            this.Abnegdonor.TabIndex = 2;
            this.Abnegdonor.Text = "Donors";
            // 
            // labelabnegcount
            // 
            this.labelabnegcount.AutoSize = true;
            this.labelabnegcount.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelabnegcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(99)))));
            this.labelabnegcount.Location = new System.Drawing.Point(88, 10);
            this.labelabnegcount.Name = "labelabnegcount";
            this.labelabnegcount.Size = new System.Drawing.Size(79, 50);
            this.labelabnegcount.TabIndex = 1;
            this.labelabnegcount.Text = "100";
            // 
            // Abneg
            // 
            this.Abneg.AutoSize = true;
            this.Abneg.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abneg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.Abneg.Location = new System.Drawing.Point(3, 20);
            this.Abneg.Name = "Abneg";
            this.Abneg.Size = new System.Drawing.Size(84, 50);
            this.Abneg.TabIndex = 0;
            this.Abneg.Text = "AB-";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.Abposdonor);
            this.panel5.Controls.Add(this.labelabposcount);
            this.panel5.Controls.Add(this.ABpos);
            this.panel5.ForeColor = System.Drawing.Color.Red;
            this.panel5.Location = new System.Drawing.Point(441, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 93);
            this.panel5.TabIndex = 8;
            // 
            // Abposdonor
            // 
            this.Abposdonor.AutoSize = true;
            this.Abposdonor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abposdonor.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Abposdonor.Location = new System.Drawing.Point(89, 57);
            this.Abposdonor.Name = "Abposdonor";
            this.Abposdonor.Size = new System.Drawing.Size(67, 23);
            this.Abposdonor.TabIndex = 2;
            this.Abposdonor.Text = "Donors";
            // 
            // labelabposcount
            // 
            this.labelabposcount.AutoSize = true;
            this.labelabposcount.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelabposcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(99)))));
            this.labelabposcount.Location = new System.Drawing.Point(86, 10);
            this.labelabposcount.Name = "labelabposcount";
            this.labelabposcount.Size = new System.Drawing.Size(79, 50);
            this.labelabposcount.TabIndex = 1;
            this.labelabposcount.Text = "100";
            // 
            // ABpos
            // 
            this.ABpos.AutoSize = true;
            this.ABpos.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABpos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ABpos.Location = new System.Drawing.Point(3, 20);
            this.ABpos.Name = "ABpos";
            this.ABpos.Size = new System.Drawing.Size(95, 50);
            this.ABpos.TabIndex = 0;
            this.ABpos.Text = "AB+";
            this.ABpos.Click += new System.EventHandler(this.label15_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.Controls.Add(this.Bnegdonor);
            this.panel6.Controls.Add(this.labelbnegcount);
            this.panel6.Controls.Add(this.Bneg);
            this.panel6.ForeColor = System.Drawing.Color.Red;
            this.panel6.Location = new System.Drawing.Point(240, 184);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 93);
            this.panel6.TabIndex = 7;
            // 
            // Bnegdonor
            // 
            this.Bnegdonor.AutoSize = true;
            this.Bnegdonor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnegdonor.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Bnegdonor.Location = new System.Drawing.Point(89, 53);
            this.Bnegdonor.Name = "Bnegdonor";
            this.Bnegdonor.Size = new System.Drawing.Size(67, 23);
            this.Bnegdonor.TabIndex = 2;
            this.Bnegdonor.Text = "Donors";
            // 
            // labelbnegcount
            // 
            this.labelbnegcount.AutoSize = true;
            this.labelbnegcount.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbnegcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(99)))));
            this.labelbnegcount.Location = new System.Drawing.Point(84, 11);
            this.labelbnegcount.Name = "labelbnegcount";
            this.labelbnegcount.Size = new System.Drawing.Size(79, 50);
            this.labelbnegcount.TabIndex = 1;
            this.labelbnegcount.Text = "100";
            // 
            // Bneg
            // 
            this.Bneg.AutoSize = true;
            this.Bneg.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bneg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.Bneg.Location = new System.Drawing.Point(3, 8);
            this.Bneg.Name = "Bneg";
            this.Bneg.Size = new System.Drawing.Size(76, 65);
            this.Bneg.TabIndex = 0;
            this.Bneg.Text = "B-";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.Controls.Add(this.BposDono);
            this.panel7.Controls.Add(this.labelbposcount);
            this.panel7.Controls.Add(this.Bpos);
            this.panel7.ForeColor = System.Drawing.Color.Red;
            this.panel7.Location = new System.Drawing.Point(33, 184);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(175, 93);
            this.panel7.TabIndex = 6;
            // 
            // BposDono
            // 
            this.BposDono.AutoSize = true;
            this.BposDono.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BposDono.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BposDono.Location = new System.Drawing.Point(89, 53);
            this.BposDono.Name = "BposDono";
            this.BposDono.Size = new System.Drawing.Size(67, 23);
            this.BposDono.TabIndex = 2;
            this.BposDono.Text = "Donors";
            // 
            // labelbposcount
            // 
            this.labelbposcount.AutoSize = true;
            this.labelbposcount.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbposcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(99)))));
            this.labelbposcount.Location = new System.Drawing.Point(84, 8);
            this.labelbposcount.Name = "labelbposcount";
            this.labelbposcount.Size = new System.Drawing.Size(79, 50);
            this.labelbposcount.TabIndex = 1;
            this.labelbposcount.Text = "100";
            // 
            // Bpos
            // 
            this.Bpos.AutoSize = true;
            this.Bpos.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bpos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.Bpos.Location = new System.Drawing.Point(3, 8);
            this.Bpos.Name = "Bpos";
            this.Bpos.Size = new System.Drawing.Size(90, 65);
            this.Bpos.TabIndex = 0;
            this.Bpos.Text = "B+";
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(33, 349);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(786, 169);
            this.dgv.TabIndex = 10;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSearch.Location = new System.Drawing.Point(28, 317);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(117, 21);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search Donor :";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(145, 314);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(674, 29);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBoxclose
            // 
            this.pictureBoxclose.BackColor = System.Drawing.Color.Teal;
            this.pictureBoxclose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxclose.Image")));
            this.pictureBoxclose.Location = new System.Drawing.Point(811, 6);
            this.pictureBoxclose.Name = "pictureBoxclose";
            this.pictureBoxclose.Size = new System.Drawing.Size(29, 28);
            this.pictureBoxclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxclose.TabIndex = 13;
            this.pictureBoxclose.TabStop = false;
            this.pictureBoxclose.Click += new System.EventHandler(this.pictureBoxclose_Click);
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblun.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblun.Location = new System.Drawing.Point(97, 525);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(0, 15);
            this.lblun.TabIndex = 19;
            // 
            // appname
            // 
            this.appname.AutoSize = true;
            this.appname.BackColor = System.Drawing.Color.Transparent;
            this.appname.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appname.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.appname.Location = new System.Drawing.Point(311, 521);
            this.appname.Name = "appname";
            this.appname.Size = new System.Drawing.Size(234, 20);
            this.appname.TabIndex = 17;
            this.appname.Text = "Blood Bank Management System";
            // 
            // lblu
            // 
            this.lblu.AutoSize = true;
            this.lblu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblu.ForeColor = System.Drawing.Color.Black;
            this.lblu.Location = new System.Drawing.Point(30, 525);
            this.lblu.Name = "lblu";
            this.lblu.Size = new System.Drawing.Size(61, 15);
            this.lblu.TabIndex = 18;
            this.lblu.Text = "Logged as";
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.lblun);
            this.Controls.Add(this.appname);
            this.Controls.Add(this.lblu);
            this.Controls.Add(this.pictureBoxclose);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel1apos);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Activated += new System.EventHandler(this.homepage_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1apos.ResumeLayout(false);
            this.panel1apos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1apos;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label labelaposcount;
        private System.Windows.Forms.Label lablodgr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblbdonoraneg;
        private System.Windows.Forms.Label labelanegcount;
        private System.Windows.Forms.Label lbloneg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label donorOneg;
        private System.Windows.Forms.Label labelonegcount;
        private System.Windows.Forms.Label laboneg;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label oposdonor;
        private System.Windows.Forms.Label labeloposcount;
        private System.Windows.Forms.Label lblopos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Abnegdonor;
        private System.Windows.Forms.Label labelabnegcount;
        private System.Windows.Forms.Label Abneg;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Abposdonor;
        private System.Windows.Forms.Label labelabposcount;
        private System.Windows.Forms.Label ABpos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label Bnegdonor;
        private System.Windows.Forms.Label labelbnegcount;
        private System.Windows.Forms.Label Bneg;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label BposDono;
        private System.Windows.Forms.Label labelbposcount;
        private System.Windows.Forms.Label Bpos;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBoxclose;
        private System.Windows.Forms.Label lblun;
        private System.Windows.Forms.Label appname;
        private System.Windows.Forms.Label lblu;
    }
}

