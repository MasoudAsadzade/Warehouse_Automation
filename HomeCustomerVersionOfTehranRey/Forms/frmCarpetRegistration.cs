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
        frmEditCarpet editForm;

        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Tehranrey;Integrated Security=True";
        SqlDataAdapter da_Customer;
        SqlDataAdapter da_Carpet;
        SqlDataAdapter da_Services;
        DataSet ds_Customer;
        DataSet ds_Carpet;
        DataSet ds_Services;

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
        decimal lengthLable;
        decimal widthLable;
        decimal areaLable;
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

        enum ServicesEnum
        {
            shour = 1, pardakht, darkeshi, rang, dogere, shiraze, sarnakh, charm, rofou
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

            HomeCustomerVersionOfTehranRey.Classes.clsHomeCustomerDB obj =
                new HomeCustomerVersionOfTehranRey.Classes.clsHomeCustomerDB();

            //********************* Inser carpet _____ Set parameters of sp_Insert Carpet

            this.carpetLable = txtCarpetLable.Text;

            Int32.TryParse(txtLength.Text, out this.length);
            Int32.TryParse(txtWidth.Text, out this.width);
            this.madeInfrom = cmbPlace.Text;
            this.size = cmbSize.Text;
            this.enterDate = faDatePicker_EnterDate.SelectedDateTime;
            this.returnDate = faDatePicker_ReturnDate.SelectedDateTime;

            obj.InsertCarpet(this.carpetLable, this.madeInfrom, this.size, this.length, this.width,
                this.enterDate, this.returnDate, true);


            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();
            SqlCommand command = new SqlCommand("SELECT MAX(carpetCode) FROM Carpet", cn);
            command.CommandType = CommandType.Text;
            this.lastCarpetCode = (long)(command.ExecuteScalar());


            //********************* End Of Inser carpet _____ Set parameters of sp_Insert Carpet

            //********************* Inser Services _____ Set parameters of sp_InsertCarpetServices

            if (chBoxShuor.Checked)
            {
                this.shourFee = (int)(numShurFee.Value);
                this.shourAmount = (decimal)(numAmountShur.Value);

                obj.CarpetServicesInsert(this.lastCarpetCode,
                    this.shourIndex, this.shourAmount, this.shourFee);
            }
            if (chBoxDarkeshi.Checked)
            {
                this.darkeshiFee = (int)(numDarkeshiFee.Value);
                this.darkeshiAmount = (decimal)(numAmountDarkeshi.Value);

                obj.CarpetServicesInsert(this.lastCarpetCode,
                    this.darkeshiIndex, this.darkeshiAmount, this.darkeshiFee);
            }
            if (chBoxPardakht.Checked)
            {
                this.pardakhtFee = (int)(numPardakhtFee.Value);
                this.pardakhtAmount = (decimal)(numAmountPardakht.Value);

                obj.CarpetServicesInsert(this.lastCarpetCode,
                    this.pardakhtIndex, this.pardakhtAmount, this.pardakhtFee);
            }
            if (chBoxRang.Checked)
            {
                this.rangFee = (int)(numRangFee.Value);
                this.rangAmount = (int)(numAmountRang.Value);

                obj.CarpetServicesInsert(this.lastCarpetCode,
                    this.rangIndex, this.rangAmount, this.rangFee);
            }
            if (chBoxRofu.Checked)
            {
                this.rofuFee = (int)(numRofuFee.Value);
                this.rofuAmount = (int)(numAmountRofu.Value);

                obj.CarpetServicesInsert(this.lastCarpetCode,
                    this.rofuIndex, this.rofuAmount, this.rofuFee);
            }
            if (chBoxDogere.Checked)
            {
                this.dogereFee = (int)(numDogereFee.Value);
                this.dogereAmount = (decimal)(numAmountDogere.Value);

                obj.CarpetServicesInsert(this.lastCarpetCode,
                    this.dogereIndex, this.dogereAmount, this.dogereFee);
            }
            if (chBoxShiraze.Checked)
            {
                this.shirazeFee = (int)(numShirazeFee.Value);
                this.shirazeAmount = (decimal)(numAmountShiraze.Value);

                obj.CarpetServicesInsert(this.lastCarpetCode,
                    this.shirazeIndex, this.shirazeAmount, this.shirazeFee);
            }
            if (chBoxSarnakh.Checked)
            {
                this.sarnakhFee = (int)(numSarnakhFee.Value);
                this.sarnakhAmount = (decimal)(numAmountSarnakh.Value);

                obj.CarpetServicesInsert(this.lastCarpetCode,
                    this.sarnakhIndex, this.sarnakhAmount, this.sarnakhFee);
            }
            if (chBoxCharm.Checked)
            {
                this.charmFee = (int)(numCharmFee.Value);
                this.charmAmount = (decimal)(numAmountCharm.Value);

                obj.CarpetServicesInsert(this.lastCarpetCode,
                    this.charmIndex, this.charmAmount, this.charmFee);
            }

            //********************* End of Inser Services _____ Set parameters of sp_InsertCarpetServices

            //********************* Inser new Row In CarpetCustomer Table with sp_InsertCarpetCustomer

            obj.CarpetCustomerInsert(this.lastCarpetCode, this.customerID);

            //********************* End of Inser new Row In CarpetCustomer Table with sp_InsertCarpetCustomer

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.Columns.Remove("cl8");
                dataGridView1.Columns.Remove("cl9");
            }

            this.SetDataGridViewForCarpets(dataGridView1, this.ShowLastCarpetOfSpecialCustomer(ds_Carpet));
            dataGridView1.Refresh();
            dataGridView1.EndEdit();
            dataGridView1.RefreshEdit();

            Microgod.AmrComponent.AmrAssistanteForms.frmWaiting.CloseWaiting();
            Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show(".فرش به لیست اضافه شد");
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
        private DataSet ShowLastCarpetOfSpecialCustomer (DataSet ds)
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

                // this line set the number of carpet of special customer to set carpetLable of new carpet
                this.carpetNumber = ds.Tables[0].Rows.Count;

                
            }
            return ds;
        }

        private void frmCarpetRegistration_Load(object sender, EventArgs e)
        {

            faDatePicker_EnterDate.SelectedDateTime = System.DateTime.Today;
            faDatePicker_ReturnDate.SelectedDateTime = System.DateTime.Today;

            //********************************Set Data to show on datagride ******************************

            this.SetDataGridViewForCarpets(dataGridView1, this.ShowLastCarpetOfSpecialCustomer(ds_Carpet));
               
            //********************************End of Set Data to show on datagride ******************************

            //************************** set the lable of carpet in txtCarpetLable******************************

            txtCarpetLable.Text = this.customerID.ToString() + "_" + ((this.carpetNumber)+1).ToString();
            txtCarpetLable.Select();

            //************************* set the lable of carpet in txtCarpetLable******************************

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
            //******************************** End Of set cmbmadeInFrom Items ***********

        }

        private void chBoxShour_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxShuor.Checked)
            {
                numAmountShur.Enabled = true;
                numShurFee.Enabled = true;
                txtShurCost.Enabled = true;

                ds_Services = new DataSet();
                da_Services = new SqlDataAdapter("SELECT * FROM Services WHERE ServiceSerial = '"
                    + (int)(ServicesEnum.shour) + "'", connectionString);
                da_Services.Fill(ds_Services);
                this.shourIndex = (int)(ds_Services.Tables[0].Rows[0]["ServiceSerial"]);
                this.temp = (long)(ds_Services.Tables[0].Rows[0]["Fee"]);
                numShurFee.Value = (decimal)(this.temp);

                Int32.TryParse(txtLength.Text, out this.length);
                Int32.TryParse(txtWidth.Text, out this.width);
                double x = this.area/ 10000.0;
                numAmountShur.Value = (decimal)(x);
                this.shourCost = (int)(numAmountShur.Value * numShurFee.Value);
                txtShurCost.Text = this.shourCost.ToString();

            }
            else
            {
                numAmountShur.Enabled = false;
                numAmountShur.Value = 0;
                numShurFee.Enabled = false;
                numShurFee.Value = 0;
                txtShurCost.Enabled = false;
                txtShurCost.Text = "";
            }
        }

        private void chBoxDarkeshi_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxDarkeshi.Checked)
            {
                numAmountDarkeshi.Enabled = true;
                numDarkeshiFee.Enabled = true;
                txtDarkeshiCost.Enabled = true;

                ds_Services = new DataSet();
                da_Services = new SqlDataAdapter("SELECT * FROM Services WHERE ServiceSerial = '"
                    + (int)(ServicesEnum.darkeshi) + "'", connectionString);
                da_Services.Fill(ds_Services);
                this.darkeshiIndex = (int)(ds_Services.Tables[0].Rows[0]["ServiceSerial"]);
                this.temp = (long)(ds_Services.Tables[0].Rows[0]["Fee"]);
                numDarkeshiFee.Value = (decimal)(this.temp);

                Int32.TryParse(txtLength.Text, out this.length);
                Int32.TryParse(txtWidth.Text, out this.width);
                double x = this.area / 10000.0;
                numAmountDarkeshi.Value = (decimal)(x);
                this.darkeshiCost = (int)(numAmountDarkeshi.Value * numDarkeshiFee.Value);
                txtDarkeshiCost.Text = this.darkeshiCost.ToString();
                
            }
            else
            {
                numAmountDarkeshi.Enabled = false;
                numAmountDarkeshi.Value = 0;
                numDarkeshiFee.Enabled = false;
                numDarkeshiFee.Value = 0;
                txtDarkeshiCost.Enabled = false;
                txtDarkeshiCost.Text = "";
            }
        }

        private void chBoxPardakht_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxPardakht.Checked)
            {
                numAmountPardakht.Enabled = true;
                numPardakhtFee.Enabled = true;
                txtPardakhtCost.Enabled = true;

                ds_Services = new DataSet();
                da_Services = new SqlDataAdapter("SELECT * FROM Services WHERE ServiceSerial = '"
                    + (int)(ServicesEnum.pardakht) + "'", connectionString);
                da_Services.Fill(ds_Services);
                this.pardakhtIndex = (int)(ds_Services.Tables[0].Rows[0]["ServiceSerial"]);
                this.temp = (long)(ds_Services.Tables[0].Rows[0]["Fee"]);
                numPardakhtFee.Value = (decimal)(this.temp);

                Int32.TryParse(txtLength.Text, out this.length);
                Int32.TryParse(txtWidth.Text, out this.width);
                double x = this.area / 10000.0;
                numAmountPardakht.Value = (decimal)(x);
                this.pardakhtCost = (int)(numAmountPardakht.Value * numPardakhtFee.Value);
                txtPardakhtCost.Text = this.pardakhtCost.ToString();
            }
            else
            {
                numAmountPardakht.Enabled = false;
                numAmountPardakht.Value = 0;
                numPardakhtFee.Enabled = false;
                numPardakhtFee.Value = 0;
                txtPardakhtCost.Enabled = false;
                txtPardakhtCost.Text = "";
            }
        }

        private void chBoxRang_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxRang.Checked)
            {
                numAmountRang.Enabled = true;
                numRangFee.Enabled = true;
                txtRangCost.Enabled = true;

                ds_Services = new DataSet();
                da_Services = new SqlDataAdapter("SELECT * FROM Services WHERE ServiceSerial = '"
                    + (int)(ServicesEnum.rang) + "'", connectionString);
                da_Services.Fill(ds_Services);
                this.rangIndex = (int)(ds_Services.Tables[0].Rows[0]["ServiceSerial"]);
                this.temp = (long)(ds_Services.Tables[0].Rows[0]["Fee"]);
                numRangFee.Value = (decimal)(this.temp);

                numAmountRang.Value = 1;
                this.rangCost = (int)(numRangFee.Value);
                txtRangCost.Text = this.rangCost.ToString();
            }
            else
            {
                numAmountRang.Enabled = false;
                numAmountRang.Value = 0;
                numRangFee.Enabled = false;
                numRangFee.Value = 0;
                txtRangCost.Enabled = false;
                txtRangCost.Text = "";
            }
        }

        private void chBoxDogere_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxDogere.Checked)
            {
                numAmountDogere.Enabled = true;
                numDogereFee.Enabled = true;
                txtDogereCost.Enabled = true;

                ds_Services = new DataSet();
                da_Services = new SqlDataAdapter("SELECT * FROM Services WHERE ServiceSerial = '"
                    + (int)(ServicesEnum.dogere) + "'", connectionString);
                da_Services.Fill(ds_Services);
                this.dogereIndex = (int)(ds_Services.Tables[0].Rows[0]["ServiceSerial"]);
                this.temp = (long)(ds_Services.Tables[0].Rows[0]["Fee"]);
                numDogereFee.Value = (decimal)(this.temp);

                Int32.TryParse(txtWidth.Text, out this.width);
                double x = this.width / 100.0;
                numAmountDogere.Value = (decimal)(2*x);
                this.dogereCost = (int)(numAmountDogere.Value * numDogereFee.Value);
                txtDogereCost.Text = this.dogereCost.ToString();
            }
            else
            {
                numAmountDogere.Enabled = false;
                numAmountDogere.Value = 0;
                numDogereFee.Enabled = false;
                numDogereFee.Value = 0;
                txtDogereCost.Enabled = false;
                txtDogereCost.Text = "";
            }
        }

        private void chBoxShiraze_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxShiraze.Checked)
            {
                numAmountShiraze.Enabled = true;
                numShirazeFee.Enabled = true;
                txtShirazeCost.Enabled = true;

                ds_Services = new DataSet();
                da_Services = new SqlDataAdapter("SELECT * FROM Services WHERE ServiceSerial = '"
                    + (int)(ServicesEnum.shiraze) + "'", connectionString);
                da_Services.Fill(ds_Services);
                this.shirazeIndex = (int)(ds_Services.Tables[0].Rows[0]["ServiceSerial"]);
                this.temp = (long)(ds_Services.Tables[0].Rows[0]["Fee"]);
                numShirazeFee.Value = (decimal)(this.temp);

                Int32.TryParse(txtLength.Text, out this.length);
                double x = this.length / 100.0;
                numAmountShiraze.Value = (decimal)(x*2);
                this.shirazeCost = (int)(numAmountShiraze.Value * numShirazeFee.Value);
                txtShirazeCost.Text = this.shirazeCost.ToString();
            }
            else
            {
                numAmountShiraze.Enabled = false;
                numAmountShiraze.Value = 0;
                numShirazeFee.Enabled = false;
                numShirazeFee.Value = 0;
                txtShirazeCost.Enabled = false;
                txtShirazeCost.Text = "";
            }
        }

        private void chBoxSarnakh_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxSarnakh.Checked)
            {
                numAmountSarnakh.Enabled = true;
                numSarnakhFee.Enabled = true;
                txtSarnakhCost.Enabled = true;

                ds_Services = new DataSet();
                da_Services = new SqlDataAdapter("SELECT * FROM Services WHERE ServiceSerial = '"
                    + (int)(ServicesEnum.sarnakh) + "'", connectionString);
                da_Services.Fill(ds_Services);
                this.sarnakhIndex = (int)(ds_Services.Tables[0].Rows[0]["ServiceSerial"]);
                this.temp = (long)(ds_Services.Tables[0].Rows[0]["Fee"]);
                numSarnakhFee.Value = (decimal)(this.temp);

                Int32.TryParse(txtLength.Text, out this.length);
                Int32.TryParse(txtWidth.Text, out this.width);
                double x = this.area / 10000.0;
                numAmountSarnakh.Value = (decimal)(x);
                this.sarnakhCost = (int)(numAmountSarnakh.Value * numSarnakhFee.Value);
                txtSarnakhCost.Text = this.sarnakhCost.ToString();
            }
            else
            {
                numAmountSarnakh.Enabled = false;
                numAmountSarnakh.Value = 0;
                numSarnakhFee.Enabled = false;
                numSarnakhFee.Value = 0;
                txtSarnakhCost.Enabled = false;
                txtSarnakhCost.Text = "";
            }
        }

        private void chBoxCharm_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxCharm.Checked)
            {
                numAmountCharm.Enabled = true;
                numCharmFee.Enabled = true;
                txtCharmCost.Enabled = true;

                ds_Services = new DataSet();
                da_Services = new SqlDataAdapter("SELECT * FROM Services WHERE ServiceSerial = '"
                    + (int)(ServicesEnum.charm) + "'", connectionString);
                da_Services.Fill(ds_Services);
                this.charmIndex = (int)(ds_Services.Tables[0].Rows[0]["ServiceSerial"]);
                this.temp = (long)(ds_Services.Tables[0].Rows[0]["Fee"]);
                numCharmFee.Value = (decimal)(this.temp);

                Int32.TryParse(txtLength.Text, out this.length);
                double x = this.length / 100.0;
                numAmountCharm.Value = (decimal)(x * 2);
                this.charmCost = (int)(numAmountCharm.Value * numCharmFee.Value);
                txtCharmCost.Text = this.charmCost.ToString();
            }
            else
            {
                numAmountCharm.Enabled = false;
                numAmountCharm.Value = 0;
                numCharmFee.Enabled = false;
                numCharmFee.Value = 0;
                txtCharmCost.Enabled = false;
                txtCharmCost.Text = "";
            }
        }

        private void chBoxRofu_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxRofu.Checked)
            {
                numAmountRofu.Enabled = true;
                numRofuFee.Enabled = true;
                txtRofuCost.Enabled = true;

                ds_Services = new DataSet();
                da_Services = new SqlDataAdapter("SELECT * FROM Services WHERE ServiceSerial = '"
                    + (int)(ServicesEnum.rofou) + "'", connectionString);
                da_Services.Fill(ds_Services);
                this.rofuIndex = (int)(ds_Services.Tables[0].Rows[0]["ServiceSerial"]);
                this.temp = (long)(ds_Services.Tables[0].Rows[0]["Fee"]);
                numRofuFee.Value = (decimal)(this.temp);

                numAmountRofu.Value = 1;
                this.rofuCost = (int)(numRofuFee.Value);
                txtRofuCost.Text = this.rofuCost.ToString();
            }
            else
            {
                numAmountRofu.Enabled = false;
                numAmountRofu.Value = 0;
                numRofuFee.Enabled = false;
                numRofuFee.Value = 0;
                txtRofuCost.Enabled = false;
                txtRofuCost.Text = "";
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
                    int y = (int)(numAmountShur.Value * numShurFee.Value);
                    txtShurCost.Text = y.ToString();
                }

                if (chBoxDarkeshi.Checked)
                {
                    numAmountDarkeshi.Value = (decimal)(a);
                    int y = (int)(numAmountDarkeshi.Value * numDarkeshiFee.Value);
                    txtDarkeshiCost.Text = y.ToString();
                }

                if (chBoxPardakht.Checked)
                {
                    numAmountPardakht.Value = (decimal)(a);
                    int y = (int)(numAmountPardakht.Value * numPardakhtFee.Value);
                    txtPardakhtCost.Text = y.ToString();
                }

                if (chBoxDogere.Checked)
                {
                    numAmountDogere.Value = (decimal)(2*w);
                    int y = (int)(numAmountDogere.Value * numDogereFee.Value);
                    txtDogereCost.Text = y.ToString();
                }

                if (chBoxShiraze.Checked)
                {
                    numAmountShiraze.Value = (decimal)(2*l);
                    int y = (int)(numAmountShiraze.Value * numShirazeFee.Value);
                    txtShirazeCost.Text = y.ToString();
                }

                if (chBoxSarnakh.Checked)
                {
                    numAmountSarnakh.Value = (decimal)(a);
                    int y = (int)(numAmountSarnakh.Value * numSarnakhFee.Value);
                    txtSarnakhCost.Text = y.ToString();
                }

                if (chBoxCharm.Checked)
                {
                    numAmountCharm.Value = (decimal)(2*l);
                    int y = (int)(numAmountCharm.Value * numCharmFee.Value);
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
                cmbPlace.Select();
            }
        }

        private void cmbPlace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cmbSize.Select();
            }
        }

        private void cmbSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtLength.Select();
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
                this.shourCost = (int)(numAmountShur.Value * numShurFee.Value);
                txtShurCost.Text = this.shourCost.ToString();

                numAmountShur.Select();
            }
        }

        private void numAmountShur_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.shourCost = (int)(numAmountShur.Value * numShurFee.Value);
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
                this.darkeshiCost = (int)(numAmountDarkeshi.Value * numDarkeshiFee.Value);
                txtDarkeshiCost.Text = this.darkeshiCost.ToString();

                numAmountDarkeshi.Select();
            }
        }

        private void numAmountDarkeshi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.darkeshiCost = (int)(numAmountDarkeshi.Value * numDarkeshiFee.Value);
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
                this.pardakhtCost = (int)(numAmountPardakht.Value * numPardakhtFee.Value);
                txtPardakhtCost.Text = this.pardakhtCost.ToString();

                numAmountPardakht.Select();
            }
        }

        private void numAmountPardakht_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.pardakhtCost = (int)(numAmountPardakht.Value * numPardakhtFee.Value);
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
                this.rangCost = (int)(numAmountRang.Value * numRangFee.Value);
                txtRangCost.Text = this.rangCost.ToString();

                numAmountRang.Select();
            }
        }

        private void numAmountRang_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                this.rangCost = (int)(numAmountRang.Value * numRangFee.Value);
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
                this.rofuCost = (int)(numAmountRofu.Value * numRofuFee.Value);
                txtRofuCost.Text = this.rofuCost.ToString();

                numAmountRofu.Select();
            }
        }

        private void numAmountRofu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.rofuCost = (int)(numAmountRofu.Value * numRofuFee.Value);
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
                this.dogereCost = (int)(numAmountDogere.Value * numDogereFee.Value);
                txtDogereCost.Text = this.dogereCost.ToString();

                numAmountDogere.Select();
            }
        }

        private void numAmountDogere_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.dogereCost = (int)(numAmountDogere.Value * numDogereFee.Value);
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
                this.shirazeCost = (int)(numAmountShiraze.Value * numShirazeFee.Value);
                txtShirazeCost.Text = this.shirazeCost.ToString();

                numAmountShiraze.Select();
            }
        }

        private void numAmountShiraze_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.shirazeCost = (int)(numAmountShiraze.Value * numShirazeFee.Value);
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
                this.sarnakhCost = (int)(numAmountSarnakh.Value * numSarnakhFee.Value);
                txtSarnakhCost.Text = this.sarnakhCost.ToString();

                numAmountSarnakh.Select();
            }
        }

        private void numAmountSarnakh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.sarnakhCost = (int)(numAmountSarnakh.Value * numSarnakhFee.Value);
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
                this.charmCost = (int)(numAmountCharm.Value * numCharmFee.Value);
                txtCharmCost.Text = this.charmCost.ToString();

                numAmountCharm.Select();
            }
        }

        private void numAmountCharm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.charmCost = (int)(numAmountCharm.Value * numCharmFee.Value);
                txtCharmCost.Text = this.charmCost.ToString();

                btnAdd_Continue.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCarpetLable.Text != "" & txtLength.Text != ""
                & txtWidth.Text != "" & cmbSize.Text != ""
                & faDatePicker_EnterDate.SelectedDateTime != null & faDatePicker_ReturnDate.SelectedDateTime != null
                || chBoxCharm.Checked || chBoxDarkeshi.Checked || chBoxShuor.Checked
                || chBoxShiraze.Checked || chBoxDogere.Checked || chBoxRang.Checked
                || chBoxRofu.Checked || chBoxSarnakh.Checked || chBoxPardakht.Checked)
            {
                this.InsertValus();
                this.carpetNumber++;
                txtCarpetLable.Text = this.prop_getCustomerID.ToString() + "_" + this.carpetNumber.ToString();
                txtCarpetLable.Select();

            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show(".اطلاعات ضروری را وارد کنید");
                txtCarpetLable.Select();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCarpetLable.Text != "" & txtLength.Text != ""
                & txtWidth.Text != "" & cmbSize.Text != ""
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
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show(".اطلاعات ضروری را وارد کنید");
                txtCarpetLable.Select();
            }            
        }

    }
}