using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem
{
    public partial class Home : Form
    {

        UserController usercontroller = new UserController();
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
            this.usernamemessage = getUsernameMessage();
            this.passwordmessage = getPasswordMessage();
           
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            

        }

        //username
        private String username;
        public void setUsername(String username)
        {
            this.username = username;
        }

        public String getUsername()
        {
            return username;
        }


        //password
        private String password;
        public void setPassword(String password)
        {
            this.password = password;
        }

        public String getPassword()
        {
            return password;
        }


        //usernamemesasge
        private String usernamemessage;
        public void setUsernameMessage(String usernameMessage)
        {
            this.usernamemessage = usernameMessage;
        }

        public String getUsernameMessage()
        {
            return usernamemessage;
        }



        //passowrdmessage
        private String passwordmessage;
        public void setPasswordMessage(String passwordmessage)
        {
            this.passwordmessage = passwordmessage;
        }

        public String getPasswordMessage()
        {
            return passwordmessage;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            



        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            setUsername(this.txtusername.Text);
            setPassword(this.txtpassword.Text);
            bool flag = usercontroller.LoginUser(getUsername(), getPassword());
            if (flag == true)
            {

                this.Hide();

            }
            else
            {
                this.setPasswordMessage("Username and Password do not match");
                this.Refresh();
            }
        }
    }
}
