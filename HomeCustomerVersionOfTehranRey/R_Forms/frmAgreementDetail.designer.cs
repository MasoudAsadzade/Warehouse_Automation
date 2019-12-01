namespace HomeCustomerVersionOfTehranRey.R_Forms
{
    partial class frmAgreementDetail
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
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label FamilyLabel;
            System.Windows.Forms.Label NameLabel;
            System.Windows.Forms.Label lblIDNo;
            System.Windows.Forms.Label lblFatherName;
            System.Windows.Forms.Label lblMelliCode;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgreementDetail));
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_FatherName = new System.Windows.Forms.Label();
            this.lbl_IDNo = new System.Windows.Forms.Label();
            this.lbl_MelliCode = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_family = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.img_worker = new System.Windows.Forms.PictureBox();
            this.btnRegister = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPrint = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.numbase_payhourFee = new System.Windows.Forms.NumericUpDown();
            this.num_Tax = new System.Windows.Forms.NumericUpDown();
            this.num_payextra_Fee = new System.Windows.Forms.NumericUpDown();
            this.num_bimeFee = new System.Windows.Forms.NumericUpDown();
            this.chBox_haghjazb = new System.Windows.Forms.CheckBox();
            this.chBox_Tax = new System.Windows.Forms.CheckBox();
            this.chBox_bime = new System.Windows.Forms.CheckBox();
            this.start_Lable = new System.Windows.Forms.Label();
            this.chBox_base_extra = new System.Windows.Forms.CheckBox();
            this.finish_lable = new System.Windows.Forms.Label();
            this.num_haghjazbFee = new System.Windows.Forms.NumericUpDown();
            this.chBox_children = new System.Windows.Forms.CheckBox();
            this.num_children_Fee = new System.Windows.Forms.NumericUpDown();
            this.num_maskanFee = new System.Windows.Forms.NumericUpDown();
            this.chBox_maskan = new System.Windows.Forms.CheckBox();
            this.chBox_basepay_hour = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.amr_FinishDate = new AmrPersianCalender.AmrUCPersianCalenderAdvanced();
            this.amr_StartDate = new AmrPersianCalender.AmrUCPersianCalenderAdvanced();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chbox_basepayment = new System.Windows.Forms.CheckBox();
            this.num_basepaymentFee = new System.Windows.Forms.NumericUpDown();
            this.grpBox_Buttun = new System.Windows.Forms.GroupBox();
            this.btnHokm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            codeLabel = new System.Windows.Forms.Label();
            FamilyLabel = new System.Windows.Forms.Label();
            NameLabel = new System.Windows.Forms.Label();
            lblIDNo = new System.Windows.Forms.Label();
            lblFatherName = new System.Windows.Forms.Label();
            lblMelliCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_worker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbase_payhourFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Tax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_payextra_Fee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_bimeFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_haghjazbFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_children_Fee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_maskanFee)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_basepaymentFee)).BeginInit();
            this.grpBox_Buttun.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(243, 21);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(59, 13);
            codeLabel.TabIndex = 3;
            codeLabel.Text = "کد شناسه :";
            // 
            // FamilyLabel
            // 
            FamilyLabel.AutoSize = true;
            FamilyLabel.Location = new System.Drawing.Point(243, 47);
            FamilyLabel.Name = "FamilyLabel";
            FamilyLabel.Size = new System.Drawing.Size(75, 13);
            FamilyLabel.TabIndex = 7;
            FamilyLabel.Text = "نام خانوادگی :";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new System.Drawing.Point(243, 70);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(26, 13);
            NameLabel.TabIndex = 5;
            NameLabel.Text = "نام :";
            // 
            // lblIDNo
            // 
            lblIDNo.AutoSize = true;
            lblIDNo.Location = new System.Drawing.Point(243, 118);
            lblIDNo.Name = "lblIDNo";
            lblIDNo.Size = new System.Drawing.Size(89, 13);
            lblIDNo.TabIndex = 26;
            lblIDNo.Text = "شماره شناسنامه :";
            // 
            // lblFatherName
            // 
            lblFatherName.AutoSize = true;
            lblFatherName.Location = new System.Drawing.Point(243, 140);
            lblFatherName.Name = "lblFatherName";
            lblFatherName.Size = new System.Drawing.Size(43, 13);
            lblFatherName.TabIndex = 27;
            lblFatherName.Text = "نام پدر :";
            // 
            // lblMelliCode
            // 
            lblMelliCode.AutoSize = true;
            lblMelliCode.Location = new System.Drawing.Point(243, 94);
            lblMelliCode.Name = "lblMelliCode";
            lblMelliCode.Size = new System.Drawing.Size(46, 13);
            lblMelliCode.TabIndex = 28;
            lblMelliCode.Text = "کد ملی :";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToAddRows = false;
            this.kryptonDataGridView1.AllowUserToDeleteRows = false;
            this.kryptonDataGridView1.AllowUserToResizeColumns = false;
            this.kryptonDataGridView1.AllowUserToResizeRows = false;
            this.kryptonDataGridView1.ColumnHeadersHeight = 28;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(9, 195);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kryptonDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(725, 293);
            this.kryptonDataGridView1.StandardTab = true;
            this.kryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonDataGridView1.TabIndex = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_FatherName);
            this.groupBox1.Controls.Add(this.lbl_IDNo);
            this.groupBox1.Controls.Add(this.lbl_MelliCode);
            this.groupBox1.Controls.Add(lblMelliCode);
            this.groupBox1.Controls.Add(lblFatherName);
            this.groupBox1.Controls.Add(lblIDNo);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.lbl_family);
            this.groupBox1.Controls.Add(this.lbl_ID);
            this.groupBox1.Controls.Add(this.img_worker);
            this.groupBox1.Controls.Add(codeLabel);
            this.groupBox1.Controls.Add(NameLabel);
            this.groupBox1.Controls.Add(FamilyLabel);
            this.groupBox1.Location = new System.Drawing.Point(512, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 176);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات کارمند";
            // 
            // lbl_FatherName
            // 
            this.lbl_FatherName.AutoSize = true;
            this.lbl_FatherName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_FatherName.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_FatherName.Location = new System.Drawing.Point(137, 139);
            this.lbl_FatherName.MinimumSize = new System.Drawing.Size(100, 20);
            this.lbl_FatherName.Name = "lbl_FatherName";
            this.lbl_FatherName.Size = new System.Drawing.Size(100, 20);
            this.lbl_FatherName.TabIndex = 31;
            // 
            // lbl_IDNo
            // 
            this.lbl_IDNo.AutoSize = true;
            this.lbl_IDNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_IDNo.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_IDNo.Location = new System.Drawing.Point(137, 117);
            this.lbl_IDNo.MinimumSize = new System.Drawing.Size(100, 20);
            this.lbl_IDNo.Name = "lbl_IDNo";
            this.lbl_IDNo.Size = new System.Drawing.Size(100, 20);
            this.lbl_IDNo.TabIndex = 30;
            // 
            // lbl_MelliCode
            // 
            this.lbl_MelliCode.AutoSize = true;
            this.lbl_MelliCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_MelliCode.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_MelliCode.Location = new System.Drawing.Point(137, 93);
            this.lbl_MelliCode.MinimumSize = new System.Drawing.Size(100, 20);
            this.lbl_MelliCode.Name = "lbl_MelliCode";
            this.lbl_MelliCode.Size = new System.Drawing.Size(100, 20);
            this.lbl_MelliCode.TabIndex = 29;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_name.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_name.Location = new System.Drawing.Point(137, 69);
            this.lbl_name.MinimumSize = new System.Drawing.Size(100, 20);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(100, 20);
            this.lbl_name.TabIndex = 25;
            // 
            // lbl_family
            // 
            this.lbl_family.AutoSize = true;
            this.lbl_family.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_family.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_family.Location = new System.Drawing.Point(137, 46);
            this.lbl_family.MinimumSize = new System.Drawing.Size(100, 20);
            this.lbl_family.Name = "lbl_family";
            this.lbl_family.Size = new System.Drawing.Size(100, 20);
            this.lbl_family.TabIndex = 24;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_ID.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_ID.Location = new System.Drawing.Point(137, 20);
            this.lbl_ID.MinimumSize = new System.Drawing.Size(100, 20);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(100, 20);
            this.lbl_ID.TabIndex = 23;
            // 
            // img_worker
            // 
            this.img_worker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img_worker.Location = new System.Drawing.Point(15, 27);
            this.img_worker.Name = "img_worker";
            this.img_worker.Size = new System.Drawing.Size(110, 125);
            this.img_worker.TabIndex = 22;
            this.img_worker.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(4, 14);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnRegister.Size = new System.Drawing.Size(103, 32);
            this.btnRegister.TabIndex = 102;
            this.btnRegister.Text = "ثبت جزئیات";
            this.btnRegister.Values.ExtraText = "";
            this.btnRegister.Values.Image = null;
            this.btnRegister.Values.ImageStates.ImageCheckedNormal = null;
            this.btnRegister.Values.ImageStates.ImageCheckedPressed = null;
            this.btnRegister.Values.ImageStates.ImageCheckedTracking = null;
            this.btnRegister.Values.Text = "ثبت جزئیات";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(4, 129);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 32);
            this.btnPrint.TabIndex = 103;
            this.btnPrint.Text = "چاپ جزئیات";
            this.btnPrint.Values.ExtraText = "";
            this.btnPrint.Values.Image = null;
            this.btnPrint.Values.ImageStates.ImageCheckedNormal = null;
            this.btnPrint.Values.ImageStates.ImageCheckedPressed = null;
            this.btnPrint.Values.ImageStates.ImageCheckedTracking = null;
            this.btnPrint.Values.Text = "چاپ جزئیات";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(4, 53);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 32);
            this.btnEdit.TabIndex = 104;
            this.btnEdit.Text = "تصحیح جزئیات";
            this.btnEdit.Values.ExtraText = "";
            this.btnEdit.Values.Image = null;
            this.btnEdit.Values.ImageStates.ImageCheckedNormal = null;
            this.btnEdit.Values.ImageStates.ImageCheckedPressed = null;
            this.btnEdit.Values.ImageStates.ImageCheckedTracking = null;
            this.btnEdit.Values.Text = "تصحیح جزئیات";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // numbase_payhourFee
            // 
            this.numbase_payhourFee.Enabled = false;
            this.numbase_payhourFee.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numbase_payhourFee.Location = new System.Drawing.Point(243, 54);
            this.numbase_payhourFee.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numbase_payhourFee.Name = "numbase_payhourFee";
            this.numbase_payhourFee.Size = new System.Drawing.Size(66, 20);
            this.numbase_payhourFee.TabIndex = 65;
            this.numbase_payhourFee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numbase_payhourFee_KeyDown);
            // 
            // num_Tax
            // 
            this.num_Tax.Enabled = false;
            this.num_Tax.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_Tax.Location = new System.Drawing.Point(60, 84);
            this.num_Tax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_Tax.Name = "num_Tax";
            this.num_Tax.Size = new System.Drawing.Size(66, 20);
            this.num_Tax.TabIndex = 90;
            this.num_Tax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_bonkarmandi_Fee_KeyDown);
            // 
            // num_payextra_Fee
            // 
            this.num_payextra_Fee.Enabled = false;
            this.num_payextra_Fee.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_payextra_Fee.Location = new System.Drawing.Point(243, 81);
            this.num_payextra_Fee.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_payextra_Fee.Name = "num_payextra_Fee";
            this.num_payextra_Fee.Size = new System.Drawing.Size(66, 20);
            this.num_payextra_Fee.TabIndex = 70;
            this.num_payextra_Fee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_payextra_Fee_KeyDown);
            // 
            // num_bimeFee
            // 
            this.num_bimeFee.Enabled = false;
            this.num_bimeFee.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_bimeFee.Location = new System.Drawing.Point(60, 55);
            this.num_bimeFee.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_bimeFee.Name = "num_bimeFee";
            this.num_bimeFee.Size = new System.Drawing.Size(66, 20);
            this.num_bimeFee.TabIndex = 85;
            this.num_bimeFee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_bimeFee_KeyDown);
            // 
            // chBox_haghjazb
            // 
            this.chBox_haghjazb.AutoSize = true;
            this.chBox_haghjazb.Location = new System.Drawing.Point(314, 111);
            this.chBox_haghjazb.Name = "chBox_haghjazb";
            this.chBox_haghjazb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chBox_haghjazb.Size = new System.Drawing.Size(64, 17);
            this.chBox_haghjazb.TabIndex = 74;
            this.chBox_haghjazb.Text = "حق جذب";
            this.chBox_haghjazb.UseVisualStyleBackColor = true;
            this.chBox_haghjazb.CheckedChanged += new System.EventHandler(this.chBox_haghjazb_CheckedChanged);
            this.chBox_haghjazb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chBox_haghjazb_KeyDown);
            // 
            // chBox_Tax
            // 
            this.chBox_Tax.AutoSize = true;
            this.chBox_Tax.Location = new System.Drawing.Point(132, 88);
            this.chBox_Tax.Name = "chBox_Tax";
            this.chBox_Tax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chBox_Tax.Size = new System.Drawing.Size(93, 17);
            this.chBox_Tax.TabIndex = 89;
            this.chBox_Tax.Text = "مالیات بر درآمد";
            this.chBox_Tax.UseVisualStyleBackColor = true;
            this.chBox_Tax.CheckedChanged += new System.EventHandler(this.chBox_bon_karmandi_CheckedChanged);
            this.chBox_Tax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chBox_bon_karmandi_KeyDown);
            // 
            // chBox_bime
            // 
            this.chBox_bime.AutoSize = true;
            this.chBox_bime.Location = new System.Drawing.Point(132, 59);
            this.chBox_bime.Name = "chBox_bime";
            this.chBox_bime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chBox_bime.Size = new System.Drawing.Size(62, 17);
            this.chBox_bime.TabIndex = 84;
            this.chBox_bime.Text = "حق بیمه";
            this.chBox_bime.UseVisualStyleBackColor = true;
            this.chBox_bime.CheckedChanged += new System.EventHandler(this.chBox_bime_CheckedChanged);
            this.chBox_bime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chBox_bime_KeyDown);
            // 
            // start_Lable
            // 
            this.start_Lable.AutoSize = true;
            this.start_Lable.Location = new System.Drawing.Point(409, 143);
            this.start_Lable.Name = "start_Lable";
            this.start_Lable.Size = new System.Drawing.Size(69, 13);
            this.start_Lable.TabIndex = 18;
            this.start_Lable.Text = "شروع قرارداد";
            // 
            // chBox_base_extra
            // 
            this.chBox_base_extra.AutoSize = true;
            this.chBox_base_extra.Location = new System.Drawing.Point(314, 84);
            this.chBox_base_extra.Name = "chBox_base_extra";
            this.chBox_base_extra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chBox_base_extra.Size = new System.Drawing.Size(103, 17);
            this.chBox_base_extra.TabIndex = 69;
            this.chBox_base_extra.Text = "پایه حقوق روزانه";
            this.chBox_base_extra.UseVisualStyleBackColor = true;
            this.chBox_base_extra.CheckedChanged += new System.EventHandler(this.chBox_base_extra_CheckedChanged);
            this.chBox_base_extra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chBox_base_extra_KeyDown);
            // 
            // finish_lable
            // 
            this.finish_lable.AutoSize = true;
            this.finish_lable.Location = new System.Drawing.Point(165, 143);
            this.finish_lable.Name = "finish_lable";
            this.finish_lable.Size = new System.Drawing.Size(65, 13);
            this.finish_lable.TabIndex = 19;
            this.finish_lable.Text = "پایان قرارداد";
            // 
            // num_haghjazbFee
            // 
            this.num_haghjazbFee.Enabled = false;
            this.num_haghjazbFee.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_haghjazbFee.Location = new System.Drawing.Point(243, 108);
            this.num_haghjazbFee.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_haghjazbFee.Name = "num_haghjazbFee";
            this.num_haghjazbFee.Size = new System.Drawing.Size(66, 20);
            this.num_haghjazbFee.TabIndex = 75;
            this.num_haghjazbFee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_haghjazbFee_KeyDown);
            // 
            // chBox_children
            // 
            this.chBox_children.AutoSize = true;
            this.chBox_children.Location = new System.Drawing.Point(132, 111);
            this.chBox_children.Name = "chBox_children";
            this.chBox_children.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chBox_children.Size = new System.Drawing.Size(64, 17);
            this.chBox_children.TabIndex = 94;
            this.chBox_children.Text = "حق اولاد";
            this.chBox_children.UseVisualStyleBackColor = true;
            this.chBox_children.CheckedChanged += new System.EventHandler(this.chBox_children_CheckedChanged);
            this.chBox_children.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chBox_children_KeyDown);
            // 
            // num_children_Fee
            // 
            this.num_children_Fee.Enabled = false;
            this.num_children_Fee.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_children_Fee.Location = new System.Drawing.Point(60, 108);
            this.num_children_Fee.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_children_Fee.Name = "num_children_Fee";
            this.num_children_Fee.Size = new System.Drawing.Size(66, 20);
            this.num_children_Fee.TabIndex = 95;
            this.num_children_Fee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_children_Fee_KeyDown);
            // 
            // num_maskanFee
            // 
            this.num_maskanFee.Enabled = false;
            this.num_maskanFee.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_maskanFee.Location = new System.Drawing.Point(61, 29);
            this.num_maskanFee.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_maskanFee.Name = "num_maskanFee";
            this.num_maskanFee.Size = new System.Drawing.Size(66, 20);
            this.num_maskanFee.TabIndex = 80;
            this.num_maskanFee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_maskanFee_KeyDown);
            // 
            // chBox_maskan
            // 
            this.chBox_maskan.AutoSize = true;
            this.chBox_maskan.Location = new System.Drawing.Point(132, 33);
            this.chBox_maskan.Name = "chBox_maskan";
            this.chBox_maskan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chBox_maskan.Size = new System.Drawing.Size(72, 17);
            this.chBox_maskan.TabIndex = 79;
            this.chBox_maskan.Text = "حق مسکن";
            this.chBox_maskan.UseVisualStyleBackColor = true;
            this.chBox_maskan.CheckedChanged += new System.EventHandler(this.chBox_maskan_CheckedChanged);
            this.chBox_maskan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chBox_maskan_KeyDown);
            // 
            // chBox_basepay_hour
            // 
            this.chBox_basepay_hour.AutoSize = true;
            this.chBox_basepay_hour.Location = new System.Drawing.Point(314, 57);
            this.chBox_basepay_hour.Name = "chBox_basepay_hour";
            this.chBox_basepay_hour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chBox_basepay_hour.Size = new System.Drawing.Size(109, 17);
            this.chBox_basepay_hour.TabIndex = 64;
            this.chBox_basepay_hour.Text = "پایه حقوق ساعتی";
            this.chBox_basepay_hour.UseVisualStyleBackColor = true;
            this.chBox_basepay_hour.CheckedChanged += new System.EventHandler(this.chBox_basepay_hour_CheckedChanged);
            this.chBox_basepay_hour.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chBox_basepay_hour_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.amr_FinishDate);
            this.groupBox2.Controls.Add(this.amr_StartDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.chbox_basepayment);
            this.groupBox2.Controls.Add(this.num_basepaymentFee);
            this.groupBox2.Controls.Add(this.chBox_basepay_hour);
            this.groupBox2.Controls.Add(this.chBox_maskan);
            this.groupBox2.Controls.Add(this.num_maskanFee);
            this.groupBox2.Controls.Add(this.num_children_Fee);
            this.groupBox2.Controls.Add(this.chBox_children);
            this.groupBox2.Controls.Add(this.num_haghjazbFee);
            this.groupBox2.Controls.Add(this.finish_lable);
            this.groupBox2.Controls.Add(this.chBox_base_extra);
            this.groupBox2.Controls.Add(this.start_Lable);
            this.groupBox2.Controls.Add(this.chBox_bime);
            this.groupBox2.Controls.Add(this.chBox_Tax);
            this.groupBox2.Controls.Add(this.chBox_haghjazb);
            this.groupBox2.Controls.Add(this.num_bimeFee);
            this.groupBox2.Controls.Add(this.num_payextra_Fee);
            this.groupBox2.Controls.Add(this.num_Tax);
            this.groupBox2.Controls.Add(this.numbase_payhourFee);
            this.groupBox2.Location = new System.Drawing.Point(9, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 176);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جزئیات قرارداد";
            // 
            // amr_FinishDate
            // 
            this.amr_FinishDate.ClmnDateTimeColumnName = null;
            this.amr_FinishDate.Location = new System.Drawing.Point(6, 138);
            this.amr_FinishDate.Name = "amr_FinishDate";
            this.amr_FinishDate.ReadOnly = false;
            this.amr_FinishDate.SelectedDate = new System.DateTime(2008, 9, 29, 1, 1, 1, 1);
            this.amr_FinishDate.Size = new System.Drawing.Size(165, 23);
            this.amr_FinishDate.TabIndex = 110;
            this.amr_FinishDate.TabOrtherType = AmrPersianDateTime.AmrUCPersianCalender.enmTabOrtherType.DayMonthYear;
            // 
            // amr_StartDate
            // 
            this.amr_StartDate.ClmnDateTimeColumnName = null;
            this.amr_StartDate.Location = new System.Drawing.Point(247, 138);
            this.amr_StartDate.Name = "amr_StartDate";
            this.amr_StartDate.ReadOnly = false;
            this.amr_StartDate.SelectedDate = new System.DateTime(2008, 9, 29, 1, 1, 1, 1);
            this.amr_StartDate.Size = new System.Drawing.Size(165, 23);
            this.amr_StartDate.TabIndex = 109;
            this.amr_StartDate.TabOrtherType = AmrPersianDateTime.AmrUCPersianCalender.enmTabOrtherType.DayMonthYear;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(230, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 108;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(474, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 107;
            this.label1.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(382, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 15);
            this.label6.TabIndex = 106;
            this.label6.Text = "*";
            // 
            // chbox_basepayment
            // 
            this.chbox_basepayment.AutoSize = true;
            this.chbox_basepayment.Location = new System.Drawing.Point(314, 31);
            this.chbox_basepayment.Name = "chbox_basepayment";
            this.chbox_basepayment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbox_basepayment.Size = new System.Drawing.Size(72, 17);
            this.chbox_basepayment.TabIndex = 96;
            this.chbox_basepayment.Text = "پایه حقوق";
            this.chbox_basepayment.UseVisualStyleBackColor = true;
            this.chbox_basepayment.CheckedChanged += new System.EventHandler(this.chkbox_basepayment_CheckedChanged);
            this.chbox_basepayment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chbox_basepayment_KeyDown);
            // 
            // num_basepaymentFee
            // 
            this.num_basepaymentFee.Enabled = false;
            this.num_basepaymentFee.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_basepaymentFee.Location = new System.Drawing.Point(243, 28);
            this.num_basepaymentFee.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_basepaymentFee.Name = "num_basepaymentFee";
            this.num_basepaymentFee.Size = new System.Drawing.Size(66, 20);
            this.num_basepaymentFee.TabIndex = 97;
            this.num_basepaymentFee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_basepaymentFee_KeyDown);
            // 
            // grpBox_Buttun
            // 
            this.grpBox_Buttun.Controls.Add(this.btnHokm);
            this.grpBox_Buttun.Controls.Add(this.btnRegister);
            this.grpBox_Buttun.Controls.Add(this.btnEdit);
            this.grpBox_Buttun.Controls.Add(this.btnPrint);
            this.grpBox_Buttun.Location = new System.Drawing.Point(740, 193);
            this.grpBox_Buttun.Name = "grpBox_Buttun";
            this.grpBox_Buttun.Size = new System.Drawing.Size(113, 169);
            this.grpBox_Buttun.TabIndex = 105;
            this.grpBox_Buttun.TabStop = false;
            // 
            // btnHokm
            // 
            this.btnHokm.Location = new System.Drawing.Point(4, 92);
            this.btnHokm.Name = "btnHokm";
            this.btnHokm.Size = new System.Drawing.Size(103, 32);
            this.btnHokm.TabIndex = 105;
            this.btnHokm.Text = "فیش حقوقی";
            this.btnHokm.Values.ExtraText = "";
            this.btnHokm.Values.Image = null;
            this.btnHokm.Values.ImageStates.ImageCheckedNormal = null;
            this.btnHokm.Values.ImageStates.ImageCheckedPressed = null;
            this.btnHokm.Values.ImageStates.ImageCheckedTracking = null;
            this.btnHokm.Values.Text = "فیش حقوقی";
            this.btnHokm.Click += new System.EventHandler(this.btnHokm_Click);
            // 
            // frmAgreementDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(861, 499);
            this.Controls.Add(this.grpBox_Buttun);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kryptonDataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAgreementDetail";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "جزئیات قرارداد";
            this.Load += new System.EventHandler(this.frmAgreementDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_worker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbase_payhourFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Tax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_payextra_Fee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_bimeFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_haghjazbFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_children_Fee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_maskanFee)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_basepaymentFee)).EndInit();
            this.grpBox_Buttun.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_worker;
        public ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRegister;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_family;
        private System.Windows.Forms.Label lbl_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPrint;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private System.Windows.Forms.NumericUpDown numbase_payhourFee;
        private System.Windows.Forms.NumericUpDown num_Tax;
        private System.Windows.Forms.NumericUpDown num_payextra_Fee;
        private System.Windows.Forms.NumericUpDown num_bimeFee;
        private System.Windows.Forms.CheckBox chBox_haghjazb;
        private System.Windows.Forms.CheckBox chBox_Tax;
        private System.Windows.Forms.CheckBox chBox_bime;
        private System.Windows.Forms.Label start_Lable;
        private System.Windows.Forms.CheckBox chBox_base_extra;
        private System.Windows.Forms.Label finish_lable;
        private System.Windows.Forms.NumericUpDown num_haghjazbFee;
        private System.Windows.Forms.CheckBox chBox_children;
        private System.Windows.Forms.NumericUpDown num_children_Fee;
        private System.Windows.Forms.NumericUpDown num_maskanFee;
        private System.Windows.Forms.CheckBox chBox_maskan;
        private System.Windows.Forms.CheckBox chBox_basepay_hour;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbox_basepayment;
        private System.Windows.Forms.NumericUpDown num_basepaymentFee;
        private System.Windows.Forms.GroupBox grpBox_Buttun;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnHokm;
        private System.Windows.Forms.Label lbl_FatherName;
        private System.Windows.Forms.Label lbl_IDNo;
        private System.Windows.Forms.Label lbl_MelliCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private AmrPersianCalender.AmrUCPersianCalenderAdvanced amr_FinishDate;
        private AmrPersianCalender.AmrUCPersianCalenderAdvanced amr_StartDate;
    }
}