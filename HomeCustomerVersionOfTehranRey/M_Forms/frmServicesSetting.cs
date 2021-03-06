using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HomeCustomerVersionOfTehranRey.Forms
{
    public partial class frmServicesSetting : Form
    {
        int Index;
        long serviceFee;
        string discribtion;

        public frmServicesSetting()
        {
            InitializeComponent();
        }

        private void Set_HeaderServices(DataGridView dg, DataTable dt)
        {
            dg.DataSource = dt;
            dg.DataMember = dt.TableName;

            if (dt.Rows.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "ردیف";
                dataGridView1.Columns[0].Width = 30;
                dataGridView1.Columns[1].HeaderText = "نام خدمت";
                dataGridView1.Columns[1].Width = 90;
                dataGridView1.Columns[2].HeaderText = "فی";
                dataGridView1.Columns[2].Width = 50;
                dataGridView1.Columns[3].HeaderText = "توضیحات";
                dataGridView1.Columns[3].Width = 100;
            }
        }
        private void frmServicesSetting_Load(object sender, EventArgs e)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj =
                new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

            DataTable dt = new DataTable();
            dt = obj.ServiceSelect();
            this.Set_HeaderServices(dataGridView1, dt);
            btnEdit.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.txtServiceFee.Text == "")
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً مبلغ را وارد کنید!");
            }
            else
            {
                HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj =
                               new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

                if (dataGridView1.SelectedRows.Count != 0)
                {
                    this.Index = System.Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value);
                    this.serviceFee = System.Convert.ToInt64(txtServiceFee.Text);
                    this.discribtion = txtDiscribtion.Text;
                    obj.ServiceUpdate(this.Index, this.txtServiceName.Text, this.serviceFee, this.discribtion);
                    Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("اطلاعات با موفقیت تصحیح شد!");
                    DataTable dt = new DataTable();
                    dt = obj.ServiceSelect();
                    this.Set_HeaderServices(dataGridView1, dt);
                }
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtServiceFee.Select();
            if (dataGridView1.SelectedRows.Count != 0)
            {
                txtServiceName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtServiceFee.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtDiscribtion.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();  
                this.btnEdit.Enabled = true;
            }
        }

        private void txtServiceFee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtDiscribtion.Select();
            }
        }

        private void txtDiscribtion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnEdit.Select();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}