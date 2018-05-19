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
    public partial class TesterDashboard : Form
    {
        public TesterDashboard()
        {
            InitializeComponent();
        }

        private int bugid;
        private Image imgnew;
        public string sessionusername;
        public DataTable dataTable;
        BugModel bug = new BugModel();
        public DataTable historytable;
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TesterDashboard_Load(object sender, EventArgs e)
        {
            logout.SizeMode = PictureBoxSizeMode.StretchImage;
            pbadd.SizeMode = PictureBoxSizeMode.StretchImage;
            pbupdatebug.SizeMode = PictureBoxSizeMode.StretchImage;
            imgscreenshot.SizeMode = PictureBoxSizeMode.StretchImage;

            this.lblusername.Text = sessionusername;
            PopulateDataGridTesterDashboard();

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pbadd_Click(object sender, EventArgs e)
        {
            ReportBug reportBug = new ReportBug();
            reportBug.sessionusername = sessionusername;

            //System.Windows.Forms.Integration.ElementHost.EnableModelessKeyboardInterop(reportBug);
            
            reportBug.Show();
            this.Refresh();

        }

        public void PopulateDataGridTesterDashboard()
        {



            datagridviewtesterdashboard.DataSource = dataTable;
            foreach (DataGridViewRow row in datagridviewtesterdashboard.Rows)
            {
                row.Height = 50;

            }
            foreach (DataGridViewColumn col in datagridviewtesterdashboard.Columns)
            {
                col.Width = 110;

            }

            for (int i = 0; i < datagridviewtesterdashboard.ColumnCount; i++)
            {
                datagridviewtesterdashboard.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                datagridviewtesterdashboard.AutoResizeColumns();
                datagridviewtesterdashboard.Columns[i].DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 8F, FontStyle.Bold);
            }


        }


        public void PopulateDashboardItems()
        {

            bug.setBugID(bugid);
            bug.setUsername(sessionusername);
            BugController bc = new BugController();
            bc.populatetesterdashboard(bug);
            historytable = bc.getHistory(bug);

            if (historytable != null && historytable.Rows.Count > 0)
            {
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
        }

        private void datagridviewtesterdashboard_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bugid = Convert.ToInt32(datagridviewtesterdashboard.Rows[e.RowIndex].Cells[0].Value.ToString());
            Debug.WriteLine("Row Clicked identified");
            PopulateDashboardItems();
        }

        private void datagridviewtesterdashboard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedrow = datagridviewtesterdashboard.Rows[index];
                bugid = Convert.ToInt32(selectedrow.Cells[0].Value.ToString());

                PopulateDashboardItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Empty cell is selected");
            }
        }

        private void pbupdatebug_Click(object sender, EventArgs e)
        {
            UpdateBug ubug = new UpdateBug();
            ubug.txtcode = bug.getCode();
            ubug.bugdesc = bug.getbugdesc();
            ubug.status = bug.getStatus();
            ubug.bugid = bugid;
            ubug.version = bug.getVersion();
            ubug.role = "tester";
            Debug.WriteLine("passing username" + sessionusername);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbllastupdatedby_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            getAuditHistory();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void imgscreenshot_Click(object sender, EventArgs e)
        {
            ImageForm img = new ImageForm();
            img.loadImage(imgnew);
            img.Show();
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
