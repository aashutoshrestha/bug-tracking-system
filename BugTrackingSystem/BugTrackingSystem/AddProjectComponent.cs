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
    public partial class AddProjectComponent : Form
    {
        public AddProjectComponent()
        {
            InitializeComponent();
        }

        public String projectmanager;
        BugController bc = new BugController();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pbsubmit_Click(object sender, EventArgs e)
        {
           
            BugModel bug = new BugModel();
            string projectname = this.cmbProject.GetItemText(this.cmbProject.SelectedItem);
            bug.setprojectid(bc.getProjectID(projectname));
            bug.setcomponentdesc(this.txtcomponentdescription.Text);
            bug.setComponentName(this.txtcomponentname.Text);
            bug.setUsername(this.txtdeveloper.Text);

           bool flag= bc.addProjectComponent(bug);
            if (flag == true)
            {
                this.Hide();
                MessageBox.Show("Project Component Was Added");
            }
            else {
                MessageBox.Show("Sorry, Project Component Could not be Added, Please Try Again");
            }


        }

        private void AddProjectComponent_Load(object sender, EventArgs e)
        {
            fillProductList();
            pbsubmit.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        //populate projects list box
        public void fillProductList()
        {

            System.Collections.ArrayList projectlist = bc.PopulateProject();
            foreach (string item in projectlist)
            {
                this.cmbProject.Items.Add(item);
            }

        }
    }
}
