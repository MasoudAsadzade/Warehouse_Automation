using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HomeCustomerVersionOfTehranRey.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
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

        private void game1_Click(object sender, EventArgs e)
        {
            Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("WELLCOME TO INKBALL");
            System.Diagnostics.Process.Start( Application.StartupPath.ToString() + "/Games/inkball/inkball.exe");
        }

        private void game2_Click(object sender, EventArgs e)
        {
            Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("WELLCOME TO PURBLEPLACE");
            System.Diagnostics.Process.Start(Application.StartupPath.ToString() + "/Games/Purble Place/PurblePlace.exe");
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

        private void analogClock1_Load(object sender, EventArgs e)
        {

        }

    }
}