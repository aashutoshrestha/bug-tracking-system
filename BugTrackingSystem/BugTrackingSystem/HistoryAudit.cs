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
    public partial class HistoryAudit : Form
    {
        DataTable history;
        public String updatedate;
        int bugid;
        public HistoryAudit()
        {
            InitializeComponent();
        }

        private void HistoryAudit_Load(object sender, EventArgs e)
        {
            populatedashboard();



        }

        public void PopulateDataGridHistory()
        {

            datagridhistory.DataSource = history;
            foreach (DataGridViewRow row in datagridhistory.Rows)
            {
                row.Height = 50;

            }
            foreach (DataGridViewColumn col in datagridhistory.Columns)
            {
                col.Width = 110;

            }

            for (int i = 0; i < datagridhistory.ColumnCount; i++)
            {
                datagridhistory.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                datagridhistory.AutoResizeColumns();
                datagridhistory.Columns[i].DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 8F, FontStyle.Bold);
            }


        }

        private void datagridhistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedrow = datagridhistory.Rows[index];
                bugid = Convert.ToInt32(selectedrow.Cells[2].Value.ToString());
                txtpreviousecode.Text = selectedrow.Cells[5].Value.ToString();
                txtremarks.Text = selectedrow.Cells[7].Value.ToString();
                lbllastupdatedby.Text = selectedrow.Cells[4].Value.ToString();
                lbllastupdateon.Text = selectedrow.Cells[3].Value.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Empty cell is selected");
            }
        }
        public void populatedashboard()
        {
            BugController bc = new BugController();
            history = BugController.getAuditHistory(updatedate);
            PopulateDataGridHistory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            history = BugController.getHistory(bugid);
        }
    }
}
