using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp112.SBL;

namespace WindowsFormsApp112.Data
{
    class admindata
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region SELECT data from database
        public DataTable Select() {
            //create object to connect data base
            SqlConnection conn = new SqlConnection(myconnstrng);

            //here hold the data in this datatable

            DataTable dt = new DataTable();

            try {
                //sqlquerytogetdata
                string sql = "SELECT * FROM Table_admins";
                //sqlcomand
                SqlCommand cmd = new SqlCommand(sql, conn);
                //adaptertoholdDataFromDataBaseTempo
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //databaseConnection open
                conn.Open();

                //transferDataFrom data adapter to table
                adapter.Fill(dt);
            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            finally {
                conn.Close();
            }
            return dt;
        }
        #endregion

        #region insert data into database
        public bool Insert(admin u) {
            //need a default for bool
            bool isSuccess = false;
            //object for sqlconnection

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sqlqueryto insert
                //user id auto increment so dont need to show here
                //use @ to pass the value from user class we can also use txtusername by creating class object
                string sql = "INSERT INTO Table_admins(admin_name,admin_mail,admin_pass," +
                    "admin_fname,admin_contact,admin_address,added_date,image) VALUES (@admin_name,@admin_mail,@admin_pass," +
                    "@admin_fname,@admin_contact,@admin_address,@added_date,@image)";
                //sqlcomand pass the value in query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //parameter to pass the get value from UI to query
                cmd.Parameters.AddWithValue("@admin_name", u.admin_name);
                cmd.Parameters.AddWithValue("@admin_mail", u.admin_mail);
                cmd.Parameters.AddWithValue("@admin_pass", u.admin_pass);
                cmd.Parameters.AddWithValue("@admin_fname", u.admin_fname);
                cmd.Parameters.AddWithValue("@admin_contact", u.admin_contact);
                cmd.Parameters.AddWithValue("@admin_address", u.admin_address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image", u.image);



                //databaseConnection open
                conn.Open();
                //create int to hold the value after the query is executed
                int rows = cmd.ExecuteNonQuery();

                //values of row > 0 if query is executed
                //else 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else {
                    isSuccess = false;
                }
            }

            catch (Exception ex)
            {      //display error if any exception error!
                MessageBox.Show(ex.Message);
            }

            finally
            {   //disconnected
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region update data
        public bool Delete(admin u) {

            //bool value set default ot false
            bool isSuccess = false;
            //object for connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //create string to hold query to delete
                string sql = "DELETE FROM Table_admins WHERE admin_id = @admin_id";

                //create sql comand to execute query and pass the value to sql query

                SqlCommand cmd = new SqlCommand(sql,conn);

                //pass the value to query to delete
                cmd.Parameters.AddWithValue("@admin_id", u.admin_id);

                conn.Open();

                //int vari to hold the values
                int rows = cmd.ExecuteNonQuery();

                //values of row > 0 if query is executed
                //else 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }

            catch (Exception ex)
            {      //display error if any exception error!
                MessageBox.Show(ex.Message);
            }

            finally
            {   //disconnected
                conn.Close();
            }

            return isSuccess;

        }
        #endregion

        #region delete data for user
        public bool Update(admin u)
        {

            //bool value set default ot false
            bool isSuccess = false;
            //object for connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //create string to hold query
                string sql = "Update Table_admins SET admin_name=@admin_name, admin_mail=@admin_mail, admin_pass=@admin_pass," +
                    "admin_fname=@admin_fname, admin_contact= @admin_contact, admin_address= @admin_address,added_date=@added_date,image=@image WHERE admin_id = @admin_id";

                //create sql comand to execute query and pass the value to sql query

                SqlCommand cmd = new SqlCommand(sql, conn);

                //pass the value to query
                cmd.Parameters.AddWithValue("@admin_id", u.admin_id);
                cmd.Parameters.AddWithValue("@admin_name", u.admin_name);
                cmd.Parameters.AddWithValue("@admin_mail", u.admin_mail);
                cmd.Parameters.AddWithValue("@admin_pass", u.admin_pass);
                cmd.Parameters.AddWithValue("@admin_fname", u.admin_fname);
                cmd.Parameters.AddWithValue("@admin_contact", u.admin_contact);
                cmd.Parameters.AddWithValue("@admin_address", u.admin_address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image", u.image);

                conn.Open();

                //int vari to hold the values
                int rows = cmd.ExecuteNonQuery();

                

                //values of row > 0 if query is executed
                //else 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }

            catch (Exception ex)
            {      //display error if any exception error!
                MessageBox.Show(ex.Message);
            }

            finally
            {   //disconnected
                conn.Close();
            }

            return isSuccess; //error will be fixed if it is successed

        }

        #endregion
        #region to search admin
        public DataTable Search(string keywords) {
            //sql connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            //create data table to hold data from db tempo
            DataTable dt = new DataTable();
            //to search user

            try
            {
                //user search query
                string sql = "SELECT * FROM Table_admins WHERE admin_id LIKE '%" + keywords + "%' OR admin_fname LIKE '%" + keywords + "%' OR admin_address LIKE'%" + keywords + "%'";
                //execute query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //data adaptor to get data frm db
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                //pass the data from adpter to dt
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally {
                //db close
                conn.Close();
            }
            return dt;

        }


        #endregion
        #region

        public admin Getuid(string admin_name)
        {
           admin u = new admin();

            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT admin_id FROM Table_admins WHERE admin_name='" + admin_name + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0) {
                    u.admin_id = int.Parse(dt.Rows[0]["admin_id"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally {
                conn.Close();
            }



            return u;

        }
         #endregion


    }

}
