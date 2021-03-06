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
    public partial class frmHomeCustomerListShow : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Tehranrey;Integrated Security=True";
        SqlDataAdapter da;
        DataSet ds;

        private long customerID;
        //private string customerName;
        //private string customerFamily;
        //private string customerReferrer;
        //private string customerPhone;
        //private string customerAddress;

        public frmHomeCustomerListShow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// finde by name & family
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="family">family</param>
        private void FindeByName(string name, string family)
        {
            ds = new DataSet();
            da = new SqlDataAdapter(
                "SELECT * FROM Customer WHERE firstName LIKE '" + name
                + "' AND lastName LIKE '" + family + "'"
                , connectionString);
            da.Fill(ds, "Customer");
        }

        /// <summary>
        /// fide by ID
        /// </summary>
        /// <param name="id">customerID</param>
        private void FindeByID(int id)
        {
            ds = new DataSet();
            da = new SqlDataAdapter(
                "SELECT * FROM Customer WHERE CustomerID =" + id
                , connectionString);
            da.Fill(ds, "Customer");
        }
	
        private void frmHomeCustomerListShow_Load(object sender, EventArgs e)
        {
            txtName.Select();

            ds = new DataSet();
            da = new SqlDataAdapter("select * from Customer", connectionString);
            da.Fill(ds, "Customer");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Customer";
            dataGridView1.Columns[0].HeaderText = "کد اشتراک";
            dataGridView1.Columns[1].HeaderText = "نام";
            dataGridView1.Columns[2].HeaderText = "نام خانوادگی";
            dataGridView1.Columns[3].HeaderText = "معرف";
            dataGridView1.Columns[4].HeaderText = "تلفن";
            dataGridView1.Columns[5].HeaderText = "آدرس";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHomeCustomerRegistration obj = new frmHomeCustomerRegistration();
            obj.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (rdbID.Checked)
            {
                if (txtCode.Text != "")
                {
                    this.FindeByID(int.Parse(txtCode.Text));

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        dataGridView1.DataSource = ds;
                        dataGridView1.DataMember = "Customer";
                    }
                    else
                    {
                        Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show(".مشتری با این مشخصات ثبت نشده است");
                        txtCode.Select();
                        return;
                    }

                }
                else
                {
                    Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("!لطفا کد اشتراک مشتری را وارد کنید");
                    txtCode.Select();
                }
            }

            else
            {
                if (txtName.Text != "" && txtFamily.Text != "")
                {
                    this.FindeByName(txtName.Text, txtFamily.Text);

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        dataGridView1.DataSource = ds;
                        dataGridView1.DataMember = "Customer";
                    }
                    else
                    {
                        Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show(".مشتری با این مشخصات ثبت نشده است");
                        txtName.Select();
                        return;
                    }

                }
                else
                {
                    Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("!لطفا نام و نام خانوادگی مشتری را وارد کنید");
                    txtName.Select();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from Customer", connectionString);
            da.Fill(ds, "Customer");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Customer";
        }

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
           
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtFamily.Focus();
            }
        }

        private void txtFamily_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSearch.Focus();
            }
        }

        private void rdbID_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbID.Checked)
            {
                txtCode.Select();
                panelName.Visible = false;
                panel_CustomerCode.Visible = true;
            }
            if (rdbName.Checked)
            {
                txtName.Select();
                panel_CustomerCode.Visible = false;
                panelName.Visible = true;
            }
        }

        private void rdbName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbName.Checked)
            {
                txtName.Select();
                panelName.Visible = true;
                panel_CustomerCode.Visible = false;
            }
            if (rdbID.Checked)
            {
                txtCode.Select();
                panel_CustomerCode.Visible = true;
                panelName.Visible = false;
            }

        }

        private void txtName_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtFamily.Select();
            }
        }

        private void txtFamily_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSearch.Select();
            }
        }

        private void txtCustomerCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSearch.Select();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                this.customerID = (Int64)dataGridView1.SelectedRows[0].Cells["CustomerID"].Value;

                HomeCustomerVersionOfTehranRey.Forms.frmHomeCustomerRegistration obj =
                    new frmHomeCustomerRegistration();

                obj.prop_GetCustomerID = this.customerID;
                obj.prop_IsEdit = true;

                obj.ShowDialog();
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفا ردیف مشتری موردنظر را انتخاب کنید");
            }
            
        }

        private void btnShowCarpetList_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count !=0)
            {
                this.customerID = (long)((dataGridView1.SelectedRows[0].Cells[0]).Value);

                frmCarpetListShow obj = new frmCarpetListShow();
                obj.prop_getCustomerID = customerID;
                obj.ShowDialog();
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفا ردیف مشتری موردنظر را انتخاب کنید");
            }
        }

        private void btnFactor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                this.customerID = (long)((dataGridView1.SelectedRows[0].Cells[0]).Value);

                frmFactorSetting obj = new frmFactorSetting();
                obj.prop_GetCustomerID = customerID;
                obj.ShowDialog();
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفا ردیف مشتری موردنظر را انتخاب کنید");
            }
        }
    }
}