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
    public partial class frmHomeCustomerRegistration : Form
    {
        public long lastSN_Customer;
        string CustomerName;
        string CustomerFamily;
        string ReferrerName;
        string PhoneNumber;
        string Address;
        long carpetNumber;

        public long prop_GetCustomerID { get; set; }
        public bool prop_IsEdit { get; set; }

        public frmHomeCustomerRegistration()
        {
            InitializeComponent();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.prop_IsEdit)
            {
                HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                    = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

                DataTable dt = new DataTable();
                dt = obj.Customer_Select_ByID(this.prop_GetCustomerID);

                txtName.Text = dt.Rows[0][1].ToString();
                txtFamily.Text = dt.Rows[0][2].ToString();
                txtReferrerName.Text = dt.Rows[0][3].ToString();
                txtPhoneNumber.Text = dt.Rows[0][4].ToString();
                txtAddress.Text = dt.Rows[0][5].ToString();
                
                this.Text = "اصلاح اطلاعات مشتری";
                btnEdit.Visible = this.prop_IsEdit;
                btnAdd.Visible = !this.prop_IsEdit;
            }
            else
            {
                this.Text = "ورود مشتری جدید";
                btnEdit.Visible = this.prop_IsEdit;
                btnAdd.Visible = !this.prop_IsEdit;
            }
            
            txtName.Select();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtFamily.Text == "" || txtAddress.Text == "" || txtPhoneNumber.Text == "")
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً اطلاعات ضروری را وارد کنید!");
                txtName.Focus();
            }
            else
            {
                CustomerName = txtName.Text;
                CustomerFamily = txtFamily.Text;
                ReferrerName = txtReferrerName.Text;
                Address = txtAddress.Text;
                PhoneNumber = txtPhoneNumber.Text;

                HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj =
                    new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();
                obj.HomeCustomerInsert(CustomerName, CustomerFamily, ReferrerName, PhoneNumber, Address);
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("مشخصات مشتری با موفقیت ثبت شد!");

                this.lastSN_Customer = obj.tblCustomer_Select_Max_CustomerID();

                //***************** for CarpetRegirstration Lables***************
                frmCarpetRegistration obj1 = new frmCarpetRegistration(); 
                obj1.prop_getCustomerID = this.lastSN_Customer;
                obj1.prop_dtCarpet = obj.CustomerCarpet_Select_ByCustomerID(obj1.prop_getCustomerID);
                obj1.prop_getCustomerName = txtName.Text;
                obj1.prop_getCustomerfamily = txtFamily.Text;
                obj1.prop_getCarpetLable = obj1.prop_getCustomerID.ToString() + "_" + ((this.carpetNumber) + 1).ToString();
               
                //***************** End of CarpetRegirstration Lables***************

                obj1.ShowDialog(); 
                this.Close(); 
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
                txtReferrerName.Focus();
            }
        }

        private void txtReferrerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtPhoneNumber.Focus();
            }
        }

        private void txtPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtAddress.Focus();
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnAdd.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtFamily.Text == "" || txtAddress.Text == "" || txtPhoneNumber.Text == "")
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً اطلاعات ضروری را وارد کنید!");
                txtName.Focus();
            }
            else
            {
                this.CustomerName = txtName.Text;
                this.CustomerFamily = txtFamily.Text;
                this.ReferrerName = txtReferrerName.Text;
                this.PhoneNumber = txtPhoneNumber.Text;
                this.Address = txtAddress.Text;

                HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj =
                    new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();
                obj.HomeCustomerUpdate(
                    this.prop_GetCustomerID,
                    this.CustomerName, this.CustomerFamily, this.ReferrerName, this.PhoneNumber,
                    this.Address);

                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("اطلاعات مشتری اصلاح شد!");
                this.Close();
            }
        }
    }
}