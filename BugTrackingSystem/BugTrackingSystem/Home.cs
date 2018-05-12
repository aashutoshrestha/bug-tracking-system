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

            if (this.txtusername.Text!="") {

                if (flag == true)
                {

                    this.Hide();

                }
                else if (flag == false)
                {
                    this.txtpassworderror.Text = "Username or Password Do Not Match";
                    this.txtpassword.ForeColor = Color.Red;


                }
                else
                {
                    this.txtpassworderror.Text = "Username or Password Do Not Match";
                    this.txtpassword.ForeColor = Color.Red;


                }
            }
            else
            {
                this.txtusernameerror.Text = "Username cannot be empty";
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassworderror_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            this.txtpassword.ForeColor = Color.Black;
        }

        private void txtusernameerror_Click(object sender, EventArgs e)
        {

        }
    }
}
