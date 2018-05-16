using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BugTrackingSystem
{
    class UserController
    {


        private String sessionusername;




        //User Login
        public bool LoginUser(String username,String password) 
        {
            bool flag=false;
            try
            {
                //query to check if username and password exists
                String sql = "select * from tbl_user where username=@username and password=@password";

                MySqlConnection conn = DBUtils.GetDBConnection();

                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;
            
                cmd.CommandText = sql;

                // Add and set value for parameter.
                cmd.Parameters.AddWithValue("@username", username);
                
                cmd.Parameters.AddWithValue("@password", password);



                MySqlDataReader login = cmd.ExecuteReader();
                

                if (login.Read())
                {
                    sessionusername = username;
                    int location = login.GetOrdinal("pplocation");
                    int role = login.GetOrdinal("role");

                    //Open Project Manager Dashboard
                    if (login.GetString(role)=="projectmanager")
                    {
                        populatePMDashboard();
                        flag = true;
                        
                       
                    }
                    else if (login.GetString(role)=="developer")
                    {
                        DeveloperDashboard ddashboard = new DeveloperDashboard();
                        flag = true;
                        ddashboard.Show();
                       
                    }
                    else if (login.GetString(role) == "tester")
                    {
                        TesterDashboard tdashboard = new TesterDashboard();
                        flag = true;
                        tdashboard.sessionusername = username;
                        tdashboard.Show();

                    }

                }
                else {
                    // home.setPasswordMessage("Username or password do not match");
                    //  home.Refresh();
                    Debug.WriteLine("Username and password do not match");
                    flag = false;
                }

            }
            catch(Exception e)
            {
                Debug.WriteLine("Error Message: " + e);
                Debug.WriteLine(e.StackTrace);
            }
            return flag;
        }



        //populate project manager dashboard
        public void populatePMDashboard()
        {
            try
            {
                String sql = "select bug_id as id, summary as Summary,submittedby from tbl_bug";

                MySqlConnection conn = DBUtils.GetDBConnection();

                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = sql;

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = cmd;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                ProjectManagerDashboard pmdashboard = new ProjectManagerDashboard();
                pmdashboard.dtable = dTable;

                pmdashboard.Show();
                Debug.WriteLine("Logged in");

            }
            catch (Exception e)
            {
                Debug.WriteLine("Error Message: " + e);
                Debug.WriteLine(e.StackTrace);
            }
        }
    }

}
