﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kakurasu
{
    public partial class FormHowToPlay : Form
    {
        public FormHowToPlay()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHowToPlay_Load(object sender, EventArgs e)
        {
            this.Icon = Resource1.Kakurasu_32;
        }
    }
}
