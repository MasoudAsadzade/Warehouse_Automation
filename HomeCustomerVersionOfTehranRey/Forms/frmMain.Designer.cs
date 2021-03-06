namespace HomeCustomerVersionOfTehranRey.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.main = new System.Windows.Forms.MenuStrip();
            this.customer = new System.Windows.Forms.ToolStripMenuItem();
            this.customerRegistrationj = new System.Windows.Forms.ToolStripMenuItem();
            this.customerListShow = new System.Windows.Forms.ToolStripMenuItem();
            this.Factor = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitis = new System.Windows.Forms.ToolStripMenuItem();
            this.Calculator = new System.Windows.Forms.ToolStripMenuItem();
            this.NotePad = new System.Windows.Forms.ToolStripMenuItem();
            this.Entertainment = new System.Windows.Forms.ToolStripMenuItem();
            this.game1 = new System.Windows.Forms.ToolStripMenuItem();
            this.game2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.analogClock1 = new AnalogClock.AnalogClock();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.main.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customer,
            this.Factor,
            this.utilitis});
            this.main.Location = new System.Drawing.Point(0, 0);
            this.main.Name = "main";
            this.main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.main.Size = new System.Drawing.Size(905, 24);
            this.main.TabIndex = 5;
            // 
            // customer
            // 
            this.customer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerRegistrationj,
            this.customerListShow});
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(53, 20);
            this.customer.Text = "مشتری";
            // 
            // customerRegistrationj
            // 
            this.customerRegistrationj.Name = "customerRegistrationj";
            this.customerRegistrationj.Size = new System.Drawing.Size(151, 22);
            this.customerRegistrationj.Text = "ثبت مشتری جدید";
            this.customerRegistrationj.Click += new System.EventHandler(this.customerRegistrationj_Click);
            // 
            // customerListShow
            // 
            this.customerListShow.Name = "customerListShow";
            this.customerListShow.Size = new System.Drawing.Size(151, 22);
            this.customerListShow.Text = "لیست مشتریان";
            this.customerListShow.Click += new System.EventHandler(this.customerListShow_Click);
            // 
            // Factor
            // 
            this.Factor.Name = "Factor";
            this.Factor.Size = new System.Drawing.Size(48, 20);
            this.Factor.Text = "فاکتور";
            this.Factor.Click += new System.EventHandler(this.Factor_Click);
            // 
            // utilitis
            // 
            this.utilitis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Calculator,
            this.NotePad,
            this.Entertainment});
            this.utilitis.Name = "utilitis";
            this.utilitis.Size = new System.Drawing.Size(53, 20);
            this.utilitis.Text = "امکانات";
            // 
            // Calculator
            // 
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(134, 22);
            this.Calculator.Text = "ماشین حساب";
            this.Calculator.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // NotePad
            // 
            this.NotePad.Name = "NotePad";
            this.NotePad.Size = new System.Drawing.Size(134, 22);
            this.NotePad.Text = "یادداشت";
            this.NotePad.Click += new System.EventHandler(this.NotePad_Click);
            // 
            // Entertainment
            // 
            this.Entertainment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.game1,
            this.game2});
            this.Entertainment.Name = "Entertainment";
            this.Entertainment.Size = new System.Drawing.Size(134, 22);
            this.Entertainment.Text = "سرگرمی";
            // 
            // game1
            // 
            this.game1.Name = "game1";
            this.game1.Size = new System.Drawing.Size(107, 22);
            this.game1.Text = "بازی 1";
            this.game1.Click += new System.EventHandler(this.game1_Click);
            // 
            // game2
            // 
            this.game2.Name = "game2";
            this.game2.Size = new System.Drawing.Size(107, 22);
            this.game2.Text = "بازی 2";
            this.game2.Click += new System.EventHandler(this.game2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(138, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "ذخیره اطلاعات";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "چاپ";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "ماشین حساب";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "یادداشت";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "راهنما";
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(141, 0);
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(141, 25);
            this.toolStripContainer2.TabIndex = 8;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // analogClock1
            // 
            this.analogClock1.DrawHourHand = true;
            this.analogClock1.DrawHourHandShadow = true;
            this.analogClock1.DrawMinuteHand = true;
            this.analogClock1.DrawMinuteHandShadow = true;
            this.analogClock1.DrawSecondHand = true;
            this.analogClock1.DropShadowColor = System.Drawing.Color.Black;
            this.analogClock1.DropShadowOffset = new System.Drawing.Point(0, 0);
            this.analogClock1.FaceColorHigh = System.Drawing.Color.Aquamarine;
            this.analogClock1.FaceColorLow = System.Drawing.Color.SteelBlue;
            this.analogClock1.FaceGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.analogClock1.FaceImage = null;
            this.analogClock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogClock1.HourHandColor = System.Drawing.Color.Gainsboro;
            this.analogClock1.HourHandDropShadowColor = System.Drawing.Color.Gray;
            this.analogClock1.Location = new System.Drawing.Point(13, 3);
            this.analogClock1.MinuteHandColor = System.Drawing.Color.WhiteSmoke;
            this.analogClock1.MinuteHandDropShadowColor = System.Drawing.Color.Gray;
            this.analogClock1.MinuteHandTickStyle = AnalogClock.TickStyle.Normal;
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.NumeralColor = System.Drawing.Color.WhiteSmoke;
            this.analogClock1.RimColorHigh = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.analogClock1.RimColorLow = System.Drawing.Color.SkyBlue;
            this.analogClock1.RimGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.analogClock1.SecondHandColor = System.Drawing.Color.Tomato;
            this.analogClock1.SecondHandDropShadowColor = System.Drawing.Color.Gray;
            this.analogClock1.SecondHandEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.analogClock1.SecondHandTickStyle = AnalogClock.TickStyle.Normal;
            this.analogClock1.Size = new System.Drawing.Size(210, 210);
            this.analogClock1.TabIndex = 1;
            this.analogClock1.Time = new System.DateTime(((long)(0)));
            this.analogClock1.Load += new System.EventHandler(this.analogClock1_Load);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.analogClock1);
            this.panel1.Location = new System.Drawing.Point(147, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 217);
            this.panel1.TabIndex = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(905, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripContainer2);
            this.Controls.Add(this.main);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainMenuStrip = this.main;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "صفحه اصلی";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip main;
        private System.Windows.Forms.ToolStripMenuItem customer;
        private System.Windows.Forms.ToolStripMenuItem customerRegistrationj;
        private System.Windows.Forms.ToolStripMenuItem customerListShow;
        private System.Windows.Forms.ToolStripMenuItem Factor;
        private System.Windows.Forms.ToolStripMenuItem utilitis;
        private System.Windows.Forms.ToolStripMenuItem Calculator;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.ToolStripMenuItem NotePad;
        private System.Windows.Forms.ToolStripMenuItem Entertainment;
        private System.Windows.Forms.ToolStripMenuItem game1;
        private System.Windows.Forms.ToolStripMenuItem game2;
        private AnalogClock.AnalogClock analogClock1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;

    }
}