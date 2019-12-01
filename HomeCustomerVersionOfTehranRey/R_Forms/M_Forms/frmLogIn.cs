using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HomeCustomerVersionOfTehranRey.M_Forms
{
    public partial class frmLogIn : Form
    {
        string connectionstring = @"Data Source=.\SQLEXPRESS;Initial Catalog=Tehranrey;Integrated Security=True";

        public bool prop_SetEnabled_Of_MainTollTip { get; set; }

        public frmLogIn()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" & txtPassWord.Text != "")
            {
                string name = txtUserName.Text;
                string pass = txtPassWord.Text;
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM tblLogIn WHERE UserName = '" +
                    name + "' AND PassWord = '" + pass + "'", connectionstring);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    this.prop_SetEnabled_Of_MainTollTip = true;
                    this.Close();
                }
                else
                {
                    Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.
                        MessageBox_Farsi.Show("نام کاربری یا کلمه عبور اشتباه است. لطفا دوباره تلاش کنید.");

                    txtUserName.Text = "";
                    txtPassWord.Text = "";
                    txtUserName.Select();
                }
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.
                        MessageBox_Farsi.Show("لطفا نام کاربری و کلمه عبور را وارد نمایید.");
                txtUserName.Select();
            }

            
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter )
            {
                txtPassWord.Select();
            }
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnEnter.Select();
            }
        }
    }
}
