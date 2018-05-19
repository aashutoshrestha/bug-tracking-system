using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem
{
    public partial class DeveloperDashboard : Form
    {
        private int bugid;
        private Image imgnew;
        public string sessionusername;
        public DataTable dtable;
        BugModel bug = new BugModel();
        public DataTable historytable;

        public DeveloperDashboard()
        {
            InitializeComponent();
        }

        private void DeveloperDashboard_Load(object sender, EventArgs e)
        {
            pbupdate.SizeMode = PictureBoxSizeMode.StretchImage;
            logout.SizeMode = PictureBoxSizeMode.StretchImage;
            imgscreenshot.SizeMode = PictureBoxSizeMode.StretchImage;
            PopulateDataGridDeveloperDashboard();
            this.lblusername.Text = sessionusername;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public void PopulateDataGridDeveloperDashboard()
        {

            

            datagridviewdeveloperdashboard.DataSource = dtable;
            foreach (DataGridViewRow row in datagridviewdeveloperdashboard.Rows)
            {
                row.Height = 50;

            }
            foreach (DataGridViewColumn col in datagridviewdeveloperdashboard.Columns)
            {
                col.Width = 110;

            }

            for (int i = 0; i < datagridviewdeveloperdashboard.ColumnCount; i++)
            {
                datagridviewdeveloperdashboard.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                datagridviewdeveloperdashboard.AutoResizeColumns();
                datagridviewdeveloperdashboard.Columns[i].DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 8F, FontStyle.Bold);
            }


        }




        public void PopulateDashboardItems()
        {
           
            bug.setBugID(bugid);
            bug.setUsername(sessionusername);
            BugController bc = new BugController();
            bc.populatedeveloperdashboard(bug);
            historytable = bc.getHistory(bug);

            if (historytable != null && historytable.Rows.Count > 0)
            {
                this.lbllastupdatedby.Text = historytable.Rows[0][4].ToString();
                this.lbllastupdateon.Text = historytable.Rows[0][3].ToString();
                

            }
            else
            {
                this.lbllastupdatedby.Text = "Unkown";
                this.lbllastupdateon.Text = "Unknown";
               
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

            
           

        }

      

        private void datagridviewdeveloperdashboard_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bugid = Convert.ToInt32(datagridviewdeveloperdashboard.Rows[e.RowIndex].Cells[0].Value.ToString());
            Debug.WriteLine("Row Clicked identified");
            PopulateDashboardItems();
        }

        private void datagridviewdeveloperdashboard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedrow = datagridviewdeveloperdashboard.Rows[index];
                bugid = Convert.ToInt32(selectedrow.Cells[0].Value.ToString());

                PopulateDashboardItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Empty cell is selected");
            }
        }

        private void imgscreenshot_Click(object sender, EventArgs e)
        {
            ImageForm img = new ImageForm();
            img.loadImage(imgnew);
            img.Show();
        }

        private void pbupdate_Click(object sender, EventArgs e)
        {
            UpdateBug ubug = new UpdateBug();
            ubug.txtcode = bug.getCode();
            ubug.bugdesc = bug.getbugdesc();
            ubug.status = bug.getStatus();
            ubug.bugid = bugid;
            ubug.version = bug.getVersion();
            Debug.WriteLine("passing username"+sessionusername);
            ubug.username = sessionusername;
            ubug.Show();

            this.Refresh();

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
                historyAudit.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SourceCodeEditor sourceCode = new SourceCodeEditor(this.richsourcecode.Text);
            sourceCode.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(bug.getVCURL());
        }
    }
}
