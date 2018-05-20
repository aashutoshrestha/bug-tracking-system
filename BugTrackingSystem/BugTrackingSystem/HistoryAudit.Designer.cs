namespace BugTrackingSystem
{
    partial class HistoryAudit
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
            this.datagridhistory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtremarks = new System.Windows.Forms.RichTextBox();
            this.txtpreviousecode = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbllastupdatedby = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbllastupdateon = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridhistory)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridhistory
            // 
            this.datagridhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridhistory.Location = new System.Drawing.Point(12, 64);
            this.datagridhistory.Name = "datagridhistory";
            this.datagridhistory.Size = new System.Drawing.Size(322, 451);
            this.datagridhistory.TabIndex = 0;
            this.datagridhistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridhistory_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "AUDIT HISTORY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Remarks/ What was updated and Why?";
            // 
            // txtremarks
            // 
            this.txtremarks.Location = new System.Drawing.Point(493, 372);
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.ReadOnly = true;
            this.txtremarks.Size = new System.Drawing.Size(413, 96);
            this.txtremarks.TabIndex = 21;
            this.txtremarks.Text = "";
            // 
            // txtpreviousecode
            // 
            this.txtpreviousecode.Location = new System.Drawing.Point(493, 139);
            this.txtpreviousecode.Name = "txtpreviousecode";
            this.txtpreviousecode.ReadOnly = true;
            this.txtpreviousecode.Size = new System.Drawing.Size(413, 180);
            this.txtpreviousecode.TabIndex = 18;
            this.txtpreviousecode.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Previous Source Code";
            // 
            // lbllastupdatedby
            // 
            this.lbllastupdatedby.AutoSize = true;
            this.lbllastupdatedby.Location = new System.Drawing.Point(783, 93);
            this.lbllastupdatedby.Name = "lbllastupdatedby";
            this.lbllastupdatedby.Size = new System.Drawing.Size(53, 13);
            this.lbllastupdatedby.TabIndex = 57;
            this.lbllastupdatedby.TabStop = true;
            this.lbllastupdatedby.Text = "Unknown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Last Updated By";
            // 
            // lbllastupdateon
            // 
            this.lbllastupdateon.AutoSize = true;
            this.lbllastupdateon.Location = new System.Drawing.Point(783, 57);
            this.lbllastupdateon.Name = "lbllastupdateon";
            this.lbllastupdateon.Size = new System.Drawing.Size(53, 13);
            this.lbllastupdateon.TabIndex = 55;
            this.lbllastupdateon.TabStop = true;
            this.lbllastupdateon.Text = "Unknown";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Last Updated on";
            // 
            // HistoryAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 570);
            this.Controls.Add(this.lbllastupdatedby);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbllastupdateon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtremarks);
            this.Controls.Add(this.txtpreviousecode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridhistory);
            this.Name = "HistoryAudit";
            this.Text = "HistoryAudit";
            this.Load += new System.EventHandler(this.HistoryAudit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridhistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridhistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtremarks;
        private System.Windows.Forms.RichTextBox txtpreviousecode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lbllastupdatedby;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lbllastupdateon;
        private System.Windows.Forms.Label label3;
    }
}