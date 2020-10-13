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

namespace WindowsFormsApp112
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        donordata data = new donordata();

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Donorount();
            DataTable dt = data.Select();
            dgv.DataSource = dt;
            lblun.Text = logInForm.loggeduser;

        }

        private void pictureBoxclose_Click(object sender, EventArgs e)
        {
            //closeapp
            this.Close();
            
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open user form
            FormAdmin admins = new FormAdmin();
            admins.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void donorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDonor donors = new FormDonor();
            donors.Show();

        }

        public void Donorount() {


            labelaposcount.Text = data.countdonor("A+ve");
            labelanegcount.Text = data.countdonor("A-ve");
            labelbposcount.Text = data.countdonor("B+ve");
            labelbnegcount.Text = data.countdonor("B-ve");
            labelabposcount.Text = data.countdonor("AB+ve");
            labelabnegcount.Text = data.countdonor("AB-ve");
            labeloposcount.Text = data.countdonor("O+ve");
            labelonegcount.Text = data.countdonor("O-ve");


        }

        private void homepage_Activated(object sender, EventArgs e)
        {
            Donorount();
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
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblu_Click(object sender, EventArgs e)
        {

        }

        private void labelaposcount_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
