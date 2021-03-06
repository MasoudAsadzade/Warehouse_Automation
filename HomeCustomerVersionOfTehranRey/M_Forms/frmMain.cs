using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HomeCustomerVersionOfTehranRey.Forms
{
    public partial class frmMain : Form
    {

        HomeCustomerVersionOfTehranRey.M_Forms.frmLogIn LogInForm;
        int oldKB = 0;

        public const int HKL_NEXT = 1;
        public const int HKL_PREV = 0;

        [DllImport("user32.dll")]
        public static extern int ActivateKeyboardLayout(int HKL, int flags);
        [DllImport("user32.dll")]
        public static extern int GetKeyboardLayout(int dwLayout);  
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ActivateKeyboardLayout(oldKB, 0);
        }

        private void customerRegistrationj_Click(object sender, EventArgs e)
        {
            frmHomeCustomerRegistration obj = new frmHomeCustomerRegistration();
            obj.prop_IsEdit = false;
            obj.ShowDialog();
        }

        private void customerListShow_Click(object sender, EventArgs e)
        {
            frmHomeCustomerListShow obj = new frmHomeCustomerListShow();
            obj.ShowDialog();
        }

        private void Factor_Click(object sender, EventArgs e)
        {
            frmHomeCustomerListShow obj = new frmHomeCustomerListShow();
            obj.ShowDialog();
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"c:/windows/system32/calc.exe");
        }

        private void NotePad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"c:/windows/system32/notepad.exe");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"c:/windows/system32/calc.exe");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"c:/windows/system32/notepad.exe");
        }

        private void اصلاحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeCustomerVersionOfTehranRey.Forms.frmHomeCustomerRegistration obj =
                new frmHomeCustomerRegistration();
            obj.prop_IsEdit = true;
            obj.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.analogClock1.Time = DateTime.Now;
        }

        private void ثبتکارمندجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeCustomerVersionOfTehranRey.R_Forms.frmWorkerRegistration obj =
                new HomeCustomerVersionOfTehranRey.R_Forms.frmWorkerRegistration();
            obj.ShowDialog();
          
        }

        private void لیستکارمندانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeCustomerVersionOfTehranRey.R_Forms.frmWorkerListShow obj =
                new HomeCustomerVersionOfTehranRey.R_Forms.frmWorkerListShow();
            obj.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.LogInForm = new HomeCustomerVersionOfTehranRey.M_Forms.frmLogIn();
            this.LogInForm.FormClosed += new FormClosedEventHandler(LogInForm_FormClosed);
            LogInForm.Show();
            btnLogIn.Enabled = false;
        }

        void LogInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Enabled = this.LogInForm.prop_SetEnabled_Of_MainTollTip;
            main.Visible = this.LogInForm.prop_SetEnabled_Of_MainTollTip;
            toolStrip1.Visible = this.LogInForm.prop_SetEnabled_Of_MainTollTip;

            btnLogIn.Enabled = false;
            btnLogIn.Visible = false;
            toolStripContainer1.Visible = true;
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main.Visible = false;
            btnLogIn.Visible = true;
            btnLogIn.Enabled = true;
            toolStripContainer1.Visible = false;
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\help.vsd");
        }
    }
}