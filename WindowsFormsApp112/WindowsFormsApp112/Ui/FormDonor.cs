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
using WindowsFormsApp112.classes;
using WindowsFormsApp112.Data;
using WindowsFormsApp112.SBL;

namespace WindowsFormsApp112.Ui
{
    public partial class FormDonor : Form
    {
        public FormDonor()
        {
            InitializeComponent();
        }
        Donor d = new Donor();
        donordata dal = new donordata();
        admindata us = new admindata();

        string image = "no-image.jpg";

        private void FormDonor_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvdonor.DataSource = dt;
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            string imagePath = paths + "\\Images\\no-image.jpg";

            profilepicturebox.Image = new Bitmap(imagePath);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            admin ul = us.Getuid(loggeduser);
            d.Added_By = ul.admin_id; //logged in user
            d.Image = image;

            bool success = dal.Insert(d);


            //check whether data inserted or not

            if (success == true)
            {
                MessageBox.Show("New Donor Successfully Added.");
                //display in data grid view
                DataTable dt = dal.Select();
                dgvdonor.DataSource = dt;
                //clear text box
                clear();
            }
            else
            {
                MessageBox.Show("Failed To Add New User!");
            }

        }

        public void clear() {

            txtdid.Text = "";
            txtfname.Text = "";
            txtlastname.Text = "";
            txtage.Text = "";
            dtpld.Value= DateTime.Now;
            txtemail.Text = "";
            cbgender.Text = "";
            cbbg.Text = "";
            txtucontactdonor.Text = "";
            txtaddressdonor.Text = "";
           
            //clearing image
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            string imagePath = paths + "\\Images\\no-image.jpg";

            profilepicturebox.Image = new Bitmap(imagePath);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            d.Donor_Id = int.Parse(txtdid.Text);
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
            
            string loggeduser = logInForm.loggeduser;
            admin ul = us.Getuid(loggeduser);
            d.Added_By = ul.admin_id; //logged in userd.added_by = 1; //logged in user
            d.Image = image;
            //varialbe to check data is updated or not
            bool success = dal.Update(d);

            if (success == true)
            {
                MessageBox.Show("Successfully Updated User");
                DataTable dt = dal.Select();
                dgvdonor.DataSource = dt;

                clear();
            }

            else {
                MessageBox.Show("Successfully Updated User");
                clear();
            }

        }

        private void dgvdonor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtdid.Text = dgvdonor.Rows[RowIndex].Cells[0].Value.ToString();
           txtfname.Text = dgvdonor.Rows[RowIndex].Cells[1].Value.ToString();
           txtlastname.Text = dgvdonor.Rows[RowIndex].Cells[2].Value.ToString();
            cbbg.Text = dgvdonor.Rows[RowIndex].Cells[3].Value.ToString();
            txtage.Text = dgvdonor.Rows[RowIndex].Cells[4].Value.ToString();
            dtpld.Text = dgvdonor.Rows[RowIndex].Cells[5].Value.ToString();
            cbgender.Text = dgvdonor.Rows[RowIndex].Cells[6].Value.ToString();
            txtucontactdonor.Text = dgvdonor.Rows[RowIndex].Cells[7].Value.ToString();
            txtemail.Text = dgvdonor.Rows[RowIndex].Cells[8].Value.ToString();
            txtaddressdonor.Text = dgvdonor.Rows[RowIndex].Cells[9].Value.ToString();

         
           

            image = dgvdonor.Rows[RowIndex].Cells[11].Value.ToString();

            //display selected user
            //get image path
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            if (image != "no-image.jpg")
            {
                //path to destination
                string imagePath = paths + "\\Images\\" + image;
                profilepicturebox.Image = new Bitmap(imagePath);
            }
            else
            {
                string imagePath = paths + "\\Images\\no-image.jpg";

                profilepicturebox.Image = new Bitmap(imagePath);
            }
        }

        private void btndetele_Click(object sender, EventArgs e)
        {
            d.Donor_Id = int.Parse(txtdid.Text);

            bool success = dal.Delete(d);

            if (success == true)
            {
                MessageBox.Show("Donor Deleted!");
                DataTable dt = dal.Select();
                dgvdonor.DataSource = dt;

                clear();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnselim_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            //specific file format
            open.Filter = "Image files( *.jpg;*.jpeg,*.png;*.PNG,*.gif;)|*.jpg;*.jpeg,*.png;*.PNG,*.gif;";
            //check file is slected/not
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    profilepicturebox.Image = new Bitmap(open.FileName);

                    //rename file name and extention  of the image
                    string ext = Path.GetExtension(open.FileName);

                    //random value
                    Random random = new Random();
                    int ranint = random.Next(0, 1000);

                    //custom image name
                    image = "BB_User_image_" + ranint + ext;

                    //save in a folder
                    string sourcepath = open.FileName;
                    //get the path of destination
                    string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                    //path to destination iamge folder
                    string destinationPath = paths + "\\Images\\" + image;
                    //copy image to desti path
                    File.Copy(sourcepath, destinationPath);
                    //display successfuk msg path
                    MessageBox.Show("Image Upload Successful.");

                }
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtsearch.Text;
            if (keywords != null)
            {
                //display user for keyword
                DataTable dt = dal.Search(keywords);
                dgvdonor.DataSource = dt;
            }
            else
            {
                //display all users
                DataTable dt = dal.Select();
                dgvdonor.DataSource = dt;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
