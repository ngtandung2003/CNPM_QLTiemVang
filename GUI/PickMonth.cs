using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp2
{
    public partial class PickMonth : Form
    {
        public PickMonth()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePickerMonth.Format = DateTimePickerFormat.Custom;
            dateTimePickerMonth.CustomFormat = "MM/yyyy";
            dateTimePickerMonth.ShowUpDown = true;
        }

        private void buttonOK_Click(object sender, EventArgs e, PickMonth pickMonth)
        {
            string selectedMonth = dateTimePickerMonth.Value.ToString("MM/yyyy");
            StorageReport reportForm = new StorageReport(selectedMonth);
            reportForm.Show();

        }
    }
}
