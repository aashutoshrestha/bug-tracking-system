using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem
{
    public partial class ProjectManagerDashboard : Form
    {
        public DataTable dtable;
        private int bugid;

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

        public ProjectManagerDashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            logout.SizeMode = PictureBoxSizeMode.StretchImage;
            imgscreenshot.SizeMode = PictureBoxSizeMode.StretchImage;
            imgbugseverity.SizeMode = PictureBoxSizeMode.StretchImage;
            PopulateDataGridPMDashboard();


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

        public void PopulateDataGridPMDashboard()
        {
            datagridviewpmdashboard.DataSource = dtable;
            foreach (DataGridViewRow row in datagridviewpmdashboard.Rows)
            {
                row.Height = 50;
               
            }
            foreach (DataGridViewColumn col in datagridviewpmdashboard.Columns)
            {
                col.Width = 110;
                
            }

            for (int i = 0; i < datagridviewpmdashboard.ColumnCount; i++)
            {
                datagridviewpmdashboard.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                datagridviewpmdashboard.AutoResizeColumns();
                datagridviewpmdashboard.Columns[i].DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 8F, FontStyle.Bold);
            }


        }

     

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void datagridviewpmdashboard_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bugid = Convert.ToInt32(datagridviewpmdashboard.Rows[e.RowIndex].Cells[0].Value.ToString());
            PopulateDashboardItems();


        }

        public void PopulateDashboardItems()
        {
            BugModel bug = new BugModel();
            bug.setBugID(bugid);
            BugController bc = new BugController();
            bc.populatepmdashboard(bug);
            this.richsourcecode.Text = bug.getCode();
            this.richbugdesc.Text = bug.getbugdesc();
            this.imgscreenshot.Image = bug.GetImage();
            if (bug.getStatus() == "unresolved")
            {
                this.imgbugseverity.Image = Properties.Resources.bugred;
            }
            else if (bug.getStatus() == "resolved")
            {
                this.imgbugseverity.Image = Properties.Resources.buggreen;
            }

        }

        private void datagridviewpmdashboard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedrow = datagridviewpmdashboard.Rows[index];
            bugid = Convert.ToInt32(selectedrow.Cells[0].Value.ToString());

            PopulateDashboardItems();
        }
    }
}
