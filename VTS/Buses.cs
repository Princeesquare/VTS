﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTS
{
    public partial class Buses : Form
    {
        
        public Buses()
        {
            InitializeComponent();
        }

        private void bus1_Click(object sender, EventArgs e)
        {
            Bus1Time b1t = new Bus1Time();
            b1t.Show();
            this.Hide();
        }

        private void signoutbtn_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }
    }
}
