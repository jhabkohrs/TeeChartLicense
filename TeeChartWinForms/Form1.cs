using System;
using System.Windows.Forms;
using TeeChartLibrary;

namespace TeeChartWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var checker = new TeeChartLicenseChecker();
            MessageBox.Show($"IsLicensed: {checker.IsLicensed()}");
        }
    }
}
