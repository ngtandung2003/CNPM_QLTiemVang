using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class StorageReport : Form
    {
        private string month;

        public StorageReport(string selectedMonth)
        {
            InitializeComponent();
            month = selectedMonth;
        }

        private void StorageReport_Load(object sender, EventArgs e)
        {
            labelMonth.Text = "Tháng: " + month;
        }
    }
}
