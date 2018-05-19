using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BugTrackingSystem
{
    
    
    class MailService
    {
        private String emailaddress;
        public bool sendMail(String assignedto)
        {
            bool flag = true;
            try
            {
                String sql = "select email from tbl_user where username=@username";

                MySqlConnection conn = DBUtils.GetDBConnection();

                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = sql;

                // Add and set value for parameter.
                cmd.Parameters.AddWithValue("@username", assignedto);

                MySqlDataReader login = cmd.ExecuteReader();

                if (login.Read())
                {
                    
                    int email = login.GetOrdinal("email");
                    emailaddress = login.GetString(email);

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("notification@bugtrackingsystem.com");
                    mail.To.Add(emailaddress);
                    mail.Subject = "You have been assigned a bug";
                    mail.Body = "Dear User You have been assigned a bug, please login to BugTrackingSystem to view more";

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("Officialsoftapps@gmail.com", "shrestha1");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("User Has been Succesfully Notified");
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return flag;
        }
    }
}
