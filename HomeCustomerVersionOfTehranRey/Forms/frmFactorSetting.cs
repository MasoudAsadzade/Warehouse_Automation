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
    public partial class frmFactorSetting : Form
    {
        string connectionstring = @"Data Source=.\SQLEXPRESS;Initial Catalog=Tehranrey;Integrated Security=True";
        DataSet ds_Customer;
        SqlDataAdapter da_Customer;
        DataSet ds_Carpet;
        SqlDataAdapter da_Carpet;
        DataSet ds_CarpetServices;
        SqlDataAdapter da_CarpetServices;
        DataSet ds_Factors;
        SqlDataAdapter da_Factors;

        Decimal totalArea;
        long totalValue = 0;
        long totalShour = 0;
        long totalPardakht = 0;
        long totalDarkeshi = 0;
        long totalRofu = 0;
        long totalRang = 0;
        long totalCharm = 0;
        long totalDogere = 0;
        long totalShiraze = 0;
        long totalSarnakh = 0;

        DateTime today = System.DateTime.Today.Date;
        List<bool> columns;

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
        decimal rangAmount;
        decimal rofuAmount;
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

        string CustomerName;
        string PhoneNumber;
        string Address;
        long FactorID;
        DateTime FactorDate;

        private long CustomerID;

        public long prop_GetCustomerID
        {
            get { return CustomerID; }
            set { CustomerID = value; }
        }


        DataTable join_CarpetList_DataTable = new DataTable();
        DataSet join_CarpetList_DataSet = new DataSet();
        DataTable join_FactorList_DataTable = new DataTable();
        DataSet join_FactorList_DataSet = new DataSet();
        DataTable CustomerInformation_DataTable = new DataTable();
        DataSet CustomerInformation_DataSet = new DataSet();

        private bool isNew = true;

        enum ServicesEnum
        {
            shour = 1, pardakht, darkeshi, rang, dogere, shiraze, sarnakh, charm, rofou
        }

        public frmFactorSetting()
        {
            InitializeComponent();
        }

        private void ShowFactorsOfCustomer(DataSet ds, DataGridView dgw)
        {
            da_Factors = new SqlDataAdapter("SELECT [FactorID],[TotalValue],[Datetime] FROM [tblFactor]" +
                "WHERE CustomerID = '" + this.CustomerID.ToString() + "'", connectionstring);
            da_Factors.Fill(ds, "tblFactor");
            dgw.DataSource = ds_Factors;
            dgw.DataMember = "tblFactor";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DateTime ent = (DateTime)(ds.Tables[0].Rows[i][2]);
                ds.Tables[0].Rows[i][2] =
                    (DateTime)(FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(ent));
            }


            dgw.Columns[0].HeaderText = "شماره فاکتور";
            dgw.Columns[0].Width = 90;
            dgw.Columns[0].ReadOnly = true;
            dgw.Columns[0].DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;

            dgw.Columns[1].HeaderText = "مبغ فاکتور";
            dgw.Columns[1].Width = 90;
            dgw.Columns[1].ReadOnly = true;
            dgw.Columns[1].DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;

            dgw.Columns[2].Visible = false;

            FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn c =
                    new FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn();

            c.Name = "c";
            c.DataPropertyName = "Datetime";
            c.HeaderText = "تاریخ صدور";
            c.Width = 150;
            c.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            c.SelectedDateTime = new System.DateTime(((long)(0)));
            c.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            c.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2000;
            c.VerticalAlignment = System.Drawing.StringAlignment.Near;
            c.DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;

            dgw.Columns.Add(c);

        }

        private void SetDataGridViewForCarpets(DataGridView dgw, DataSet ds)
        {
           dgw.Refresh();
           dgw.DataSource = ds;
           dgw.DataMember = ds.Tables[0].TableName;

           if (ds.Tables.Count != 0)
           {
               dgw.Columns[0].HeaderText = "تایید";
               dgw.Columns[0].Width = 40;
               dgw.Columns[0].ReadOnly = false;
               dgw.Columns[0].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[1].Visible = false;

               dgw.Columns[2].HeaderText = "شماره";
               dgw.Columns[2].Width = 60;
               dgw.Columns[2].ReadOnly = true;
               dgw.Columns[2].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[3].HeaderText = "محل بافت";
               dgw.Columns[3].Width = 70;
               dgw.Columns[3].ReadOnly = true;
               dgw.Columns[3].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[4].HeaderText = "سایز";
               dgw.Columns[4].Width = 50;
               dgw.Columns[4].ReadOnly = true;
               dgw.Columns[4].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[5].HeaderText = "طول";
               dgw.Columns[5].Width = 39;
               dgw.Columns[5].ReadOnly = true;
               dgw.Columns[5].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[6].HeaderText = "عرض";
               dgw.Columns[6].Width = 39;
               dgw.Columns[6].ReadOnly = true;
               dgw.Columns[6].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[7].HeaderText = "مساحت";
               dgw.Columns[7].Width = 50;
               dgw.Columns[7].ReadOnly = true;
               dgw.Columns[7].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[8].HeaderText = "فی";
               dgw.Columns[8].Width = 37;
               dgw.Columns[8].ReadOnly = true;
               dgw.Columns[8].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[9].HeaderText = "شور";
               dgw.Columns[9].Width = 47;
               dgw.Columns[9].ReadOnly = true;
               dgw.Columns[9].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[10].HeaderText = "فی";
               dgw.Columns[10].Width = 47;
               dgw.Columns[10].ReadOnly = true;
               dgw.Columns[10].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[11].HeaderText = "پرداخت";
               dgw.Columns[11].Width = 47;
               dgw.Columns[11].ReadOnly = true;
               dgw.Columns[11].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[12].HeaderText = "فی";
               dgw.Columns[12].Width = 47;
               dgw.Columns[12].ReadOnly = true;
               dgw.Columns[12].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[13].HeaderText = "دارکشی";
               dgw.Columns[13].Width = 47;
               dgw.Columns[13].ReadOnly = true;
               dgw.Columns[13].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[14].HeaderText = "فی";
               dgw.Columns[14].Width = 50;
               dgw.Columns[14].ReadOnly = true;
               dgw.Columns[14].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[15].HeaderText = "رنگبرداری";
               dgw.Columns[15].Width = 47;
               dgw.Columns[15].ReadOnly = true;
               dgw.Columns[15].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[16].HeaderText = "فی";
               dgw.Columns[16].Width = 35;
               dgw.Columns[16].ReadOnly = true;
               dgw.Columns[16].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[17].HeaderText = "رفو";
               dgw.Columns[17].Width = 47;
               dgw.Columns[17].ReadOnly = true;
               dgw.Columns[17].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[18].HeaderText = "فی";
               dgw.Columns[18].Width = 40;
               dgw.Columns[18].ReadOnly = true;
               dgw.Columns[18].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[19].HeaderText = "دوگره";
               dgw.Columns[19].Width = 47;
               dgw.Columns[19].ReadOnly = true;
               dgw.Columns[19].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[20].HeaderText = "فی";
               dgw.Columns[20].Width = 40;
               dgw.Columns[20].ReadOnly = true;
               dgw.Columns[20].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[21].HeaderText = "شیرازه";
               dgw.Columns[21].Width = 47;
               dgw.Columns[21].ReadOnly = true;
               dgw.Columns[21].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[22].HeaderText = "فی";
               dgw.Columns[22].Width = 36;
               dgw.Columns[22].ReadOnly = true;
               dgw.Columns[22].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[23].HeaderText = "سرنخ";
               dgw.Columns[23].Width = 47;
               dgw.Columns[23].ReadOnly = true;
               dgw.Columns[23].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[24].HeaderText = "فی";
               dgw.Columns[24].Width = 35;
               dgw.Columns[24].ReadOnly = true;
               dgw.Columns[24].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[25].HeaderText = "چرم";
               dgw.Columns[25].Width = 47;
               dgw.Columns[25].ReadOnly = true;
               dgw.Columns[25].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[26].HeaderText = "مجموع";
               dgw.Columns[26].Width = 55;
               dgw.Columns[26].ReadOnly = true;
               dgw.Columns[26].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

               dgw.Columns[27].HeaderText = "توضیحات";
               dgw.Columns[27].Width = 100;
               dgw.Columns[27].ReadOnly = true;
               dgw.Columns[27].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

           }   
        }

        

        /// <summary>
        ///this method set the dataset include the active caprpets of special customer
        /// to be datasource of datagridview ...
        /// <param name="ds"></param>
        /// <returns></returns>
        private DataSet ShowLastCarpetOfSpecialCustomer(DataSet ds)
        {
            //****************************** Fill Carpets Of Customer in joinTable ************
            join_CarpetList_DataTable.TableName = "jointbl";
            SqlConnection cn = new SqlConnection(connectionstring);
            cn.Open();

            SqlCommand command = new SqlCommand("SELECT CarpetCode FROM CustomerCarpet WHERE CustomerID= '"
                + this.prop_GetCustomerID.ToString() + "' ORDER BY carpetCode ", cn);
            command.CommandType = CommandType.Text;
            SqlDataReader obj = command.ExecuteReader();

            if (obj.HasRows)
            {
                while (obj.Read())
                {
                    long codeTemp = obj.GetInt64(0);

                    da_Carpet = new SqlDataAdapter("SELECT carpetCode, carpetLable," +
                        " madeInFrom, carpetSize, length, width, Area FROM Carpet WHERE CarpetCode= '"
                        + codeTemp.ToString() + "' AND IsActive= '1' AND IsFactored= '0'"
                        , connectionstring);
                    da_Carpet.Fill(ds, "jointbl");

                }
                obj.Close();
                //******************************End Of Fill Carpets Of Customer in joinTable ************

                //****************************** Add other Columns to the joinTable ************
                DataColumn dc = new DataColumn("IsFactore", Type.GetType("System.Boolean"));
                ds.Tables[0].Columns.Add(dc);
                ds.Tables[0].Columns["IsFactore"].SetOrdinal(0);
                ds.Tables[0].Columns["IsFactore"].DefaultValue = true;
                //ds.Tables[0].Columns["IsFactore"].AllowDBNull = false;

                string[] columnsName = {"ShourFee", "ShourCost", "PardakhtFee", "PardakhCost", "DarkeshiFee", "DarkeshiCost",
                "RangFee", "RangCost", "RofuFee", "RofuCost", "DogereFee", "DogereCost", "ShirazeFee", "ShirazeCost",
                "SarnakhFee", "SarnakhCost", "CharmFee", "CharmCost"};
                for (int i = 0; i < 17; i += 2)
                {
                    DataColumn cl1 = new DataColumn();
                    DataColumn cl2 = new DataColumn();

                    cl1.DataType = System.Type.GetType("System.Int64");
                    cl1.ColumnName = columnsName[i];
                    cl2.DataType = System.Type.GetType("System.Int64");
                    cl2.ColumnName = columnsName[i + 1];
                    ds.Tables[0].Columns.Add(cl1);
                    ds.Tables[0].Columns.Add(cl2);
                }

                DataColumn dc1 = new DataColumn("TotalCost");
                dc1.DataType = System.Type.GetType("System.Int64");
                ds.Tables[0].Columns.Add(dc1);

                DataColumn dc2 = new DataColumn("Discribtion");
                dc2.DataType = System.Type.GetType("System.String");
                ds.Tables[0].Columns.Add(dc2);
                //****************************** End Of Add other Columns to the joinTable ************

                //****************************** Enter Data in joinTable *********************
                ds_CarpetServices = new DataSet();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    this.shourCost = 0;
                    this.darkeshiCost = 0;
                    this.pardakhtCost = 0;
                    this.rangCost = 0;
                    this.rofuCost = 0;
                    this.dogereCost = 0;
                    this.shirazeCost = 0;
                    this.sarnakhCost = 0;
                    this.charmCost = 0;

                    // خسته شدم از دست این DBNULL **************************
                    ds.Tables[0].Rows[i][0] = false;
                    long Ccode = (long)(ds.Tables[0].Rows[i][1]);
                    ds_CarpetServices.Clear();
                    da_CarpetServices = new SqlDataAdapter("SELECT * FROM CarpetServices" +
                        " WHERE CarpetCode = '" + Ccode.ToString() + "'", connectionstring);
                    da_CarpetServices.Fill(ds_CarpetServices, "CarpetServices");

                    for (int j = 0; j < ds_CarpetServices.Tables[0].Rows.Count; j++)
                    {

                        int Sserial = (int)(ds_CarpetServices.Tables[0].Rows[j][1]);

                        if (Sserial == (int)(ServicesEnum.shour))
                        {
                            this.shourAmount = (decimal)(ds_CarpetServices.Tables[0].Rows[j][2]);
                            this.shourFee = (long)(ds_CarpetServices.Tables[0].Rows[j][3]);
                            this.shourCost = (long)(this.shourAmount * this.shourFee);
                            ds.Tables[0].Rows[i]["ShourFee"] = this.shourFee;
                            ds.Tables[0].Rows[i]["ShourCost"] = this.shourCost;
                        }
                        if (Sserial == (int)(ServicesEnum.pardakht))
                        {
                            this.pardakhtAmount = (decimal)(ds_CarpetServices.Tables[0].Rows[j][2]);
                            this.pardakhtFee = (long)(ds_CarpetServices.Tables[0].Rows[j][3]);
                            this.pardakhtCost = (long)(this.pardakhtAmount * this.pardakhtFee);
                            ds.Tables[0].Rows[i]["PardakhtFee"] = this.pardakhtFee;
                            ds.Tables[0].Rows[i]["PardakhCost"] = this.pardakhtCost;
                        }
                        if (Sserial == (int)(ServicesEnum.darkeshi))
                        {
                            this.darkeshiAmount = (decimal)(ds_CarpetServices.Tables[0].Rows[j][2]);
                            this.darkeshiFee = (long)(ds_CarpetServices.Tables[0].Rows[j][3]);
                            this.darkeshiCost = (long)(this.darkeshiAmount * this.darkeshiFee);
                            ds.Tables[0].Rows[i]["DarkeshiFee"] = this.darkeshiFee;
                            ds.Tables[0].Rows[i]["DarkeshiCost"] = this.darkeshiCost;
                        }
                        if (Sserial == (int)(ServicesEnum.rang))
                        {
                            this.rangAmount = (decimal)(ds_CarpetServices.Tables[0].Rows[j][2]);
                            this.rangFee = (long)(ds_CarpetServices.Tables[0].Rows[j][3]);
                            this.rangCost = (long)(this.rangAmount * this.rangFee);
                            ds.Tables[0].Rows[i]["RangFee"] = this.rangFee;
                            ds.Tables[0].Rows[i]["RangCost"] = this.rangCost;
                        }
                        if (Sserial == (int)(ServicesEnum.rofou))
                        {
                            this.rofuAmount = (decimal)(ds_CarpetServices.Tables[0].Rows[j][2]);
                            this.rofuFee = (long)(ds_CarpetServices.Tables[0].Rows[j][3]);
                            this.rofuCost = (long)(this.rofuAmount * this.rofuFee);
                            ds.Tables[0].Rows[i]["RofuFee"] = this.rofuFee;
                            ds.Tables[0].Rows[i]["RofuCost"] = this.rofuCost;
                        }
                        if (Sserial == (int)(ServicesEnum.dogere))
                        {
                            this.dogereAmount = (decimal)(ds_CarpetServices.Tables[0].Rows[j][2]);
                            this.dogereFee = (long)(ds_CarpetServices.Tables[0].Rows[j][3]);
                            this.dogereCost = (long)(this.dogereAmount * this.dogereFee);
                            ds.Tables[0].Rows[i]["DogereFee"] = this.dogereFee;
                            ds.Tables[0].Rows[i]["DogereCost"] = this.dogereCost;
                        }
                        if (Sserial == (int)(ServicesEnum.shiraze))
                        {
                            this.shirazeAmount = (decimal)(ds_CarpetServices.Tables[0].Rows[j][2]);
                            this.shirazeFee = (long)(ds_CarpetServices.Tables[0].Rows[j][3]);
                            this.shirazeCost = (long)(this.shirazeAmount * this.shirazeFee);
                            ds.Tables[0].Rows[i]["ShirazeFee"] = this.shirazeFee;
                            ds.Tables[0].Rows[i]["ShirazeCost"] = this.shirazeCost;
                        }
                        if (Sserial == (int)(ServicesEnum.sarnakh))
                        {
                            this.sarnakhAmount = (decimal)(ds_CarpetServices.Tables[0].Rows[j][2]);
                            this.sarnakhFee = (long)(ds_CarpetServices.Tables[0].Rows[j][3]);
                            this.sarnakhCost = (long)(this.sarnakhAmount * this.sarnakhFee);
                            ds.Tables[0].Rows[i]["SarnakhFee"] = this.sarnakhFee;
                            ds.Tables[0].Rows[i]["SarnakhCost"] = this.sarnakhCost;
                        }
                        if (Sserial == (int)(ServicesEnum.charm))
                        {
                            this.charmAmount = (decimal)(ds_CarpetServices.Tables[0].Rows[j][2]);
                            this.charmFee = (long)(ds_CarpetServices.Tables[0].Rows[j][3]);
                            this.charmCost = (long)(this.charmAmount * this.charmFee);
                            ds.Tables[0].Rows[i]["CharmFee"] = this.charmFee;
                            ds.Tables[0].Rows[i]["CharmCost"] = this.charmCost;
                        }

                        long sum = this.shourCost +
                            this.darkeshiCost +
                            this.pardakhtCost +
                            this.rangCost +
                            this.rofuCost +
                            this.dogereCost +
                            this.shirazeCost +
                            this.sarnakhCost +
                            this.charmCost;
                        ds.Tables[0].Rows[i]["TotalCost"] = sum;

                    }
                }
                //******************************End OF Enter Data in joinTable *********************
            }

            return ds;
        }

        private DataSet ShowCarpetOfSpecialFactor(DataSet ds, long factorIndex)
        {
            //****************************** Fill Carpets Of Customer in joinTable ************
            ds.Reset();
            ds.Tables.Add("jointbl");
            SqlConnection cn = new SqlConnection(connectionstring);
            cn.Open();

            SqlCommand command = new SqlCommand("SELECT CarpetCode FROM tblFactorCarpet WHERE FactorID= '"
                + factorIndex.ToString() + "' ORDER BY CarpetCode ", cn);
            command.CommandType = CommandType.Text;
            SqlDataReader obj = command.ExecuteReader();

            if (obj.HasRows)
            {
                while (obj.Read())
                {
                    long codeTemp = obj.GetInt64(0);

                    da_Carpet = new SqlDataAdapter("SELECT carpetCode, carpetLable," +
                        " madeInFrom, carpetSize, length, width, Area FROM Carpet WHERE CarpetCode= '"
                        + codeTemp.ToString() + "' AND IsActive= '1' AND IsFactored= '1'"
                        , connectionstring);
                    da_Carpet.Fill(ds, "jointbl");

                }
                obj.Close();
                //******************************End Of Fill Carpets Of Customer in joinTable ************

                //****************************** Add other Columns to the joinTable ************
                DataColumn dc = new DataColumn("IsFactore", Type.GetType("System.Boolean"));
                ds.Tables[0].Columns.Add(dc);
                ds.Tables[0].Columns["IsFactore"].SetOrdinal(0);
                ds.Tables[0].Columns["IsFactore"].DefaultValue = true;
                //ds.Tables[0].Columns["IsFactore"].AllowDBNull = false;

                string[] columnsName = {"ShourFee", "ShourCost", "PardakhtFee", "PardakhCost", "DarkeshiFee", "DarkeshiCost",
                "RangFee", "RangCost", "RofuFee", "RofuCost", "DogereFee", "DogereCost", "ShirazeFee", "ShirazeCost",
                "SarnakhFee", "SarnakhCost", "CharmFee", "CharmCost"};
                for (int i = 0; i < 17; i += 2)
                {
                    DataColumn cl1 = new DataColumn();
                    DataColumn cl2 = new DataColumn();

                    cl1.DataType = System.Type.GetType("System.Int64");
                    cl1.ColumnName = columnsName[i];
                    cl2.DataType = System.Type.GetType("System.Int64");
                    cl2.ColumnName = columnsName[i + 1];
                    ds.Tables[0].Columns.Add(cl1);
                    ds.Tables[0].Columns.Add(cl2);
                }

                DataColumn dc1 = new DataColumn("TotalCost");
                dc1.DataType = System.Type.GetType("System.Int64");
                ds.Tables[0].Columns.Add(dc1);

                DataColumn dc2 = new DataColumn("Discribtion");
                dc2.DataType = System.Type.GetType("System.String");
                ds.Tables[0].Columns.Add(dc2);
                //****************************** End Of Add other Columns to the joinTable ************

                //****************************** Enter Data in joinTable *********************
                ds_CarpetServices = new DataSet();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    this.shourCost = 0;
                    this.darkeshiCost = 0;
                    this.pardakhtCost = 0;
                    this.rangCost = 0;
                    this.rofuCost = 0;
                    this.dogereCost = 0;
                    this.shirazeCost = 0;
                    this.sarnakhCost = 0;
                    this.charmCost = 0;

                    // خسته شدم از دست این DBNULL **************************
                    ds.Tables[0].Rows[i][0] = false;
                    long Ccode = (long)(ds.Tables[0].Rows[i][1]);
                    ds_CarpetServices.Clear();
                    da_CarpetServices = new SqlDataAdapter("SELECT * FROM CarpetServices" +
                        " WHERE CarpetCode = '" + Ccode.ToString() + "'", connectionstring);
                    da_CarpetServices.Fill(ds_CarpetServices, "CarpetServices");

                    for (int j = 0; j < ds_CarpetServices.Tables[0].Rows.Count; j++)
                    {

                        int Sserial = (int)(ds_CarpetServices.Tables[0].Rows[j][1]);

                        if (Sserial == (int)(ServicesEnum.shour))
                        {
                            this.shourAmount = (decimal)(ds_CarpetServices.Tables[0].Rows[j][2]);
                            this.shourFee = (long)(ds_CarpetServices.Tables[0].Rows[j][3]);
                            this.shourCost = (long)(this.shourAmount * this.shourFee);
                            ds.Tables[0].Rows[i]["ShourFee"] = this.shourFee;
                            ds.Tables[0].Rows[i]["ShourCost"] = this.shourCost;
                        }
                        if (Sserial == (int)(ServicesEnum.pardakht))
                        {
                            this.pardakhtAmount = (decimal)(ds_CarpetServices.Tables[0].Rows[j][2]);
                            this.pardakhtFee = (long)(ds_CarpetServices.Tables[0].Rows[j][3]);
                            this.pardakhtCost = (long)(this.pardakhtAmount * this.pardakhtFee);
                            ds.Tables[0].Rows[i]["PardakhtFee"] = this.pardakhtFee;
                            ds.Tables[0].Rows[i]["PardakhCost"] = this.pardakhtCost;
                        }
                        if (Sserial == (int)(ServicesEnum.darkeshi))
                        {
                            this.darkeshiAmount = (decimal)(ds_CarpetServices.Tables[0].Rows[j][2]);
                            this.darkeshiFee = (long)(ds_CarpetServices.Tables[0].Rows[j][3]);
                            this.darkeshiCost = (long)(this.darkeshiAmount * this.darkeshiFee);
                            ds.Tables[0].Rows[i]["DarkeshiFee"] = this.darkeshiFee;
                            ds.Tables[0].Rows[i]["DarkeshiCost"] = this.darkeshiCost;
                        }
                        if (Sserial == (int)(ServicesEnum.rang))
                        {
                            this.rangAmount = (decimal)(ds_CarpetServices.Tables[0].Rows[j][2]);
                            this.rangFee = (long)(ds_CarpetServices.Tables[0].Rows[j][3]);
                            this.rangCost = (long)(this.rangAmount * this.rangFee);
                            ds.Tables[0].Rows[i]["RangFee"] = this.rangFee;
                            ds.Tables[0].Rows[i]["RangCost"] = this.rangCost;
                        }
                        if (Sserial == (int)(ServicesEnum.rofou))
                        {
                            this.rofuAmount = (decimal)(ds_CarpetServices.Tables[0].Rows[j][2]);
                            this.rofuFee = (long)(ds_CarpetServices.Tables[0].Rows[j][3]);
                            this.rofuCost = (long)(this.rofuAmount * this.rofuFee);
                            ds.Tables[0].Rows[i]["RofuFee"] = this.rofuFee;
                            ds.Tables[0].Rows[i]["RofuCost"] = this.rofuCost;
                        }
                        if (Sserial == (int)(ServicesEnum.dogere))
                        {
                            this.dogereAmount = (decimal)(ds_CarpetServices.Tables[0].Rows[j][2]);
                            this.dogereFee = (long)(ds_CarpetServices.Tables[0].Rows[j][3]);
                            this.dogereCost = (long)(this.dogereAmount * this.dogereFee);
                            ds.Tables[0].Rows[i]["DogereFee"] = this.dogereFee;
                            ds.Tables[0].Rows[i]["DogereCost"] = this.dogereCost;
                        }
                        if (Sserial == (int)(ServicesEnum.shiraze))
                        {
                            this.shirazeAmount = (decimal)(ds_CarpetServices.Tables[0].Rows[j][2]);
                            this.shirazeFee = (long)(ds_CarpetServices.Tables[0].Rows[j][3]);
                            this.shirazeCost = (long)(this.shirazeAmount * this.shirazeFee);
                            ds.Tables[0].Rows[i]["ShirazeFee"] = this.shirazeFee;
                            ds.Tables[0].Rows[i]["ShirazeCost"] = this.shirazeCost;
                        }
                        if (Sserial == (int)(ServicesEnum.sarnakh))
                        {
                            this.sarnakhAmount = (decimal)(ds_CarpetServices.Tables[0].Rows[j][2]);
                            this.sarnakhFee = (long)(ds_CarpetServices.Tables[0].Rows[j][3]);
                            this.sarnakhCost = (long)(this.sarnakhAmount * this.sarnakhFee);
                            ds.Tables[0].Rows[i]["SarnakhFee"] = this.sarnakhFee;
                            ds.Tables[0].Rows[i]["SarnakhCost"] = this.sarnakhCost;
                        }
                        if (Sserial == (int)(ServicesEnum.charm))
                        {
                            this.charmAmount = (decimal)(ds_CarpetServices.Tables[0].Rows[j][2]);
                            this.charmFee = (long)(ds_CarpetServices.Tables[0].Rows[j][3]);
                            this.charmCost = (long)(this.charmAmount * this.charmFee);
                            ds.Tables[0].Rows[i]["CharmFee"] = this.charmFee;
                            ds.Tables[0].Rows[i]["CharmCost"] = this.charmCost;
                        }

                        long sum = this.shourCost +
                            this.darkeshiCost +
                            this.pardakhtCost +
                            this.rangCost +
                            this.rofuCost +
                            this.dogereCost +
                            this.shirazeCost +
                            this.sarnakhCost +
                            this.charmCost;
                        ds.Tables[0].Rows[i]["TotalCost"] = sum;

                    }
                }
                //******************************End OF Enter Data in joinTable *********************
            }

            return ds;
        }

        private void dataGridView_Factors_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void frmFactorSetting_Load(object sender, EventArgs e)
        {
            //*********************** Set Information Of Customer *******************************
            da_Customer = new SqlDataAdapter("SELECT * FROM Customer WHERE CustomerID = '"
                + prop_GetCustomerID.ToString() + "'", connectionstring);
            ds_Customer = new DataSet();
            da_Customer.Fill(ds_Customer, "Customer");

            this.CustomerID = Convert.ToInt64(ds_Customer.Tables[0].Rows[0]["CustomerID"]);
            this.CustomerName = (ds_Customer.Tables[0].Rows[0]["firstName"]).ToString() +
                " " + (ds_Customer.Tables[0].Rows[0]["lastName"]).ToString();
            this.Address = (ds_Customer.Tables[0].Rows[0]["Address"]).ToString();
            this.PhoneNumber = (ds_Customer.Tables[0].Rows[0]["phoneNumber"]).ToString();

            lblCustomerName.Text = this.CustomerName;
            lblCustomerID.Text = this.CustomerID.ToString();
            lblPhoneNum.Text = this.PhoneNumber;
            lblAddress.Text = this.Address;
            //*********************** End of Set Information Of Customer ****************************

            //*********************** Set datagridviwe with joine dataset ***************************
            this.SetDataGridViewForCarpets(dataGridView1
                , this.ShowLastCarpetOfSpecialCustomer(join_CarpetList_DataSet));
            //*********************** End Of Set datagridviwe with joine dataset ********************

            //*********************** Set the total lables in form ********************
            this.SumArea_Cost();
            //*********************** End Of Set the total lables in form ********************

            ds_Factors = new DataSet();
            this.ShowFactorsOfCustomer(ds_Factors, dataGridView_Factors);


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < join_CarpetList_DataSet.Tables[0].Rows.Count; i++)
            {
                join_CarpetList_DataSet.Tables[0].Rows[i][0] = true;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < join_CarpetList_DataSet.Tables[0].Rows.Count; i++)
            {
                join_CarpetList_DataSet.Tables[0].Rows[i][0] = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
            treeView1.Refresh();
            //************************************ Select Columns To Print *********************************
            this.columns = new List<bool>();

            for (int i = 0; i < treeView1.Nodes.Count - 1; i++)
            {
                for (int j = 0; j < treeView1.Nodes[i].Nodes.Count; j++)
                {
                    if (treeView1.Nodes[i].Nodes[j].Checked)
                    {
                        columns.Add(true);
                    }
                    else
                    {
                        columns.Add(false);
                    }
                }
            }

            for (int i = 0; i < columns.Count; i++)
            {
                if (this.isNew)
                {
                    if (!columns[i])
                    {
                        join_CarpetList_DataSet.Tables[0].Columns.RemoveAt(i + 8);
                        columns.RemoveAt(i);
                        i--;
                    }
                }
                else
                {
                    if (!columns[i])
                    {
                        join_FactorList_DataSet.Tables[0].Columns.RemoveAt(i + 8);
                        columns.RemoveAt(i);
                        i--;
                    }
                }
            }

            if (!treeView1.Nodes[treeView1.Nodes.Count - 1].Checked)
            {
                join_CarpetList_DataSet.Tables[0].Columns.RemoveAt(join_CarpetList_DataSet.Tables[0].Columns.Count-1);
            }
            btnColumnAccept.Enabled = false;
            //**************************** End Of Select Columns To Print *********************************  
        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (treeView1.Nodes[0].Checked)
            {
                treeView1.Nodes[0].Nodes[0].Checked = true;
                treeView1.Nodes[0].Nodes[1].Checked = true;
            }
            else
            {
                treeView1.Nodes[0].Nodes[0].Checked = false;
                treeView1.Nodes[0].Nodes[1].Checked = false;
            }

            if (treeView1.Nodes[1].Checked)
            {
                treeView1.Nodes[1].Nodes[0].Checked = true;
                treeView1.Nodes[1].Nodes[1].Checked = true;
            }
            else
            {
                treeView1.Nodes[1].Nodes[0].Checked = false;
                treeView1.Nodes[1].Nodes[1].Checked = false;
            }

            if (treeView1.Nodes[2].Checked)
            {
                treeView1.Nodes[2].Nodes[0].Checked = true;
                treeView1.Nodes[2].Nodes[1].Checked = true;
            }
            else
            {
                treeView1.Nodes[2].Nodes[0].Checked = false;
                treeView1.Nodes[2].Nodes[1].Checked = false;
            }
            if (treeView1.Nodes[3].Checked)
            {
                treeView1.Nodes[3].Nodes[0].Checked = true;
                treeView1.Nodes[3].Nodes[1].Checked = true;
            }
            else
            {
                treeView1.Nodes[3].Nodes[0].Checked = false;
                treeView1.Nodes[3].Nodes[1].Checked = false;
            }
            if (treeView1.Nodes[4].Checked)
            {
                treeView1.Nodes[4].Nodes[0].Checked = true;
                treeView1.Nodes[4].Nodes[1].Checked = true;
            }
            else
            {
                treeView1.Nodes[4].Nodes[0].Checked = false;
                treeView1.Nodes[4].Nodes[1].Checked = false;
            }
            if (treeView1.Nodes[5].Checked)
            {
                treeView1.Nodes[5].Nodes[0].Checked = true;
                treeView1.Nodes[5].Nodes[1].Checked = true;
            }
            else
            {
                treeView1.Nodes[5].Nodes[0].Checked = false;
                treeView1.Nodes[5].Nodes[1].Checked = false;
            }
            if (treeView1.Nodes[6].Checked)
            {
                treeView1.Nodes[6].Nodes[0].Checked = true;
                treeView1.Nodes[6].Nodes[1].Checked = true;
            }
            else
            {
                treeView1.Nodes[6].Nodes[0].Checked = false;
                treeView1.Nodes[6].Nodes[1].Checked = false;
            }
            if (treeView1.Nodes[7].Checked)
            {
                treeView1.Nodes[7].Nodes[0].Checked = true;
                treeView1.Nodes[7].Nodes[1].Checked = true;
            }
            else
            {
                treeView1.Nodes[7].Nodes[0].Checked = false;
                treeView1.Nodes[7].Nodes[1].Checked = false;
            }
            if (treeView1.Nodes[8].Checked)
            {
                treeView1.Nodes[8].Nodes[0].Checked = true;
                treeView1.Nodes[8].Nodes[1].Checked = true;
            }
            else
            {
                treeView1.Nodes[8].Nodes[0].Checked = false;
                treeView1.Nodes[8].Nodes[1].Checked = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //************************************ Select Rows To Print *********************************
            int count = 0;
            for (int i = 0; i < join_CarpetList_DataSet.Tables[0].Rows.Count; i++)
            {
                if (Convert.ToBoolean(join_CarpetList_DataSet.Tables[0].Rows[i][0]))
                {
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("!هیچ یک از فرش ها تایید نشده اند");
                return;
            }


            HomeCustomerVersionOfTehranRey.Classes.clsHomeCustomerDB obj =
                new HomeCustomerVersionOfTehranRey.Classes.clsHomeCustomerDB();

            SqlConnection cn = new SqlConnection(connectionstring);
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MAX(FactorID) FROM tblFactor";
            if (cmd.ExecuteScalar().GetType().Name == "DBNull")
            {
                this.FactorID = 0;
            }
            else
                this.FactorID = Convert.ToInt64(cmd.ExecuteScalar());

            for (int i = 0; i < join_CarpetList_DataSet.Tables[0].Rows.Count; i++)
            {
                long Code = (long)(join_CarpetList_DataSet.Tables[0].Rows[i][1]);

                if (!(bool)(join_CarpetList_DataSet.Tables[0].Rows[i][0]))
                {
                    join_CarpetList_DataSet.Tables[0].Rows[i].Delete();
                }
                else
                {
                    obj.UpdateIsFactord(Code);
                    obj.FctorCarpetInsert(Code, this.FactorID + 1);
                }
            }
            //**************************** End of Select Rows To Print *********************************
            this.SumArea_Cost();
            obj.FactorInsert(this.CustomerID, this.today.Date, this.totalValue);
            this.FactorDate = this.today.Date;

            Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("!!!فرش های انتخابی فاکتور شد. برای چاپ فاکتور دکمه چاپ را کلیک کنید");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet temp = new DataSet();

            if (this.isNew)
            {
                temp = join_CarpetList_DataSet;
            }
            else
            {
                temp = join_FactorList_DataSet;
            }

            temp.Tables[0].Columns.Remove("IsFactore");
            temp.Tables[0].Columns.Remove("CarpetCode");
            temp.WriteXml(Application.StartupPath + "\\c.xml");
            Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("!برای چاپ تایید شد");

            List<DataGridViewColumn> columnShouldSum = new List<DataGridViewColumn>();

            columnShouldSum.Add(dataGridView1.Columns[5]);
            for (int i = 1; i < columns.Count; i += 2)
            {
                //int index = columns.IndexOf(true);
                columnShouldSum.Add(dataGridView1.Columns[i + 6]);
            }
            columnShouldSum.Add(dataGridView1.Columns[dataGridView1.ColumnCount - 2]);

            cmoExcelReport1.prop_CustomerName = this.CustomerName;
            cmoExcelReport1.prop_CustomerID = this.CustomerID;
            cmoExcelReport1.prop_FactorID = this.FactorID;
            //cmoExcelReport1.prop_date = this.FactorDate.ToString();
            cmoExcelReport1.prop_date = this.today.Date;
            cmoExcelReport1.prop_Address = this.Address;
            cmoExcelReport1.prop_PhoneNumber = this.PhoneNumber;
            
            cmoExcelReport1.start2(dataGridView1, columnShouldSum);
        }

        private void SumArea_Cost()
        {
            this.totalArea = 0;
            this.totalValue = 0;
            this.totalShour = 0;
            this.totalPardakht = 0;
            this.totalDarkeshi = 0;
            this.totalSarnakh = 0;
            this.totalRofu = 0;
            this.totalCharm = 0;
            this.totalShiraze = 0;
            this.totalDogere = 0;
            this.totalRang = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1["TotalCost", i].Value == System.DBNull.Value)
                {
                    dataGridView1["TotalCost", i].Value = 0;
                }
                Int64 TotalValue = (Int64)(dataGridView1["TotalCost", i].Value);
                this.totalValue += TotalValue;

                if (dataGridView1["ShourCost", i].Value == System.DBNull.Value)
                {
                    dataGridView1["ShourCost", i].Value = 0;
                }
                Int64 ShourValue = (Int64)(dataGridView1["ShourCost", i].Value);
                this.totalShour += ShourValue;

                if (dataGridView1["PardakhCost", i].Value == System.DBNull.Value)
                {
                    dataGridView1["PardakhCost", i].Value = 0;
                }
                Int64 PardakhtValue = (Int64)(dataGridView1["PardakhCost", i].Value);
                this.totalPardakht += PardakhtValue;

                if (dataGridView1["DarkeshiCost", i].Value == System.DBNull.Value)
                {
                    dataGridView1["DarkeshiCost", i].Value = 0;
                }
                Int64 DarkeshiValue = (Int64)(dataGridView1["DarkeshiCost", i].Value);
                this.totalDarkeshi += DarkeshiValue;

                if (dataGridView1["RangCost", i].Value == System.DBNull.Value)
                {
                    dataGridView1["RangCost", i].Value = 0;
                }
                Int64 RangValue = (Int64)(dataGridView1["RangCost", i].Value);
                this.totalRang += RangValue;

                if (dataGridView1["RofuCost", i].Value == System.DBNull.Value)
                {
                    dataGridView1["RofuCost", i].Value = 0;
                }
                Int64 RofuValue = (Int64)(dataGridView1["RofuCost", i].Value);
                this.totalRofu += RofuValue;

                if (dataGridView1["DogereCost", i].Value == System.DBNull.Value)
                {
                    dataGridView1["DogereCost", i].Value = 0;
                }
                Int64 DogereValue = (Int64)(dataGridView1["DogereCost", i].Value);
                this.totalDogere += DogereValue;

                if (dataGridView1["ShirazeCost", i].Value == System.DBNull.Value)
                {
                    dataGridView1["ShirazeCost", i].Value = 0;
                }
                Int64 ShirazehValue = (Int64)(dataGridView1["ShirazeCost", i].Value);
                this.totalShiraze += ShirazehValue;

                if (dataGridView1["SarnakhCost", i].Value == System.DBNull.Value)
                {
                    dataGridView1["SarnakhCost", i].Value = 0;
                }
                Int64 SarnakhValue = (Int64)(dataGridView1["SarnakhCost", i].Value);
                this.totalSarnakh += SarnakhValue;

                if (dataGridView1["CharmCost", i].Value == System.DBNull.Value)
                {
                    dataGridView1["CharmCost", i].Value = 0;
                }
                Int64 CharmValue = (Int64)(dataGridView1["CharmCost", i].Value);
                this.totalCharm += CharmValue;

                Decimal area = (decimal)(dataGridView1[7, i].Value);
                this.totalArea += area;
                
            }
            lblTotalArea.Text = "مساحت : " + this.totalArea.ToString();
            lblTotalCost.Text = "مجموع : " + this.totalValue.ToString();
            lblTotalShour.Text = "شور : " + this.totalShour.ToString();
            lblTotalDarkeshi.Text = "دارکشی : " + this.totalDarkeshi.ToString();
            lblTotalPardakht.Text = "پرداخت : " + this.totalPardakht.ToString();
            lblTotalRofu.Text = "رفو : " + this.totalRofu.ToString();
            lblTotalRang.Text = "رنگ : " + this.totalRang.ToString();
            lblTotalShirazeh.Text = "شیرازه : " + this.totalShiraze.ToString();
            lblTotalDogereh.Text = "دوگره : " + this.totalDogere.ToString();
            lblTotalCharm.Text = "چرم : " + this.totalCharm.ToString();
            lblTotalSranakh.Text = "سرنخ : " + this.totalSarnakh.ToString();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView_Factors.SelectedRows.Count != 1)
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show
                    ("لطفا فاکتور مورد نظر خود را وارد کنید.");
            }
            else
            {
                this.isNew = false;

                //join_FactorList_DataSet.Reset();
                long index = (long)(dataGridView_Factors.SelectedRows[0].Cells[0].Value);
                this.SetDataGridViewForCarpets(dataGridView1
                    , this.ShowCarpetOfSpecialFactor(join_FactorList_DataSet, index));
                dataGridView1.Columns[0].Visible = false;
                btnRowAccept.Enabled = false;

                this.FactorID = index;
                this.FactorDate = (DateTime)(dataGridView_Factors.SelectedRows[0].Cells[2].Value);

                this.SumArea_Cost();
            }
        }
    }
}