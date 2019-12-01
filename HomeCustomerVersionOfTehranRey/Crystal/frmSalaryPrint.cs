using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HomeCustomerVersionOfTehranRey.Crystal
{
    public partial class frmSalaryPrint : Form
    {
        public frmSalaryPrint()
        {
            InitializeComponent();
        }

        private void SalaryPrint_Load(object sender, EventArgs e)
        {
            CrystalReportWorkerSalary1.ResourceName = Application.StartupPath.ToString() + "\\SalaryReport.xml";
        }
    }
}
