using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace HomeCustomerVersionOfTehranRey.Component
{
    public partial class cmoReportInExcel : Component
    {
        public cmoReportInExcel()
        {
            InitializeComponent();
        }

        public cmoReportInExcel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
