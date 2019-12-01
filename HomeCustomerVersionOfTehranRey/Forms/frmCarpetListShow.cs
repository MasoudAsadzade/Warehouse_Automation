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
    public partial class frmCarpetListShow : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Tehranrey;Integrated Security=True";
        SqlDataAdapter da_Carpet;
        SqlDataAdapter da_Customer;
        DataSet ds_Carpet;
        DataSet ds_Customer;
        DataSet ds;

        frmEditCarpet editForm;

        public frmCarpetListShow()
        {
            InitializeComponent();
        }

        public long prop_getCustomerID { get; set; }

        private void rdbCarpetCode_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCarpetCode.Checked)
            {
                txtCarpetCode.Select();
                panelPlace.Visible = false;
                panelSize.Visible = false;
                panelCode.Visible = true;
            }
        }

        private void rdbCarpetSize_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCarpetSize.Checked)
            {
                cmbSize.Select();
                panelPlace.Visible = false;
                panelCode.Visible = false;
                panelSize.Visible = true;
            }
        }

        private void rdbMadInFrom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMadInFrom.Checked)
            {
                cmbPlace.Select();
                panelPlace.Visible = true;
                panelSize.Visible = false;
                panelCode.Visible = true;
            }
        }

        private void frmCarpetListShow_Load(object sender, EventArgs e)
        {
            //***************************************Set the Header Labale Of Form******************************

            lblCustomerID.Text = prop_getCustomerID.ToString();
            ds_Customer = new DataSet();
            da_Customer = new SqlDataAdapter("SELECT firstName,lastName FROM Customer WHERE CustomerID='"
                + this.prop_getCustomerID.ToString() + "'", connectionString);
            da_Customer.Fill(ds_Customer, "Customer");
            lblCustomerName.Text = ds_Customer.Tables[0].Rows[0][0].ToString();
            lblCustomerFamily.Text = ds_Customer.Tables[0].Rows[0][1].ToString();

            //********************************END OF Set the Header Labale Of Form******************************
            
            //******************************** set cmbPlace & cmbSize Items ***********

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT madeInFrom,carpetSize FROM Carpet", connectionString);
            da.Fill(ds, "Carpet");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string str = (ds.Tables[0].Rows[i]["madeInFrom"]).ToString();
                string str1 = (ds.Tables[0].Rows[i]["carpetSize"]).ToString();
                if (cmbPlace.Items.IndexOf(str) == -1)
                {
                    cmbPlace.Items.Add(str);
                }
                if (cmbSize.Items.IndexOf(str1) == -1)
                {
                    cmbSize.Items.Add(str1);
                }
            }
            //End Of //******************************** set cmbPlace & cmbSize Items ***********

            //******************************* Set datagrid & Show data of special customer in it*****

            this.SetDataGridViewForCarpets(dataGridView1, this.ShowLastCarpetOfSpecialCustomer(ds_Carpet));

            //End Of //******************************* Set datagrid & Show data of special customer in it*****

            // ******** set lblResultCount *****************
            lblResultCount.Text =
             dataGridView1.RowCount.ToString() + "  تخته فرش";
            //End of // ******** set lblResultCount *****************
        }

        /// <summary>
        /// this method set a datagridview to show data of Carpet table
        /// </summary>
        /// <param name="dgw">the datagridview that data of carpet table show on it</param>
        /// <param name="ds">the dataset of carpet table</param>
        private void SetDataGridViewForCarpets(DataGridView dgw, DataSet ds)
        {
            dgw.DataMember = "Carpet";
            dgw.DataSource = ds;

            if (dgw.DataSource != null)
            {
                dgw.Columns[0].HeaderText = "شماره";
                dgw.Columns[0].Width = 80;
                dgw.Columns[1].HeaderText = "محل بافت";
                dgw.Columns[1].Width = 110;
                dgw.Columns[2].HeaderText = "سایز";
                dgw.Columns[2].Width = 100;
                dgw.Columns[3].HeaderText = "طول";
                dgw.Columns[3].Width = 65;
                dgw.Columns[4].HeaderText = "عرض";
                dgw.Columns[4].Width = 65;
                dgw.Columns[5].HeaderText = "مساحت";
                dgw.Columns[5].Width = 80;
                dgw.Columns[6].HeaderText = "تاریخ ورود";
                dgw.Columns[6].Visible = false;
                dgw.Columns[7].HeaderText = "تاریخ تحویل";
                dgw.Columns[7].Visible = false;

                FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn cl8 =
                    new FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn();

                FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn cl9 =
                    new FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn();

                cl8.Name = "cl8";
                cl8.DataPropertyName = "enterDate";
                cl8.HeaderText = "تاریخ ورود";
                cl8.Width = 130;
                cl8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                cl8.SelectedDateTime = new System.DateTime(((long)(0)));
                cl8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
                cl8.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2000;
                cl8.VerticalAlignment = System.Drawing.StringAlignment.Near;
                cl9.Name = "cl9";
                cl9.DataPropertyName = "returnDate";
                cl9.HeaderText = "تاریخ تحویل";
                cl9.Width = 130;
                cl9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                cl9.SelectedDateTime = new System.DateTime(((long)(0)));
                cl9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
                cl9.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2000;
                cl9.VerticalAlignment = System.Drawing.StringAlignment.Near;

                dgw.Columns.Add(cl8);
                dgw.Columns.Add(cl9);


            }
        }

        /// <summary>
        /// this method set the dataset include the active caprpets of special customer
        /// to be datasource of datagridview ...
        /// </summary>
        private DataSet ShowLastCarpetOfSpecialCustomer(DataSet ds)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();

            SqlCommand command = new SqlCommand("SELECT CarpetCode FROM CustomerCarpet WHERE CustomerID= '"
                + this.prop_getCustomerID.ToString() + "' ORDER BY carpetCode DESC", cn);
            command.CommandType = CommandType.Text;
            SqlDataReader obj = command.ExecuteReader();

            if (obj.HasRows)
            {
                ds = new DataSet();
                DataSet temp = new DataSet();

                while (obj.Read())
                {
                    long codeTemp = obj.GetInt64(0);
                    SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM Carpet WHERE CarpetCode= '"
                        + codeTemp.ToString() + "'"
                        , connectionString);
                    da1.Fill(temp, "Carpet");
                    da_Carpet = new SqlDataAdapter("SELECT carpetLable," +
                        " madeInFrom, carpetSize, length, width, Area, enterDate, returnDate FROM Carpet WHERE CarpetCode= '"
                        + codeTemp.ToString() + "'AND IsActive = '1'"
                        , connectionString);
                    da_Carpet.Fill(ds, "Carpet");

                }
                obj.Close();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DateTime ent = (DateTime)(ds.Tables[0].Rows[i]["enterDate"]);
                    DateTime ret = (DateTime)(ds.Tables[0].Rows[i]["returnDate"]);

                    ds.Tables[0].Rows[i]["enterDate"] =
                        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ent));
                    ds.Tables[0].Rows[i]["returnDate"] =
                        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ret));

                }
            }
            return ds;
        }

        /// <summary>
        /// find carpet by code
        /// </summary>
        /// <param name="code">carpet code</param>
        private DataSet FindByCarpetCode(string lable)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();

            SqlCommand command = new SqlCommand("SELECT CarpetCode FROM CustomerCarpet WHERE CustomerID= '"
                + this.prop_getCustomerID.ToString() + "' ORDER BY carpetCode DESC", cn);
            command.CommandType = CommandType.Text;
            SqlDataReader obj = command.ExecuteReader();

            if (obj.HasRows)
            {
                ds = new DataSet();
                DataSet temp = new DataSet();

                while (obj.Read())
                {
                    long codeTemp = obj.GetInt64(0);
                    SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM Carpet WHERE CarpetCode= '"
                        + codeTemp.ToString() + "'"
                        , connectionString);
                    da1.Fill(temp, "Carpet");
                    da_Carpet = new SqlDataAdapter("SELECT carpetLable," +
                        " madeInFrom, carpetSize, length, width, Area, enterDate, returnDate FROM Carpet WHERE CarpetCode= '"
                        + codeTemp.ToString() + "'AND IsActive = '1'" + 
                        "AND carpetLable = '" + lable + "'"
                        , connectionString);
                    da_Carpet.Fill(ds, "Carpet");

                }
                obj.Close();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DateTime ent = (DateTime)(ds.Tables[0].Rows[i]["enterDate"]);
                    DateTime ret = (DateTime)(ds.Tables[0].Rows[i]["returnDate"]);

                    ds.Tables[0].Rows[i]["enterDate"] =
                        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ent));
                    ds.Tables[0].Rows[i]["returnDate"] =
                        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ret));

                }
            }
            return ds;
        }

        /// <summary>
        /// finde carpet by size 
        /// </summary>
        /// <param name="size">size</param>
        /// <returns>dataset that fill filtered data in it</returns>
        private DataSet FindBySize(string size)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();

            SqlCommand command = new SqlCommand("SELECT CarpetCode FROM CustomerCarpet WHERE CustomerID= '"
                + this.prop_getCustomerID.ToString() + "' ORDER BY carpetCode DESC", cn);
            command.CommandType = CommandType.Text;
            SqlDataReader obj = command.ExecuteReader();

            if (obj.HasRows)
            {
                ds = new DataSet();
                DataSet temp = new DataSet();

                while (obj.Read())
                {
                    long codeTemp = obj.GetInt64(0);
                    SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM Carpet WHERE CarpetCode= '"
                        + codeTemp.ToString() + "'"
                        , connectionString);
                    da1.Fill(temp, "Carpet");
                    da_Carpet = new SqlDataAdapter("SELECT carpetLable," +
                        " madeInFrom, carpetSize, length, width, Area, enterDate, returnDate FROM Carpet WHERE CarpetCode= '"
                        + codeTemp.ToString() + "'AND IsActive = '1'" +
                        "AND carpetSize = '" + size + "'"
                        , connectionString);
                    da_Carpet.Fill(ds, "Carpet");

                }
                obj.Close();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DateTime ent = (DateTime)(ds.Tables[0].Rows[i]["enterDate"]);
                    DateTime ret = (DateTime)(ds.Tables[0].Rows[i]["returnDate"]);

                    ds.Tables[0].Rows[i]["enterDate"] =
                        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ent));
                    ds.Tables[0].Rows[i]["returnDate"] =
                        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ret));

                }
            }
            return ds;
        }

        /// <summary>
        /// finde carpet by place 
        /// </summary>
        /// <param name="place">place</param>
        /// <returns>dataset that fill filtered data in it</returns>
        private DataSet FindByPlace(string place)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();

            SqlCommand command = new SqlCommand("SELECT CarpetCode FROM CustomerCarpet WHERE CustomerID= '"
                + this.prop_getCustomerID.ToString() + "' ORDER BY carpetCode DESC", cn);
            command.CommandType = CommandType.Text;
            SqlDataReader obj = command.ExecuteReader();

            if (obj.HasRows)
            {
                ds = new DataSet();
                DataSet temp = new DataSet();

                while (obj.Read())
                {
                    long codeTemp = obj.GetInt64(0);
                    SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM Carpet WHERE CarpetCode= '"
                        + codeTemp.ToString() + "'"
                        , connectionString);
                    da1.Fill(temp, "Carpet");
                    da_Carpet = new SqlDataAdapter("SELECT carpetLable," +
                        " madeInFrom, carpetSize, length, width, Area, enterDate, returnDate FROM Carpet WHERE CarpetCode= '"
                        + codeTemp.ToString() + "'AND IsActive = '1'" +
                        "AND madeInFrom = '" + place + "'"
                        , connectionString);
                    da_Carpet.Fill(ds, "Carpet");

                }
                obj.Close();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DateTime ent = (DateTime)(ds.Tables[0].Rows[i]["enterDate"]);
                    DateTime ret = (DateTime)(ds.Tables[0].Rows[i]["returnDate"]);

                    ds.Tables[0].Rows[i]["enterDate"] =
                        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ent));
                    ds.Tables[0].Rows[i]["returnDate"] =
                        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ret));

                }
            }
            return ds;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Microgod.AmrComponent.AmrAssistanteForms.frmWaiting.ShowWaiting();
            DataSet Carpet;
            if (rdbCarpetCode.Checked)
            {
                Carpet = this.FindByCarpetCode(txtCarpetCode.Text);
                dataGridView1.DataSource = Carpet;
            }
            if (rdbCarpetSize.Checked)
            {
                Carpet = this.FindBySize(this.cmbSize.Text);
                dataGridView1.DataSource = Carpet;
            }
            if (rdbMadInFrom.Checked)
            {
                Carpet = this.FindByPlace(this.cmbPlace.Text);
                dataGridView1.DataSource = Carpet;
            }
            Microgod.AmrComponent.AmrAssistanteForms.frmWaiting.CloseWaiting();

            lblResultCount.Text =
                dataGridView1.RowCount.ToString() + "  تخته فرش";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Microgod.AmrComponent.AmrAssistanteForms.frmWaiting.ShowWaiting();

            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();

            SqlCommand command = new SqlCommand("SELECT CarpetCode FROM CustomerCarpet WHERE CustomerID= '"
                + this.prop_getCustomerID.ToString() + "' ORDER BY carpetCode DESC", cn);
            command.CommandType = CommandType.Text;
            SqlDataReader obj = command.ExecuteReader();

            if (obj.HasRows)
            {
                ds = new DataSet();
                DataSet temp = new DataSet();

                while (obj.Read())
                {
                    long codeTemp = obj.GetInt64(0);
                    SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM Carpet WHERE CarpetCode= '"
                        + codeTemp.ToString() + "'"
                        , connectionString);
                    da1.Fill(temp, "Carpet");
                    da_Carpet = new SqlDataAdapter("SELECT carpetLable," +
                        " madeInFrom, carpetSize, length, width, Area, enterDate, returnDate FROM Carpet WHERE CarpetCode= '"
                        + codeTemp.ToString() + "'AND IsActive = '1'"
                        , connectionString);
                    da_Carpet.Fill(ds, "Carpet");

                }
                obj.Close();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DateTime ent = (DateTime)(ds.Tables[0].Rows[i]["enterDate"]);
                    DateTime ret = (DateTime)(ds.Tables[0].Rows[i]["returnDate"]);

                    ds.Tables[0].Rows[i]["enterDate"] =
                        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ent));
                    ds.Tables[0].Rows[i]["returnDate"] =
                        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ret));

                }
            }
            dataGridView1.DataSource = ds;

            Microgod.AmrComponent.AmrAssistanteForms.frmWaiting.CloseWaiting();

            lblResultCount.Text =
              dataGridView1.RowCount.ToString() + "  تخته فرش";
            
        }

        private void btnAddNewCarpet_Click(object sender, EventArgs e)
        {
            frmCarpetRegistration obj = new frmCarpetRegistration();
            obj.prop_getCustomerID = this.prop_getCustomerID;
            obj.ShowDialog();
        }

        private void btnEditCarpet_Click(object sender, EventArgs e)
        {
            string index1;
            index1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Carpet WHERE carpetLable = N'" + index1 + "'"
                , connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Carpet");

            editForm = new frmEditCarpet();
            editForm.prop_SetCarpetCode = (long)(ds.Tables[0].Rows[0]["CarpetCode"]);
            editForm.prop_SetCarpetLable = ds.Tables[0].Rows[0]["carpetLable"].ToString();
            editForm.prop_SetWidth = (int)(ds.Tables[0].Rows[0]["Width"]);
            editForm.prop_SetLength = (int)(ds.Tables[0].Rows[0]["Length"]);
            editForm.prop_SetMadeInFrom = (ds.Tables[0].Rows[0]["madeInFrom"]).ToString();
            editForm.prop_SetSize = (ds.Tables[0].Rows[0]["carpetSize"]).ToString();
            editForm.prop_SetEnterDate = (DateTime)(ds.Tables[0].Rows[0]["enterDate"]);
            editForm.prop_SetReturnDate = (DateTime)(ds.Tables[0].Rows[0]["returnDate"]);

            editForm.FormClosed += new FormClosedEventHandler(editForm_FormClosed);
            
            editForm.ShowDialog();
        }

        void editForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.Columns.Remove("cl8");
                dataGridView1.Columns.Remove("cl9");
            }
            DataSet ds = new DataSet();
            ds = editForm.prop_getDataset;
            this.SetDataGridViewForCarpets(dataGridView1, this.ShowLastCarpetOfSpecialCustomer(ds));  
        }

        private void btnFactor_Click(object sender, EventArgs e)
        {
            frmFactorSetting obj = new frmFactorSetting();
            obj.prop_GetCustomerID = this.prop_getCustomerID;
            obj.ShowDialog();
        }





    }
    
}
