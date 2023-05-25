using System;
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
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int centerX = screenWidth / 2;
            int centerY = screenHeight / 2;
           
            Bus1Time b1t = new Bus1Time();
            b1t.StartPosition = FormStartPosition.Manual;
            b1t.Location = new System.Drawing.Point(centerX - b1t.Width / 2, centerY - b1t.Height / 2);
            b1t.Show();
            this.Hide();
        }

        private void signoutbtn_Click(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int centerX = screenWidth / 2;
            int centerY = screenHeight / 2;
            LoginPage login = new LoginPage();
            login.StartPosition = FormStartPosition.Manual;
            login.Location = new System.Drawing.Point(centerX - login.Width / 2, centerY - login.Height / 2);
            login.Show();
            this.Hide();
        }
    }
}
