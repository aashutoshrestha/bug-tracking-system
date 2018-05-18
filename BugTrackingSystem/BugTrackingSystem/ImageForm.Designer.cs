namespace BugTrackingSystem
{
    partial class ImageForm
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
            this.pbmain = new System.Windows.Forms.PictureBox();
            this.pbclose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbmain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbmain
            // 
            this.pbmain.Location = new System.Drawing.Point(0, 31);
            this.pbmain.Name = "pbmain";
            this.pbmain.Size = new System.Drawing.Size(981, 555);
            this.pbmain.TabIndex = 0;
            this.pbmain.TabStop = false;
            // 
            // pbclose
            // 
            this.pbclose.Image = global::BugTrackingSystem.Properties.Resources.Red_Cross_PNG_File;
            this.pbclose.Location = new System.Drawing.Point(953, -4);
            this.pbclose.Name = "pbclose";
            this.pbclose.Size = new System.Drawing.Size(28, 29);
            this.pbclose.TabIndex = 1;
            this.pbclose.TabStop = false;
            this.pbclose.Click += new System.EventHandler(this.pbclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(912, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Close";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 584);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbclose);
            this.Controls.Add(this.pbmain);
            this.Name = "ImageForm";
            this.Text = "Image";
            this.Load += new System.EventHandler(this.Image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbmain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbmain;
        private System.Windows.Forms.PictureBox pbclose;
        private System.Windows.Forms.Label label1;
    }
}