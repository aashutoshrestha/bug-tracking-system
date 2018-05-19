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

        /// <summary>
        /// Populate project manager dashboard
        /// </summary>
        /// <param name="bug"></param>
        public void populatepmdashboard(BugModel bug)
        {
            try { 
            String sql = "select pro.project_name,com.component_name," +
                    "bug.summary,bug.version,bug.severity,bug.os,bug.class,bug.method,bug.linenofrom,bug.linenoto,bug.vcrurl," +
                    "bug.screenshot,bug.bugdesc,bug.code,bug.submittedby,bug.submitteddate,bug.status,bug.assignedto" +
                    " from tbl_project as pro" +
                    " inner join tbl_component as com on pro.project_id = com.project_id " +
                    "inner join tbl_bug as bug on com.component_id = bug.component_id " +
                    "where bug_id = @bug_id";

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

                bug.setProjectName(dTable.Rows[0][0].ToString());
                bug.setComponentName(dTable.Rows[0][1].ToString());
                bug.setVersion(dTable.Rows[0][3].ToString());
                bug.setSeverity(dTable.Rows[0][4].ToString());
                bug.setClass(dTable.Rows[0][6].ToString());
                bug.setMethod(dTable.Rows[0][7].ToString());
                bug.setlinenofrom(Convert.ToInt32(dTable.Rows[0][8].ToString()));
                bug.setlinenoto(Convert.ToInt32(dTable.Rows[0][9].ToString()));
                bug.setbugdesc(dTable.Rows[0][12].ToString());
                bug.setCode(dTable.Rows[0][13].ToString());
                bug.setVCURL(dTable.Rows[0][10].ToString());

                Debug.WriteLine("This is debug for pmdashboard");
                Debug.WriteLine(bug.getBUGID());
                Debug.WriteLine((dTable.Rows[0][13].ToString()));


                byte[] img =(byte[]) dTable.Rows[0][11];
                MemoryStream ms = new MemoryStream(img);
                bug.setImage(System.Drawing.Image.FromStream(ms));


                bug.setStatus(dTable.Rows[0][16].ToString());
                bug.setAssignedTo(dTable.Rows[0][17].ToString());



            }
            catch (Exception e)
            {
                Debug.WriteLine("Error Message: " + e);
                Debug.WriteLine(e.StackTrace);
            }





}
        
        public void populatedeveloperdashboard(BugModel bug)
        {
            
            
            try
            {
                String sql = "select pro.project_name,com.component_name," +
                        "bug.summary,bug.version,bug.severity,bug.os,bug.class,bug.method,bug.linenofrom,bug.linenoto,bug.vcrurl," +
                        "bug.screenshot,bug.bugdesc,bug.code,bug.submittedby,bug.submitteddate,bug.status,bug.assignedto" +
                        " from tbl_project as pro" +
                        " inner join tbl_component as com on pro.project_id = com.project_id " +
                        "inner join tbl_bug as bug on com.component_id = bug.component_id " +
                        "where bug_id = @bug_id";

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

                bug.dtable = dTable;
                bug.setProjectName(dTable.Rows[0][0].ToString());
                bug.setComponentName(dTable.Rows[0][1].ToString());
                bug.setVersion(dTable.Rows[0][3].ToString());
                bug.setSeverity(dTable.Rows[0][4].ToString());
               
                bug.setClass(dTable.Rows[0][6].ToString());
                bug.setMethod(dTable.Rows[0][7].ToString());
                bug.setlinenofrom(Convert.ToInt32(dTable.Rows[0][8].ToString()));
                bug.setlinenoto(Convert.ToInt32(dTable.Rows[0][9].ToString()));
                bug.setbugdesc(dTable.Rows[0][12].ToString());
                bug.setCode(dTable.Rows[0][13].ToString());
                bug.setVCURL(dTable.Rows[0][10].ToString());





                byte[] img = (byte[])dTable.Rows[0][11];
                MemoryStream ms = new MemoryStream(img);
                bug.setImage(System.Drawing.Image.FromStream(ms));


                bug.setStatus(dTable.Rows[0][16].ToString());
                bug.setAssignedTo(dTable.Rows[0][17].ToString());

               

            }
            catch (Exception e)
            {
                Debug.WriteLine("Error Message: " + e);
                Debug.WriteLine(e.StackTrace);
            }
            
            
        }



        /// <summary>
        /// Tester Dashboard Load
        /// </summary>
        /// <param name="bug"></param>
        public void populatetesterdashboard(BugModel bug)
        {


            try
            {
                String sql = "select pro.project_name,com.component_name," +
                        "bug.summary,bug.version,bug.severity,bug.os,bug.class,bug.method,bug.linenofrom,bug.linenoto,bug.vcrurl," +
                        "bug.screenshot,bug.bugdesc,bug.code,bug.submittedby,bug.submitteddate,bug.status,bug.assignedto" +
                        " from tbl_project as pro" +
                        " inner join tbl_component as com on pro.project_id = com.project_id " +
                        "inner join tbl_bug as bug on com.component_id = bug.component_id " +
                        "where bug_id = @bug_id";

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

                bug.dtable = dTable;
                bug.setProjectName(dTable.Rows[0][0].ToString());
                bug.setComponentName(dTable.Rows[0][1].ToString());
                bug.setVersion(dTable.Rows[0][3].ToString());
                bug.setSeverity(dTable.Rows[0][4].ToString());

                bug.setClass(dTable.Rows[0][6].ToString());
                bug.setMethod(dTable.Rows[0][7].ToString());
                bug.setlinenofrom(Convert.ToInt32(dTable.Rows[0][8].ToString()));
                bug.setlinenoto(Convert.ToInt32(dTable.Rows[0][9].ToString()));
                bug.setbugdesc(dTable.Rows[0][12].ToString());
                bug.setCode(dTable.Rows[0][13].ToString());
                bug.setVCURL(dTable.Rows[0][10].ToString());





                byte[] img = (byte[])dTable.Rows[0][11];
                MemoryStream ms = new MemoryStream(img);
                bug.setImage(System.Drawing.Image.FromStream(ms));


                bug.setStatus(dTable.Rows[0][16].ToString());
                bug.setAssignedTo(dTable.Rows[0][17].ToString());



            }
            catch (Exception e)
            {
                Debug.WriteLine("Error Message: " + e);
                Debug.WriteLine(e.StackTrace);
            }


        }



        /// <summary>
        /// //assign bug
        /// </summary>
        /// <param name="bug"></param>
        /// <returns> flag </returns>
        public bool AssignBug(BugModel bug)
        {
            bool flag = false;
            if (CheckUsername(bug.getAssignedTo())==false)
            {
                flag = false;
            }
            else
            {
                try { 
                String sql = "update tbl_bug set assignedto = @username, status='assigned' where bug_id = @bug_id";

                MySqlConnection conn = DBUtils.GetDBConnection();

                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = sql;

                // Add and set value for parameter.
                cmd.Parameters.AddWithValue("@username", bug.getAssignedTo());
                cmd.Parameters.AddWithValue("@bug_id", bug.getBUGID());

                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount>0)
                    {
                        MailService mail = new MailService();
                       flag =  mail.sendMail(bug.getAssignedTo());
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



        }



            return flag;
        }
       
        //check username if assign
        public bool CheckUsername(String username)
        {
            bool flag = false;
            try {
                String sql = "select * from tbl_user where username=@developerusername";

                MySqlConnection conn = DBUtils.GetDBConnection();

                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = sql;

                // Add and set value for parameter.
                cmd.Parameters.AddWithValue("@developerusername", username);
                MySqlDataReader component = cmd.ExecuteReader();
                if (component.Read())
                {
                    int forrole = component.GetOrdinal("role");
                   String role = component.GetString(forrole);
                    if (role == "developer")
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine("Error Message: " + e);
                Debug.WriteLine(e.StackTrace);
            }

            return flag;

        }


        /// <summary>
        /// Update Bug Information
        /// </summary>
        /// <param name="bug"></param>
        /// <returns></returns>

        public bool UpdateBug(BugModel bug)
        {
            bool flag = false;
            try
            {
                String sql = "update tbl_bug set code=@code, status=@status where bug_id = @bug_id";
                MySqlConnection conn = DBUtils.GetDBConnection();

                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = sql;

                // Add and set value for parameter.
                Debug.WriteLine("UpdateBUg Called");

                cmd.Parameters.AddWithValue("@code", bug.getCode());
                cmd.Parameters.AddWithValue("@status", bug.getStatus());
                cmd.Parameters.AddWithValue("@bug_id", bug.getBUGID());
                Debug.WriteLine(bug.getCode() + bug.getStatus()+ bug.getBUGID());
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    Debug.WriteLine("Updated");

                    flag = setHistory(bug);

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



        /// <summary>
        /// Get History for Audit
        /// </summary>
        /// <param name="bug"></param>
        public bool setHistory(BugModel bug)
        {

            bool flag = false;
            try {
                String sql = "INSERT INTO `tbl_history`( `bug_id`,`version`, `updatedate`, `updatedby`, `code`, `status`, `remarks`) " +
                    "VALUES (@bug_id,@version,@updatedate,@updatedby,@code,@status,@remarks)";
               
                MySqlConnection conn = DBUtils.GetDBConnection();

                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Parameters.AddWithValue("@bug_id", bug.getBUGID());
                cmd.Parameters.AddWithValue("@version", bug.getVersion());
                cmd.Parameters.AddWithValue("@updatedate", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"));
                cmd.Parameters.AddWithValue("@updatedby", bug.getUsername());
                cmd.Parameters.AddWithValue("@code", bug.getCode());
                cmd.Parameters.AddWithValue("@status", bug.getStatus());
                cmd.Parameters.AddWithValue("@remarks", bug.getRemarks());
                Debug.WriteLine("setHistory Called");
                cmd.Connection = conn;

                cmd.CommandText = sql;
                int rowCount = cmd.ExecuteNonQuery();

                if (rowCount > 0)
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


        /// <summary>
        /// Get History
        /// </summary>
        /// <param name="bug"></param>
        /// <returns></returns>
        public DataTable getHistory(BugModel bug)
        {
            DataTable historytable = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbl_history where bug_id=@bug_id ORDER BY updatedate LIMIT 1";
               
                MySqlConnection conn = DBUtils.GetDBConnection();

                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = sql;
                Debug.WriteLine("History Called"+ bug.getBUGID());
                // Add and set value for parameter.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                cmd.Parameters.AddWithValue("@bug_id", bug.getBUGID());
                MyAdapter.SelectCommand = cmd;

                
                MyAdapter.Fill(historytable);

            
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error Message: " + e);
                Debug.WriteLine(e.StackTrace);
            }
            return historytable;
        }


        /// <summary>
        /// Audit History Creator
        /// </summary>
        /// <returns></returns>

            public static DataTable getHistory(int bugid)
        {

            using (DataTable historytable = new DataTable())
            {
                try
                {
                    String sql = "SELECT * FROM tbl_history where bug_id=@bug_id";

                    MySqlConnection conn = DBUtils.GetDBConnection();

                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = conn;

                    cmd.CommandText = sql;

                    
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                    cmd.Parameters.AddWithValue("@bug_id", bugid);

                    Debug.WriteLine(bugid);
                    MyAdapter.SelectCommand = cmd;


                    MyAdapter.Fill(historytable);


                }
                catch (Exception e)
                {
                    Debug.WriteLine("Error Message: " + e);
                    Debug.WriteLine(e.StackTrace);
                }
                return historytable;
            }
        }

        /// <summary>
        /// View All Audit History
        /// </summary>
        /// <param name="updatedate"></param>
        /// <returns></returns>
        public static DataTable getAuditHistory(String updatedate)
        {
            using (DataTable historytable = new DataTable())
            {
                try
                {
                    String sql = "SELECT * FROM tbl_history where updatedate=@updatedate";

                    MySqlConnection conn = DBUtils.GetDBConnection();

                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = conn;

                    cmd.CommandText = sql;

                    DateTime enteredDate = DateTime.Parse(updatedate);
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                    cmd.Parameters.AddWithValue("@updatedate", enteredDate);

                    Debug.WriteLine(updatedate);
                    MyAdapter.SelectCommand = cmd;


                    MyAdapter.Fill(historytable);


                }
                catch (Exception e)
                {
                    Debug.WriteLine("Error Message: " + e);
                    Debug.WriteLine(e.StackTrace);
                }
                return historytable;
            }
        }

        public static DataTable getSearch(String searchtext)
        {
            using (DataTable historytable = new DataTable())
            {
                try
                {
                    String sql = "select bug_id as id, summary as Summary,submittedby from tbl_bug  " +
                        "where bugdesc LIKE '" +
                        "@searchtext1" +
                        "%' " +
                        "or bugdesc LIKE '%" +
                        "@searchtext2" +
                        "' " +
                        "or bugdesc Like '%" +
                        "@searchtext3" +
                        "%' " +

                        "or summary Like '%" +
                        "@searchtext4" +
                        "%' " +
                        "or summary Like '" +
                        "@searchtext5" +
                        "%' " +
                        "or summary Like '%" +
                        "@searchtext6" +
                        "'" +
                        "or class Like '@searchtext7'" +
                        "or method Like '@searchtext8'" +
                        "or code Like '%" +
                        "@searchtext9'" +
                        "or code Like '%" +
                        "@searchtext10" +
                        "%'" +
                        "or code Like '@searchtext11" +
                        "%";

                    MySqlConnection conn = DBUtils.GetDBConnection();
                    Debug.WriteLine(sql);
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = conn;

                    cmd.CommandText = sql;

                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                    cmd.Parameters.AddWithValue("@searchtext1", searchtext);
                    cmd.Parameters.AddWithValue("@searchtext2", searchtext);
                    cmd.Parameters.AddWithValue("@searchtext3", searchtext);
                    cmd.Parameters.AddWithValue("@searchtext4", searchtext);
                    cmd.Parameters.AddWithValue("@searchtext5", searchtext);
                    cmd.Parameters.AddWithValue("@searchtext6", searchtext);
                    cmd.Parameters.AddWithValue("@searchtext7", searchtext);
                    cmd.Parameters.AddWithValue("@searchtext8", searchtext);
                    cmd.Parameters.AddWithValue("@searchtext9", searchtext);
                    cmd.Parameters.AddWithValue("@searchtext10", searchtext);
                    cmd.Parameters.AddWithValue("@searchtext11", searchtext);


                    Debug.WriteLine(searchtext);
                    MyAdapter.SelectCommand = cmd;


                    MyAdapter.Fill(historytable);


                }
                catch (Exception e)
                {
                    Debug.WriteLine("Error Message: " + e);
                    Debug.WriteLine(e.StackTrace);
                }
                return historytable;
            }
        }

       
    }
}
