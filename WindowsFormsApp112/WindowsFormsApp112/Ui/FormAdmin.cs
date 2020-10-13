using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp112.Data;
using WindowsFormsApp112.SBL;

namespace WindowsFormsApp112.Ui
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        admin u = new admin();
        admindata udt = new admindata();
        string image = "no-image.jpg";
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBoxclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void profilepicturebox_Click(object sender, EventArgs e)
        {

        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            //get the value from ui
            u.admin_fname = txtFullname.Text;
            u.admin_mail = txtemail.Text;
            u.admin_name = txtusername.Text;
            u.admin_pass = txtpass.Text;
            u.admin_contact = txtucontact.Text;
            u.admin_address = txtaddress.Text;
            u.added_date = DateTime.Now;
            u.image = image;

            //adding value from ui to db
            bool success = udt.Insert(u);

            //check whether data inserted or not
            
            if (success== true)
            {
                MessageBox.Show("New User Successfully Added.");
                //display in data grid view
                DataTable dt = udt.Select();
                dgvuser.DataSource = dt;
                //clear text box
                Clear();
            }
            else
            {
                MessageBox.Show("Failed To Add New User!");
            }
        }
        //clear text box
        public void Clear() {
            txtFullname.Text = "";
            txtemail.Text = "";
            txtusername.Text = "";
            txtpass.Text = "";
            txtucontact.Text = "";
            txtaddress.Text = "";
            txtuid.Text = "";

         string paths = Application.StartupPath.Substring(0,(Application.StartupPath.Length - 10));

            string imagePath = paths + "\\Images\\no-image.jpg";

            profilepicturebox.Image = new Bitmap(imagePath);

        }
        private void txtuid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgvuser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //find the row index
            int RowIndex = e.RowIndex;
            txtuid.Text = dgvuser.Rows[RowIndex].Cells[0].Value.ToString();
            txtusername.Text = dgvuser.Rows[RowIndex].Cells[1].Value.ToString();
            txtemail.Text = dgvuser.Rows[RowIndex].Cells[2].Value.ToString();
            txtpass.Text = dgvuser.Rows[RowIndex].Cells[3].Value.ToString();
            txtFullname.Text = dgvuser.Rows[RowIndex].Cells[4].Value.ToString();
            txtucontact.Text = dgvuser.Rows[RowIndex].Cells[5].Value.ToString();
            txtaddress.Text = dgvuser.Rows[RowIndex].Cells[6].Value.ToString();
            image = dgvuser.Rows[RowIndex].Cells[8].Value.ToString();

            //display selected user
            //get image path
            string paths = Application.StartupPath.Substring(0,(Application.StartupPath.Length-10));

            if (image != "no-image.jpg")
            {
                //path to destination
                string imagePath = paths + "\\Images\\" + image;
                profilepicturebox.Image = new Bitmap(imagePath);
            }
            else {
                string imagePath = paths + "\\Images\\no-image.jpg";

                profilepicturebox.Image = new Bitmap(imagePath);
            }
                
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            //display user info in dgrib view f
            DataTable dt = udt.Select();
            dgvuser.DataSource = dt;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //get the value from ui
            u.admin_id = int.Parse(txtuid.Text); //convert int to strind user id
            u.admin_fname = txtFullname.Text;
            u.admin_mail = txtemail.Text;
            u.admin_name = txtusername.Text;
            u.admin_pass = txtpass.Text;
            u.admin_contact = txtucontact.Text;
            u.admin_address = txtaddress.Text;
            u.added_date = DateTime.Now;
            u.image = image;

            //varialbe to check data is updated or not
            bool success = udt.Update(u);

            if (success == true)
            {
                MessageBox.Show("Successfully Updated User");
                DataTable dt = udt.Select();
                dgvuser.DataSource = dt;

                Clear();
            }

        }

        private void btndetele_Click(object sender, EventArgs e)
        {
            //get uid from txtbox to delete
            u.admin_id = int.Parse(txtuid.Text);

            bool success = udt.Delete(u);

            if (success == true)
            {
                MessageBox.Show("Successfully Deleted User.");
                DataTable dt = udt.Select();
                dgvuser.DataSource = dt;

                Clear();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnselim_Click(object sender, EventArgs e)
        {
            //code to upload the image od user
            OpenFileDialog open = new OpenFileDialog();
            //specific file format
            open.Filter = "Image files( *.jpg;*.jpeg,*.png;*.PNG,*.gif;)|*.jpg;*.jpeg,*.png;*.PNG,*.gif;";
            //check file is slected/not
            if (open.ShowDialog() == DialogResult.OK) {
                if (open.CheckFileExists) {
                    profilepicturebox.Image = new Bitmap(open.FileName);

                    //rename file name and extention  of the image
                    string ext = Path.GetExtension(open.FileName);

                    //random value
                    Random random = new Random();
                    int ranint = random.Next(0,1000);

                    //custom image name
                    image = "BB_User_image_" + ranint + ext;

                    //save in a folder
                    string sourcepath = open.FileName;
                    //get the path of destination
                    string paths = Application.StartupPath.Substring(0,Application.StartupPath.Length-10);
                    //path to destination iamge folder
                    string destinationPath = paths + "\\Images\\" + image;
                    //copy image to desti path
                    File.Copy(sourcepath , destinationPath);
                    //display successfuk msg path
                    MessageBox.Show("Image Upload Successful.");
                    
                }
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //get user keywrds
            string keywords = txtsearch.Text;
            if (keywords != null) {
                //display user for keyword
                DataTable dt = udt.Search(keywords);
                dgvuser.DataSource = dt;
            }
            else {
                //display all users
                DataTable dt = udt.Select();
                dgvuser.DataSource = dt;
            }
        }

       
    }
}
