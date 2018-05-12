﻿namespace BugTrackingSystem
{
    partial class ReportBug
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseScreenshot = new System.Windows.Forms.Button();
            this.txtscreenshotlocation = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtshortdesc = new System.Windows.Forms.TextBox();
            this.txtclassname = new System.Windows.Forms.TextBox();
            this.txtMethodname = new System.Windows.Forms.TextBox();
            this.txtlinefrom = new System.Windows.Forms.TextBox();
            this.txtlineto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richtxtbugdesc = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSeverity = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRepoURL = new System.Windows.Forms.TextBox();
            this.imgsubmit = new System.Windows.Forms.PictureBox();
            this.pbscreenshot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgsubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbscreenshot)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Summary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Screenshot";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnBrowseScreenshot
            // 
            this.btnBrowseScreenshot.Location = new System.Drawing.Point(538, 510);
            this.btnBrowseScreenshot.Name = "btnBrowseScreenshot";
            this.btnBrowseScreenshot.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseScreenshot.TabIndex = 3;
            this.btnBrowseScreenshot.Text = "Browse";
            this.btnBrowseScreenshot.UseVisualStyleBackColor = true;
            this.btnBrowseScreenshot.Click += new System.EventHandler(this.btnBrowseScreenshot_Click);
            // 
            // txtscreenshotlocation
            // 
            this.txtscreenshotlocation.Enabled = false;
            this.txtscreenshotlocation.Location = new System.Drawing.Point(194, 513);
            this.txtscreenshotlocation.Name = "txtscreenshotlocation";
            this.txtscreenshotlocation.Size = new System.Drawing.Size(313, 20);
            this.txtscreenshotlocation.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(201, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(313, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Line Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "To";
            // 
            // txtshortdesc
            // 
            this.txtshortdesc.Location = new System.Drawing.Point(201, 195);
            this.txtshortdesc.Name = "txtshortdesc";
            this.txtshortdesc.Size = new System.Drawing.Size(260, 20);
            this.txtshortdesc.TabIndex = 11;
            this.txtshortdesc.TextChanged += new System.EventHandler(this.txtshortdesc_TextChanged);
            // 
            // txtclassname
            // 
            this.txtclassname.Location = new System.Drawing.Point(198, 291);
            this.txtclassname.Name = "txtclassname";
            this.txtclassname.Size = new System.Drawing.Size(260, 20);
            this.txtclassname.TabIndex = 12;
            // 
            // txtMethodname
            // 
            this.txtMethodname.Location = new System.Drawing.Point(198, 336);
            this.txtMethodname.Name = "txtMethodname";
            this.txtMethodname.Size = new System.Drawing.Size(260, 20);
            this.txtMethodname.TabIndex = 13;
            // 
            // txtlinefrom
            // 
            this.txtlinefrom.Location = new System.Drawing.Point(198, 424);
            this.txtlinefrom.Name = "txtlinefrom";
            this.txtlinefrom.Size = new System.Drawing.Size(100, 20);
            this.txtlinefrom.TabIndex = 14;
            // 
            // txtlineto
            // 
            this.txtlineto.Location = new System.Drawing.Point(407, 424);
            this.txtlineto.Name = "txtlineto";
            this.txtlineto.Size = new System.Drawing.Size(100, 20);
            this.txtlineto.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 578);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Bug Description";
            // 
            // richtxtbugdesc
            // 
            this.richtxtbugdesc.Location = new System.Drawing.Point(194, 552);
            this.richtxtbugdesc.Name = "richtxtbugdesc";
            this.richtxtbugdesc.Size = new System.Drawing.Size(711, 114);
            this.richtxtbugdesc.TabIndex = 18;
            this.richtxtbugdesc.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Components";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(201, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 95);
            this.listBox1.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(591, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Severity";
            // 
            // cmbSeverity
            // 
            this.cmbSeverity.FormattingEnabled = true;
            this.cmbSeverity.Items.AddRange(new object[] {
            "Critical",
            "High",
            "Normal",
            "Low"});
            this.cmbSeverity.Location = new System.Drawing.Point(671, 92);
            this.cmbSeverity.Name = "cmbSeverity";
            this.cmbSeverity.Size = new System.Drawing.Size(121, 21);
            this.cmbSeverity.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(595, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "OS";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.Location = new System.Drawing.Point(20, 243);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(57, 13);
            this.Version.TabIndex = 24;
            this.Version.Text = "Version";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(201, 236);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(100, 20);
            this.txtVersion.TabIndex = 25;
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(671, 127);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(100, 20);
            this.txtOS.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 474);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Repository URL";
            // 
            // txtRepoURL
            // 
            this.txtRepoURL.Location = new System.Drawing.Point(201, 466);
            this.txtRepoURL.Name = "txtRepoURL";
            this.txtRepoURL.Size = new System.Drawing.Size(293, 20);
            this.txtRepoURL.TabIndex = 28;
            // 
            // imgsubmit
            // 
            this.imgsubmit.Image = global::BugTrackingSystem.Properties.Resources.submit;
            this.imgsubmit.Location = new System.Drawing.Point(194, 705);
            this.imgsubmit.Name = "imgsubmit";
            this.imgsubmit.Size = new System.Drawing.Size(126, 33);
            this.imgsubmit.TabIndex = 29;
            this.imgsubmit.TabStop = false;
            // 
            // pbscreenshot
            // 
            this.pbscreenshot.Location = new System.Drawing.Point(574, 243);
            this.pbscreenshot.Name = "pbscreenshot";
            this.pbscreenshot.Size = new System.Drawing.Size(315, 243);
            this.pbscreenshot.TabIndex = 16;
            this.pbscreenshot.TabStop = false;
            // 
            // ReportBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 750);
            this.Controls.Add(this.imgsubmit);
            this.Controls.Add(this.txtRepoURL);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbSeverity);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.richtxtbugdesc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pbscreenshot);
            this.Controls.Add(this.txtlineto);
            this.Controls.Add(this.txtlinefrom);
            this.Controls.Add(this.txtMethodname);
            this.Controls.Add(this.txtclassname);
            this.Controls.Add(this.txtshortdesc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtscreenshotlocation);
            this.Controls.Add(this.btnBrowseScreenshot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Enabled = false;
            this.Name = "ReportBug";
            this.Text = "Report Bug";
            this.Load += new System.EventHandler(this.ReportBug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgsubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbscreenshot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseScreenshot;
        private System.Windows.Forms.TextBox txtscreenshotlocation;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtshortdesc;
        private System.Windows.Forms.TextBox txtclassname;
        private System.Windows.Forms.TextBox txtMethodname;
        private System.Windows.Forms.TextBox txtlinefrom;
        private System.Windows.Forms.TextBox txtlineto;
        private System.Windows.Forms.PictureBox pbscreenshot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richtxtbugdesc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSeverity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRepoURL;
        private System.Windows.Forms.PictureBox imgsubmit;
    }
}