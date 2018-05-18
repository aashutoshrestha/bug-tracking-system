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
        private Image imgnew;
        private String sessionusername;
        BugModel bug = new BugModel();


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




        /// <summary>
        /// populate data in dridview
        /// </summary>
        public void PopulateDataGridPMDashboard()
        {
            PopulateDashboardItems();
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



        /// <summary>
        ///populate dashboard
        /// </summary>


        public void PopulateDashboardItems()
        {
            
            bug.setBugID(bugid);
            BugController bc = new BugController();
            bc.populatepmdashboard(bug);
            this.richsourcecode.Text = bug.getCode();
            this.richbugdesc.Text = bug.getbugdesc();
            this.imgscreenshot.Image = bug.GetImage();
            this.txtclassname.Text = bug.getClass();
            this.txtcomponent.Text = bug.getComponentName();
            this.txtproject.Text = bug.getProjectName();
            this.txtmethodname.Text = bug.getMethod();
            this.txtlinefrom.Text = bug.getlinenofrom().ToString();
            this.txtlineto.Text = bug.getlinenoto().ToString();
            this.lblbugstatus.Text = bug.getStatus();
            imgnew = bug.GetImage();


            //setting bug image
            if (bug.getSeverity() == "Critical")
            {
                this.imgbugseverity.Image = Properties.Resources.bugred;
            }
            else if (bug.getSeverity() == "Low")
            {
                this.imgbugseverity.Image = Properties.Resources.buggreen;
                
            }

            //enabling disabling assign bug feature
            if(bug.getAssignedTo() != "")
            {
                this.txtdeveloperusername.ReadOnly = true;
                this.txtdeveloperusername.Text = bug.getAssignedTo();
                this.btnassignbug.Enabled = false;
            }
            else
            {
                this.txtdeveloperusername.ReadOnly = false;
                this.btnassignbug.Enabled = true;
            }

        }

        //on table item clicked
        private void datagridviewpmdashboard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedrow = datagridviewpmdashboard.Rows[index];
            bugid = Convert.ToInt32(selectedrow.Cells[0].Value.ToString());

            PopulateDashboardItems();
        }

        //showing image in a new form
        private void imgscreenshot_Click(object sender, EventArgs e)
        {
            ImageForm img = new ImageForm();
            img.loadImage(imgnew);
            img.Show();
        }

        private void btnassignbug_Click(object sender, EventArgs e)
        {
            BugModel bug = new BugModel();
            bug.setAssignedTo(this.txtdeveloperusername.Text);
            bug.setBugID(bugid);

            BugController bc = new BugController();
            if (bc.AssignBug(bug)==false)
            {
                MessageBox.Show("Sorry, Bug cannot be assigned to this user. Either Check the privilage or if the user exists.", "Assign Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Bug has been assigned and the developer has been notified");
            }



        }
    }
}
