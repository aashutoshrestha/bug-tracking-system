using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public DataTable dtable,historytable;
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
            this.lblusername.Text = sessionusername;

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
            historytable = bc.getHistory(bug);

            if (historytable != null && historytable.Rows.Count > 0) {
                this.lbllastupdatedby.Text = historytable.Rows[0][4].ToString();
                this.lbllastupdateon.Text = historytable.Rows[0][3].ToString();
                this.richremarks.Text = historytable.Rows[0][7].ToString();

            }
            else
            {
                this.lbllastupdatedby.Text = "Unkown";
                this.lbllastupdateon.Text = "Unknown";
                this.richremarks.Text = "";
            }
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
            this.lblversion.Text = bug.getVersion();
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
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedrow = datagridviewpmdashboard.Rows[index];
                bugid = Convert.ToInt32(selectedrow.Cells[0].Value.ToString());

                PopulateDashboardItems();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }

        }

        //showing image in a new form
        private void imgscreenshot_Click(object sender, EventArgs e)
        {
            ImageForm img = new ImageForm();
            img.loadImage(imgnew);
            img.Show();
        }

        private void lbllastupdateon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lbllastupdateon.Text == "Unknown")
            {
                MessageBox.Show("No History found");
            }
            else
            {
                HistoryAudit historyAudit = new HistoryAudit();
                historyAudit.updatedate = lbllastupdateon.Text;
                historyAudit.bugid = bug.getBUGID();
                historyAudit.Show();
            }
        }

        public void getAuditHistory()
        {
            if (lbllastupdateon.Text == "Unknown")
            {
                MessageBox.Show("No History found");
            }
            else
            {
                HistoryAudit historyAudit = new HistoryAudit();
                historyAudit.updatedate = lbllastupdateon.Text;
                historyAudit.Show();
            }
        }

        private void lbllastupdatedby_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            getAuditHistory();
        }

        private void btnopenide_Click(object sender, EventArgs e)
        {
            SourceCodeEditor sourceCode = new SourceCodeEditor(this.richsourcecode.Text);
            sourceCode.Show();
        }


        /// <summary>
        /// Search 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsearchbug_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable searchhistory = new DataTable();
                String searchfor;
                String search;
                searchfor = this.cmbsearchfor.GetItemText(this.cmbsearchfor.SelectedItem);
                switch (searchfor)
                {
                   
                    case "summary":
                        search = "summary";
                        searchhistory = BugController.getSearch(search, this.txtsearchbug.Text);
                        dtable = searchhistory;
                        Debug.WriteLine("Search query found" + searchhistory.Rows[0][2].ToString());
                        PopulateDataGridPMDashboard();
                        this.Refresh();
                        break;
                    case "bug description":
                        search = "bugdesc";
                        searchhistory = BugController.getSearch(search, this.txtsearchbug.Text);
                        dtable = searchhistory;
                        Debug.WriteLine("Search query found" + searchhistory.Rows[0][2].ToString());
                        PopulateDataGridPMDashboard();
                        this.Refresh();
                        break;
                    case "code":
                        search = "code";
                        searchhistory = BugController.getSearch(search, this.txtsearchbug.Text);
                        dtable = searchhistory;
                        Debug.WriteLine("Search query found" + searchhistory.Rows[0][2].ToString());
                        PopulateDataGridPMDashboard();
                        this.Refresh();
                        break;
                    case "class":
                        search = "class";
                        searchhistory = BugController.getSearch(search, this.txtsearchbug.Text);
                        dtable = searchhistory;
                        Debug.WriteLine("Search query found" + searchhistory.Rows[0][2].ToString());
                        PopulateDataGridPMDashboard();
                        this.Refresh();
                        break;
                    case "method":
                        search = "method";
                        searchhistory = BugController.getSearch(search, this.txtsearchbug.Text);
                        dtable = searchhistory;
                        Debug.WriteLine("Search query found" + searchhistory.Rows[0][2].ToString());
                        PopulateDataGridPMDashboard();
                        this.Refresh();
                        break;
                    default:
                        MessageBox.Show("Please select a search criteria");
                        break;

                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Data Found");
                Debug.WriteLine(ex);
            }

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(bug.getVCURL());
        }

        private void cmbsearchfor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProjectComponent addProjectComponent = new AddProjectComponent();
            addProjectComponent.Show();
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
