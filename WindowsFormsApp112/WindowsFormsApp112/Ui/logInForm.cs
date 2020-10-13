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
    public partial class logInForm : Form
    {
        public logInForm()
        {
            InitializeComponent();
        }

        login l = new login();
        logindata ld = new logindata();

        //save the user name
        public static string loggeduser;

        private void pictureBoxclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logInForm_Load(object sender, EventArgs e)
        {

        }

        private void btnlog_Click(object sender, EventArgs e)
        {


            l.admin_name = txtun.Text;
            l.admin_pass = txtpass.Text;

            bool isSuccess = ld.logincheck(l);

            if (isSuccess == true)
            {
                MessageBox.Show("Login Successful");

                //save user
                loggeduser = l.admin_name;
                homepage home = new homepage();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed!Try Again.");
            }


        }

        private void lbun_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
