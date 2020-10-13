using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp112.Data;
using WindowsFormsApp112.Ui;
using System.Data.SqlClient;


namespace WindowsFormsApp112.Ui
{
    public partial class DUhome : Form
    {
        public DUhome()
        {
            InitializeComponent();
        }
        donordata data = new donordata();
        public void Donorount()
        {

            labelaposcount.Text = data.countdonor("A+ve");
            labelanegcount.Text = data.countdonor("A-ve");
            labelbposcount.Text = data.countdonor("B+ve");
            labelbnegcount.Text = data.countdonor("B-ve");
            labelabposcount.Text = data.countdonor("AB+ve");
            labelabnegcount.Text = data.countdonor("AB-ve");
            labeloposcount.Text = data.countdonor("O+ve");
            labelonegcount.Text = data.countdonor("O-ve");


        }

        private void CustomerVIew_Load(object sender, EventArgs e)
        {
            Donorount();
            DataTable dt = data.Select();
            dgv.DataSource = dt;
            // lblun.Text = logInForm.loggeduser;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logInForm lf = new logInForm();
            lf.Show();
        }

        private void pictureBoxclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                //display user for keyword
                DataTable dt = data.Search(keywords);
                dgv.DataSource = dt;
            }
            else
            {
                //display all users
                DataTable dt = data.Select();
                dgv.DataSource = dt;
                //}
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            donor_register dr = new donor_register();
            dr.Show();

        }

        private void appname_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            DataTable dt = data.Select();
            dgv.DataSource = dt;
        }
    }
}
