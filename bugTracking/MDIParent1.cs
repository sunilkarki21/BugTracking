﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bugTracking
{
    public partial class MDIParent1 : Form
    {
          

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void biodataToolStripMenuItem_Click(object sender, EventArgs e)
        {
         }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
