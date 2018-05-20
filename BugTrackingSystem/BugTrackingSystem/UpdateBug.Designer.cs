namespace BugTrackingSystem
{
    partial class UpdateBug
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
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblrequest = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbllastupdateon = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbllastupdatedby = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpreviousecode = new System.Windows.Forms.RichTextBox();
            this.txtupdatecode = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtremarks = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtversion = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.submit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Unresolved",
            "Reviewed",
            "Resolved"});
            this.cmbStatus.Location = new System.Drawing.Point(157, 40);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 1;
            // 
            // lblrequest
            // 
            this.lblrequest.AutoSize = true;
            this.lblrequest.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblrequest.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrequest.LinkColor = System.Drawing.Color.Red;
            this.lblrequest.Location = new System.Drawing.Point(351, 40);
            this.lblrequest.Name = "lblrequest";
            this.lblrequest.Size = new System.Drawing.Size(401, 18);
            this.lblrequest.TabIndex = 2;
            this.lblrequest.TabStop = true;
            this.lblrequest.Text = "!Request Project Manager to Assign new Developer!";
            this.lblrequest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Updated on";
            // 
            // lbllastupdateon
            // 
            this.lbllastupdateon.AutoSize = true;
            this.lbllastupdateon.Location = new System.Drawing.Point(467, 80);
            this.lbllastupdateon.Name = "lbllastupdateon";
            this.lbllastupdateon.Size = new System.Drawing.Size(53, 13);
            this.lbllastupdateon.TabIndex = 4;
            this.lbllastupdateon.TabStop = true;
            this.lbllastupdateon.Text = "Unknown";
            this.lbllastupdateon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllastupdateon_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Updated By";
            // 
            // lbllastupdatedby
            // 
            this.lbllastupdatedby.AutoSize = true;
            this.lbllastupdatedby.Location = new System.Drawing.Point(467, 121);
            this.lbllastupdatedby.Name = "lbllastupdatedby";
            this.lbllastupdatedby.Size = new System.Drawing.Size(53, 13);
            this.lbllastupdatedby.TabIndex = 6;
            this.lbllastupdatedby.TabStop = true;
            this.lbllastupdatedby.Text = "Unknown";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bug Description";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(157, 178);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.ReadOnly = true;
            this.txtdesc.Size = new System.Drawing.Size(649, 96);
            this.txtdesc.TabIndex = 8;
            this.txtdesc.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Previous Source Code";
            // 
            // txtpreviousecode
            // 
            this.txtpreviousecode.Location = new System.Drawing.Point(157, 300);
            this.txtpreviousecode.Name = "txtpreviousecode";
            this.txtpreviousecode.ReadOnly = true;
            this.txtpreviousecode.Size = new System.Drawing.Size(649, 180);
            this.txtpreviousecode.TabIndex = 10;
            this.txtpreviousecode.Text = "";
            // 
            // txtupdatecode
            // 
            this.txtupdatecode.Location = new System.Drawing.Point(157, 486);
            this.txtupdatecode.Name = "txtupdatecode";
            this.txtupdatecode.Size = new System.Drawing.Size(649, 174);
            this.txtupdatecode.TabIndex = 11;
            this.txtupdatecode.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 517);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Updated Source Code";
            // 
            // txtremarks
            // 
            this.txtremarks.Location = new System.Drawing.Point(157, 696);
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.Size = new System.Drawing.Size(649, 96);
            this.txtremarks.TabIndex = 13;
            this.txtremarks.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 669);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Remarks/ What was updated and Why?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Version";
            // 
            // txtversion
            // 
            this.txtversion.Location = new System.Drawing.Point(157, 95);
            this.txtversion.Name = "txtversion";
            this.txtversion.Size = new System.Drawing.Size(121, 20);
            this.txtversion.TabIndex = 17;
            // 
            // submit
            // 
            this.submit.Image = global::BugTrackingSystem.Properties.Resources.submit;
            this.submit.Location = new System.Drawing.Point(37, 800);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(138, 35);
            this.submit.TabIndex = 15;
            this.submit.TabStop = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Open in Text Editor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 836);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtversion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtremarks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtupdatecode);
            this.Controls.Add(this.txtpreviousecode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbllastupdatedby);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbllastupdateon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblrequest);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label1);
            this.Name = "UpdateBug";
            this.Text = "UpdateBug";
            this.Load += new System.EventHandler(this.UpdateBug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.submit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.LinkLabel lblrequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lbllastupdateon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lbllastupdatedby;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtdesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtpreviousecode;
        private System.Windows.Forms.RichTextBox txtupdatecode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtremarks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox submit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtversion;
        private System.Windows.Forms.Button button1;
    }
}