namespace HomeCustomerVersionOfTehranRey.Forms
{
    partial class frmHomeCustomerListShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomeCustomerListShow));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdbName = new System.Windows.Forms.RadioButton();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.panelName = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_CustomerCode = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnFactor = new System.Windows.Forms.Button();
            this.btnShowCarpetList = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnHomeCustomerRegisteration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelName.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_CustomerCode.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(662, 432);
            this.dataGridView1.TabIndex = 30;
            // 
            // rdbName
            // 
            this.rdbName.AutoSize = true;
            this.rdbName.Location = new System.Drawing.Point(25, 43);
            this.rdbName.Name = "rdbName";
            this.rdbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbName.Size = new System.Drawing.Size(147, 17);
            this.rdbName.TabIndex = 31;
            this.rdbName.Text = "بر اساس نام، نام خانوادگی";
            this.rdbName.UseVisualStyleBackColor = true;
            this.rdbName.CheckedChanged += new System.EventHandler(this.rdbName_CheckedChanged);
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.Checked = true;
            this.rdbID.Location = new System.Drawing.Point(53, 20);
            this.rdbID.Name = "rdbID";
            this.rdbID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbID.Size = new System.Drawing.Size(119, 17);
            this.rdbID.TabIndex = 33;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "بر اساس کد اشتراک";
            this.rdbID.UseVisualStyleBackColor = true;
            this.rdbID.CheckedChanged += new System.EventHandler(this.rdbID_CheckedChanged);
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.label3);
            this.panelName.Controls.Add(this.txtFamily);
            this.panelName.Controls.Add(this.label2);
            this.panelName.Controls.Add(this.txtName);
            this.panelName.Location = new System.Drawing.Point(10, 76);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(173, 57);
            this.panelName.TabIndex = 34;
            this.panelName.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "نام خانوادگی";
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(4, 31);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(101, 21);
            this.txtFamily.TabIndex = 8;
            this.txtFamily.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFamily_KeyDown_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "نام";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(101, 21);
            this.txtName.TabIndex = 6;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel_CustomerCode);
            this.groupBox1.Controls.Add(this.panelName);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.rdbName);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.rdbID);
            this.groupBox1.Location = new System.Drawing.Point(683, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(190, 191);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // panel_CustomerCode
            // 
            this.panel_CustomerCode.Controls.Add(this.label1);
            this.panel_CustomerCode.Controls.Add(this.txtCode);
            this.panel_CustomerCode.Location = new System.Drawing.Point(10, 86);
            this.panel_CustomerCode.Name = "panel_CustomerCode";
            this.panel_CustomerCode.Size = new System.Drawing.Size(174, 37);
            this.panel_CustomerCode.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "کد اشتراک";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(3, 7);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(101, 21);
            this.txtCode.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.binoculars;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(94, 139);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSearch.Size = new System.Drawing.Size(87, 40);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.mobsync_16;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(8, 139);
            this.btnReset.Name = "btnReset";
            this.btnReset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReset.Size = new System.Drawing.Size(85, 40);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "بازیابی";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnFactor);
            this.groupBox2.Controls.Add(this.btnShowCarpetList);
            this.groupBox2.Controls.Add(this.btnEditCustomer);
            this.groupBox2.Controls.Add(this.btnHomeCustomerRegisteration);
            this.groupBox2.Location = new System.Drawing.Point(683, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(190, 246);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrint.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.print_32;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(10, 199);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrint.Size = new System.Drawing.Size(171, 40);
            this.btnPrint.TabIndex = 31;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnFactor
            // 
            this.btnFactor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFactor.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.paste;
            this.btnFactor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactor.Location = new System.Drawing.Point(10, 153);
            this.btnFactor.Name = "btnFactor";
            this.btnFactor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFactor.Size = new System.Drawing.Size(171, 40);
            this.btnFactor.TabIndex = 30;
            this.btnFactor.Text = "صدور فاکتور برای مشتری";
            this.btnFactor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFactor.UseVisualStyleBackColor = true;
            this.btnFactor.Click += new System.EventHandler(this.btnFactor_Click);
            // 
            // btnShowCarpetList
            // 
            this.btnShowCarpetList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowCarpetList.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.send;
            this.btnShowCarpetList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowCarpetList.Location = new System.Drawing.Point(10, 107);
            this.btnShowCarpetList.Name = "btnShowCarpetList";
            this.btnShowCarpetList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShowCarpetList.Size = new System.Drawing.Size(171, 40);
            this.btnShowCarpetList.TabIndex = 29;
            this.btnShowCarpetList.Text = "ورود به انبار مشتری";
            this.btnShowCarpetList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowCarpetList.UseVisualStyleBackColor = true;
            this.btnShowCarpetList.Click += new System.EventHandler(this.btnShowCarpetList_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditCustomer.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.edit_user;
            this.btnEditCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCustomer.Location = new System.Drawing.Point(10, 16);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditCustomer.Size = new System.Drawing.Size(171, 39);
            this.btnEditCustomer.TabIndex = 28;
            this.btnEditCustomer.Text = "اصلاح اطلاعات مشتری";
            this.btnEditCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnHomeCustomerRegisteration
            // 
            this.btnHomeCustomerRegisteration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHomeCustomerRegisteration.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.add_user;
            this.btnHomeCustomerRegisteration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeCustomerRegisteration.Location = new System.Drawing.Point(10, 61);
            this.btnHomeCustomerRegisteration.Name = "btnHomeCustomerRegisteration";
            this.btnHomeCustomerRegisteration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHomeCustomerRegisteration.Size = new System.Drawing.Size(171, 40);
            this.btnHomeCustomerRegisteration.TabIndex = 25;
            this.btnHomeCustomerRegisteration.Text = "ثبت مشتری جدید";
            this.btnHomeCustomerRegisteration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHomeCustomerRegisteration.UseVisualStyleBackColor = true;
            this.btnHomeCustomerRegisteration.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHomeCustomerListShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHomeCustomerListShow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست مشتریان";
            this.Load += new System.EventHandler(this.frmHomeCustomerListShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_CustomerCode.ResumeLayout(false);
            this.panel_CustomerCode.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHomeCustomerRegisteration;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rdbName;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnShowCarpetList;
        private System.Windows.Forms.Button btnFactor;
        private System.Windows.Forms.Panel panel_CustomerCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPrint;
    }
}