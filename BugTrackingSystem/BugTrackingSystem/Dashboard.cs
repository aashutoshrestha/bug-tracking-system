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
    public partial class Dashboard : Form
    {

        private String sessionusername;

        public void setSessionUsername(String username)
        {
            this.sessionusername = username;
        }
        public String getUsername()
        {
            return sessionusername;
        }
        private String profileimagelocation;

        public void setProfileimagelocation(String profileimagelocation)
        {
            this.profileimagelocation = profileimagelocation;
        }
        public String getProfileImageLocation()
        {
            return profileimagelocation;
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            logout.SizeMode = PictureBoxSizeMode.StretchImage;
            profileimg.SizeMode = PictureBoxSizeMode.StretchImage;
            profileimg.ImageLocation = @getProfileImageLocation();
        }

        private void lblsessionusername_Click(object sender, EventArgs e)
        {

        }

        private void lblaccountinfo_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void panelDashboard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
