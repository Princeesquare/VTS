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
        private void SetupDataGridView()
        {
            // Create columns
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "Column 1";
            dataGridView.Columns.Add(column1);

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Column 2";
            dataGridView.Columns.Add(column2);

            // Create rows
            for (int i = 0; i < 10; i++)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = "Row " + (i + 1) + ", Column 1";
                dataGridView.Rows[i].Cells[1].Value = "Row " + (i + 1) + ", Column 2";
            }
        }

        private void Bus1Time_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }
    }
}
