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
using WindowsFormsApp112.classes;

namespace WindowsFormsApp112.Data
{
    class donordata
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region SELECT data from database
        public DataTable Select()
        {
            //create object to connect data base
            SqlConnection conn = new SqlConnection(myconnstrng);

            //here hold the data in this datatable

            DataTable dt = new DataTable();

            try
            {
                //sqlquerytogetdata
                string sql = "SELECT * FROM Table_donor";
                //sqlcomand to execute the query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //adaptertoholdDataFromDataBaseTempo
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //db Connection open
                conn.Open();

                //transferDataFrom data adapter to table
                adapter.Fill(dt);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion

        #region insert data into database
        public bool Insert(Donor d)
        {
            //need a default for bool
            bool isSuccess = false;
            //object for sqlconnection

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sqlqueryto insert
                //user id auto increment so dont need to show here
                //use @ to pass the value from user class we can also use txtusername by creating class object
                string sql = "INSERT INTO Table_donor(First_Name,Last_Name,Blood_Group,Age,Last_Donated," +
                    "Gender,Contact,Email,Address,Added_Date,Image,Added_By) VALUES (@First_Name,@Last_Name,@Blood_Group,@Age,@Last_Donated," +
                    "@Gender,@Contact,@Email,@Address,@Added_Date,@Image,@Added_By)";
                //sqlcomand pass the value in query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //parameter to pass the get value from UI to query
                cmd.Parameters.AddWithValue("@First_Name", d.First_Name);
                cmd.Parameters.AddWithValue("@Last_Name", d.Last_Name);
                cmd.Parameters.AddWithValue("@Blood_Group", d.Blood_Group);
                cmd.Parameters.AddWithValue("@Age", d.Age);
                cmd.Parameters.AddWithValue("@Last_Donated",d.Last_Donated);
                cmd.Parameters.AddWithValue("@Gender",d.Gender);
                cmd.Parameters.AddWithValue("@Contact",d.Contact);
                cmd.Parameters.AddWithValue("@Email", d.Email);
                cmd.Parameters.AddWithValue("@Address", d.Address);
                cmd.Parameters.AddWithValue("@Added_Date", d.Added_Date);
                cmd.Parameters.AddWithValue("@Image", d.Image);
                cmd.Parameters.AddWithValue("@Added_By", d.Added_By);



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
        #region delete data
        public bool Delete(Donor d)
        {

            //bool value set default ot false
            bool isSuccess = false;
            //object for connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //create string to hold query to delete
                string sql = "DELETE FROM Table_donor WHERE Donor_Id = @Donor_Id";

                //create sql comand to execute query and pass the value to sql query

                SqlCommand cmd = new SqlCommand(sql, conn);

                //pass the value to query to delete
                cmd.Parameters.AddWithValue("@Donor_Id", d.Donor_Id);

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

        #region update data for user
        public bool Update(Donor d)
        {

            //bool value set default ot false
            bool isSuccess = false;
            //object for connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //create string to hold query
                string sql = "Update Table_donor SET First_Name=@First_Name, Last_Name=@Last_Name,Blood_Group=@Blood_Group,Age=@Age,Last_Donated=@Last_Donated," +
                    "Gender= @Gender,Contact=@Contact,Email=@Email,Address= @Address,Image=@Image,Added_By=@Added_By WHERE Donor_Id = @Donor_Id";

                //create sql comand to execute query and pass the value to sql query

                SqlCommand cmd = new SqlCommand(sql, conn);

                //pass the value to query
                cmd.Parameters.AddWithValue("@First_Name", d.First_Name);
                cmd.Parameters.AddWithValue("@Last_Name", d.Last_Name);
                cmd.Parameters.AddWithValue("@Blood_Group", d.Blood_Group);
                cmd.Parameters.AddWithValue("@Age", d.Age);
                cmd.Parameters.AddWithValue("@Last_Donated", d.Last_Donated);
                cmd.Parameters.AddWithValue("@Gender", d.Gender);
                cmd.Parameters.AddWithValue("@Contact", d.Contact);
                cmd.Parameters.AddWithValue("@Email", d.Email);
                cmd.Parameters.AddWithValue("@Address", d.Address);
                cmd.Parameters.AddWithValue("@Added_Date", d.Added_Date);
                cmd.Parameters.AddWithValue("@Image", d.Image);
                cmd.Parameters.AddWithValue("@Added_By", d.Added_By);
                cmd.Parameters.AddWithValue("@Donor_Id", d.Donor_Id);
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
        #region to search donor
        public DataTable Search(string keywords)
        {
            //sql connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            //create data table to hold data from db tempo
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Table_donor WHERE donor_id LIKE '%" + keywords + "%' " +
                    "OR First_Name LIKE '%" + keywords + "%'" +
                    " OR  Last_Name LIKE '%" + keywords + "%' " +
                    "OR Email LIKE'%" + keywords + "%'OR Blood_Group LIKE '%" + keywords + "%'";
                //execute query
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                //transfer data to datatable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return dt;

        }


        #endregion

        #region count donor
        public string countdonor(string Blood_Group) {
            //sql connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            string donors = "0";

            try
            {
                //user search query
                string sql = "SELECT * FROM Table_donor WHERE Blood_Group = '"+Blood_Group+"'"; 
                SqlCommand cmd = new SqlCommand(sql, conn);
                //data adaptor to get data frm db
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                DataTable dt = new DataTable();

                //pass the data from adpter to dt
                adapter.Fill(dt);

                donors = dt.Rows.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                //db close
                conn.Close();
            }
            return donors;
        }

        #endregion

    }

}
