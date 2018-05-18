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
using System.Windows.Documents;
using System.Windows.Forms;

namespace BugTrackingSystem
{
    public partial class ReportBug : Form
    {
        public ReportBug()
        {
            InitializeComponent();
            componentlist = new System.Collections.ArrayList();
        }
        BugModel bug = new BugModel();
        BugController bc = new BugController();
        private String projectname;
        public String sessionusername;
        private System.Collections.ArrayList componentlist;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtshortdesc_TextChanged(object sender, EventArgs e)
        {

        }


        //browse and set image
        private void btnBrowseScreenshot_Click(object sender, EventArgs e)
        {

            var fd = new OpenFileDialog();
            fd.Filter = "PNG(*.png)|*.png;|Bmp(*.bmp)|bmp;|Jpeg(*.jpg)|*.jpg";
            fd.AddExtension = true;
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                long length = new System.IO.FileInfo(fd.FileName).Length;

                if (length >= 2000000)
                {
                    MessageBox.Show("Image is Too Large, Only select file below 2MB", "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (
                    !String.Equals(Path.GetExtension(fd.FileName), ".png", StringComparison.OrdinalIgnoreCase) 
                    && !String.Equals(Path.GetExtension(fd.FileName), ".bmp", StringComparison.OrdinalIgnoreCase)
                     && !String.Equals(Path.GetExtension(fd.FileName), ".jpg", StringComparison.OrdinalIgnoreCase)
                    )
                {
                    
                    MessageBox.Show("You must select an Image file.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                try
                {
                    
                    Debug.WriteLine(length);
                    //Bitmap.FromFile(fd.FileName);
                    Bitmap img = new Bitmap(fd.FileName);
                        pbscreenshot.Image = img;
                        this.Refresh();
                        bug.setImageLocation(fd.FileName);
                       txtscreenshotlocation.Text = fd.FileName;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to Load Image:" + "\n" + ex.Message, "Load Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // failed to load, display error message
                }
            }


        }

        //form load
          private void ReportBug_Load(object sender, EventArgs e)
        {
            imgsubmit.SizeMode = PictureBoxSizeMode.StretchImage;
            pbscreenshot.SizeMode = PictureBoxSizeMode.StretchImage;
            fillProductList();
        }


        //To Highlight/Color Code the code snippets
        public void SyntaxHighlight()
        {
           // richtextcodesnippet.Settings


        }


        //submit bug
        private void imgsubmit_Click(object sender, EventArgs e)
        {
            string rtfText = this.richtextcodesnippet.Rtf; //string to save to db
            this.richtextcodesnippet.Rtf = rtfText;
            bug.setCode(rtfText);
            bug.setClass(this.txtclassname.Text);
            bug.setMethod(this.txtMethodname.Text);
            bug.setOS(this.txtOS.Text);
            bug.setSeverity(this.cmbSeverity.Text);
            bug.setVersion(this.txtVersion.Text);
            bug.setSummary(this.txtsummary.Text);
            bug.setlinenofrom(Convert.ToInt32(this.txtlinefrom.Text));
            bug.setlinenoto(Convert.ToInt32(this.txtlineto.Text));
            bug.setVCURL(this.txtRepoURL.Text);
            bug.setbugdesc(this.richtxtbugdesc.Text);
            bug.setCode(this.richtextcodesnippet.Text);
            bc.submittedby = sessionusername;
            bool flag = bc.ReportBug(bug);


            if (flag == true)
            {
                this.Hide();
                MessageBox.Show("Bug has been reported succesfully");
                
            }
            else
            {
                MessageBox.Show("Fields with * cannot be empty");
            }

        }



        //populate component list box
        public void fillComponentList()
        {
            componentlist.Clear();

            componentlist = bc.PopulateComponent(this.cmbproject.GetItemText(this.cmbproject.SelectedItem));
            foreach (string item in componentlist)
            {
                this.listboxcomponent.Items.Add(item);
            }
        }


        //populate projects list box
        public void fillProductList()
        {
            
            System.Collections.ArrayList projectlist = bc.PopulateProject();
            foreach (string item in projectlist)
            {
                this.cmbproject.Items.Add(item);
            }

        }

        private void listboxcomponent_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void cmbproject_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxcomponent.Items.Clear();
            
            fillComponentList();
            
        }

        private void cmbproject_DropDownClosed(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void listboxcomponent_SelectedIndexChanged(object sender, EventArgs e)
        {

            string ComponentName = listboxcomponent.GetItemText(listboxcomponent.SelectedItem);
            bug.setComponentID(bc.getComponentID(ComponentName));
        }
    }
}
