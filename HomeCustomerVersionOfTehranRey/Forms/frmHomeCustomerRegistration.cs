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
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Tehranrey;Integrated Security=True";
        public long lastSN_Customer;

        string CustomerName;
        string CustomerFamily;
        string ReferrerName;
        string PhoneNumber;
        string Address;


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
                SqlConnection cn = new SqlConnection(connectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Customer WHERE CustomerID =" + prop_GetCustomerID.ToString()
                    , cn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                txtName.Text = dr.GetSqlValue(1).ToString();
                txtFamily.Text = dr.GetSqlValue(2).ToString();
                txtReferrerName.Text = dr.GetSqlValue(3).ToString();
                txtPhoneNumber.Text = dr.GetSqlValue(4).ToString();
                txtAddress.Text = dr.GetSqlValue(5).ToString();
                
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
            if (txtName.Text == "" || txtFamily.Text =="" || txtAddress.Text=="" || txtPhoneNumber.Text=="")
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show(".لطفا اطلاعات ضروری را وارد کنید");
                txtName.Focus();
            }
            else
            {
                CustomerName = txtName.Text;
                CustomerFamily = txtFamily.Text;
                ReferrerName = txtReferrerName.Text;
                Address = txtAddress.Text;
                PhoneNumber = txtPhoneNumber.Text;

                HomeCustomerVersionOfTehranRey.Classes.clsHomeCustomerDB obj = new HomeCustomerVersionOfTehranRey.Classes.clsHomeCustomerDB();
                obj.HomeCustomerInsert(CustomerName, CustomerFamily, ReferrerName, PhoneNumber, Address);
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show(".مشخصات مشتری ثبت شد");
                SqlDataAdapter da = new SqlDataAdapter("SELECT MAX(CustomerID) FROM Customer", connectionString);
                DataSet ds = new DataSet();
                da.Fill(ds, "Customer");
                this.lastSN_Customer = (long)(ds.Tables[0].Rows[0][0]);

                frmCarpetRegistration obj1 = new frmCarpetRegistration();
                obj1.prop_getCustomerID = this.lastSN_Customer;
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
            this.CustomerName = txtName.Text;
            this.CustomerFamily = txtFamily.Text;
            this.ReferrerName = txtReferrerName.Text;
            this.PhoneNumber = txtPhoneNumber.Text;
            this.Address = txtAddress.Text;

            HomeCustomerVersionOfTehranRey.Classes.clsHomeCustomerDB obj =
                new HomeCustomerVersionOfTehranRey.Classes.clsHomeCustomerDB();
            obj.HomeCustomerUpdate(
                this.prop_GetCustomerID,
                this.CustomerName, this.CustomerFamily, this.ReferrerName, this.PhoneNumber,
                this.Address);

            Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("اطلاعات مشتری اصلاح شد");
            this.Close();
        }
    }
}