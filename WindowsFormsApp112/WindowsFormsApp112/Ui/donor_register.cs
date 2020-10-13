using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp112.classes;
using WindowsFormsApp112.Data;

namespace WindowsFormsApp112.Ui
{
    public partial class donor_register : Form
    {
        public donor_register()
        {
            InitializeComponent();
        }

        Donor d = new Donor();
        donordata dal = new donordata();
        admindata us = new admindata();

       // DataTable dt = dal.Select();
       // dgvdonor.DataSource = dt;

        string image = "no-image.jpg";
        public void clear()
        {

            txtdid.Text = "";
            txtfname.Text = "";
            txtlastname.Text = "";
            txtage.Text = "";
            dtpld.Value = DateTime.Now;
            txtemail.Text = "";
            cbgender.Text = "";
            cbbg.Text = "";
            txtucontactdonor.Text = "";
            txtaddressdonor.Text = "";

            //clearing image
           /* string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            string imagePath = paths + "\\Images\\no-image.jpg";

           // profilepicturebox.Image = new Bitmap(imagePath);*/
        }

        private void pictureBoxclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            d.First_Name = txtfname.Text;
            d.Last_Name = txtlastname.Text;
            d.Blood_Group = cbbg.Text;
            d.Age = int.Parse(txtage.Text);
            d.Last_Donated = dtpld.Value;
            d.Gender = cbgender.Text;
            d.Contact = txtucontactdonor.Text;
            d.Email = txtemail.Text;
            d.Address = txtaddressdonor.Text;
            d.Added_Date = DateTime.Now;
            //id of logged user
            string loggeduser = logInForm.loggeduser;
          //  admin ul = us.Getuid(loggeduser);
            d.Added_By = 1; //logged in user
            d.Image = image;

            bool success = dal.Insert(d);


            //check whether data inserted or not

            if (success == true)
            {
                MessageBox.Show("New Donor Successfully Added.");
               
            }
            else
            {
                MessageBox.Show("Failed To Add New User!");
            }
            clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
            //Application.Run(new DUhome());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
