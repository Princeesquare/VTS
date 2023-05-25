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
    public partial class Bus1Time : Form
    {
        public Bus1Time()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buses bus = new Buses();
            bus.Show();

            this.Hide();
        }
    }
}
