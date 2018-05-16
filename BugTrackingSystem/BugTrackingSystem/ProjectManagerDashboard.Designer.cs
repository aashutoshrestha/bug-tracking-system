namespace BugTrackingSystem
{
    partial class ProjectManagerDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsearchbug = new System.Windows.Forms.Button();
            this.txtsearchbug = new System.Windows.Forms.TextBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblbugstatus = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.imgbugseverity = new System.Windows.Forms.PictureBox();
            this.richsourcecode = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbllastupdatedby = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbllastupdateon = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richbugdesc = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgscreenshot = new System.Windows.Forms.PictureBox();
            this.datagridviewpmdashboard = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            this.panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbugseverity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgscreenshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewpmdashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.notificationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1225, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bugToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            // 
            // bugToolStripMenuItem
            // 
            this.bugToolStripMenuItem.Name = "bugToolStripMenuItem";
            this.bugToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.bugToolStripMenuItem.Text = "Bug";
            // 
            // notificationToolStripMenuItem
            // 
            this.notificationToolStripMenuItem.Name = "notificationToolStripMenuItem";
            this.notificationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.notificationToolStripMenuItem.Text = "Notification";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.panelDashboard);
            this.panelMain.Location = new System.Drawing.Point(0, 27);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1225, 558);
            this.panelMain.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnsearchbug);
            this.panel1.Controls.Add(this.txtsearchbug);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 33);
            this.panel1.TabIndex = 2;
            // 
            // btnsearchbug
            // 
            this.btnsearchbug.Location = new System.Drawing.Point(601, 4);
            this.btnsearchbug.Name = "btnsearchbug";
            this.btnsearchbug.Size = new System.Drawing.Size(75, 23);
            this.btnsearchbug.TabIndex = 5;
            this.btnsearchbug.Text = "Search Bug";
            this.btnsearchbug.UseVisualStyleBackColor = true;
            // 
            // txtsearchbug
            // 
            this.txtsearchbug.Location = new System.Drawing.Point(420, 6);
            this.txtsearchbug.Name = "txtsearchbug";
            this.txtsearchbug.Size = new System.Drawing.Size(161, 20);
            this.txtsearchbug.TabIndex = 4;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.Control;
            this.logout.Image = global::BugTrackingSystem.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(1116, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(100, 23);
            this.logout.TabIndex = 3;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.White;
            this.panelDashboard.Controls.Add(this.label8);
            this.panelDashboard.Controls.Add(this.lblbugstatus);
            this.panelDashboard.Controls.Add(this.label7);
            this.panelDashboard.Controls.Add(this.imgbugseverity);
            this.panelDashboard.Controls.Add(this.richsourcecode);
            this.panelDashboard.Controls.Add(this.label6);
            this.panelDashboard.Controls.Add(this.lbllastupdatedby);
            this.panelDashboard.Controls.Add(this.label4);
            this.panelDashboard.Controls.Add(this.lbllastupdateon);
            this.panelDashboard.Controls.Add(this.label5);
            this.panelDashboard.Controls.Add(this.label3);
            this.panelDashboard.Controls.Add(this.label2);
            this.panelDashboard.Controls.Add(this.richbugdesc);
            this.panelDashboard.Controls.Add(this.label1);
            this.panelDashboard.Controls.Add(this.imgscreenshot);
            this.panelDashboard.Controls.Add(this.datagridviewpmdashboard);
            this.panelDashboard.Location = new System.Drawing.Point(3, 39);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1219, 689);
            this.panelDashboard.TabIndex = 1;
            this.panelDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDashboard_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(391, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Source Code";
            // 
            // lblbugstatus
            // 
            this.lblbugstatus.AutoSize = true;
            this.lblbugstatus.Location = new System.Drawing.Point(1120, 157);
            this.lblbugstatus.Name = "lblbugstatus";
            this.lblbugstatus.Size = new System.Drawing.Size(53, 13);
            this.lblbugstatus.TabIndex = 15;
            this.lblbugstatus.TabStop = true;
            this.lblbugstatus.Text = "Unknown";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1004, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Current Bug Status";
            // 
            // imgbugseverity
            // 
            this.imgbugseverity.Location = new System.Drawing.Point(1007, 187);
            this.imgbugseverity.Name = "imgbugseverity";
            this.imgbugseverity.Size = new System.Drawing.Size(82, 50);
            this.imgbugseverity.TabIndex = 13;
            this.imgbugseverity.TabStop = false;
            this.imgbugseverity.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // richsourcecode
            // 
            this.richsourcecode.Location = new System.Drawing.Point(299, 294);
            this.richsourcecode.Name = "richsourcecode";
            this.richsourcecode.ReadOnly = true;
            this.richsourcecode.Size = new System.Drawing.Size(611, 222);
            this.richsourcecode.TabIndex = 12;
            this.richsourcecode.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1023, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Audit History";
            // 
            // lbllastupdatedby
            // 
            this.lbllastupdatedby.AutoSize = true;
            this.lbllastupdatedby.Location = new System.Drawing.Point(1121, 117);
            this.lbllastupdatedby.Name = "lbllastupdatedby";
            this.lbllastupdatedby.Size = new System.Drawing.Size(53, 13);
            this.lbllastupdatedby.TabIndex = 10;
            this.lbllastupdatedby.TabStop = true;
            this.lbllastupdatedby.Text = "Unknown";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1005, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Updated By";
            // 
            // lbllastupdateon
            // 
            this.lbllastupdateon.AutoSize = true;
            this.lbllastupdateon.Location = new System.Drawing.Point(1121, 76);
            this.lbllastupdateon.Name = "lbllastupdateon";
            this.lbllastupdateon.Size = new System.Drawing.Size(53, 13);
            this.lbllastupdateon.TabIndex = 8;
            this.lbllastupdateon.TabStop = true;
            this.lbllastupdateon.Text = "Unknown";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1005, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Last Updated on";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Attachment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(685, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bug Description";
            // 
            // richbugdesc
            // 
            this.richbugdesc.Location = new System.Drawing.Point(688, 37);
            this.richbugdesc.Name = "richbugdesc";
            this.richbugdesc.ReadOnly = true;
            this.richbugdesc.Size = new System.Drawing.Size(222, 226);
            this.richbugdesc.TabIndex = 3;
            this.richbugdesc.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reported bugs";
            // 
            // imgscreenshot
            // 
            this.imgscreenshot.Location = new System.Drawing.Point(299, 37);
            this.imgscreenshot.Name = "imgscreenshot";
            this.imgscreenshot.Size = new System.Drawing.Size(377, 226);
            this.imgscreenshot.TabIndex = 1;
            this.imgscreenshot.TabStop = false;
            // 
            // datagridviewpmdashboard
            // 
            this.datagridviewpmdashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewpmdashboard.Location = new System.Drawing.Point(3, 37);
            this.datagridviewpmdashboard.Name = "datagridviewpmdashboard";
            this.datagridviewpmdashboard.Size = new System.Drawing.Size(290, 482);
            this.datagridviewpmdashboard.TabIndex = 0;
            this.datagridviewpmdashboard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewpmdashboard_CellClick);
            this.datagridviewpmdashboard.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridviewpmdashboard_RowHeaderMouseClick);
            // 
            // ProjectManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 611);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProjectManagerDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbugseverity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgscreenshot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewpmdashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem bugToolStripMenuItem;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.ToolStripMenuItem notificationToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView datagridviewpmdashboard;
        private System.Windows.Forms.PictureBox imgscreenshot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richbugdesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lbllastupdatedby;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lbllastupdateon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richsourcecode;
        private System.Windows.Forms.PictureBox imgbugseverity;
        private System.Windows.Forms.LinkLabel lblbugstatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsearchbug;
        private System.Windows.Forms.TextBox txtsearchbug;
    }
}