using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FarsiLibrary;

namespace HomeCustomerVersionOfTehranRey.Forms
{
    public partial class frmEditCarpet : Form
    {
        DataTable dt_Services;
        DataTable dt_Carpets;

        private int customerID;
        long temp;
        long carpetCode;
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

        int shourCost;
        int darkeshiCost;
        int pardakhtCost;
        int rangCost;
        int rofuCost;
        int dogereCost;
        int shirazeCost;
        int sarnakhCost;
        int charmCost;

        decimal shourAmount;
        decimal darkeshiAmount;
        decimal pardakhtAmount;
        int rangAmount;
        int rofuAmount;
        decimal dogereAmount;
        decimal shirazeAmount;
        decimal sarnakhAmount;
        decimal charmAmount;

        int shourFee;
        int darkeshiFee;
        int pardakhtFee;
        int rangFee;
        int rofuFee;
        int dogereFee;
        int shirazeFee;
        int sarnakhFee;
        int charmFee;

        enum ServicesEnum
        {
            shour = 1, pardakht, darkeshi, rang, rofou, dogere, shiraze, charm, sarnakh
        }

        public frmEditCarpet()
        {
            InitializeComponent();
        }

        private DataTable mydetaTable;
        public long prop_getCustomerID { get; set; }
        public string prop_getCustomername { get; set; }
        public string prop_getCustomerfamily { get; set; }

        public long prop_shourFee { get; set; }
        public decimal prop_shourAmount { get; set; }
        public long prop_shourCost { get; set; }

        public long prop_DarkeshiFee { get; set; }
        public decimal prop_DarkeshiAmount { get; set; }
        public long prop_DarkeshiCost { get; set; }

        public long prop_PardakhtFee { get; set; }
        public decimal prop_PardakhtAmount { get; set; }
        public long prop_PardakhtCost { get; set; }

        public long prop_RangFee { get; set; }
        public decimal prop_RangAmount { get; set; }
        public long prop_RangCost { get; set; }

        public long prop_RofuFee { get; set; }
        public decimal prop_RofuAmount { get; set; }
        public long prop_RofuCost { get; set; }

        public long prop_DogereFee { get; set; }
        public decimal prop_DogereAmount { get; set; }
        public long prop_DogereCost { get; set; }

        public long prop_ShirazehFee { get; set; }
        public decimal prop_ShirazehAmount { get; set; }
        public long prop_shirazehCost { get; set; }

        public long prop_SarnakhFee { get; set; }
        public decimal prop_SarnakhAmount { get; set; }
        public long prop_SarnakhCost { get; set; }

        public long prop_CharmFee { get; set; }
        public decimal prop_CharmAmount { get; set; }
        public long prop_CharmCost { get; set; }

        public DataTable prop_getDataTable
        {
            get { return mydetaTable; }
            set { mydetaTable = value; }
        }
	

        public long prop_SetCarpetCode
        {
            get { return carpetCode; }
            set { carpetCode = value; }
        }

	    public int prop_SetCustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public int prop_SetLength
        {
            get { return length; }
            set { length = value; }
        }

        public int prop_SetWidth
        {
            get { return width; }
            set { width = value; }
        }

        public DateTime prop_SetEnterDate
        {
            get { return enterDate; }
            set { enterDate = value; }
        }

        public DateTime prop_SetReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        public string prop_SetCarpetLable
        {
            get { return carpetLable; }
            set { carpetLable = value; }
        }

        public string prop_SetMadeInFrom
        {
            get { return madeInfrom; }
            set { madeInfrom = value; }
        }

        public string  prop_SetSize
        {
            get { return size; }
            set { size = value; }
        }

        private void Set_HeaderLables()
        {
            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

            lblCustomerID.Text = prop_getCustomerID.ToString();
            lblCustomerName.Text = prop_getCustomername.ToString();
            lblCustomerFamily.Text = prop_getCustomerfamily.ToString();
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

        private void frmEditCarpet_Load(object sender, EventArgs e)
        {
            //*******************************Set the Header Labale Of Form*************************
            this.Set_HeaderLables();
            // End Of //*******************************Set the Header Labale Of Form***************
            
            //******************************** set txtPlace & txtSize Items ***********
            this.Set_AutoCompleteCustomSource_Of_txtPlace_And_txtSize();
            //End Of //******************************** set txtPlace & txtSize Items ***********

            txtCarpetLable.Text = prop_SetCarpetLable;
            txtWidth.Text = prop_SetWidth.ToString();
            txtLength.Text = prop_SetLength.ToString();
            txtPlace.Text = prop_SetMadeInFrom;
            txtSize.Text = prop_SetSize;
            faDatePicker_EnterDate.SelectedDateTime = prop_SetEnterDate;
            faDatePicker_returnDate.SelectedDateTime = prop_SetReturnDate;

            //************* Set Carpet Services****************
 
            this.numShurFee.Value = prop_shourFee;
            this.numDarkeshiFee.Value = prop_DarkeshiFee;
            this.numPardakhtFee.Value = prop_PardakhtFee;
            this.numRangFee.Value = prop_RangFee;
            this.numDogereFee.Value = prop_DogereFee;
            this.numShirazeFee.Value = prop_ShirazehFee;
            this.numSarnakhFee.Value = prop_SarnakhFee;
            this.numCharmFee.Value = prop_CharmFee;
            this.numRofuFee.Value = prop_RofuFee;

            if (numShurFee.Value != 0 )
            {
                chBoxShuor.Checked = true;
                numShurFee.Enabled = true;
                numAmountShur.Enabled = true;

                this.numAmountShur.Value = prop_shourAmount;
                this.txtShurCost.Text = prop_shourCost.ToString();
                this.txtShurCost.BackColor = System.Drawing.Color.SeaShell;
            }
            if (numDarkeshiFee.Value != 0)
            {
                chBoxDarkeshi.Checked = true;
                numDarkeshiFee.Enabled = true;
                numAmountDarkeshi.Enabled = true;

                this.numAmountDarkeshi.Value = prop_DarkeshiAmount;
                this.txtDarkeshiCost.Text = prop_DarkeshiCost.ToString();
                this.txtDarkeshiCost.BackColor = System.Drawing.Color.SeaShell;
            }
            if (numPardakhtFee.Value != 0)
            {
                chBoxPardakht.Checked = true;
                numPardakhtFee.Enabled = true;
                numAmountPardakht.Enabled = true;

                this.numAmountPardakht.Value = prop_PardakhtAmount;
                this.txtPardakhtCost.Text = prop_PardakhtCost.ToString();
                this.txtPardakhtCost.BackColor = System.Drawing.Color.SeaShell;
            }
            if (numRangFee.Value != 0)
            {
                chBoxRang.Checked = true;
                numRangFee.Enabled = true;
                numAmountRang.Enabled = true;
                
                this.numAmountRang.Value = prop_RangAmount;
                this.txtRangCost.Text = prop_RangCost.ToString();
                this.txtRangCost.BackColor = System.Drawing.Color.SeaShell;
            }
            if (numRofuFee.Value != 0)
            {
                chBoxRofu.Checked = true;
                numRofuFee.Enabled = true;
                numAmountRofu.Enabled = true;

                this.numAmountRofu.Value = prop_RofuAmount;
                this.txtRofuCost.Text = prop_RofuCost.ToString();
                this.txtRofuCost.BackColor = System.Drawing.Color.SeaShell;
            }
            if (numDogereFee.Value != 0)
            {
                chBoxDogere.Checked = true;
                numDogereFee.Enabled = true;
                numAmountDogere.Enabled = true;

                this.numAmountDogere.Value = prop_DogereAmount;
                this.txtDogereCost.Text = prop_DogereCost.ToString();
                this.txtDogereCost.BackColor = System.Drawing.Color.SeaShell;
            }
            if (numShirazeFee.Value != 0)
            {
                chBoxShiraze.Checked = true;
                numShirazeFee.Enabled = true;
                numAmountShiraze.Enabled = true;

                this.numAmountShiraze.Value = prop_ShirazehAmount;
                this.txtShirazeCost.Text = prop_shirazehCost.ToString();
                this.txtShirazeCost.BackColor = System.Drawing.Color.SeaShell;
            }
            if (numSarnakhFee.Value != 0)
            {
                chBoxSarnakh.Checked = true;
                numSarnakhFee.Enabled = true;
                numAmountSarnakh.Enabled = true;

                this.numAmountSarnakh.Value = prop_SarnakhAmount;
                this.txtSarnakhCost.Text = prop_SarnakhCost.ToString();
                this.txtSarnakhCost.BackColor = System.Drawing.Color.SeaShell;
            }
            if (numCharmFee.Value != 0)
            {
                chBoxCharm.Checked = true;
                numCharmFee.Enabled = true;
                numAmountCharm.Enabled = true;

                this.numAmountCharm.Value = prop_CharmAmount;
                this.txtCharmCost.Text = prop_CharmCost.ToString();
                this.txtCharmCost.BackColor = System.Drawing.Color.SeaShell;
            }
            //End of //*********Set Carpet Services************ 

            txtCarpetLable.Select(); 
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
            if (e.KeyData == Keys.Enter)
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
                    btnAdd_Close.Focus();
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

                btnAdd_Close.Focus();
            }
        }

        private void txtWidth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
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
                    numAmountDogere.Value = (decimal)(2 * w);
                    int y = (int)(numAmountDogere.Value * numDogereFee.Value);
                    txtDogereCost.Text = y.ToString();
                }

                if (chBoxShiraze.Checked)
                {
                    numAmountShiraze.Value = (decimal)(2 * l);
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
                    numAmountCharm.Value = (decimal)(2 * l);
                    int y = (int)(numAmountCharm.Value * numCharmFee.Value);
                    txtCharmCost.Text = y.ToString();
                }

                //dateTimePicker_enterDate.Select();
                faDatePicker_EnterDate.Select();
            }
        }

        private void txtCarpetLable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
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

        private void chBoxShuor_CheckedChanged(object sender, EventArgs e)
        {
            
                if (chBoxShuor.Checked)
                {
                    numAmountShur.Enabled = true;
                    numShurFee.Enabled = true;
                    txtShurCost.Enabled = true;

                    HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj
                        = new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

                    dt_Services = new DataTable();
                    dt_Services = obj.Service_Select_ByServiceSerial((int)(ServicesEnum.shour));

                    this.shourIndex = System.Convert.ToInt16(dt_Services.Rows[0]["ServiceSerial"]);
                    this.temp = System.Convert.ToInt64(dt_Services.Rows[0]["Fee"]);
                    numShurFee.Value = System.Convert.ToDecimal(this.temp);

                    Int32.TryParse(txtLength.Text, out this.length);
                    Int32.TryParse(txtWidth.Text, out this.width);
                    double x = this.area / 10000.0;
                    numAmountShur.Value = (decimal)(x);
                    this.shourCost = (int)(numAmountShur.Value * numShurFee.Value);
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
                dt_Services = obj.Service_Select_ByServiceSerial((int)(ServicesEnum.darkeshi));

                this.darkeshiIndex = System.Convert.ToInt16(dt_Services.Rows[0]["ServiceSerial"]);
                this.temp = System.Convert.ToInt64(dt_Services.Rows[0]["Fee"]);
                numDarkeshiFee.Value = System.Convert.ToDecimal(this.temp);

                Int32.TryParse(txtLength.Text, out this.length);
                Int32.TryParse(txtWidth.Text, out this.width);
                double x = this.area / 10000.0;
                numAmountDarkeshi.Value = (decimal)(x);
                this.darkeshiCost = (int)(numAmountDarkeshi.Value * numDarkeshiFee.Value);
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
                dt_Services = obj.Service_Select_ByServiceSerial((int)(ServicesEnum.pardakht));

                this.pardakhtIndex = System.Convert.ToInt16(dt_Services.Rows[0]["ServiceSerial"]);
                this.temp = System.Convert.ToInt64(dt_Services.Rows[0]["Fee"]);
                numPardakhtFee.Value = System.Convert.ToDecimal(this.temp);

                Int32.TryParse(txtLength.Text, out this.length);
                Int32.TryParse(txtWidth.Text, out this.width);
                double x = this.area / 10000.0;
                numAmountPardakht.Value = (decimal)(x);
                this.pardakhtCost = (int)(numAmountPardakht.Value * numPardakhtFee.Value);
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
                dt_Services = obj.Service_Select_ByServiceSerial((int)(ServicesEnum.rang));

                this.rangIndex = System.Convert.ToInt16(dt_Services.Rows[0]["ServiceSerial"]);
                this.temp = System.Convert.ToInt64(dt_Services.Rows[0]["Fee"]);
                numRangFee.Value = System.Convert.ToDecimal(this.temp);

                numAmountRang.Value = 1;
                this.rangCost = (int)(numRangFee.Value);
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
                dt_Services = obj.Service_Select_ByServiceSerial((int)(ServicesEnum.dogere));

                this.dogereIndex = System.Convert.ToInt16(dt_Services.Rows[0]["ServiceSerial"]);
                this.temp = System.Convert.ToInt64(dt_Services.Rows[0]["Fee"]);
                numDogereFee.Value = System.Convert.ToDecimal(this.temp);

                Int32.TryParse(txtWidth.Text, out this.width);
                double x = this.width / 100.0;
                numAmountDogere.Value = (decimal)(2 * x);
                this.dogereCost = (int)(numAmountDogere.Value * numDogereFee.Value);
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
                dt_Services = obj.Service_Select_ByServiceSerial((int)(ServicesEnum.shiraze));

                this.shirazeIndex = System.Convert.ToInt16(dt_Services.Rows[0]["ServiceSerial"]);
                this.temp = System.Convert.ToInt64(dt_Services.Rows[0]["Fee"]);
                numShirazeFee.Value = System.Convert.ToDecimal(this.temp);

                Int32.TryParse(txtLength.Text, out this.length);
                double x = this.length / 100.0;
                numAmountShiraze.Value = (decimal)(x * 2);
                this.shirazeCost = (int)(numAmountShiraze.Value * numShirazeFee.Value);
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
                dt_Services = obj.Service_Select_ByServiceSerial((int)(ServicesEnum.sarnakh));

                this.sarnakhIndex = System.Convert.ToInt16(dt_Services.Rows[0]["ServiceSerial"]);
                this.temp = System.Convert.ToInt64(dt_Services.Rows[0]["Fee"]);
                numSarnakhFee.Value = System.Convert.ToDecimal(this.temp);

                Int32.TryParse(txtLength.Text, out this.length);
                Int32.TryParse(txtWidth.Text, out this.width);
                double x = this.area / 10000.0;
                numAmountSarnakh.Value = (decimal)(x);
                this.sarnakhCost = (int)(numAmountSarnakh.Value * numSarnakhFee.Value);
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
                dt_Services = obj.Service_Select_ByServiceSerial((int)(ServicesEnum.charm));

                this.charmIndex = System.Convert.ToInt16(dt_Services.Rows[0]["ServiceSerial"]);
                this.temp = System.Convert.ToInt64(dt_Services.Rows[0]["Fee"]);
                numCharmFee.Value = System.Convert.ToDecimal(this.temp);

                Int32.TryParse(txtLength.Text, out this.length);
                double x = this.length / 100.0;
                numAmountCharm.Value = (decimal)(x * 2);
                this.charmCost = (int)(numAmountCharm.Value * numCharmFee.Value);
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
                dt_Services = obj.Service_Select_ByServiceSerial((int)(ServicesEnum.rofou));

                this.rofuIndex = System.Convert.ToInt16(dt_Services.Rows[0]["ServiceSerial"]);
                this.temp = System.Convert.ToInt64(dt_Services.Rows[0]["Fee"]);
                numRofuFee.Value = System.Convert.ToDecimal(this.temp);

                numAmountRofu.Value = 1;
                this.rofuCost = (int)(numRofuFee.Value);
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

        private void btnAdd_Close_Click(object sender, EventArgs e)
        {
            Microgod.AmrComponent.AmrAssistanteForms.frmWaiting.ShowWaiting();
            //********************* Inser carpet _____ Set parameters of sp_Insert Carpet

            this.carpetLable = txtCarpetLable.Text;
            Int32.TryParse(txtLength.Text, out this.length);
            Int32.TryParse(txtWidth.Text, out this.width);
            decimal x = (decimal)((this.length * this.width)/10000.0) ;
            //float y = (float)x;
            this.madeInfrom = txtPlace.Text;
            this.size = txtSize.Text;
            this.enterDate = faDatePicker_EnterDate.SelectedDateTime;
            this.returnDate = faDatePicker_returnDate.SelectedDateTime;

            HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer obj = 
                new HomeCustomerVersionOfTehranRey.Classes.clsAnbarManagment_DataAccessLAyer();

            obj.UpdateCarpet(this.carpetCode, this.carpetLable, this.madeInfrom, this.size,
                this.length, this.width, this.enterDate, this.returnDate);
            obj.CarpetServices_Delete(this.carpetCode);

            if (chBoxShuor.Checked)
            {
                this.shourFee = (int)(numShurFee.Value);
                this.shourAmount = (decimal)(numAmountShur.Value);

                obj.CarpetServicesInsert(this.carpetCode,
                    this.shourIndex, this.shourAmount, this.shourFee);
            }
            if (chBoxDarkeshi.Checked)
            {
                this.darkeshiFee = (int)(numDarkeshiFee.Value);
                this.darkeshiAmount = (decimal)(numAmountDarkeshi.Value);

                obj.CarpetServicesInsert(this.carpetCode,
                    this.darkeshiIndex, this.darkeshiAmount, this.darkeshiFee);
            }
            if (chBoxPardakht.Checked)
            {
                this.pardakhtFee = (int)(numPardakhtFee.Value);
                this.pardakhtAmount = (decimal)(numAmountPardakht.Value);

                obj.CarpetServicesInsert(this.carpetCode,
                    this.pardakhtIndex, this.pardakhtAmount, this.pardakhtFee);
            }
            if (chBoxRang.Checked)
            {
                this.rangFee = (int)(numRangFee.Value);
                this.rangAmount = (int)(numAmountRang.Value);

                obj.CarpetServicesInsert(this.carpetCode,
                    this.rangIndex, this.rangAmount, this.rangFee);
            }
            if (chBoxRofu.Checked)
            {
                this.rofuFee = (int)(numRofuFee.Value);
                this.rofuAmount = (int)(numAmountRofu.Value);

                obj.CarpetServicesInsert(this.carpetCode,
                    this.rofuIndex, this.rofuAmount, this.rofuFee);
            }
            if (chBoxDogere.Checked)
            {
                this.dogereFee = (int)(numDogereFee.Value);
                this.dogereAmount = (decimal)(numAmountDogere.Value);

                obj.CarpetServicesInsert(this.carpetCode,
                    this.dogereIndex, this.dogereAmount, this.dogereFee);
            }
            if (chBoxRofu.Checked)
            {
                this.shirazeFee = (int)(numShirazeFee.Value);
                this.shirazeAmount = (decimal)(numAmountShiraze.Value);

                obj.CarpetServicesInsert(this.carpetCode,
                    this.shirazeIndex, this.shirazeAmount, this.shirazeFee);
            }
            if (chBoxSarnakh.Checked)
            {
                this.sarnakhFee = (int)(numSarnakhFee.Value);
                this.sarnakhAmount = (decimal)(numAmountSarnakh.Value);

                obj.CarpetServicesInsert(this.carpetCode,
                    this.sarnakhIndex, this.sarnakhAmount, this.sarnakhFee);
            }
            if (chBoxCharm.Checked)
            {
                this.charmFee = (int)(numCharmFee.Value);
                this.charmAmount = (decimal)(numAmountCharm.Value);

                obj.CarpetServicesInsert(this.carpetCode,
                    this.charmIndex, this.charmAmount, this.charmFee);
            }

            //********************* End of Inser Services _____ Set parameters of sp_InsertCarpetServices
            Microgod.AmrComponent.AmrAssistanteForms.frmWaiting.CloseWaiting();

            Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("اطلاعات به روز شد!");
            this.Close();

           
        }

        private void frmEditCarpet_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.prop_getDataTable = this.dt_Carpets;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnServicesSetting_Click(object sender, EventArgs e)
        {
            frmServicesSetting obj = new frmServicesSetting();
            obj.ShowDialog();
        }
       
    }
}