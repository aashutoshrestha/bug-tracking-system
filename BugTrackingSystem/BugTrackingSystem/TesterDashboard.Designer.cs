namespace BugTrackingSystem
{
    partial class TesterDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbupdatebug = new System.Windows.Forms.PictureBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.pbadd = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datagridviewtesterdashboard = new System.Windows.Forms.DataGridView();
            this.txtcomponent = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtproject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richbugdesc = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.richremarks = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtclassname = new System.Windows.Forms.TextBox();
            this.txtmethodname = new System.Windows.Forms.TextBox();
            this.txtlinefrom = new System.Windows.Forms.TextBox();
            this.txtlineto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richsourcecode = new System.Windows.Forms.RichTextBox();
            this.lblversion = new System.Windows.Forms.LinkLabel();
            this.label17 = new System.Windows.Forms.Label();
            this.lblbugstatus = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbllastupdatedby = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbllastupdateon = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.imgbugseverity = new System.Windows.Forms.PictureBox();
            this.imgscreenshot = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbupdatebug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewtesterdashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbugseverity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgscreenshot)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pbupdatebug);
            this.panel1.Controls.Add(this.lblusername);
            this.panel1.Controls.Add(this.pbadd);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 35);
            this.panel1.TabIndex = 2;
            // 
            // pbupdatebug
            // 
            this.pbupdatebug.Image = global::BugTrackingSystem.Properties.Resources.button_update_bug;
            this.pbupdatebug.Location = new System.Drawing.Point(84, 3);
            this.pbupdatebug.Name = "pbupdatebug";
            this.pbupdatebug.Size = new System.Drawing.Size(157, 29);
            this.pbupdatebug.TabIndex = 60;
            this.pbupdatebug.TabStop = false;
            this.pbupdatebug.Click += new System.EventHandler(this.pbupdatebug_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.White;
            this.lblusername.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(1050, 3);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(95, 13);
            this.lblusername.TabIndex = 6;
            this.lblusername.Text = "lblusername";
            // 
            // pbadd
            // 
            this.pbadd.Image = global::BugTrackingSystem.Properties.Resources._8009622212;
            this.pbadd.Location = new System.Drawing.Point(12, 3);
            this.pbadd.Name = "pbadd";
            this.pbadd.Size = new System.Drawing.Size(43, 29);
            this.pbadd.TabIndex = 5;
            this.pbadd.TabStop = false;
            this.pbadd.Click += new System.EventHandler(this.pbadd_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.White;
            this.logout.Image = global::BugTrackingSystem.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(1151, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(100, 23);
            this.logout.TabIndex = 4;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Reported Bugs";
            // 
            // datagridviewtesterdashboard
            // 
            this.datagridviewtesterdashboard.BackgroundColor = System.Drawing.Color.White;
            this.datagridviewtesterdashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewtesterdashboard.Location = new System.Drawing.Point(0, 107);
            this.datagridviewtesterdashboard.Name = "datagridviewtesterdashboard";
            this.datagridviewtesterdashboard.Size = new System.Drawing.Size(290, 780);
            this.datagridviewtesterdashboard.TabIndex = 3;
            this.datagridviewtesterdashboard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewtesterdashboard_CellClick);
            this.datagridviewtesterdashboard.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridviewtesterdashboard_RowHeaderMouseClick);
            // 
            // txtcomponent
            // 
            this.txtcomponent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtcomponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomponent.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtcomponent.Location = new System.Drawing.Point(543, 118);
            this.txtcomponent.Name = "txtcomponent";
            this.txtcomponent.ReadOnly = true;
            this.txtcomponent.Size = new System.Drawing.Size(230, 26);
            this.txtcomponent.TabIndex = 37;
            this.txtcomponent.Text = "Component";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(298, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(239, 16);
            this.label12.TabIndex = 36;
            this.label12.Text = "Component/Application";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(298, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 35;
            this.label11.Text = "Project";
            // 
            // txtproject
            // 
            this.txtproject.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtproject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproject.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtproject.Location = new System.Drawing.Point(543, 78);
            this.txtproject.Name = "txtproject";
            this.txtproject.ReadOnly = true;
            this.txtproject.Size = new System.Drawing.Size(230, 26);
            this.txtproject.TabIndex = 34;
            this.txtproject.Text = "Project";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Attachment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(659, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Bug Description";
            // 
            // richbugdesc
            // 
            this.richbugdesc.Location = new System.Drawing.Point(631, 177);
            this.richbugdesc.Name = "richbugdesc";
            this.richbugdesc.ReadOnly = true;
            this.richbugdesc.Size = new System.Drawing.Size(222, 226);
            this.richbugdesc.TabIndex = 31;
            this.richbugdesc.Text = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(303, 775);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 16);
            this.label18.TabIndex = 49;
            this.label18.Text = "Remarks";
            // 
            // richremarks
            // 
            this.richremarks.Location = new System.Drawing.Point(449, 756);
            this.richremarks.Name = "richremarks";
            this.richremarks.Size = new System.Drawing.Size(409, 133);
            this.richremarks.TabIndex = 48;
            this.richremarks.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(649, 418);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 16);
            this.label16.TabIndex = 47;
            this.label16.Text = "To";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(444, 419);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 16);
            this.label15.TabIndex = 46;
            this.label15.Text = "Line No";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(303, 719);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 16);
            this.label14.TabIndex = 45;
            this.label14.Text = "Method Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(303, 682);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 16);
            this.label13.TabIndex = 44;
            this.label13.Text = "Class Name";
            // 
            // txtclassname
            // 
            this.txtclassname.Location = new System.Drawing.Point(449, 681);
            this.txtclassname.Name = "txtclassname";
            this.txtclassname.ReadOnly = true;
            this.txtclassname.Size = new System.Drawing.Size(230, 20);
            this.txtclassname.TabIndex = 43;
            // 
            // txtmethodname
            // 
            this.txtmethodname.Location = new System.Drawing.Point(449, 718);
            this.txtmethodname.Name = "txtmethodname";
            this.txtmethodname.ReadOnly = true;
            this.txtmethodname.Size = new System.Drawing.Size(230, 20);
            this.txtmethodname.TabIndex = 42;
            // 
            // txtlinefrom
            // 
            this.txtlinefrom.Location = new System.Drawing.Point(530, 418);
            this.txtlinefrom.Name = "txtlinefrom";
            this.txtlinefrom.Size = new System.Drawing.Size(100, 20);
            this.txtlinefrom.TabIndex = 41;
            // 
            // txtlineto
            // 
            this.txtlineto.Location = new System.Drawing.Point(705, 418);
            this.txtlineto.Name = "txtlineto";
            this.txtlineto.Size = new System.Drawing.Size(100, 20);
            this.txtlineto.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(298, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Source Code";
            // 
            // richsourcecode
            // 
            this.richsourcecode.Location = new System.Drawing.Point(301, 438);
            this.richsourcecode.Name = "richsourcecode";
            this.richsourcecode.ReadOnly = true;
            this.richsourcecode.Size = new System.Drawing.Size(557, 222);
            this.richsourcecode.TabIndex = 38;
            this.richsourcecode.Text = "";
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.Location = new System.Drawing.Point(1085, 186);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(53, 13);
            this.lblversion.TabIndex = 59;
            this.lblversion.TabStop = true;
            this.lblversion.Text = "Unknown";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(969, 186);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 13);
            this.label17.TabIndex = 58;
            this.label17.Text = "Last Known Version";
            // 
            // lblbugstatus
            // 
            this.lblbugstatus.AutoSize = true;
            this.lblbugstatus.Location = new System.Drawing.Point(1085, 222);
            this.lblbugstatus.Name = "lblbugstatus";
            this.lblbugstatus.Size = new System.Drawing.Size(53, 13);
            this.lblbugstatus.TabIndex = 57;
            this.lblbugstatus.TabStop = true;
            this.lblbugstatus.Text = "Unknown";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(969, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Current Bug Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(969, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Audit History";
            // 
            // lbllastupdatedby
            // 
            this.lbllastupdatedby.AutoSize = true;
            this.lbllastupdatedby.Location = new System.Drawing.Point(1086, 144);
            this.lbllastupdatedby.Name = "lbllastupdatedby";
            this.lbllastupdatedby.Size = new System.Drawing.Size(53, 13);
            this.lbllastupdatedby.TabIndex = 53;
            this.lbllastupdatedby.TabStop = true;
            this.lbllastupdatedby.Text = "Unknown";
            this.lbllastupdatedby.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllastupdatedby_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(970, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Last Updated By";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbllastupdateon
            // 
            this.lbllastupdateon.AutoSize = true;
            this.lbllastupdateon.Location = new System.Drawing.Point(1086, 108);
            this.lbllastupdateon.Name = "lbllastupdateon";
            this.lbllastupdateon.Size = new System.Drawing.Size(53, 13);
            this.lbllastupdateon.TabIndex = 51;
            this.lbllastupdateon.TabStop = true;
            this.lbllastupdateon.Text = "Unknown";
            this.lbllastupdateon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllastupdateon_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(970, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Last Updated on";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // imgbugseverity
            // 
            this.imgbugseverity.Location = new System.Drawing.Point(972, 268);
            this.imgbugseverity.Name = "imgbugseverity";
            this.imgbugseverity.Size = new System.Drawing.Size(82, 50);
            this.imgbugseverity.TabIndex = 55;
            this.imgbugseverity.TabStop = false;
            this.imgbugseverity.Click += new System.EventHandler(this.imgbugseverity_Click);
            // 
            // imgscreenshot
            // 
            this.imgscreenshot.Location = new System.Drawing.Point(296, 177);
            this.imgscreenshot.Name = "imgscreenshot";
            this.imgscreenshot.Size = new System.Drawing.Size(329, 226);
            this.imgscreenshot.TabIndex = 30;
            this.imgscreenshot.TabStop = false;
            this.imgscreenshot.Click += new System.EventHandler(this.imgscreenshot_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(864, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 40);
            this.button1.TabIndex = 60;
            this.button1.Text = "Open In Text Editor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(779, 124);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(128, 20);
            this.linkLabel1.TabIndex = 61;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Open Repository";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // TesterDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 900);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblversion);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblbugstatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.imgbugseverity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbllastupdatedby);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbllastupdateon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.richremarks);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtclassname);
            this.Controls.Add(this.txtmethodname);
            this.Controls.Add(this.txtlinefrom);
            this.Controls.Add(this.txtlineto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richsourcecode);
            this.Controls.Add(this.txtcomponent);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtproject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richbugdesc);
            this.Controls.Add(this.imgscreenshot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridviewtesterdashboard);
            this.Controls.Add(this.panel1);
            this.Name = "TesterDashboard";
            this.Text = "TesterDashboard";
            this.Load += new System.EventHandler(this.TesterDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbupdatebug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewtesterdashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbugseverity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgscreenshot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.PictureBox pbadd;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridviewtesterdashboard;
        private System.Windows.Forms.TextBox txtcomponent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtproject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richbugdesc;
        private System.Windows.Forms.PictureBox imgscreenshot;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RichTextBox richremarks;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtclassname;
        private System.Windows.Forms.TextBox txtmethodname;
        private System.Windows.Forms.TextBox txtlinefrom;
        private System.Windows.Forms.TextBox txtlineto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richsourcecode;
        private System.Windows.Forms.LinkLabel lblversion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.LinkLabel lblbugstatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox imgbugseverity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lbllastupdatedby;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lbllastupdateon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbupdatebug;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}