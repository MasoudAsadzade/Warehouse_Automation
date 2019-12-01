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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelPlace = new System.Windows.Forms.Panel();
            this.cmbPlace = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSize = new System.Windows.Forms.Panel();
            this.cmbSize = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.Controls.Add(this.panelPlace);
            this.groupBox1.Controls.Add(this.panelSize);
            this.groupBox1.Controls.Add(this.rdbMadInFrom);
            this.groupBox1.Controls.Add(this.panelCode);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.rdbCarpetSize);
            this.groupBox1.Controls.Add(this.rdbCarpetCode);
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(194, 197);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // panelPlace
            // 
            this.panelPlace.Controls.Add(this.cmbPlace);
            this.panelPlace.Controls.Add(this.label3);
            this.panelPlace.Location = new System.Drawing.Point(9, 103);
            this.panelPlace.Name = "panelPlace";
            this.panelPlace.Size = new System.Drawing.Size(177, 30);
            this.panelPlace.TabIndex = 39;
            this.panelPlace.Visible = false;
            // 
            // cmbPlace
            // 
            this.cmbPlace.FormattingEnabled = true;
            this.cmbPlace.Location = new System.Drawing.Point(6, 4);
            this.cmbPlace.Name = "cmbPlace";
            this.cmbPlace.Size = new System.Drawing.Size(105, 21);
            this.cmbPlace.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "محل بافت";
            // 
            // panelSize
            // 
            this.panelSize.Controls.Add(this.cmbSize);
            this.panelSize.Controls.Add(this.label2);
            this.panelSize.Location = new System.Drawing.Point(9, 103);
            this.panelSize.Name = "panelSize";
            this.panelSize.Size = new System.Drawing.Size(179, 30);
            this.panelSize.TabIndex = 38;
            this.panelSize.Visible = false;
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(6, 4);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(127, 21);
            this.cmbSize.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 7);
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
            this.panelCode.Location = new System.Drawing.Point(9, 103);
            this.panelCode.Name = "panelCode";
            this.panelCode.Size = new System.Drawing.Size(179, 30);
            this.panelCode.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "کد فرش";
            // 
            // txtCarpetCode
            // 
            this.txtCarpetCode.Location = new System.Drawing.Point(4, 4);
            this.txtCarpetCode.Name = "txtCarpetCode";
            this.txtCarpetCode.Size = new System.Drawing.Size(127, 21);
            this.txtCarpetCode.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.mobsync_16;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(7, 146);
            this.btnReset.Name = "btnReset";
            this.btnReset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReset.Size = new System.Drawing.Size(89, 40);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "بازیابی";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.binoculars;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(99, 146);
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
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(216, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(723, 384);
            this.dataGridView1.TabIndex = 37;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.lblResultCount);
            this.groupBox2.Location = new System.Drawing.Point(11, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(194, 68);
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
            this.groupBox3.Controls.Add(this.btnFactor);
            this.groupBox3.Controls.Add(this.btnEditCarpet);
            this.groupBox3.Controls.Add(this.btnAddNewCarpet);
            this.groupBox3.Location = new System.Drawing.Point(11, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(194, 161);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            // 
            // btnFactor
            // 
            this.btnFactor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFactor.Image = global::HomeCustomerVersionOfTehranRey.Properties.Resources.paste;
            this.btnFactor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactor.Location = new System.Drawing.Point(9, 109);
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
            this.btnEditCarpet.Location = new System.Drawing.Point(9, 66);
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
            this.btnAddNewCarpet.Location = new System.Drawing.Point(9, 20);
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
            this.lblCustomerFamily.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerFamily.Location = new System.Drawing.Point(468, 9);
            this.lblCustomerFamily.Name = "lblCustomerFamily";
            this.lblCustomerFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCustomerFamily.Size = new System.Drawing.Size(177, 29);
            this.lblCustomerFamily.TabIndex = 49;
            this.lblCustomerFamily.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCustomerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblCustomerID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(242, 9);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(110, 29);
            this.lblCustomerID.TabIndex = 48;
            this.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 9);
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
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(639, 9);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCustomerName.Size = new System.Drawing.Size(140, 29);
            this.lblCustomerName.TabIndex = 46;
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(779, 9);
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 1);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // frmCarpetListShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 447);
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
            this.Name = "frmCarpetListShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSditCarpet";
            this.Load += new System.EventHandler(this.frmCarpetListShow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.ComboBox cmbPlace;
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
    }
}