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
        DataTable dt;

        private long customerID;
        
        public frmHomeCustomerListShow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// finde by name & family
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="family">family</param>
        private DataTable FindeByName(string name, string family)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj 
                = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

            DataTable dt = new DataTable();
            dt = obj.Customer_Select_ByName_And_Family(name, family);

            return dt;
        }

        /// <summary>
        /// fide by ID
        /// </summary>
        /// <param name="id">customerID</param>
        private DataTable FindeByID(long id)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

            DataTable dt = new DataTable();
            dt = obj.Customer_Select_ByID(id);

            return dt;
        }
        public void Set_HeaderCostumerListShow(DataGridView dg, DataTable dt)
        {

            dg.DataSource = dt;
            dg.DataMember = dt.TableName;

            if (dt.Rows.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "کد اشتراک";
                dataGridView1.Columns[1].HeaderText = "نام";
                dataGridView1.Columns[2].HeaderText = "نام خانوادگی";
                dataGridView1.Columns[3].HeaderText = "معرف";
                dataGridView1.Columns[4].HeaderText = "تلفن";
                dataGridView1.Columns[5].HeaderText = "آدرس";
            }

        }
        private void frmHomeCustomerListShow_Load(object sender, EventArgs e)
        {
            txtName.Select();

            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

            this.dt = obj.Customer_Select();

            Set_HeaderCostumerListShow(dataGridView1, dt);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj1 =
                new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();
            
            frmHomeCustomerRegistration obj = new frmHomeCustomerRegistration();
            obj.ShowDialog();
            DataTable temp = new DataTable();
            temp = obj1.Customer_Select();
            Set_HeaderCostumerListShow(dataGridView1,temp);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable Costumer;

            if (rdbID.Checked)
            {
                if (txtCode.Text != "")
                { 
                    Costumer = this.FindeByID(int.Parse(txtCode.Text));
                    Set_HeaderCostumerListShow(dataGridView1,Costumer);
                    
                    if (Costumer.Rows.Count == 0)
                    {
                        Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("مشتری با این مشخصات ثبت نشده است !");
                        txtCode.Select();
                    }
                }
                else
                {
                    Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً کد اشتراک مشتری را وارد کنید !");
                    txtCode.Select();
                }
            }

            if(rdbName.Checked)
            {
                if (txtName.Text != "" && txtFamily.Text != "")
                {
                    Costumer = this.FindeByName(txtName.Text, txtFamily.Text);
                    Set_HeaderCostumerListShow(dataGridView1, Costumer);

                    if (Costumer.Rows.Count == 0)
                    {
                        Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("مشتری با این مشخصات ثبت نشده است !");
                        txtCode.Select();
                    }
                }
                else
                {
                    Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً نام و نام خانوادگی مشتری را وارد کنید !");
                    txtName.Select();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();
            this.dt = obj.Customer_Select();
            Set_HeaderCostumerListShow(dataGridView1, dt);
            
            if (dt.Rows.Count >0)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.DataMember = dt.TableName;
            }
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
                this.customerID = System.Convert.ToInt64(dataGridView1.SelectedRows[0].Cells["CustomerID"].Value);

                HomeCustomerVersionOfTehranRey.Forms.frmHomeCustomerRegistration obj =
                    new frmHomeCustomerRegistration();

                obj.prop_GetCustomerID = this.customerID;
                obj.prop_IsEdit = true;

                obj.FormClosed += new FormClosedEventHandler(obj_FormClosed);
                obj.ShowDialog();
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً ردیف مشتری مورد نظر را انتخاب کنید!");
            }
            
        }

        void obj_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj =
                new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();
            dt = obj.Customer_Select();
            Set_HeaderCostumerListShow(dataGridView1, dt);
        }

        private void btnShowCarpetList_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count !=0)
            {
                this.customerID = System.Convert.ToInt64((dataGridView1.SelectedRows[0].Cells[0]).Value);

                frmCarpetListShow obj = new frmCarpetListShow();
                obj.prop_getCustomerID = customerID;
                obj.ShowDialog();
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً ردیف مشتری مورد نظر را انتخاب کنید!");
            }
        }

        private void btnFactor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                this.customerID = System.Convert.ToInt64((dataGridView1.SelectedRows[0].Cells[0]).Value);

                frmFactorSetting obj = new frmFactorSetting();
                obj.prop_GetCustomerID = customerID;
                obj.ShowDialog();
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً ردیف مشتری مورد نظر را انتخاب کنید!");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Microgod.AmrComponent.AmrDynamicCrystal.frmReport report = new Microgod.AmrComponent.AmrDynamicCrystal.frmReport(dataGridView1, "", "");

            report.ShowDialog();
        }
    }
}