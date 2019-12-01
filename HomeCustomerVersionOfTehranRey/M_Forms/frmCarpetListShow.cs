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
        DataTable dt_Carpet;
        DataTable dt_Customer;
        DataTable dt;
        DataTable dt_CarpetServices;
        frmEditCarpet editForm;
        long carpetNumber;

        public frmCarpetListShow()
        {
            InitializeComponent();
        }

        enum ServicesEnum
        {
            shour = 1, pardakht, darkeshi, rang, dogere, shiraze, sarnakh, charm, rofou
        }

        public long prop_getCustomerID { get; set; }

        private void rdbCarpetCode_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCarpetCode.Checked)
            { 
                panelCode.Visible = true; 
                panelPlace.Visible = false;
                panelSize.Visible = false;
                panelDate.Visible = false;
                txtCarpetCode.Select();
            }
        }

        private void rdbCarpetSize_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCarpetSize.Checked)
            {   
                panelSize.Visible = true;
                panelPlace.Visible = false;
                panelCode.Visible = false;
                panelDate.Visible = false;
                txtSize.Select();
            }
        }

        private void rdbMadInFrom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMadInFrom.Checked)
            {
                panelPlace.Visible = true;
                panelSize.Visible = false;
                panelCode.Visible = false;
                panelDate.Visible = false;
                txtPlace.Select();
            }
        }

        /// <summary>
        /// this method use the Customer_Select_ByID method  clsAnbarManagment_DataAccessLAyer
        /// to select the special customer of db and show information of that in headers lable of form
        /// </summary>
        private void Set_HeaderLables()
        {
            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

            dt_Customer = new DataTable();
            dt_Customer = obj.Customer_Select_ByID(prop_getCustomerID);

            lblCustomerID.Text = prop_getCustomerID.ToString();
            lblCustomerName.Text = dt_Customer.Rows[0][1].ToString();
            lblCustomerFamily.Text = dt_Customer.Rows[0][2].ToString();
        }

        /// <summary>
        /// this method use the Carpet_Select_Place_And_Size method  clsAnbarManagment_DataAccessLAyer
        /// to fill data to AutoCompleteCustomSource of txtPlace & txtSize
        /// </summary>
        private void Set_AutoCompleteCustomSource_Of_txtPlace_And_txtSize()
        {
            DataTable dt = new DataTable();

            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();
            dt = obj.Carpet_Select_Place_And_Size();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string str = (dt.Rows[i]["madeInFrom"]).ToString();
                string str1 = (dt.Rows[i]["carpetSize"]).ToString();
                if (txtPlace.AutoCompleteCustomSource.IndexOf(str) == -1)
                {
                    txtPlace.AutoCompleteCustomSource.Add(str);
                }
                if (txtSize.AutoCompleteCustomSource.IndexOf(str1) == -1)
                {
                    txtSize.AutoCompleteCustomSource.Add(str1);
                }
            }
        }

        private void frmCarpetListShow_Load(object sender, EventArgs e)
        {
            //*******************************Set the Header Labale Of Form*************************
            this.Set_HeaderLables();
            // End Of //*******************************Set the Header Labale Of Form*************************

            //******************************** set txtPlace & txtSize Items ***********
            this.Set_AutoCompleteCustomSource_Of_txtPlace_And_txtSize();
            //End Of //******************************** set txtPlace & txtSize Items ***********

            //******************************* Set datagrid & Show data of special customer in it*****
            this.dt_Carpet = new DataTable();
            this.dt_Carpet = this.ShowLastCarpetOfSpecialCustomer(dt_Carpet);
            this.SetDataGridViewForCarpets(dataGridView1, this.dt_Carpet);
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
        private void SetDataGridViewForCarpets(DataGridView dgw, DataTable dt)
        {
            dgw.DataSource = dt;
            dgw.DataMember = dt.TableName;

            if (dt.Rows.Count >0)
            {

                dgw.Columns[0].Visible = false;
                dgw.Columns[0].HeaderText = "شناسه فرش";
                dgw.Columns[0].Width = 80;
                dgw.Columns[1].HeaderText = "شماره";
                dgw.Columns[1].Width = 80;
                dgw.Columns[2].HeaderText = "محل بافت";
                dgw.Columns[2].Width = 90;
                dgw.Columns[3].HeaderText = "سایز";
                dgw.Columns[3].Width = 90;
                dgw.Columns[4].HeaderText = "طول";
                dgw.Columns[4].Width = 65;
                dgw.Columns[5].HeaderText = "عرض";
                dgw.Columns[5].Width = 65;
                dgw.Columns[6].HeaderText = "مساحت";
                dgw.Columns[6].Width = 80;
                dgw.Columns[7].HeaderText = "تاریخ ورود";
                dgw.Columns[7].Width = 97;
                dgw.Columns[8].HeaderText = "تاریخ تحویل";
                dgw.Columns[8].Width = 97;
                dgw.Columns[9].Visible = false;
                dgw.Columns[9].HeaderText = "تاریخ خروج";
                dgw.Columns[9].Width = 80;
                dgw.Columns[10].Visible = false;
                dgw.Columns[11].Visible = false;

                //FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn cl8 =
                //    new FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn();

                //FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn cl9 =
                //    new FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn();

                //cl8.Name = "cl8";
                //cl8.DataPropertyName = "enterDate";
                //cl8.HeaderText = "تاریخ ورود";
                //cl8.Width = 130;
                //cl8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                //cl8.SelectedDateTime = new System.DateTime(((long)(0)));
                //cl8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
                //cl8.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2000;
                //cl8.VerticalAlignment = System.Drawing.StringAlignment.Near;
                //cl9.Name = "cl9";
                //cl9.DataPropertyName = "returnDate";
                //cl9.HeaderText = "تاریخ تحویل";
                //cl9.Width = 130;
                //cl9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                //cl9.SelectedDateTime = new System.DateTime(((long)(0)));
                //cl9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
                //cl9.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2000;
                //cl9.VerticalAlignment = System.Drawing.StringAlignment.Near;

                //dgw.Columns.Add(cl8);
                //dgw.Columns.Add(cl9);
            }
            
        }

        /// <summary>
        /// this method set the dataset include the active caprpets of special customer
        /// to be datasource of datagridview ...
        /// </summary>
        private DataTable ShowLastCarpetOfSpecialCustomer(DataTable dt)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();
            DataTable temp = obj.CustomerCarpet_Select_ByCustomerID(this.prop_getCustomerID);

            if (temp.Rows.Count != 0)
            {
                dt = new DataTable();
                
                for (int i = 0; i < temp.Rows.Count; i++)
                {
                    long index;
                    Int64.TryParse((temp.Rows[i]["CarpetCode"]).ToString(), out index);
                    dt.Merge(obj.Carpet_Select_ByCarpetCode_AndIsActive(index, true));
                    
                }

                //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                //{
                //    //DateTime ent = (DateTime)(ds.Tables[0].Rows[i]["enterDate"]).ToString();
                //    DateTime ent;
                //    DateTime.TryParse((ds.Tables[0].Rows[i]["enterDate"]).ToString(), out ent);
                //    //DateTime ret = (DateTime)(ds.Tables[0].Rows[i]["returnDate"]);
                //    DateTime ret;
                //    DateTime.TryParse((ds.Tables[0].Rows[i]["returnDate"]).ToString(), out ret);

                //    ds.Tables[0].Rows[i]["enterDate"] =
                //        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ent));
                //    ds.Tables[0].Rows[i]["returnDate"] =
                //        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ret));
                //}
            }

            return dt;
        }

        /// <summary>
        /// find carpet by code
        /// </summary>
        /// <param name="code">carpet code</param>
        private DataTable FindByCarpetLable(string lable)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();
            DataTable temp = obj.CustomerCarpet_Select_ByCustomerID(this.prop_getCustomerID);

            if (temp.Rows.Count != 0)
            {
                dt = new DataTable();
               
                for (int i = 0; i < temp.Rows.Count; i++)
                {
                    long index;
                    Int64.TryParse((temp.Rows[i]["CarpetCode"]).ToString(), out index);
                    dt.Merge(obj.Carpet_Select_ByCarpetLable(index, lable));
                }

                //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                //{
                //    DateTime ent = (DateTime)(ds.Tables[0].Rows[i]["enterDate"]);
                //    DateTime ret = (DateTime)(ds.Tables[0].Rows[i]["returnDate"]);

                //    ds.Tables[0].Rows[i]["enterDate"] =
                //        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ent));
                //    ds.Tables[0].Rows[i]["returnDate"] =
                //        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ret));
                //}        
            }

            return dt;

        }

        /// <summary>
        /// finde carpet by size 
        /// </summary>
        /// <param name="size">size</param>
        /// <returns>DataTable that fill filtered data in it</returns>
        private DataTable FindBySize(string size)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();
            DataTable temp = obj.CustomerCarpet_Select_ByCustomerID(this.prop_getCustomerID);

            if (temp.Rows.Count != 0)
            {
                dt = new DataTable();
                
                for (int i = 0; i < temp.Rows.Count; i++)
                {
                    long index;
                    Int64.TryParse((temp.Rows[i]["CarpetCode"]).ToString(), out index);
                    dt.Merge(obj.Carpet_Select_ByCarpetSize(index, size));
                }

                //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                //{
                //    DateTime ent = (DateTime)(ds.Tables[0].Rows[i]["enterDate"]);
                //    DateTime ret = (DateTime)(ds.Tables[0].Rows[i]["returnDate"]);

                //    ds.Tables[0].Rows[i]["enterDate"] =
                //        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ent));
                //    ds.Tables[0].Rows[i]["returnDate"] =
                //        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ret));
                //}
            }
            return dt;
        }

        /// <summary>
        /// finde carpet by place 
        /// </summary>
        /// <param name="place">place</param>
        /// <returns>DataTable that fill filtered data in it</returns>
        private DataTable FindByPlace(string place)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();
            DataTable temp = obj.CustomerCarpet_Select_ByCustomerID(this.prop_getCustomerID);

            if (temp.Rows.Count != 0)
            {
                dt = new DataTable();
              
                for (int i = 0; i < temp.Rows.Count; i++)
                {
                    long index;
                    Int64.TryParse((temp.Rows[i]["CarpetCode"]).ToString(), out index);
                    dt.Merge(obj.Carpet_Select_ByPlace(index, place));
                }

                //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                //{
                //    DateTime ent = (DateTime)(ds.Tables[0].Rows[i]["enterDate"]);
                //    DateTime ret = (DateTime)(ds.Tables[0].Rows[i]["returnDate"]);

                //    ds.Tables[0].Rows[i]["enterDate"] =
                //        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ent));
                //    ds.Tables[0].Rows[i]["returnDate"] =
                //        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ret));
                //}
            }
            return dt;
        }

        private DataTable FindByEnteryDate(DateTime dateFrom, DateTime dateTo)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();
            dt = new DataTable();
            dt = obj.Carpet_Select_ByEnteryDate(this.prop_getCustomerID ,dateFrom, dateTo);
            
            return dt;
        }
        private DataTable FindByReturnDate(DateTime dateFrom, DateTime dateTo)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

            dt = new DataTable();
            dt = obj.Carpet_Select_ByReturnDate(this.prop_getCustomerID, dateFrom, dateTo);
            
            return dt;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Microgod.AmrComponent.AmrAssistanteForms.frmWaiting.ShowWaiting();
            DataTable Carpet;
            if (rdbCarpetCode.Checked)
            {
                Carpet = this.FindByCarpetLable(txtCarpetCode.Text);
                SetDataGridViewForCarpets(dataGridView1, Carpet);
                if (Carpet.Rows.Count == 0)
                {
                    Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("هیچ موردی یافت نشد!");
                } 
            }
            if (rdbCarpetSize.Checked)
            {
                Carpet = this.FindBySize(this.txtSize.Text);
                SetDataGridViewForCarpets(dataGridView1, Carpet);
                if (Carpet.Rows.Count == 0)
                {
                    Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("هیچ موردی یافت نشد!");
                } 
            }
            if (rdbMadInFrom.Checked)
            {
                Carpet = this.FindByPlace(this.txtPlace.Text);
                SetDataGridViewForCarpets(dataGridView1, Carpet);
                if (Carpet.Rows.Count == 0)
                {
                    Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("هیچ موردی یافت نشد!");
                } 
            }
            if (rdbDateEntery.Checked)
            {
                Carpet = this.FindByEnteryDate(amrUCPersianCalenderAdvanced_DateFrom.SelectedDate.Value
                    , amrUCPersianCalenderAdvanced_DateTo.SelectedDate.Value);
                SetDataGridViewForCarpets(dataGridView1, Carpet);
                if (Carpet.Rows.Count == 0)
                {
                    Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("هیچ موردی یافت نشد!");
                }
            }
            if (rdbDateBack.Checked)
            {
                Carpet = this.FindByReturnDate(amrUCPersianCalenderAdvanced_DateFrom.SelectedDate.Value,
                    amrUCPersianCalenderAdvanced_DateTo.SelectedDate.Value);
                SetDataGridViewForCarpets(dataGridView1, Carpet);
                if (Carpet.Rows.Count == 0)
                {
                    Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("هیچ موردی یافت نشد!");
                }
            }
            //Microgod.AmrComponent.AmrAssistanteForms.frmWaiting.CloseWaiting();

            lblResultCount.Text =
                dataGridView1.RowCount.ToString() + "  تخته فرش";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Microgod.AmrComponent.AmrAssistanteForms.frmWaiting.ShowWaiting();

            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

            DataTable temp = obj.CustomerCarpet_Select_ByCustomerID(this.prop_getCustomerID);
            if (temp.Rows.Count != 0)
            {
                dt = new DataTable();
                for (int i = 0; i < temp.Rows.Count; i++)
                {
                    long index;
                    Int64.TryParse((temp.Rows[i]["CarpetCode"]).ToString(), out index);
                    dt.Merge(obj.Carpet_Select_ByCarpetCode_AndIsActive(index, true));
                }

                //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                //{
                //    //DateTime ent = (DateTime)(ds.Tables[0].Rows[i]["enterDate"]).ToString();
                //    DateTime ent;
                //    DateTime.TryParse((ds.Tables[0].Rows[i]["enterDate"]).ToString(), out ent);
                //    //DateTime ret = (DateTime)(ds.Tables[0].Rows[i]["returnDate"]);
                //    DateTime ret;
                //    DateTime.TryParse((ds.Tables[0].Rows[i]["returnDate"]).ToString(), out ret);

                //    ds.Tables[0].Rows[i]["enterDate"] =
                //        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ent));
                //    ds.Tables[0].Rows[i]["returnDate"] =
                //        (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ret));
                //}
            }
            this.SetDataGridViewForCarpets(dataGridView1, dt);

            Microgod.AmrComponent.AmrAssistanteForms.frmWaiting.CloseWaiting();

            lblResultCount.Text = dataGridView1.RowCount.ToString() + "  تخته فرش";
        }

        private void btnAddNewCarpet_Click(object sender, EventArgs e)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj1
                   = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();
            
            //***************** for AddCarpet Lables***************
            frmCarpetRegistration obj = new frmCarpetRegistration();
            dt_Customer = obj1.Customer_Select_ByID(prop_getCustomerID);
            obj.prop_getCustomerID = System.Convert.ToInt64(dt_Customer.Rows[0][0].ToString());
            obj.prop_getCustomerName = dt_Customer.Rows[0][1].ToString();
            obj.prop_getCustomerfamily = dt_Customer.Rows[0][2].ToString();
            obj.prop_getCarpetLable = obj.prop_getCustomerID.ToString() + "_" + ((this.carpetNumber) + 1).ToString();
            obj.prop_dtCarpet = obj1.CustomerCarpet_Select_ByCustomerID(prop_getCustomerID);
            //***************** for AddCarpet Lables***************

            obj.FormClosed += new FormClosedEventHandler(obj_FormClosed);
            obj.ShowDialog();
        }

        void obj_FormClosed(object sender, FormClosedEventArgs e)
        {
            //******************************* Set datagrid & Show data of special customer in it*****
            this.dt_Carpet = new DataTable();
            this.dt_Carpet = this.ShowLastCarpetOfSpecialCustomer(dt_Carpet);
            this.SetDataGridViewForCarpets(dataGridView1, this.dt_Carpet);
            //End Of //******************************* Set datagrid & Show data of special customer in it*****

            // ******** set lblResultCount *****************
            lblResultCount.Text =
             dataGridView1.RowCount.ToString() + "  تخته فرش";
            //End of // ******** set lblResultCount *****************
        }

        private void btnEditCarpet_Click(object sender, EventArgs e)
        {
            
            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                   = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

            if (dataGridView1.SelectedRows.Count != 0)
            {
                string index1;
                index1 = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DataTable dt = obj.Carpet_Select_ByJustCarpetLable(index1);

                editForm = new frmEditCarpet();
           
                //****** set Lables for frmEditCarpet *********

                dt_Customer = obj.Customer_Select_ByID(prop_getCustomerID);
                editForm.prop_getCustomerID = System.Convert.ToInt64(dt_Customer.Rows[0][0].ToString());
                editForm.prop_getCustomername = dt_Customer.Rows[0][1].ToString();
                editForm.prop_getCustomerfamily = dt_Customer.Rows[0][2].ToString();

                //******* End of set Lables for frmEditCarpet*****

                editForm.prop_SetCarpetCode = System.Convert.ToInt64(dt.Rows[0]["CarpetCode"]);
                editForm.prop_SetCarpetLable = (dt.Rows[0]["carpetLable"]).ToString();
                editForm.prop_SetWidth = System.Convert.ToInt16(dt.Rows[0]["Width"]);
                editForm.prop_SetLength = System.Convert.ToInt16(dt.Rows[0]["Length"]); 
                editForm.prop_SetMadeInFrom = (dt.Rows[0]["madeInFrom"]).ToString(); 
                editForm.prop_SetSize = (dt.Rows[0]["carpetSize"]).ToString(); 
                editForm.prop_SetEnterDate = System.Convert.ToDateTime(dt.Rows[0]["enterDate"]); 
                editForm.prop_SetReturnDate = System.Convert.ToDateTime(dt.Rows[0]["returnDate"]); 

                //*********** Set Carpet Servises for frmEditCarpet****
                dt_CarpetServices = new DataTable();
                 
                long Ccode = System.Convert.ToInt64(dt.Rows[0]["CarpetCode"]);
                dt_CarpetServices = obj.CarpetServices_Select_ByCarpetCode(Ccode);

                for (int j = 0; j < dt_CarpetServices.Rows.Count; j++)
                {
                    int Sserial = System.Convert.ToInt16(dt_CarpetServices.Rows[j][1]);

                    if (Sserial == System.Convert.ToInt16(ServicesEnum.shour))
                    {
                        editForm.prop_shourAmount = System.Convert.ToDecimal(dt_CarpetServices.Rows[j][2]);
                        editForm.prop_shourFee = System.Convert.ToInt64(dt_CarpetServices.Rows[j][3]);
                        editForm.prop_shourCost = System.Convert.ToInt64(editForm.prop_shourAmount * editForm.prop_shourFee);
                    }
                    if (Sserial == System.Convert.ToInt16(ServicesEnum.darkeshi))
                    {
                        editForm.prop_DarkeshiAmount = System.Convert.ToDecimal(dt_CarpetServices.Rows[j][2]);
                        editForm.prop_DarkeshiFee = System.Convert.ToInt64(dt_CarpetServices.Rows[j][3]);
                        editForm.prop_DarkeshiCost = System.Convert.ToInt64(editForm.prop_DarkeshiAmount * editForm.prop_DarkeshiFee);
                    }
                    if (Sserial == System.Convert.ToInt16(ServicesEnum.pardakht))
                    {
                        editForm.prop_PardakhtAmount = System.Convert.ToDecimal(dt_CarpetServices.Rows[j][2]);
                        editForm.prop_PardakhtFee = System.Convert.ToInt64(dt_CarpetServices.Rows[j][3]);
                        editForm.prop_PardakhtCost = System.Convert.ToInt64(editForm.prop_PardakhtAmount * editForm.prop_PardakhtFee);
                    }
                    if (Sserial == System.Convert.ToInt16(ServicesEnum.rang))
                    {
                        editForm.prop_RangAmount = System.Convert.ToDecimal(dt_CarpetServices.Rows[j][2]);
                        editForm.prop_RangFee = System.Convert.ToInt64(dt_CarpetServices.Rows[j][3]);
                        editForm.prop_RangCost = System.Convert.ToInt64(editForm.prop_RangAmount * editForm.prop_RangFee);
                    }
                    if (Sserial == System.Convert.ToInt16(ServicesEnum.rofou))
                    {
                        editForm.prop_RofuAmount = System.Convert.ToDecimal(dt_CarpetServices.Rows[j][2]);
                        editForm.prop_RofuFee = System.Convert.ToInt64(dt_CarpetServices.Rows[j][3]);
                        editForm.prop_RofuCost = System.Convert.ToInt64(editForm.prop_RofuAmount * editForm.prop_RofuFee);
                    }
                    if (Sserial == System.Convert.ToInt16(ServicesEnum.dogere))
                    {
                        editForm.prop_DogereAmount = System.Convert.ToDecimal(dt_CarpetServices.Rows[j][2]);
                        editForm.prop_DogereFee = System.Convert.ToInt64(dt_CarpetServices.Rows[j][3]);
                        editForm.prop_DogereCost = System.Convert.ToInt64(editForm.prop_DogereAmount * editForm.prop_DogereFee);
                    }
                    if (Sserial == System.Convert.ToInt16(ServicesEnum.shiraze))
                    {
                        editForm.prop_ShirazehAmount = System.Convert.ToDecimal(dt_CarpetServices.Rows[j][2]);
                        editForm.prop_ShirazehFee = System.Convert.ToInt64(dt_CarpetServices.Rows[j][3]);
                        editForm.prop_shirazehCost = System.Convert.ToInt64(editForm.prop_ShirazehAmount * editForm.prop_ShirazehFee);
                    }
                    if (Sserial == System.Convert.ToInt16(ServicesEnum.sarnakh))
                    {
                        editForm.prop_SarnakhAmount = System.Convert.ToDecimal(dt_CarpetServices.Rows[j][2]);
                        editForm.prop_SarnakhFee = System.Convert.ToInt64(dt_CarpetServices.Rows[j][3]);
                        editForm.prop_SarnakhCost = System.Convert.ToInt64(editForm.prop_SarnakhAmount * editForm.prop_SarnakhFee);
                    }
                    if (Sserial == System.Convert.ToInt16(ServicesEnum.charm))
                    {
                        editForm.prop_CharmAmount = System.Convert.ToDecimal(dt_CarpetServices.Rows[j][2]);
                        editForm.prop_CharmFee = System.Convert.ToInt64(dt_CarpetServices.Rows[j][3]);
                        editForm.prop_CharmCost = System.Convert.ToInt64(editForm.prop_CharmAmount * editForm.prop_CharmFee);
                    }
                }

                //End of//****** Set Carpet Servises for frmEditCarpet****

                editForm.FormClosed += new FormClosedEventHandler(editForm_FormClosed);         
                editForm.ShowDialog();
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً ردیف مشتری مورد نظر را انتخاب کنید !");
            }
        }

        void editForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                //dataGridView1.Columns.Remove("cl8");
                //dataGridView1.Columns.Remove("cl9");
            }
            DataTable dt = new DataTable();
            dt = editForm.prop_getDataTable;
            this.SetDataGridViewForCarpets(dataGridView1, this.ShowLastCarpetOfSpecialCustomer(dt));  
        }

        private void btnFactor_Click(object sender, EventArgs e)
        {
            frmFactorSetting obj = new frmFactorSetting();
            obj.prop_GetCustomerID = this.prop_getCustomerID;
            obj.ShowDialog();
        }

        private void rdbDateEntery_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDateEntery.Checked)
            {
                panelPlace.Visible = false;
                panelSize.Visible = false;
                panelCode.Visible = false;
                panelDate.Visible = true;
            }
        }

        private void rdbDateBack_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDateBack.Checked)
            {
                panelPlace.Visible = false;
                panelSize.Visible = false;
                panelCode.Visible = false;
                panelDate.Visible = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Microgod.AmrComponent.AmrDynamicCrystal.frmReport obj
                = new Microgod.AmrComponent.AmrDynamicCrystal.frmReport(dataGridView1,"","");
            obj.ShowDialog();
        }

    }
    
}
