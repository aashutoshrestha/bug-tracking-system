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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbsearchfor = new System.Windows.Forms.ComboBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.btnsearchbug = new System.Windows.Forms.Button();
            this.txtsearchbug = new System.Windows.Forms.TextBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.btnopenide = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label18 = new System.Windows.Forms.Label();
            this.richremarks = new System.Windows.Forms.RichTextBox();
            this.lblversion = new System.Windows.Forms.LinkLabel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcomponent = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtclassname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmethodname = new System.Windows.Forms.TextBox();
            this.txtproject = new System.Windows.Forms.TextBox();
            this.txtlinefrom = new System.Windows.Forms.TextBox();
            this.txtlineto = new System.Windows.Forms.TextBox();
            this.btnassignbug = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdeveloperusername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            this.panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbugseverity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgscreenshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewpmdashboard)).BeginInit();
            this.SuspendLayout();
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
            this.panelMain.Size = new System.Drawing.Size(1225, 869);
            this.panelMain.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmbsearchfor);
            this.panel1.Controls.Add(this.lblusername);
            this.panel1.Controls.Add(this.btnsearchbug);
            this.panel1.Controls.Add(this.txtsearchbug);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 33);
            this.panel1.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(553, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "in";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(9, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Component/Application";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbsearchfor
            // 
            this.cmbsearchfor.FormattingEnabled = true;
            this.cmbsearchfor.Items.AddRange(new object[] {
            "summary",
            "bug description",
            "code",
            "class",
            "method"});
            this.cmbsearchfor.Location = new System.Drawing.Point(586, 5);
            this.cmbsearchfor.Name = "cmbsearchfor";
            this.cmbsearchfor.Size = new System.Drawing.Size(121, 21);
            this.cmbsearchfor.TabIndex = 8;
            this.cmbsearchfor.SelectedIndexChanged += new System.EventHandler(this.cmbsearchfor_SelectedIndexChanged);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.White;
            this.lblusername.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(1010, 10);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(95, 13);
            this.lblusername.TabIndex = 7;
            this.lblusername.Text = "lblusername";
            // 
            // btnsearchbug
            // 
            this.btnsearchbug.Location = new System.Drawing.Point(713, 4);
            this.btnsearchbug.Name = "btnsearchbug";
            this.btnsearchbug.Size = new System.Drawing.Size(75, 23);
            this.btnsearchbug.TabIndex = 5;
            this.btnsearchbug.Text = "Search Bug";
            this.btnsearchbug.UseVisualStyleBackColor = true;
            this.btnsearchbug.Click += new System.EventHandler(this.btnsearchbug_Click);
            // 
            // txtsearchbug
            // 
            this.txtsearchbug.Location = new System.Drawing.Point(376, 6);
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
            this.panelDashboard.Controls.Add(this.btnopenide);
            this.panelDashboard.Controls.Add(this.linkLabel1);
            this.panelDashboard.Controls.Add(this.label18);
            this.panelDashboard.Controls.Add(this.richremarks);
            this.panelDashboard.Controls.Add(this.lblversion);
            this.panelDashboard.Controls.Add(this.label17);
            this.panelDashboard.Controls.Add(this.label16);
            this.panelDashboard.Controls.Add(this.label15);
            this.panelDashboard.Controls.Add(this.label14);
            this.panelDashboard.Controls.Add(this.label13);
            this.panelDashboard.Controls.Add(this.txtcomponent);
            this.panelDashboard.Controls.Add(this.label12);
            this.panelDashboard.Controls.Add(this.txtclassname);
            this.panelDashboard.Controls.Add(this.label11);
            this.panelDashboard.Controls.Add(this.txtmethodname);
            this.panelDashboard.Controls.Add(this.txtproject);
            this.panelDashboard.Controls.Add(this.txtlinefrom);
            this.panelDashboard.Controls.Add(this.txtlineto);
            this.panelDashboard.Controls.Add(this.btnassignbug);
            this.panelDashboard.Controls.Add(this.label10);
            this.panelDashboard.Controls.Add(this.txtdeveloperusername);
            this.panelDashboard.Controls.Add(this.label9);
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
            this.panelDashboard.Size = new System.Drawing.Size(1222, 827);
            this.panelDashboard.TabIndex = 1;
            this.panelDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDashboard_Paint);
            // 
            // btnopenide
            // 
            this.btnopenide.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopenide.Location = new System.Drawing.Point(872, 546);
            this.btnopenide.Name = "btnopenide";
            this.btnopenide.Size = new System.Drawing.Size(191, 42);
            this.btnopenide.TabIndex = 40;
            this.btnopenide.Text = "Open in Text Editor";
            this.btnopenide.UseVisualStyleBackColor = true;
            this.btnopenide.Click += new System.EventHandler(this.btnopenide_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(792, 56);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(128, 20);
            this.linkLabel1.TabIndex = 39;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Open Repository";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(311, 703);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 16);
            this.label18.TabIndex = 37;
            this.label18.Text = "Remarks";
            // 
            // richremarks
            // 
            this.richremarks.Location = new System.Drawing.Point(457, 684);
            this.richremarks.Name = "richremarks";
            this.richremarks.Size = new System.Drawing.Size(409, 133);
            this.richremarks.TabIndex = 36;
            this.richremarks.Text = "";
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.Location = new System.Drawing.Point(1120, 154);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(53, 13);
            this.lblversion.TabIndex = 35;
            this.lblversion.TabStop = true;
            this.lblversion.Text = "Unknown";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1004, 154);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Last Known Version";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(657, 346);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 16);
            this.label16.TabIndex = 33;
            this.label16.Text = "To";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(452, 347);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "Line No";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(311, 647);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 16);
            this.label14.TabIndex = 31;
            this.label14.Text = "Method Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(311, 610);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Class Name";
            // 
            // txtcomponent
            // 
            this.txtcomponent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtcomponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomponent.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtcomponent.Location = new System.Drawing.Point(556, 50);
            this.txtcomponent.Name = "txtcomponent";
            this.txtcomponent.ReadOnly = true;
            this.txtcomponent.Size = new System.Drawing.Size(230, 26);
            this.txtcomponent.TabIndex = 29;
            this.txtcomponent.Text = "Component";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(311, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(239, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Component/Application";
            // 
            // txtclassname
            // 
            this.txtclassname.Location = new System.Drawing.Point(457, 609);
            this.txtclassname.Name = "txtclassname";
            this.txtclassname.ReadOnly = true;
            this.txtclassname.Size = new System.Drawing.Size(230, 20);
            this.txtclassname.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(311, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Project";
            // 
            // txtmethodname
            // 
            this.txtmethodname.Location = new System.Drawing.Point(457, 646);
            this.txtmethodname.Name = "txtmethodname";
            this.txtmethodname.ReadOnly = true;
            this.txtmethodname.Size = new System.Drawing.Size(230, 20);
            this.txtmethodname.TabIndex = 25;
            // 
            // txtproject
            // 
            this.txtproject.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtproject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproject.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtproject.Location = new System.Drawing.Point(556, 10);
            this.txtproject.Name = "txtproject";
            this.txtproject.ReadOnly = true;
            this.txtproject.Size = new System.Drawing.Size(230, 26);
            this.txtproject.TabIndex = 24;
            this.txtproject.Text = "Project";
            // 
            // txtlinefrom
            // 
            this.txtlinefrom.Location = new System.Drawing.Point(538, 346);
            this.txtlinefrom.Name = "txtlinefrom";
            this.txtlinefrom.Size = new System.Drawing.Size(100, 20);
            this.txtlinefrom.TabIndex = 23;
            // 
            // txtlineto
            // 
            this.txtlineto.Location = new System.Drawing.Point(713, 346);
            this.txtlineto.Name = "txtlineto";
            this.txtlineto.Size = new System.Drawing.Size(100, 20);
            this.txtlineto.TabIndex = 21;
            // 
            // btnassignbug
            // 
            this.btnassignbug.Location = new System.Drawing.Point(1012, 402);
            this.btnassignbug.Name = "btnassignbug";
            this.btnassignbug.Size = new System.Drawing.Size(82, 31);
            this.btnassignbug.TabIndex = 20;
            this.btnassignbug.Text = "Assign";
            this.btnassignbug.UseVisualStyleBackColor = true;
            this.btnassignbug.Click += new System.EventHandler(this.btnassignbug_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(899, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Developer Username";
            // 
            // txtdeveloperusername
            // 
            this.txtdeveloperusername.Location = new System.Drawing.Point(1012, 363);
            this.txtdeveloperusername.Name = "txtdeveloperusername";
            this.txtdeveloperusername.Size = new System.Drawing.Size(165, 20);
            this.txtdeveloperusername.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1009, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Assign Bug";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(306, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Source Code";
            // 
            // lblbugstatus
            // 
            this.lblbugstatus.AutoSize = true;
            this.lblbugstatus.Location = new System.Drawing.Point(1120, 190);
            this.lblbugstatus.Name = "lblbugstatus";
            this.lblbugstatus.Size = new System.Drawing.Size(53, 13);
            this.lblbugstatus.TabIndex = 15;
            this.lblbugstatus.TabStop = true;
            this.lblbugstatus.Text = "Unknown";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1004, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Current Bug Status";
            // 
            // imgbugseverity
            // 
            this.imgbugseverity.Location = new System.Drawing.Point(1007, 236);
            this.imgbugseverity.Name = "imgbugseverity";
            this.imgbugseverity.Size = new System.Drawing.Size(82, 50);
            this.imgbugseverity.TabIndex = 13;
            this.imgbugseverity.TabStop = false;
            this.imgbugseverity.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // richsourcecode
            // 
            this.richsourcecode.Location = new System.Drawing.Point(309, 366);
            this.richsourcecode.Name = "richsourcecode";
            this.richsourcecode.ReadOnly = true;
            this.richsourcecode.Size = new System.Drawing.Size(557, 222);
            this.richsourcecode.TabIndex = 12;
            this.richsourcecode.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1004, 50);
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
            this.lbllastupdatedby.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllastupdatedby_LinkClicked);
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
            this.lbllastupdateon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllastupdateon_LinkClicked);
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
            this.label3.Location = new System.Drawing.Point(419, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Attachment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(672, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bug Description";
            // 
            // richbugdesc
            // 
            this.richbugdesc.Location = new System.Drawing.Point(644, 109);
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
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reported bugs";
            // 
            // imgscreenshot
            // 
            this.imgscreenshot.Location = new System.Drawing.Point(309, 109);
            this.imgscreenshot.Name = "imgscreenshot";
            this.imgscreenshot.Size = new System.Drawing.Size(329, 226);
            this.imgscreenshot.TabIndex = 1;
            this.imgscreenshot.TabStop = false;
            this.imgscreenshot.Click += new System.EventHandler(this.imgscreenshot_Click);
            // 
            // datagridviewpmdashboard
            // 
            this.datagridviewpmdashboard.BackgroundColor = System.Drawing.Color.White;
            this.datagridviewpmdashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewpmdashboard.Location = new System.Drawing.Point(13, 37);
            this.datagridviewpmdashboard.Name = "datagridviewpmdashboard";
            this.datagridviewpmdashboard.Size = new System.Drawing.Size(290, 780);
            this.datagridviewpmdashboard.TabIndex = 0;
            this.datagridviewpmdashboard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewpmdashboard_CellClick);
            this.datagridviewpmdashboard.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridviewpmdashboard_RowHeaderMouseClick);
            // 
            // ProjectManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 895);
            this.Controls.Add(this.panelMain);
            this.Name = "ProjectManagerDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
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

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.Panel panelDashboard;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnassignbug;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdeveloperusername;
        private System.Windows.Forms.TextBox txtcomponent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtclassname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtmethodname;
        private System.Windows.Forms.TextBox txtproject;
        private System.Windows.Forms.TextBox txtlinefrom;
        private System.Windows.Forms.TextBox txtlineto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel lblversion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RichTextBox richremarks;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnopenide;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbsearchfor;
        private System.Windows.Forms.Button button1;
    }
}