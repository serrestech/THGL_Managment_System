﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THGL_Managment_System
{
    public partial class mdiForm : Form
    {
        public mdiForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void νέοΠροϊόνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newProductForm proion = new newProductForm();
            proion.MdiParent = this;
            proion.Show();
        }
    }
}
