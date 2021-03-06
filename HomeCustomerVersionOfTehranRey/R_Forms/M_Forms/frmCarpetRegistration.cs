using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.math;

namespace HomeCustomerVersionOfTehranRey.Forms
{
    public partial class frmCarpetRegistration : Form
    {
        DataTable dt_Services;
        DataTable dt_Carpet;
        DataTable dt_Customer; 

        private long customerID;
        long temp; // as cost of services
        long carpetNumber;
        long lastCarpetCode;
        DateTime enterDate;
        DateTime returnDate;

        string carpetLable;
        int length;
        int width;
        float area;
        string madeInfrom;
        string size;
        
        int shourIndex;
        int darkeshiIndex;
        int pardakhtIndex;
        int rangIndex;
        int rofuIndex;
        int dogereIndex;
        int shirazeIndex;
        int sarnakhIndex;
        int charmIndex;

        long shourCost;
        long darkeshiCost;
        long pardakhtCost;
        long rangCost;
        long rofuCost;
        long dogereCost;
        long shirazeCost;
        long sarnakhCost;
        long charmCost;

        decimal shourAmount;
        decimal darkeshiAmount;
        decimal pardakhtAmount;
        int rangAmount;
        int rofuAmount;
        decimal dogereAmount;
        decimal shirazeAmount;
        decimal sarnakhAmount;
        decimal charmAmount;

        long shourFee;
        long darkeshiFee;
        long pardakhtFee;
        long rangFee;
        long rofuFee;
        long dogereFee;
        long shirazeFee;
        long sarnakhFee;
        long charmFee;

        public frmCarpetRegistration()
        {
            InitializeComponent();
        }

        public string prop_getCustomerName { get; set; }
        public string prop_getCustomerfamily { get; set; }
        public string prop_getCarpetLable { get; set; }
        public DataTable prop_dtCarpet { get; set; }

        enum ServicesEnum
        {
            shour = 1, pardakht, darkeshi, rang, rofou, dogere, shiraze, charm, sarnakh
        }
        
        /// <summary>
        /// set the customer id
        /// </summary>
        public long prop_getCustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        /// <summary>
        /// insert values in to tables 
        /// </summary>


        private void InsertValus()
        {
            Microgod.AmrComponent.AmrAssistanteForms.frmWaiting.ShowWaiting();

            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj =
                new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

            //********************* Inser carpet _____ Set parameters of sp_Insert Carpet

            this.carpetLable = txtCarpetLable.Text;

            Int32.TryParse(txtLength.Text, out this.length);
            Int32.TryParse(txtWidth.Text, out this.width);
            this.madeInfrom = txtPlace.Text;
            this.size = txtSize.Text;
            this.enterDate = faDatePicker_EnterDate.SelectedDateTime;
            this.returnDate = faDatePicker_ReturnDate.SelectedDateTime;

            obj.InsertCarpet(this.carpetLable, this.madeInfrom, this.size, this.length, this.width,
                this.enterDate, this.returnDate, true);

            this.lastCarpetCode = System.Convert.ToInt64(obj.LastCarpetCode_Select());


            //********************* End Of Inser carpet _____ Set parameters of sp_Insert Carpet

            //********************* Inser Services _____ Set parameters of sp_InsertCarpetServices

            if (chBoxShuor.Checked)
            {
                this.shourFee = System.Convert.ToInt16(numShurFee.Value);
                this.shourAmount = System.Convert.ToDecimal(numAmountShur.Value);

                obj.CarpetServicesInsert(this.lastCarpetCode,
                    this.shourIndex, this.shourAmount, this.shourFee);
            }
            if (chBoxDarkeshi.Checked)
            {
                this.darkeshiFee = System.Convert.ToInt16(numDarkeshiFee.Value);
                this.darkeshiAmount = System.Convert.ToDecimal(numAmountDarkeshi.Value);

                obj.CarpetServicesInsert(this.lastCarpetCode,
                    this.darkeshiIndex, this.darkeshiAmount, this.darkeshiFee);
            }
            if (chBoxPardakht.Checked)
            {
                this.pardakhtFee = System.Convert.ToInt16(numPardakhtFee.Value);
                this.pardakhtAmount = System.Convert.ToDecimal(numAmountPardakht.Value);

                obj.CarpetServicesInsert(this.lastCarpetCode,
                    this.pardakhtIndex, this.pardakhtAmount, this.pardakhtFee);
            }
            if (chBoxRang.Checked)
            {
                this.rangFee = System.Convert.ToInt16(numRangFee.Value);
                this.rangAmount = System.Convert.ToInt16(numAmountRang.Value);

                obj.CarpetServicesInsert(this.lastCarpetCode,
                    this.rangIndex, this.rangAmount, this.rangFee);
            }
            if (chBoxRofu.Checked)
            {
                this.rofuFee = System.Convert.ToInt16(numRofuFee.Value);
                this.rofuAmount = System.Convert.ToInt16(numAmountRofu.Value);

                obj.CarpetServicesInsert(this.lastCarpetCode,
                    this.rofuIndex, this.rofuAmount, this.rofuFee);
            }
            if (chBoxDogere.Checked)
            {
                this.dogereFee = System.Convert.ToInt16(numDogereFee.Value);
                this.dogereAmount = System.Convert.ToDecimal(numAmountDogere.Value);

                obj.CarpetServicesInsert(this.lastCarpetCode,
                    this.dogereIndex, this.dogereAmount, this.dogereFee);
            }
            if (chBoxShiraze.Checked)
            {
                this.shirazeFee = System.Convert.ToInt16(numShirazeFee.Value);
                this.shirazeAmount = System.Convert.ToDecimal(numAmountShiraze.Value);

                obj.CarpetServicesInsert(this.lastCarpetCode,
                    this.shirazeIndex, this.shirazeAmount, this.shirazeFee);
            }
            if (chBoxSarnakh.Checked)
            {
                this.sarnakhFee = System.Convert.ToInt16(numSarnakhFee.Value);
                this.sarnakhAmount = System.Convert.ToDecimal(numAmountSarnakh.Value);

                obj.CarpetServicesInsert(this.lastCarpetCode,
                    this.sarnakhIndex, this.sarnakhAmount, this.sarnakhFee);
            }
            if (chBoxCharm.Checked)
            {
                this.charmFee = System.Convert.ToInt16(numCharmFee.Value);
                this.charmAmount = System.Convert.ToDecimal(numAmountCharm.Value);

                obj.CarpetServicesInsert(this.lastCarpetCode,
                    this.charmIndex, this.charmAmount, this.charmFee);
            }

            //********************* End of Inser Services _____ Set parameters of sp_InsertCarpetServices

            //********************* Inser new Row In CarpetCustomer Table with sp_InsertCarpetCustomer

            obj.CarpetCustomerInsert(this.lastCarpetCode, this.customerID);

            //********************* End of Inser new Row In CarpetCustomer Table with sp_InsertCarpetCustomer

            if (dataGridView1.DataSource != null)
            {
                //dataGridView1.Columns.Remove("cl8");
                //dataGridView1.Columns.Remove("cl9");
            }

            //this.dt_Carpet = new DataTable();
            this.SetDataGridViewForCarpets(dataGridView1, this.ShowLastCarpetOfSpecialCustomer(dt_Carpet));
            dataGridView1.Refresh();
            dataGridView1.EndEdit();
            dataGridView1.RefreshEdit();

            Microgod.AmrComponent.AmrAssistanteForms.frmWaiting.CloseWaiting();
            Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("فرش به لیست اضافه شد!");
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

            if (dt.Rows.Count > 0)
            {
                dgw.Columns[0].Visible = false;
                dgw.Columns[1].HeaderText = "شماره";
                dgw.Columns[1].Width = 80;
                dgw.Columns[2].HeaderText = "محل بافت";
                dgw.Columns[2].Width = 110;
                dgw.Columns[3].HeaderText = "سایز";
                dgw.Columns[3].Width = 100;
                dgw.Columns[4].HeaderText = "طول";
                dgw.Columns[4].Width = 65;
                dgw.Columns[5].HeaderText = "عرض";
                dgw.Columns[5].Width = 65;
                dgw.Columns[6].HeaderText = "مساحت";
                dgw.Columns[6].Width = 80;
                dgw.Columns[7].HeaderText = "تاریخ ورود";
                dgw.Columns[7].Visible = true;
                dgw.Columns[8].HeaderText = "تاریخ تحویل";
                dgw.Columns[8].Visible = true;

                dgw.Columns[9].Visible = false;
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
        private DataTable ShowLastCarpetOfSpecialCustomer (DataTable dt)
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

                this.carpetNumber = dt.Rows.Count;
            }
            return dt;
                // this line set the number of carpet of special customer to set carpetLable of new carpet
                
        }

        private void Set_HeaderLables()
        {
            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

            dt_Customer = new DataTable();
            dt_Customer = obj.Customer_Select_ByID(prop_getCustomerID);

            lblCustomerID.Text = prop_getCustomerID.ToString();
            lblCustomerName.Text = prop_getCustomerName.ToString();
            lblCustomerFamily.Text = prop_getCustomerfamily.ToString();
            txtCarpetLable.Text = prop_getCarpetLable.ToString();
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

        private void frmCarpetRegistration_Load(object sender, EventArgs e)
        {
            faDatePicker_EnterDate.SelectedDateTime = System.DateTime.Today;
            faDatePicker_ReturnDate.SelectedDateTime = System.DateTime.Today;

            //*******************************Set the Header Labale Of Form*************************
            this.Set_HeaderLables();
            // End Of //*******************************Set the Header Labale Of Form*************************

            //********************************Set Data to show on datagride ******************************
            this.SetDataGridViewForCarpets(dataGridView1, this.ShowLastCarpetOfSpecialCustomer(prop_dtCarpet)); 
            //End Of //********************************Set Data to show on datagride ************************

            //************************** set the lable of carpet in txtCarpetLable****************************
            txtCarpetLable.Text = this.prop_getCustomerID.ToString() + "_" + ((this.carpetNumber)+1).ToString();
            txtCarpetLable.Select();
            //End Of //************************** set the lable of carpet in txtCarpetLable****************

            //******************************** set txtPlace & txtSize Items ***********
            this.Set_AutoCompleteCustomSource_Of_txtPlace_And_txtSize();
            //End Of //******************************** set txtPlace & txtSize Items **********

        }

        private void chBoxShour_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxShuor.Checked)
            {
                numAmountShur.Enabled = true;
                numShurFee.Enabled = true;
                txtShurCost.Enabled = true;

                HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                    = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

                dt_Services = new DataTable();
                dt_Services = obj.Service_Select_ByServiceSerial(System.Convert.ToInt16(ServicesEnum.shour));

                this.shourIndex = System.Convert.ToInt16(dt_Services.Rows[0]["ServiceSerial"]);
                this.temp = System.Convert.ToInt64(dt_Services.Rows[0]["Fee"]);
                numShurFee.Value = System.Convert.ToDecimal(this.temp);

                Int32.TryParse(txtLength.Text, out this.length);
                Int32.TryParse(txtWidth.Text, out this.width);
                double x = this.area/ 10000.0;
                numAmountShur.Value = (decimal)(x);
                this.shourCost = System.Convert.ToInt16(numAmountShur.Value * numShurFee.Value);
                txtShurCost.Text = this.shourCost.ToString();
                this.txtShurCost.BackColor = System.Drawing.Color.SeaShell;
            }
            else
            {
                numAmountShur.Enabled = false;
                numAmountShur.Value = 0;
                numShurFee.Enabled = false;
                numShurFee.Value = 0;
                txtShurCost.Enabled = false;
                txtShurCost.Text = "";
                this.txtShurCost.BackColor = System.Drawing.Color.Gainsboro;
            }
        }

        private void chBoxDarkeshi_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxDarkeshi.Checked)
            {
                numAmountDarkeshi.Enabled = true;
                numDarkeshiFee.Enabled = true;
                txtDarkeshiCost.Enabled = true;

                HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                    = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

                dt_Services = new DataTable();
                dt_Services = obj.Service_Select_ByServiceSerial(System.Convert.ToInt16(ServicesEnum.darkeshi));

                this.darkeshiIndex = System.Convert.ToInt16(dt_Services.Rows[0]["ServiceSerial"]);
                this.temp = System.Convert.ToInt64(dt_Services.Rows[0]["Fee"]);
                numDarkeshiFee.Value = System.Convert.ToDecimal(this.temp);

                Int32.TryParse(txtLength.Text, out this.length);
                Int32.TryParse(txtWidth.Text, out this.width);
                double x = this.area / 10000.0;
                numAmountDarkeshi.Value = (decimal)(x);
                this.darkeshiCost = System.Convert.ToInt16(numAmountDarkeshi.Value * numDarkeshiFee.Value);
                txtDarkeshiCost.Text = this.darkeshiCost.ToString();
                this.txtDarkeshiCost.BackColor = System.Drawing.Color.SeaShell;
            }
            else
            {
                numAmountDarkeshi.Enabled = false;
                numAmountDarkeshi.Value = 0;
                numDarkeshiFee.Enabled = false;
                numDarkeshiFee.Value = 0;
                txtDarkeshiCost.Enabled = false;
                txtDarkeshiCost.Text = "";
                this.txtDarkeshiCost.BackColor = System.Drawing.Color.Gainsboro;
            }
        }

        private void chBoxPardakht_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxPardakht.Checked)
            {
                numAmountPardakht.Enabled = true;
                numPardakhtFee.Enabled = true;
                txtPardakhtCost.Enabled = true;

                HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                    = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

                dt_Services = new DataTable();
                dt_Services = obj.Service_Select_ByServiceSerial(System.Convert.ToInt16(ServicesEnum.pardakht));

                this.pardakhtIndex = System.Convert.ToInt16(dt_Services.Rows[0]["ServiceSerial"]);
                this.temp = System.Convert.ToInt64(dt_Services.Rows[0]["Fee"]);
                numPardakhtFee.Value = System.Convert.ToDecimal(this.temp);

                Int32.TryParse(txtLength.Text, out this.length);
                Int32.TryParse(txtWidth.Text, out this.width);
                double x = this.area / 10000.0;
                numAmountPardakht.Value = (decimal)(x);
                this.pardakhtCost = System.Convert.ToInt16(numAmountPardakht.Value * numPardakhtFee.Value);
                txtPardakhtCost.Text = this.pardakhtCost.ToString();
                this.txtPardakhtCost.BackColor = System.Drawing.Color.SeaShell;
            }
            else
            {
                numAmountPardakht.Enabled = false;
                numAmountPardakht.Value = 0;
                numPardakhtFee.Enabled = false;
                numPardakhtFee.Value = 0;
                txtPardakhtCost.Enabled = false;
                txtPardakhtCost.Text = "";
                this.txtPardakhtCost.BackColor = System.Drawing.Color.Gainsboro;
            }
        }

        private void chBoxRang_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxRang.Checked)
            {
                numAmountRang.Enabled = true;
                numRangFee.Enabled = true;
                txtRangCost.Enabled = true;

                HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                    = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

                dt_Services = new DataTable();
                dt_Services = obj.Service_Select_ByServiceSerial(System.Convert.ToInt16(ServicesEnum.rang));

                this.rangIndex = System.Convert.ToInt16(dt_Services.Rows[0]["ServiceSerial"]);
                this.temp = System.Convert.ToInt64(dt_Services.Rows[0]["Fee"]);
                numRangFee.Value = System.Convert.ToDecimal(this.temp);

                numAmountRang.Value = 1;
                this.rangCost = System.Convert.ToInt16(numRangFee.Value);
                txtRangCost.Text = this.rangCost.ToString();
                this.txtRangCost.BackColor = System.Drawing.Color.SeaShell;
            }
            else
            {
                numAmountRang.Enabled = false;
                numAmountRang.Value = 0;
                numRangFee.Enabled = false;
                numRangFee.Value = 0;
                txtRangCost.Enabled = false;
                txtRangCost.Text = "";
                this.txtRangCost.BackColor = System.Drawing.Color.Gainsboro;
            }
        }

        private void chBoxDogere_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxDogere.Checked)
            {
                numAmountDogere.Enabled = true;
                numDogereFee.Enabled = true;
                txtDogereCost.Enabled = true;

                HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                    = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

                dt_Services = new DataTable();
                dt_Services = obj.Service_Select_ByServiceSerial(System.Convert.ToInt16(ServicesEnum.dogere));

                this.dogereIndex = System.Convert.ToInt16(dt_Services.Rows[0]["ServiceSerial"]);
                this.temp = System.Convert.ToInt64(dt_Services.Rows[0]["Fee"]);
                numDogereFee.Value = System.Convert.ToDecimal(this.temp);

                Int32.TryParse(txtWidth.Text, out this.width);
                double x = this.width / 100.0;
                numAmountDogere.Value = (decimal)(2*x);
                this.dogereCost = System.Convert.ToInt16(numAmountDogere.Value * numDogereFee.Value);
                txtDogereCost.Text = this.dogereCost.ToString();
                this.txtDogereCost.BackColor = System.Drawing.Color.SeaShell;
            }
            else
            {
                numAmountDogere.Enabled = false;
                numAmountDogere.Value = 0;
                numDogereFee.Enabled = false;
                numDogereFee.Value = 0;
                txtDogereCost.Enabled = false;
                txtDogereCost.Text = "";
                this.txtDogereCost.BackColor = System.Drawing.Color.Gainsboro;
            }
        }

        private void chBoxShiraze_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxShiraze.Checked)
            {
                numAmountShiraze.Enabled = true;
                numShirazeFee.Enabled = true;
                txtShirazeCost.Enabled = true;

                HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                    = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

                dt_Services = new DataTable();
                dt_Services = obj.Service_Select_ByServiceSerial(System.Convert.ToInt16(ServicesEnum.shiraze));

                this.shirazeIndex = System.Convert.ToInt16(dt_Services.Rows[0]["ServiceSerial"]);
                this.temp = System.Convert.ToInt64(dt_Services.Rows[0]["Fee"]);
                numShirazeFee.Value = System.Convert.ToDecimal(this.temp);

                Int32.TryParse(txtLength.Text, out this.length);
                double x = this.length / 100.0;
                numAmountShiraze.Value = (decimal)(x*2);
                this.shirazeCost = System.Convert.ToInt16(numAmountShiraze.Value * numShirazeFee.Value);
                txtShirazeCost.Text = this.shirazeCost.ToString();
                this.txtShirazeCost.BackColor = System.Drawing.Color.SeaShell;
            }
            else
            {
                numAmountShiraze.Enabled = false;
                numAmountShiraze.Value = 0;
                numShirazeFee.Enabled = false;
                numShirazeFee.Value = 0;
                txtShirazeCost.Enabled = false;
                txtShirazeCost.Text = "";
                this.txtShirazeCost.BackColor = System.Drawing.Color.Gainsboro;
            }
        }

        private void chBoxSarnakh_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxSarnakh.Checked)
            {
                numAmountSarnakh.Enabled = true;
                numSarnakhFee.Enabled = true;
                txtSarnakhCost.Enabled = true;

                HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                    = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

                dt_Services = new DataTable();
                dt_Services = obj.Service_Select_ByServiceSerial(System.Convert.ToInt16(ServicesEnum.sarnakh));

                this.sarnakhIndex = System.Convert.ToInt16(dt_Services.Rows[0]["ServiceSerial"]);
                this.temp = System.Convert.ToInt64(dt_Services.Rows[0]["Fee"]);
                numSarnakhFee.Value = System.Convert.ToDecimal(this.temp);

                Int32.TryParse(txtLength.Text, out this.length);
                Int32.TryParse(txtWidth.Text, out this.width);
                double x = this.area / 10000.0;
                numAmountSarnakh.Value = (decimal)(x);
                this.sarnakhCost = System.Convert.ToInt16(numAmountSarnakh.Value * numSarnakhFee.Value);
                txtSarnakhCost.Text = this.sarnakhCost.ToString();
                this.txtSarnakhCost.BackColor = System.Drawing.Color.SeaShell;
            }
            else
            {
                numAmountSarnakh.Enabled = false;
                numAmountSarnakh.Value = 0;
                numSarnakhFee.Enabled = false;
                numSarnakhFee.Value = 0;
                txtSarnakhCost.Enabled = false;
                txtSarnakhCost.Text = "";
                this.txtSarnakhCost.BackColor = System.Drawing.Color.Gainsboro;
            }
        }

        private void chBoxCharm_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxCharm.Checked)
            {
                numAmountCharm.Enabled = true;
                numCharmFee.Enabled = true;
                txtCharmCost.Enabled = true;

                HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                    = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

                dt_Services = new DataTable();
                dt_Services = obj.Service_Select_ByServiceSerial(System.Convert.ToInt16(ServicesEnum.charm));

                this.charmIndex = System.Convert.ToInt16(dt_Services.Rows[0]["ServiceSerial"]);
                this.temp = System.Convert.ToInt64(dt_Services.Rows[0]["Fee"]);
                numCharmFee.Value = System.Convert.ToDecimal(this.temp);

                Int32.TryParse(txtLength.Text, out this.length);
                double x = this.length / 100.0;
                numAmountCharm.Value = (decimal)(x * 2);
                this.charmCost = System.Convert.ToInt16(numAmountCharm.Value * numCharmFee.Value);
                txtCharmCost.Text = this.charmCost.ToString();
                this.txtCharmCost.BackColor = System.Drawing.Color.SeaShell;
            }
            else
            {
                numAmountCharm.Enabled = false;
                numAmountCharm.Value = 0;
                numCharmFee.Enabled = false;
                numCharmFee.Value = 0;
                txtCharmCost.Enabled = false;
                txtCharmCost.Text = "";
                this.txtCharmCost.BackColor = System.Drawing.Color.Gainsboro;
            }
        }

        private void chBoxRofu_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxRofu.Checked)
            {
                numAmountRofu.Enabled = true;
                numRofuFee.Enabled = true;
                txtRofuCost.Enabled = true;

                HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                    = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

                dt_Services = new DataTable();
                dt_Services = obj.Service_Select_ByServiceSerial(System.Convert.ToInt16(ServicesEnum.rofou));

                this.rofuIndex = System.Convert.ToInt16(dt_Services.Rows[0]["ServiceSerial"]);
                this.temp = System.Convert.ToInt64(dt_Services.Rows[0]["Fee"]);
                numRofuFee.Value = System.Convert.ToDecimal(this.temp);

                numAmountRofu.Value = 1;
                this.rofuCost = System.Convert.ToInt16(numRofuFee.Value);
                txtRofuCost.Text = this.rofuCost.ToString();
                this.txtRofuCost.BackColor = System.Drawing.Color.SeaShell;
            }
            else
            {
                numAmountRofu.Enabled = false;
                numAmountRofu.Value = 0;
                numRofuFee.Enabled = false;
                numRofuFee.Value = 0;
                txtRofuCost.Enabled = false;
                txtRofuCost.Text = "";
                this.txtRofuCost.BackColor = System.Drawing.Color.Gainsboro;
            }
        }

        private void txtWidth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter )
            {
                Int32.TryParse(txtWidth.Text, out this.width);
                Int32.TryParse(txtLength.Text, out this.length);
                this.area = this.length * this.width;
                double w = this.width / 100.0;
                double l = this.length / 100.0;
                double a = this.area / 10000.0;

                if (chBoxShuor.Checked)
                {
                    numAmountShur.Value = (decimal)(a);
                    int y = System.Convert.ToInt16(numAmountShur.Value * numShurFee.Value);
                    txtShurCost.Text = y.ToString();
                }

                if (chBoxDarkeshi.Checked)
                {
                    numAmountDarkeshi.Value = (decimal)(a);
                    int y = System.Convert.ToInt16(numAmountDarkeshi.Value * numDarkeshiFee.Value);
                    txtDarkeshiCost.Text = y.ToString();
                }

                if (chBoxPardakht.Checked)
                {
                    numAmountPardakht.Value = (decimal)(a);
                    int y = System.Convert.ToInt16(numAmountPardakht.Value * numPardakhtFee.Value);
                    txtPardakhtCost.Text = y.ToString();
                }

                if (chBoxDogere.Checked)
                {
                    numAmountDogere.Value = (decimal)(2*w);
                    int y = System.Convert.ToInt16(numAmountDogere.Value * numDogereFee.Value);
                    txtDogereCost.Text = y.ToString();
                }

                if (chBoxShiraze.Checked)
                {
                    numAmountShiraze.Value = (decimal)(2*l);
                    int y = System.Convert.ToInt16(numAmountShiraze.Value * numShirazeFee.Value);
                    txtShirazeCost.Text = y.ToString();
                }

                if (chBoxSarnakh.Checked)
                {
                    numAmountSarnakh.Value = (decimal)(a);
                    int y = System.Convert.ToInt16(numAmountSarnakh.Value * numSarnakhFee.Value);
                    txtSarnakhCost.Text = y.ToString();
                }

                if (chBoxCharm.Checked)
                {
                    numAmountCharm.Value = (decimal)(2*l);
                    int y = System.Convert.ToInt16(numAmountCharm.Value * numCharmFee.Value);
                    txtCharmCost.Text = y.ToString();
                }

                faDatePicker_EnterDate.Select();
            }
        }

        private void btnServicesSetting_Click(object sender, EventArgs e)
        {
            HomeCustomerVersionOfTehranRey.Forms.frmServicesSetting obj = new frmServicesSetting();
            obj.ShowDialog();
        }

        private void txtCarpetLable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Enter)
            {
                txtPlace.Select();
            }
        }

        private void txtLength_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtWidth.Select();
            }
        }

        private void chBoxShuor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chBoxShuor.Checked)
                {
                    numShurFee.Select();   
                }
                else
                {
                    chBoxDarkeshi.Focus();
                }
            }
        }

        private void numShurFee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Enter)
            {
                this.shourCost = System.Convert.ToInt16(numAmountShur.Value * numShurFee.Value);
                txtShurCost.Text = this.shourCost.ToString();

                numAmountShur.Select();
            }
        }

        private void numAmountShur_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.shourCost = System.Convert.ToInt16(numAmountShur.Value * numShurFee.Value);
                txtShurCost.Text = this.shourCost.ToString();

                chBoxDarkeshi.Select();
            }
        }

        private void chBoxDarkeshi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chBoxDarkeshi.Checked)
                {
                    numDarkeshiFee.Select();
                }
                else
                {
                    chBoxPardakht.Focus();
                }
            }
        }

        private void numDarkeshiFee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.darkeshiCost = System.Convert.ToInt16(numAmountDarkeshi.Value * numDarkeshiFee.Value);
                txtDarkeshiCost.Text = this.darkeshiCost.ToString();

                numAmountDarkeshi.Select();
            }
        }

        private void numAmountDarkeshi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.darkeshiCost = System.Convert.ToInt16(numAmountDarkeshi.Value * numDarkeshiFee.Value);
                txtDarkeshiCost.Text = this.darkeshiCost.ToString();

                chBoxPardakht.Select();
            }
        }

        private void chBoxPardakht_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chBoxPardakht.Checked)
                {
                    numPardakhtFee.Select();
                }
                else
                {
                    chBoxRang.Focus();
                }
            }
        }

        private void numPardakhtFee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.pardakhtCost = System.Convert.ToInt16(numAmountPardakht.Value * numPardakhtFee.Value);
                txtPardakhtCost.Text = this.pardakhtCost.ToString();

                numAmountPardakht.Select();
            }
        }

        private void numAmountPardakht_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.pardakhtCost = System.Convert.ToInt16(numAmountPardakht.Value * numPardakhtFee.Value);
                txtPardakhtCost.Text = this.pardakhtCost.ToString();

                chBoxRang.Select();
            }
        }

        private void chBoxRang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chBoxRang.Checked)
                {
                    numRangFee.Select();
                }
                else
                {
                    chBoxRofu.Focus();
                }
            }
        }

        private void numRangFee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.rangCost = System.Convert.ToInt16(numAmountRang.Value * numRangFee.Value);
                txtRangCost.Text = this.rangCost.ToString();

                numAmountRang.Select();
            }
        }

        private void numAmountRang_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                this.rangCost = System.Convert.ToInt16(numAmountRang.Value * numRangFee.Value);
                txtRangCost.Text = this.rangCost.ToString();

                chBoxRofu.Select();
            }
        }

        private void chBoxRofu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chBoxRofu.Checked)
                {
                    numRofuFee.Select();
                }
                else
                {
                    chBoxDogere.Focus();
                }
            }
        }

        private void numRofuFee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.rofuCost = System.Convert.ToInt16(numAmountRofu.Value * numRofuFee.Value);
                txtRofuCost.Text = this.rofuCost.ToString();

                numAmountRofu.Select();
            }
        }

        private void numAmountRofu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.rofuCost = System.Convert.ToInt16(numAmountRofu.Value * numRofuFee.Value);
                txtRofuCost.Text = this.rofuCost.ToString();

                chBoxDogere.Select();
            }
        }

        private void chBoxDogere_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chBoxDogere.Checked)
                {
                    numDogereFee.Select();
                }
                else
                {
                    chBoxShiraze.Focus();
                }
            }
        }

        private void numDogereFee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.dogereCost = System.Convert.ToInt16(numAmountDogere.Value * numDogereFee.Value);
                txtDogereCost.Text = this.dogereCost.ToString();

                numAmountDogere.Select();
            }
        }

        private void numAmountDogere_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.dogereCost = System.Convert.ToInt16(numAmountDogere.Value * numDogereFee.Value);
                txtDogereCost.Text = this.dogereCost.ToString();

                chBoxShiraze.Select();
            }
        }

        private void chBoxShiraze_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chBoxShiraze.Checked)
                {
                    numShirazeFee.Select();
                }
                else
                {
                    chBoxSarnakh.Focus();
                }
            }
        }

        private void numShirazeFee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.shirazeCost = System.Convert.ToInt16(numAmountShiraze.Value * numShirazeFee.Value);
                txtShirazeCost.Text = this.shirazeCost.ToString();

                numAmountShiraze.Select();
            }
        }

        private void numAmountShiraze_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.shirazeCost = System.Convert.ToInt16(numAmountShiraze.Value * numShirazeFee.Value);
                txtShirazeCost.Text = this.shirazeCost.ToString();

                chBoxSarnakh.Select();
            }
        }

        private void chBoxSarnakh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chBoxSarnakh.Checked)
                {
                    numSarnakhFee.Select();
                }
                else
                {
                    chBoxCharm.Focus();
                }
            }
        }

        private void numSarnakhFee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.sarnakhCost = System.Convert.ToInt16(numAmountSarnakh.Value * numSarnakhFee.Value);
                txtSarnakhCost.Text = this.sarnakhCost.ToString();

                numAmountSarnakh.Select();
            }
        }

        private void numAmountSarnakh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.sarnakhCost = System.Convert.ToInt16(numAmountSarnakh.Value * numSarnakhFee.Value);
                txtSarnakhCost.Text = this.sarnakhCost.ToString();

                chBoxCharm.Select();
            }
        }

        private void chBoxCharm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chBoxCharm.Checked)
                {
                    numCharmFee.Select();
                }
                else
                {
                    btnAdd_Continue.Focus();
                }
            }
        }

        private void numCharmFee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.charmCost = System.Convert.ToInt16(numAmountCharm.Value * numCharmFee.Value);
                txtCharmCost.Text = this.charmCost.ToString();

                numAmountCharm.Select();
            }
        }

        private void numAmountCharm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.charmCost = System.Convert.ToInt16(numAmountCharm.Value * numCharmFee.Value);
                txtCharmCost.Text = this.charmCost.ToString();

                btnAdd_Continue.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCarpetLable.Text != "" & txtLength.Text != ""
                & txtWidth.Text != "" & txtSize.Text != ""
                & faDatePicker_EnterDate.SelectedDateTime != null & faDatePicker_ReturnDate.SelectedDateTime != null
                &( chBoxCharm.Checked || chBoxDarkeshi.Checked || chBoxShuor.Checked
                || chBoxShiraze.Checked || chBoxDogere.Checked || chBoxRang.Checked
                || chBoxRofu.Checked || chBoxSarnakh.Checked || chBoxPardakht.Checked))
            {
                this.InsertValus();
                this.carpetNumber++;
                txtCarpetLable.Text = this.prop_getCustomerID.ToString() + "_" + this.carpetNumber.ToString();
                txtCarpetLable.Select();

            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("اطلاعات ضروری را وارد کنید!");
                txtCarpetLable.Select();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCarpetLable.Text != "" & txtLength.Text != ""
                & txtWidth.Text != "" & txtSize.Text != ""
                & faDatePicker_EnterDate.SelectedDateTime != null & faDatePicker_ReturnDate.SelectedDateTime != null
                &
                ( chBoxCharm.Checked || chBoxDarkeshi.Checked || chBoxShuor.Checked
                || chBoxShiraze.Checked || chBoxDogere.Checked || chBoxRang.Checked
                || chBoxRofu.Checked || chBoxSarnakh.Checked || chBoxPardakht.Checked))
            {
                this.InsertValus();
                this.Close();
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("اطلاعات ضروری را وارد کنید!");
                txtCarpetLable.Select();
            }            
        }

        private void txtPlace_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtSize.Select();
            }
        }

        private void txtSize_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtLength.Select();
            }
        }

    }
}