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
    public partial class UpdateBug : Form
    {
        public UpdateBug()
        {
            InitializeComponent();
           

        }
        public String txtcode,version,username,role;
        public string bugdesc;
        public string status;
        public int bugid;
       
        private void submit_Click(object sender, EventArgs e)
        {
            BugModel bug = new BugModel();
            bug.setRemarks(this.txtremarks.Text);
            bug.setCode(this.txtupdatecode.Text);
            bug.setStatus(this.cmbStatus.Text);
            bug.setVersion(this.txtversion.Text);
            Debug.WriteLine("Username is:"+username);
            bug.setUsername(username);
            bug.setBugID(bugid);
            BugController bc = new BugController();
            bool flag = bc.UpdateBug(bug);
            if(flag == true)
            {
                this.Hide();
                MessageBox.Show("Bug Was Succesfully Updated");
            }
            else if(flag == false)
            {
                MessageBox.Show("Bug could not be updated");
            }

        }

        private void lbllastupdateon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(lbllastupdateon.Text == "Unknown"){
                MessageBox.Show("No History found");
            }
            HistoryAudit historyAudit = new HistoryAudit();
            historyAudit.updatedate = lbllastupdateon.Text;
            historyAudit.Show();
        }

        private void UpdateBug_Load(object sender, EventArgs e)
        {
            submit.SizeMode = PictureBoxSizeMode.StretchImage;
            populateUpdateBug();
            if (role == "tester")
            {
                txtupdatecode.ReadOnly = true;
                txtupdatecode.Text = txtcode;
                lblrequest.Visible = false;
                txtversion.ReadOnly = true;

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        public void populateUpdateBug()
        {
            this.txtdesc.Text = bugdesc;
            this.txtpreviousecode.Text = txtcode;
            this.cmbStatus.Text = status;
            this.txtversion.Text = version;
            
        }



        
    }
}
