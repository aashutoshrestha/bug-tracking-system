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
        


        //User Login
        public void LoginUser(String username,String password) 
        {
            
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
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    Debug.WriteLine("Logged in");
                    

                }
                else {
                    // home.setPasswordMessage("Username or password do not match");
                    //  home.Refresh();
                    Debug.WriteLine("Username and password do not match");
                    
                }

            }
            catch(Exception e)
            {
                Debug.WriteLine("Error Message: " + e);
                Debug.WriteLine(e.StackTrace);
            }
           
        }

       
    }
}
