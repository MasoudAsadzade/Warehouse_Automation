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
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Tehranrey;Integrated Security=True";
        SqlDataAdapter da_Customer;
        SqlDataAdapter da_Carpet;
        SqlDataAdapter da_Services;
        DataSet ds_Customer;
        DataSet ds_Carpet;
        DataSet ds_Services;

        private int customerID;
        long temp;
        long carpetCode;
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
            shour = 1, pardakht, darkeshi, rang, dogere, shiraze, sarnakh, charm, rofou
        }

        public frmEditCarpet()
        {
            InitializeComponent();
        }

        private DataSet mydetaset;

        public DataSet prop_getDataset
        {
            get { return mydetaset; }
            set { mydetaset = value; }
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

        private void frmEditCarpet_Load(object sender, EventArgs e)
        {
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

            txtCarpetLable.Text = prop_SetCarpetLable;
            txtWidth.Text = prop_SetWidth.ToString();
            txtLength.Text = prop_SetLength.ToString();
            cmbPlace.Text = prop_SetMadeInFrom;
            cmbSize.Text = prop_SetSize;
            faDatePicker_EnterDate.SelectedDateTime = prop_SetEnterDate;
            faDatePicker_returnDate.SelectedDateTime = prop_SetReturnDate;

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

        private void chBoxShuor_CheckedChanged(object sender, EventArgs e)
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
                double x = this.area / 10000.0;
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
                numAmountDogere.Value = (decimal)(2 * x);
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
                numAmountShiraze.Value = (decimal)(x * 2);
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

        private void btnAdd_Close_Click(object sender, EventArgs e)
        {
            Microgod.AmrComponent.AmrAssistanteForms.frmWaiting.ShowWaiting();
            //********************* Inser carpet _____ Set parameters of sp_Insert Carpet

            this.carpetLable = txtCarpetLable.Text;
            Int32.TryParse(txtLength.Text, out this.length);
            Int32.TryParse(txtWidth.Text, out this.width);
            decimal x = (decimal)((this.length * this.width)/10000.0) ;
            //float y = (float)x;
            this.madeInfrom = cmbPlace.Text;
            this.size = cmbSize.Text;
            this.enterDate = faDatePicker_EnterDate.SelectedDateTime;
            this.returnDate = faDatePicker_returnDate.SelectedDateTime;

            HomeCustomerVersionOfTehranRey.Classes.clsHomeCustomerDB obj = 
                new HomeCustomerVersionOfTehranRey.Classes.clsHomeCustomerDB();
            obj.UpdateCarpet(this.carpetCode, this.carpetLable, this.madeInfrom, this.size,
                this.length, this.width, this.enterDate, this.returnDate);
                
            da_Services = new SqlDataAdapter("DELETE FROM CarpetServices WHERE carpetCode = '" +
                this.carpetCode + "'", connectionString);
            ds_Services = new DataSet();
            da_Services.Fill(ds_Services, "CarpetServices");

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

            Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show(".ÇØáÇÚÇÊ ÇÕáÇÍ ÔÏ");
            this.Close();

           
        }

        private void frmEditCarpet_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.prop_getDataset = ds_Carpet;
        }

       
    }
}