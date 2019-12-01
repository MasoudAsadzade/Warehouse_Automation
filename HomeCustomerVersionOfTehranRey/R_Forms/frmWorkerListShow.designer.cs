namespace HomeCustomerVersionOfTehranRey.R_Forms
{
    partial class frmWorkerListShow
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
            System.Windows.Forms.Button btnShowAgreementDetail;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkerListShow));
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnFactor = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnHomeCustomerRegisteration = new System.Windows.Forms.Button();
            this.rdbName = new System.Windows.Forms.RadioButton();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_CustomerCode = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.panelName = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.picbox_worker = new System.Windows.Forms.PictureBox();
            btnShowAgreementDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_CustomerCode.SuspendLayout();
            this.panelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_worker)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowAgreementDetail
            // 
            btnShowAgreementDetail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnShowAgreementDetail.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.send;
            btnShowAgreementDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnShowAgreementDetail.Location = new System.Drawing.Point(6, 105);
            btnShowAgreementDetail.Name = "btnShowAgreementDetail";
            btnShowAgreementDetail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            btnShowAgreementDetail.Size = new System.Drawing.Size(173, 40);
            btnShowAgreementDetail.TabIndex = 29;
            btnShowAgreementDetail.Text = "جزئیات قرارداد";
            btnShowAgreementDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnShowAgreementDetail.UseVisualStyleBackColor = true;
            btnShowAgreementDetail.Click += new System.EventHandler(this.btnShowCarpetList_Click);
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToAddRows = false;
            this.kryptonDataGridView1.AllowUserToDeleteRows = false;
            this.kryptonDataGridView1.AllowUserToResizeRows = false;
            this.kryptonDataGridView1.ColumnHeadersHeight = 28;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.kryptonDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(7, 12);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(647, 576);
            this.kryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonDataGridView1.TabIndex = 0;
            this.kryptonDataGridView1.Click += new System.EventHandler(this.kryptonDataGridView1_Click);
            // 
            // btnFactor
            // 
            this.btnFactor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFactor.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.paste;
            this.btnFactor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactor.Location = new System.Drawing.Point(6, 151);
            this.btnFactor.Name = "btnFactor";
            this.btnFactor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFactor.Size = new System.Drawing.Size(173, 40);
            this.btnFactor.TabIndex = 30;
            this.btnFactor.Text = "فیش حقوقی";
            this.btnFactor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFactor.UseVisualStyleBackColor = true;
            this.btnFactor.Click += new System.EventHandler(this.btnFactor_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.binoculars;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(94, 157);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSearch.Size = new System.Drawing.Size(87, 40);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnFactor);
            this.groupBox2.Controls.Add(btnShowAgreementDetail);
            this.groupBox2.Controls.Add(this.btnEditCustomer);
            this.groupBox2.Controls.Add(this.btnHomeCustomerRegisteration);
            this.groupBox2.Location = new System.Drawing.Point(667, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(187, 243);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrint.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.print_32;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(6, 196);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrint.Size = new System.Drawing.Size(173, 40);
            this.btnPrint.TabIndex = 31;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditCustomer.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.edit_user;
            this.btnEditCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCustomer.Location = new System.Drawing.Point(6, 14);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditCustomer.Size = new System.Drawing.Size(173, 39);
            this.btnEditCustomer.TabIndex = 28;
            this.btnEditCustomer.Text = "تصحیح اطلاعات کارمند";
            this.btnEditCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnHomeCustomerRegisteration
            // 
            this.btnHomeCustomerRegisteration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHomeCustomerRegisteration.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.add_user;
            this.btnHomeCustomerRegisteration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeCustomerRegisteration.Location = new System.Drawing.Point(6, 59);
            this.btnHomeCustomerRegisteration.Name = "btnHomeCustomerRegisteration";
            this.btnHomeCustomerRegisteration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHomeCustomerRegisteration.Size = new System.Drawing.Size(173, 40);
            this.btnHomeCustomerRegisteration.TabIndex = 25;
            this.btnHomeCustomerRegisteration.Text = "ثبت کارمند جدید";
            this.btnHomeCustomerRegisteration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHomeCustomerRegisteration.UseVisualStyleBackColor = true;
            this.btnHomeCustomerRegisteration.Click += new System.EventHandler(this.btnHomeCustomerRegisteration_Click);
            // 
            // rdbName
            // 
            this.rdbName.AutoSize = true;
            this.rdbName.Location = new System.Drawing.Point(33, 57);
            this.rdbName.Name = "rdbName";
            this.rdbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbName.Size = new System.Drawing.Size(148, 17);
            this.rdbName.TabIndex = 31;
            this.rdbName.Text = "بر اساس نام، نام خانوادگی";
            this.rdbName.UseVisualStyleBackColor = true;
            this.rdbName.CheckedChanged += new System.EventHandler(this.rdbName_CheckedChanged);
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.Checked = true;
            this.rdbID.Location = new System.Drawing.Point(70, 30);
            this.rdbID.Name = "rdbID";
            this.rdbID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbID.Size = new System.Drawing.Size(111, 17);
            this.rdbID.TabIndex = 33;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "بر اساس کد شناسه";
            this.rdbID.UseVisualStyleBackColor = true;
            this.rdbID.CheckedChanged += new System.EventHandler(this.rdbID_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel_CustomerCode);
            this.groupBox1.Controls.Add(this.panelName);
            this.groupBox1.Controls.Add(this.rdbName);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.rdbID);
            this.groupBox1.Location = new System.Drawing.Point(667, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(187, 206);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // panel_CustomerCode
            // 
            this.panel_CustomerCode.Controls.Add(this.label1);
            this.panel_CustomerCode.Controls.Add(this.txtCode);
            this.panel_CustomerCode.Location = new System.Drawing.Point(4, 103);
            this.panel_CustomerCode.Name = "panel_CustomerCode";
            this.panel_CustomerCode.Size = new System.Drawing.Size(180, 37);
            this.panel_CustomerCode.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "کد شناسه";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(6, 7);
            this.txtCode.Name = "txtCode";
            this.txtCode.ShortcutsEnabled = false;
            this.txtCode.Size = new System.Drawing.Size(98, 20);
            this.txtCode.TabIndex = 8;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.label3);
            this.panelName.Controls.Add(this.txtFamily);
            this.panelName.Controls.Add(this.label2);
            this.panelName.Controls.Add(this.txtName);
            this.panelName.Location = new System.Drawing.Point(6, 92);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(175, 57);
            this.panelName.TabIndex = 35;
            this.panelName.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "نام خانوادگی";
            // 
            // txtFamily
            // 
            this.txtFamily.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFamily.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFamily.Location = new System.Drawing.Point(4, 31);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(98, 20);
            this.txtFamily.TabIndex = 8;
            this.txtFamily.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFamily_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "نام";
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtName.Location = new System.Drawing.Point(4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(98, 20);
            this.txtName.TabIndex = 6;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.mobsync_16;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(6, 157);
            this.btnReset.Name = "btnReset";
            this.btnReset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReset.Size = new System.Drawing.Size(85, 40);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "بازیابی";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // picbox_worker
            // 
            this.picbox_worker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox_worker.Location = new System.Drawing.Point(707, 220);
            this.picbox_worker.Name = "picbox_worker";
            this.picbox_worker.Size = new System.Drawing.Size(110, 125);
            this.picbox_worker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbox_worker.TabIndex = 39;
            this.picbox_worker.TabStop = false;
            // 
            // frmWorkerListShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(861, 597);
            this.Controls.Add(this.picbox_worker);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kryptonDataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmWorkerListShow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست کارمندان";
            this.Load += new System.EventHandler(this.frmWorkerListShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_CustomerCode.ResumeLayout(false);
            this.panel_CustomerCode.PerformLayout();
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_worker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.Button btnFactor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnHomeCustomerRegisteration;
        private System.Windows.Forms.RadioButton rdbName;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox picbox_worker;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel_CustomerCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnPrint;
    }
}