namespace BugTrackingSystem
{
    partial class Dashboard
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.bugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.lblsessionusername = new System.Windows.Forms.Label();
            this.lblaccountinfo = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.PictureBox();
            this.profileimg = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileimg)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelDashboard);
            this.panelMain.Controls.Add(this.panelUserInfo);
            this.panelMain.Location = new System.Drawing.Point(0, 27);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1225, 558);
            this.panelMain.TabIndex = 2;
            // 
            // bugToolStripMenuItem
            // 
            this.bugToolStripMenuItem.Name = "bugToolStripMenuItem";
            this.bugToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.bugToolStripMenuItem.Text = "Bug";
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelUserInfo.Controls.Add(this.profileimg);
            this.panelUserInfo.Controls.Add(this.lblaccountinfo);
            this.panelUserInfo.Controls.Add(this.lblsessionusername);
            this.panelUserInfo.Location = new System.Drawing.Point(3, 3);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(188, 552);
            this.panelUserInfo.TabIndex = 0;
            // 
            // panelDashboard
            // 
            this.panelDashboard.Location = new System.Drawing.Point(197, 3);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1025, 555);
            this.panelDashboard.TabIndex = 1;
            this.panelDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDashboard_Paint);
            // 
            // lblsessionusername
            // 
            this.lblsessionusername.AutoSize = true;
            this.lblsessionusername.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsessionusername.ForeColor = System.Drawing.Color.Green;
            this.lblsessionusername.Location = new System.Drawing.Point(3, 148);
            this.lblsessionusername.Name = "lblsessionusername";
            this.lblsessionusername.Size = new System.Drawing.Size(165, 25);
            this.lblsessionusername.TabIndex = 0;
            this.lblsessionusername.Text = "SessionUsername";
            this.lblsessionusername.Click += new System.EventHandler(this.lblsessionusername_Click);
            // 
            // lblaccountinfo
            // 
            this.lblaccountinfo.AutoSize = true;
            this.lblaccountinfo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaccountinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblaccountinfo.Location = new System.Drawing.Point(19, 173);
            this.lblaccountinfo.Name = "lblaccountinfo";
            this.lblaccountinfo.Size = new System.Drawing.Size(121, 25);
            this.lblaccountinfo.TabIndex = 1;
            this.lblaccountinfo.Text = "Account Info";
            this.lblaccountinfo.Click += new System.EventHandler(this.lblaccountinfo_Click);
            // 
            // logout
            // 
            this.logout.Image = global::BugTrackingSystem.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(1125, 1);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(100, 23);
            this.logout.TabIndex = 3;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // profileimg
            // 
            this.profileimg.Location = new System.Drawing.Point(34, 3);
            this.profileimg.Name = "profileimg";
            this.profileimg.Size = new System.Drawing.Size(119, 130);
            this.profileimg.TabIndex = 0;
            this.profileimg.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 589);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileimg)).EndInit();
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
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label lblsessionusername;
        private System.Windows.Forms.Label lblaccountinfo;
        private System.Windows.Forms.PictureBox profileimg;
    }
}