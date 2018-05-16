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
    public partial class TesterDashboard : Form
    {
        public TesterDashboard()
        {
            InitializeComponent();
        }

        public string sessionusername;
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TesterDashboard_Load(object sender, EventArgs e)
        {
            logout.SizeMode = PictureBoxSizeMode.StretchImage;
            pbadd.SizeMode = PictureBoxSizeMode.StretchImage;
            this.lblusername.Text = sessionusername;


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

        }
    }
}
