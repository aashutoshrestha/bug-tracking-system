using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem
{
    class BugController
    {
        bool flag = false;
        private System.Collections.ArrayList componentlist;
        private System.Collections.ArrayList projectlist;


        public BugController()
        {
            componentlist = new System.Collections.ArrayList();
            projectlist = new System.Collections.ArrayList();
        }

       public String submittedby;
       


        //report bug
        public bool ReportBug(BugModel bug)
        {
            Bitmap img = new Bitmap(bug.getImageLocation());
            var image = imageToByte(img);
            try
            {
                //query to insert bug report to the database

                MySqlConnection conn = DBUtils.GetDBConnection();

                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                String sql = "INSERT INTO `tbl_bug`( `component_id`, `summary`, `version`, `severity`, `os`," +
                    " `class`, `method`, `linenofrom`, `linenoto`, " +
                    "`vcrurl`, `screenshot`, `bugdesc`, `code`,`submittedby`,`submitteddate`) VALUES (@component_id,@summary,@version,@severity,@os,@class,@method," +
                    "@linenofrom,@linenoto,@vcrurl,@screenshot,@bugdesc,@code,@submittedby,@submitteddate)";


                //adding values to the parameters
                cmd.Parameters.AddWithValue("@component_id", bug.getComponentID());
                cmd.Parameters.AddWithValue("@summary", bug.getSummary());
                cmd.Parameters.AddWithValue("@version", bug.getVersion());
                cmd.Parameters.AddWithValue("@severity", bug.getSeverity());
                cmd.Parameters.AddWithValue("@os", bug.getOS());
                cmd.Parameters.AddWithValue("@class", bug.getClass());
                cmd.Parameters.AddWithValue("@method", bug.getMethod());
                cmd.Parameters.AddWithValue("@linenofrom", bug.getlinenofrom());
                cmd.Parameters.AddWithValue("@linenoto", bug.getlinenoto());
                cmd.Parameters.AddWithValue("@vcrurl", bug.getVCURL());

                //getting image
                var paramUserImage = new MySqlParameter("@screenshot", MySqlDbType.Blob, image.Length);
                paramUserImage.Value = image;

                cmd.Parameters.Add(paramUserImage);

                cmd.Parameters.AddWithValue("@bugdesc", bug.getbugdesc());
                cmd.Parameters.AddWithValue("@code", bug.getCode());
                cmd.Parameters.AddWithValue("@submittedby", submittedby);
                cmd.Parameters.AddWithValue("@submitteddate", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"));

                cmd.Connection = conn;

                cmd.CommandText = sql;
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount >= 1)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error Message: " + e);
                Debug.WriteLine(e.StackTrace);
            }

            return flag;
        }




        //populate product list
        public System.Collections.ArrayList PopulateProject()
        {
            try
            {
                //query to select component id
                String sql = "select * from tbl_project";

                MySqlConnection conn = DBUtils.GetDBConnection();

                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = sql;

               
                
                MySqlDataReader project = cmd.ExecuteReader();
                while (project.Read())
                {
                    int project_name = project.GetOrdinal("project_name");
                    projectlist.Add(project.GetString(project_name));
                    Debug.WriteLine(project.GetString(project_name));
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine("Error Message: " + e);
                Debug.WriteLine(e.StackTrace);
            }
            return projectlist;
        }


        //popolate component list
        public System.Collections.ArrayList PopulateComponent(String project_name)
        {

            int project_id = getProjectID(project_name);
            Debug.WriteLine("This IS Debug Message"+project_id + project_name);

            try
            {
                //query to select component id
                String sql = "select * from tbl_component where project_id=@project_id";

                MySqlConnection conn = DBUtils.GetDBConnection();

                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = sql;

                // Add and set value for parameter.
                cmd.Parameters.AddWithValue("@project_id", project_id);
                MySqlDataReader component = cmd.ExecuteReader();
               while(component.Read())
                {
                    int component_name = component.GetOrdinal("component_name");
                    componentlist.Add(component.GetString(component_name));
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine("Error Message: " + e);
                Debug.WriteLine(e.StackTrace);
            }
            return componentlist;
        }


        //get component id
        public int getComponentID(String component_name)
        {
            int componentid = 0;
            try
            {
                
                //query to select component id
                String sql = "select * from tbl_component where component_name=@component_name";

                MySqlConnection conn = DBUtils.GetDBConnection();

                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = sql;

                // Add and set value for parameter.
                cmd.Parameters.AddWithValue("@component_name", component_name);
                MySqlDataReader component = cmd.ExecuteReader();
                if (component.Read())
                {
                    int component_id = component.GetOrdinal("component_id");
                    componentid = component.GetInt32(component_id);
                }
                
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error Message: " + e);
                Debug.WriteLine(e.StackTrace);
            }
            return componentid;
        }



        //get project id
        public int getProjectID(String project_name)
        {
            int projectid=0;
            try
            {

                //query to select component id
                String sql = "select * from tbl_project where project_name=@project_name";

                MySqlConnection conn = DBUtils.GetDBConnection();

                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = sql;

                // Add and set value for parameter.
                cmd.Parameters.AddWithValue("@project_name", project_name);
                MySqlDataReader component = cmd.ExecuteReader();
                if (component.Read())
                {
                    int project_id = component.GetOrdinal("project_id");
                    projectid = component.GetInt32(project_id);
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine("Error Message: " + e);
                Debug.WriteLine(e.StackTrace);
            }
            return projectid;
        }


        //Image to byte convert
        public byte[] imageToByte(Bitmap img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }


        public void populatepmdashboard(BugModel bug)
        {
            try { 
            String sql = "select * from tbl_bug where bug_id=@bug_id";

            MySqlConnection conn = DBUtils.GetDBConnection();

            conn.Open();

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = conn;

            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@bug_id", bug.getBUGID());
           
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = cmd;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                bug.setbugdesc(dTable.Rows[0][12].ToString());
                bug.setCode(dTable.Rows[0][13].ToString());

                Debug.WriteLine("This is debug for pmdashboard");
                Debug.WriteLine(bug.getBUGID());
                Debug.WriteLine((dTable.Rows[0][13].ToString()));


                byte[] img =(byte[]) dTable.Rows[0][11];
                MemoryStream ms = new MemoryStream(img);
                bug.setImage(System.Drawing.Image.FromStream(ms));

                bug.setStatus(dTable.Rows[0][16].ToString());
                



            }
            catch (Exception e)
            {
                Debug.WriteLine("Error Message: " + e);
                Debug.WriteLine(e.StackTrace);
            }



}

       
    }
}
