namespace BugTrackingSystem
{
    partial class AddProjectComponent
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
            this.txtcomponentdescription = new System.Windows.Forms.RichTextBox();
            this.txtdeveloper = new System.Windows.Forms.TextBox();
            this.txtcomponentname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbsubmit = new System.Windows.Forms.PictureBox();
            this.listBoxAssignedProjectComponents = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbsubmit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Component Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Component Description";
            // 
            // txtcomponentdescription
            // 
            this.txtcomponentdescription.Location = new System.Drawing.Point(181, 144);
            this.txtcomponentdescription.Name = "txtcomponentdescription";
            this.txtcomponentdescription.Size = new System.Drawing.Size(225, 142);
            this.txtcomponentdescription.TabIndex = 3;
            this.txtcomponentdescription.Text = "";
            // 
            // txtdeveloper
            // 
            this.txtdeveloper.Location = new System.Drawing.Point(181, 314);
            this.txtdeveloper.Name = "txtdeveloper";
            this.txtdeveloper.Size = new System.Drawing.Size(243, 20);
            this.txtdeveloper.TabIndex = 4;
            // 
            // txtcomponentname
            // 
            this.txtcomponentname.Location = new System.Drawing.Point(181, 87);
            this.txtcomponentname.Name = "txtcomponentname";
            this.txtcomponentname.Size = new System.Drawing.Size(252, 20);
            this.txtcomponentname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Assign Developer";
            // 
            // pbsubmit
            // 
            this.pbsubmit.Image = global::BugTrackingSystem.Properties.Resources.submit;
            this.pbsubmit.Location = new System.Drawing.Point(181, 358);
            this.pbsubmit.Name = "pbsubmit";
            this.pbsubmit.Size = new System.Drawing.Size(125, 34);
            this.pbsubmit.TabIndex = 7;
            this.pbsubmit.TabStop = false;
            // 
            // listBoxAssignedProjectComponents
            // 
            this.listBoxAssignedProjectComponents.FormattingEnabled = true;
            this.listBoxAssignedProjectComponents.Location = new System.Drawing.Point(513, 313);
            this.listBoxAssignedProjectComponents.Name = "listBoxAssignedProjectComponents";
            this.listBoxAssignedProjectComponents.Size = new System.Drawing.Size(231, 121);
            this.listBoxAssignedProjectComponents.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Currently Assigned Project Components";
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(181, 23);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(225, 21);
            this.cmbProject.TabIndex = 10;
            // 
            // AddProjectComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 487);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxAssignedProjectComponents);
            this.Controls.Add(this.pbsubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcomponentname);
            this.Controls.Add(this.txtdeveloper);
            this.Controls.Add(this.txtcomponentdescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProjectComponent";
            this.Text = "CreateProject";
            ((System.ComponentModel.ISupportInitialize)(this.pbsubmit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtcomponentdescription;
        private System.Windows.Forms.TextBox txtdeveloper;
        private System.Windows.Forms.TextBox txtcomponentname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbsubmit;
        private System.Windows.Forms.ListBox listBoxAssignedProjectComponents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProject;
    }
}