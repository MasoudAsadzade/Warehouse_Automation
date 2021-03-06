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
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Tehranrey;Integrated Security=True";
        SqlDataAdapter da;
        SqlConnection cn;
        DataSet ds = new DataSet();

        int Index;
        string serviceName;
        long serviceFee;
        string discribtion;

        public frmServicesSetting()
        {
            InitializeComponent();
        }

        private void frmServicesSetting_Load(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;

            
            da = new SqlDataAdapter("SELECT * FROM Services", connectionString);
            da.Fill(ds, "Services");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Services";
            if (dataGridView1.DataSource != null)
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

        private void dataGrid_Services_DoubleClick(object sender, EventArgs e)
        {
            

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.serviceName = txtServiceName.Text;
            Int64.TryParse(txtServiceFee.Text, out this.serviceFee);
            string str = this.serviceFee.ToString();
            String str1 = this.Index.ToString();
            this.discribtion = txtDiscribtion.Text;

            DataSet ds1 = new DataSet();
            da = new SqlDataAdapter("UPDATE Services SET ServiceType ='" + this.serviceName + 
                "' , Fee ='" + str + "' , Discribtion ='" + this.discribtion +
                "' WHERE ServiceSerial='" + str1 + "'"
                , connectionString);
            da.Fill(ds, "Services");

            da = new SqlDataAdapter("SELECT * FROM Services "
                , connectionString);
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            da.Fill(ds1, "Services");

            dataGridView1.DataSource = ds1;



            //da = new SqlDataAdapter("SELECT * FROM Services", connectionString);
            //da.Fill(ds, "Services");
            //dataGridView1.Refresh();
            //dataGridView1.EndEdit();
            //dataGridView1.RefreshEdit();
            //dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Services";

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            this.Index = (int)(dataGridView1.SelectedRows[0].Cells[0].Value);
            txtServiceName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtServiceFee.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtDiscribtion.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtServiceName.Select();
            this.btnEdit.Enabled = true;
        }

        private void txtServiceName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtServiceFee.Select();
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


    }
}