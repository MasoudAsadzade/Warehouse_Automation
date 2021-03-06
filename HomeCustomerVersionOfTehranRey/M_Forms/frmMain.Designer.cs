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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.main = new System.Windows.Forms.MenuStrip();
            this.customer = new System.Windows.Forms.ToolStripMenuItem();
            this.customerRegistrationj = new System.Windows.Forms.ToolStripMenuItem();
            this.customerListShow = new System.Windows.Forms.ToolStripMenuItem();
            this.Factor = new System.Windows.Forms.ToolStripMenuItem();
            this.Worker = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتکارمندجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستکارمندانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitis = new System.Windows.Forms.ToolStripMenuItem();
            this.Calculator = new System.Windows.Forms.ToolStripMenuItem();
            this.NotePad = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLogIn = new System.Windows.Forms.Button();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.analogClock1 = new AnalogClock.AnalogClock();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.main.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip1);
            resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton1,
            this.helpToolStripButton});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.saveToolStripButton, "saveToolStripButton");
            this.saveToolStripButton.Name = "saveToolStripButton";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.printToolStripButton, "printToolStripButton");
            this.printToolStripButton.Name = "printToolStripButton";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.helpToolStripButton, "helpToolStripButton");
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // main
            // 
            resources.ApplyResources(this.main, "main");
            this.main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customer,
            this.Factor,
            this.Worker,
            this.utilitis,
            this.Exit});
            this.main.Name = "main";
            // 
            // customer
            // 
            this.customer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerRegistrationj,
            this.customerListShow});
            this.customer.Name = "customer";
            resources.ApplyResources(this.customer, "customer");
            // 
            // customerRegistrationj
            // 
            this.customerRegistrationj.Name = "customerRegistrationj";
            resources.ApplyResources(this.customerRegistrationj, "customerRegistrationj");
            this.customerRegistrationj.Click += new System.EventHandler(this.customerRegistrationj_Click);
            // 
            // customerListShow
            // 
            this.customerListShow.Name = "customerListShow";
            resources.ApplyResources(this.customerListShow, "customerListShow");
            this.customerListShow.Click += new System.EventHandler(this.customerListShow_Click);
            // 
            // Factor
            // 
            this.Factor.Name = "Factor";
            resources.ApplyResources(this.Factor, "Factor");
            this.Factor.Click += new System.EventHandler(this.Factor_Click);
            // 
            // Worker
            // 
            this.Worker.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتکارمندجدیدToolStripMenuItem,
            this.لیستکارمندانToolStripMenuItem});
            this.Worker.Name = "Worker";
            resources.ApplyResources(this.Worker, "Worker");
            // 
            // ثبتکارمندجدیدToolStripMenuItem
            // 
            this.ثبتکارمندجدیدToolStripMenuItem.Name = "ثبتکارمندجدیدToolStripMenuItem";
            resources.ApplyResources(this.ثبتکارمندجدیدToolStripMenuItem, "ثبتکارمندجدیدToolStripMenuItem");
            this.ثبتکارمندجدیدToolStripMenuItem.Click += new System.EventHandler(this.ثبتکارمندجدیدToolStripMenuItem_Click);
            // 
            // لیستکارمندانToolStripMenuItem
            // 
            this.لیستکارمندانToolStripMenuItem.Name = "لیستکارمندانToolStripMenuItem";
            resources.ApplyResources(this.لیستکارمندانToolStripMenuItem, "لیستکارمندانToolStripMenuItem");
            this.لیستکارمندانToolStripMenuItem.Click += new System.EventHandler(this.لیستکارمندانToolStripMenuItem_Click);
            // 
            // utilitis
            // 
            this.utilitis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Calculator,
            this.NotePad});
            this.utilitis.Name = "utilitis";
            resources.ApplyResources(this.utilitis, "utilitis");
            // 
            // Calculator
            // 
            this.Calculator.Name = "Calculator";
            resources.ApplyResources(this.Calculator, "Calculator");
            this.Calculator.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // NotePad
            // 
            this.NotePad.Name = "NotePad";
            resources.ApplyResources(this.NotePad, "NotePad");
            this.NotePad.Click += new System.EventHandler(this.NotePad_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLogIn
            // 
            resources.ApplyResources(this.btnLogIn, "btnLogIn");
            this.btnLogIn.BackColor = System.Drawing.Color.LightBlue;
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // analogClock1
            // 
            resources.ApplyResources(this.analogClock1, "analogClock1");
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
            this.analogClock1.HourHandColor = System.Drawing.Color.Gainsboro;
            this.analogClock1.HourHandDropShadowColor = System.Drawing.Color.Gray;
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
            this.analogClock1.Time = new System.DateTime(((long)(0)));
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.analogClock1);
            this.Controls.Add(this.main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.main;
            this.Name = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem NotePad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem Worker;
        private System.Windows.Forms.ToolStripMenuItem ثبتکارمندجدیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستکارمندانToolStripMenuItem;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private AnalogClock.AnalogClock analogClock1;

    }
}