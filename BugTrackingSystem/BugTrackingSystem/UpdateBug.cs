﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem
{
    public partial class UpdateBug : Form
    {
        public UpdateBug()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBug_Load(object sender, EventArgs e)
        {
            submit.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
