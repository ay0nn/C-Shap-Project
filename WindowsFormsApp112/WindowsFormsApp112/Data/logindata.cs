using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp112.classes;

namespace WindowsFormsApp112.Data
{
    class logindata
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public bool logincheck(login l) {

            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try {
                string sql = "SELECT * FROM Table_admins WHERE admin_name=@admin_name AND admin_pass=@admin_pass";
          
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@admin_name", l.admin_name);
                cmd.Parameters.AddWithValue("@admin_pass", l.admin_pass);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    isSuccess = true;
                }
                else {
                    isSuccess = false;
                }

            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                conn.Close();
            }


            return isSuccess;

        }

    }
}
