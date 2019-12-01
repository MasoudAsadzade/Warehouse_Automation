namespace HomeCustomerVersionOfTehranRey.Forms
{
    partial class frmCarpetListShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarpetListShow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDateBack = new System.Windows.Forms.RadioButton();
            this.panelDate = new System.Windows.Forms.Panel();
            this.amrUCPersianCalenderAdvanced_DateTo = new AmrPersianCalender.AmrUCPersianCalenderAdvanced();
            this.amrUCPersianCalenderAdvanced_DateFrom = new AmrPersianCalender.AmrUCPersianCalenderAdvanced();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rdbDateEntery = new System.Windows.Forms.RadioButton();
            this.panelPlace = new System.Windows.Forms.Panel();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSize = new System.Windows.Forms.Panel();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbMadInFrom = new System.Windows.Forms.RadioButton();
            this.panelCode = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCarpetCode = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdbCarpetSize = new System.Windows.Forms.RadioButton();
            this.rdbCarpetCode = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResultCount = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnFactor = new System.Windows.Forms.Button();
            this.btnEditCarpet = new System.Windows.Forms.Button();
            this.btnAddNewCarpet = new System.Windows.Forms.Button();
            this.lblCustomerFamily = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panelDate.SuspendLayout();
            this.panelPlace.SuspendLayout();
            this.panelSize.SuspendLayout();
            this.panelCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDateBack);
            this.groupBox1.Controls.Add(this.panelDate);
            this.groupBox1.Controls.Add(this.rdbDateEntery);
            this.groupBox1.Controls.Add(this.panelPlace);
            this.groupBox1.Controls.Add(this.panelSize);
            this.groupBox1.Controls.Add(this.rdbMadInFrom);
            this.groupBox1.Controls.Add(this.panelCode);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.rdbCarpetSize);
            this.groupBox1.Controls.Add(this.rdbCarpetCode);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(194, 256);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // rdbDateBack
            // 
            this.rdbDateBack.AutoSize = true;
            this.rdbDateBack.Location = new System.Drawing.Point(49, 116);
            this.rdbDateBack.Name = "rdbDateBack";
            this.rdbDateBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbDateBack.Size = new System.Drawing.Size(119, 17);
            this.rdbDateBack.TabIndex = 41;
            this.rdbDateBack.Text = "بر اساس تاریخ تحویل";
            this.rdbDateBack.UseVisualStyleBackColor = true;
            this.rdbDateBack.CheckedChanged += new System.EventHandler(this.rdbDateBack_CheckedChanged);
            // 
            // panelDate
            // 
            this.panelDate.Controls.Add(this.amrUCPersianCalenderAdvanced_DateTo);
            this.panelDate.Controls.Add(this.amrUCPersianCalenderAdvanced_DateFrom);
            this.panelDate.Controls.Add(this.label11);
            this.panelDate.Controls.Add(this.label12);
            this.panelDate.Location = new System.Drawing.Point(6, 143);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(182, 59);
            this.panelDate.TabIndex = 40;
            this.panelDate.Visible = false;
            // 
            // amrUCPersianCalenderAdvanced_DateTo
            // 
            this.amrUCPersianCalenderAdvanced_DateTo.ClmnDateTimeColumnName = null;
            this.amrUCPersianCalenderAdvanced_DateTo.Location = new System.Drawing.Point(5, 33);
            this.amrUCPersianCalenderAdvanced_DateTo.Name = "amrUCPersianCalenderAdvanced_DateTo";
            this.amrUCPersianCalenderAdvanced_DateTo.ReadOnly = false;
            this.amrUCPersianCalenderAdvanced_DateTo.SelectedDate = new System.DateTime(2008, 9, 19, 1, 1, 1, 1);
            this.amrUCPersianCalenderAdvanced_DateTo.Size = new System.Drawing.Size(161, 23);
            this.amrUCPersianCalenderAdvanced_DateTo.TabIndex = 52;
            this.amrUCPersianCalenderAdvanced_DateTo.TabOrtherType = AmrPersianDateTime.AmrUCPersianCalender.enmTabOrtherType.DayMonthYear;
            // 
            // amrUCPersianCalenderAdvanced_DateFrom
            // 
            this.amrUCPersianCalenderAdvanced_DateFrom.ClmnDateTimeColumnName = null;
            this.amrUCPersianCalenderAdvanced_DateFrom.Location = new System.Drawing.Point(5, 6);
            this.amrUCPersianCalenderAdvanced_DateFrom.Name = "amrUCPersianCalenderAdvanced_DateFrom";
            this.amrUCPersianCalenderAdvanced_DateFrom.ReadOnly = false;
            this.amrUCPersianCalenderAdvanced_DateFrom.SelectedDate = new System.DateTime(2008, 9, 19, 1, 1, 1, 1);
            this.amrUCPersianCalenderAdvanced_DateFrom.Size = new System.Drawing.Size(161, 23);
            this.amrUCPersianCalenderAdvanced_DateFrom.TabIndex = 51;
            this.amrUCPersianCalenderAdvanced_DateFrom.TabOrtherType = AmrPersianDateTime.AmrUCPersianCalender.enmTabOrtherType.DayMonthYear;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(164, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "تا";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(165, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "از";
            // 
            // rdbDateEntery
            // 
            this.rdbDateEntery.AutoSize = true;
            this.rdbDateEntery.Location = new System.Drawing.Point(56, 93);
            this.rdbDateEntery.Name = "rdbDateEntery";
            this.rdbDateEntery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbDateEntery.Size = new System.Drawing.Size(112, 17);
            this.rdbDateEntery.TabIndex = 40;
            this.rdbDateEntery.Text = "بر اساس تاریخ ورود";
            this.rdbDateEntery.UseVisualStyleBackColor = true;
            this.rdbDateEntery.CheckedChanged += new System.EventHandler(this.rdbDateEntery_CheckedChanged);
            // 
            // panelPlace
            // 
            this.panelPlace.Controls.Add(this.txtPlace);
            this.panelPlace.Controls.Add(this.label3);
            this.panelPlace.Location = new System.Drawing.Point(9, 157);
            this.panelPlace.Name = "panelPlace";
            this.panelPlace.Size = new System.Drawing.Size(182, 30);
            this.panelPlace.TabIndex = 39;
            this.panelPlace.Visible = false;
            // 
            // txtPlace
            // 
            this.txtPlace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPlace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPlace.Location = new System.Drawing.Point(3, 4);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(110, 21);
            this.txtPlace.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "محل بافت";
            // 
            // panelSize
            // 
            this.panelSize.Controls.Add(this.txtSize);
            this.panelSize.Controls.Add(this.label2);
            this.panelSize.Location = new System.Drawing.Point(5, 156);
            this.panelSize.Name = "panelSize";
            this.panelSize.Size = new System.Drawing.Size(182, 30);
            this.panelSize.TabIndex = 38;
            this.panelSize.Visible = false;
            // 
            // txtSize
            // 
            this.txtSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSize.Location = new System.Drawing.Point(5, 5);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(110, 21);
            this.txtSize.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "سایز";
            // 
            // rdbMadInFrom
            // 
            this.rdbMadInFrom.AutoSize = true;
            this.rdbMadInFrom.Location = new System.Drawing.Point(54, 70);
            this.rdbMadInFrom.Name = "rdbMadInFrom";
            this.rdbMadInFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbMadInFrom.Size = new System.Drawing.Size(114, 17);
            this.rdbMadInFrom.TabIndex = 37;
            this.rdbMadInFrom.Text = "بر اساس محل بافت";
            this.rdbMadInFrom.UseVisualStyleBackColor = true;
            this.rdbMadInFrom.CheckedChanged += new System.EventHandler(this.rdbMadInFrom_CheckedChanged);
            // 
            // panelCode
            // 
            this.panelCode.Controls.Add(this.label1);
            this.panelCode.Controls.Add(this.txtCarpetCode);
            this.panelCode.Location = new System.Drawing.Point(7, 157);
            this.panelCode.Name = "panelCode";
            this.panelCode.Size = new System.Drawing.Size(173, 30);
            this.panelCode.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "کد فرش";
            // 
            // txtCarpetCode
            // 
            this.txtCarpetCode.Location = new System.Drawing.Point(4, 4);
            this.txtCarpetCode.Name = "txtCarpetCode";
            this.txtCarpetCode.Size = new System.Drawing.Size(110, 21);
            this.txtCarpetCode.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.mobsync_16;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(7, 209);
            this.btnReset.Name = "btnReset";
            this.btnReset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReset.Size = new System.Drawing.Size(89, 40);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "لیست کل";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.binoculars;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(99, 209);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSearch.Size = new System.Drawing.Size(89, 40);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdbCarpetSize
            // 
            this.rdbCarpetSize.AutoSize = true;
            this.rdbCarpetSize.Location = new System.Drawing.Point(77, 47);
            this.rdbCarpetSize.Name = "rdbCarpetSize";
            this.rdbCarpetSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbCarpetSize.Size = new System.Drawing.Size(91, 17);
            this.rdbCarpetSize.TabIndex = 31;
            this.rdbCarpetSize.Text = "بر اساس سایز";
            this.rdbCarpetSize.UseVisualStyleBackColor = true;
            this.rdbCarpetSize.CheckedChanged += new System.EventHandler(this.rdbCarpetSize_CheckedChanged);
            // 
            // rdbCarpetCode
            // 
            this.rdbCarpetCode.AutoSize = true;
            this.rdbCarpetCode.Checked = true;
            this.rdbCarpetCode.Location = new System.Drawing.Point(69, 20);
            this.rdbCarpetCode.Name = "rdbCarpetCode";
            this.rdbCarpetCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbCarpetCode.Size = new System.Drawing.Size(99, 17);
            this.rdbCarpetCode.TabIndex = 33;
            this.rdbCarpetCode.TabStop = true;
            this.rdbCarpetCode.Text = "بر اساس شماره";
            this.rdbCarpetCode.UseVisualStyleBackColor = true;
            this.rdbCarpetCode.CheckedChanged += new System.EventHandler(this.rdbCarpetCode_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(218, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(724, 468);
            this.dataGridView1.TabIndex = 37;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.lblResultCount);
            this.groupBox2.Location = new System.Drawing.Point(7, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(194, 64);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تعداد نتایج جستجو";
            // 
            // lblResultCount
            // 
            this.lblResultCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblResultCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultCount.Location = new System.Drawing.Point(20, 27);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(155, 25);
            this.lblResultCount.TabIndex = 39;
            this.lblResultCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.btnFactor);
            this.groupBox3.Controls.Add(this.btnEditCarpet);
            this.groupBox3.Controls.Add(this.btnAddNewCarpet);
            this.groupBox3.Location = new System.Drawing.Point(7, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(194, 193);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrint.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.print_32;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(9, 148);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrint.Size = new System.Drawing.Size(177, 40);
            this.btnPrint.TabIndex = 43;
            this.btnPrint.Text = "چاپ لیست نمایش داده شده";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnFactor
            // 
            this.btnFactor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFactor.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.paste;
            this.btnFactor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactor.Location = new System.Drawing.Point(9, 104);
            this.btnFactor.Name = "btnFactor";
            this.btnFactor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFactor.Size = new System.Drawing.Size(177, 40);
            this.btnFactor.TabIndex = 42;
            this.btnFactor.Text = "صدور فاکتور برای مشتری";
            this.btnFactor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFactor.UseVisualStyleBackColor = true;
            this.btnFactor.Click += new System.EventHandler(this.btnFactor_Click);
            // 
            // btnEditCarpet
            // 
            this.btnEditCarpet.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.edit1;
            this.btnEditCarpet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCarpet.Location = new System.Drawing.Point(9, 61);
            this.btnEditCarpet.Name = "btnEditCarpet";
            this.btnEditCarpet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditCarpet.Size = new System.Drawing.Size(177, 40);
            this.btnEditCarpet.TabIndex = 41;
            this.btnEditCarpet.Text = "اصلاح اطلاعات فرش";
            this.btnEditCarpet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCarpet.UseVisualStyleBackColor = true;
            this.btnEditCarpet.Click += new System.EventHandler(this.btnEditCarpet_Click);
            // 
            // btnAddNewCarpet
            // 
            this.btnAddNewCarpet.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.new_folder;
            this.btnAddNewCarpet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewCarpet.Location = new System.Drawing.Point(9, 15);
            this.btnAddNewCarpet.Name = "btnAddNewCarpet";
            this.btnAddNewCarpet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddNewCarpet.Size = new System.Drawing.Size(177, 40);
            this.btnAddNewCarpet.TabIndex = 40;
            this.btnAddNewCarpet.Text = "افزودن فرش جدید";
            this.btnAddNewCarpet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewCarpet.UseVisualStyleBackColor = true;
            this.btnAddNewCarpet.Click += new System.EventHandler(this.btnAddNewCarpet_Click);
            // 
            // lblCustomerFamily
            // 
            this.lblCustomerFamily.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCustomerFamily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblCustomerFamily.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerFamily.Location = new System.Drawing.Point(466, 9);
            this.lblCustomerFamily.Name = "lblCustomerFamily";
            this.lblCustomerFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCustomerFamily.Size = new System.Drawing.Size(177, 29);
            this.lblCustomerFamily.TabIndex = 49;
            this.lblCustomerFamily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCustomerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblCustomerID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(240, 9);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(110, 29);
            this.lblCustomerID.TabIndex = 48;
            this.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label5.Location = new System.Drawing.Point(350, 9);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(116, 29);
            this.label5.TabIndex = 47;
            this.label5.Text = "کد مشتری:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(637, 9);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCustomerName.Size = new System.Drawing.Size(140, 29);
            this.lblCustomerName.TabIndex = 46;
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label4.Location = new System.Drawing.Point(777, 9);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(129, 29);
            this.label4.TabIndex = 45;
            this.label4.Text = "لیست فرش های ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources._221;
            this.pictureBox1.Location = new System.Drawing.Point(8, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 1);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // frmCarpetListShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCustomerFamily);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 563);
            this.Name = "frmCarpetListShow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست فرش های مشتری";
            this.Load += new System.EventHandler(this.frmCarpetListShow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.panelPlace.ResumeLayout(false);
            this.panelPlace.PerformLayout();
            this.panelSize.ResumeLayout(false);
            this.panelSize.PerformLayout();
            this.panelCode.ResumeLayout(false);
            this.panelCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCarpetCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdbCarpetSize;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rdbCarpetCode;
        private System.Windows.Forms.RadioButton rdbMadInFrom;
        private System.Windows.Forms.Panel panelSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPlace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResultCount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddNewCarpet;
        private System.Windows.Forms.Button btnEditCarpet;
        private System.Windows.Forms.Button btnFactor;
        private System.Windows.Forms.Label lblCustomerFamily;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.RadioButton rdbDateEntery;
        private System.Windows.Forms.RadioButton rdbDateBack;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPrint;
        private AmrPersianCalender.AmrUCPersianCalenderAdvanced amrUCPersianCalenderAdvanced_DateTo;
        private AmrPersianCalender.AmrUCPersianCalenderAdvanced amrUCPersianCalenderAdvanced_DateFrom;
    }
}