using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace HomeCustomerVersionOfTehranRey.R_Forms
{
    public partial class frmSalary : Form
    {
        DateTime date;
        int  workDay;
        int  workHour;
        long mosaedeh;
        long bonKarmandi;

        public frmSalary()
        {
            InitializeComponent();
        }
        DataTable dt_Salary;
        DataTable dt_Worker;

        DataTable join_SalaryInformation_DataTable = new DataTable();
        public long prop_WorkerID { get; set; }
        public string prop_Workername { get; set; }
        public string prop_Workerfamily { get; set; }
        public string prop_melliCode { get; set; }
        public string prop_IDNo { get; set; }
        public string prop_fatherName { get; set; }
        public long prop_AgreementID { get; set; }

        public long prop_basepayment { get; set; }
        public long prop_basepayhour { get; set; }
        public long prop_basepayDaily { get; set; }
        public long prop_HaghMaskan { get; set; }
        public long prop_HaghJazb { get; set; }
        public long prop_KasrBime { get; set; }
        public long prop_KasrMaliat { get; set; }
        public long prop_HaghOwlad { get; set; }
        public long prop_RecieveMoney {get; set; }
        public long prop_KasrMosaedeh { get; set; }
        public long prop_BonKarmandi { get; set; }
        public long prop_SalaryID { get; set; }


        private long m_TotalBasePayment = 0;
        private long m_SumDailyPayment = 0;
        private long m_SumHourPayment = 0;
        private long m_HaghJazb = 0;
        private long m_HaghMaskan = 0;
        private long m_KasrBime = 0;
        private long m_KasrMaliat = 0;
        private long m_HaghOwlad = 0;
        private long m_KasrMosaede = 0;
        private long m_BonKarmandi = 0;
        private long m_TotalPayment = 0;

        private long CalculateSalary(
            long t_BasePay,
            long s_DailyPay,
            long s_HourPay,
            long haghJazb,
            long haghMaskan,
            long kasrBime,
            long kasrMaliat,
            long haghOwlad,
            long kasrMosaede,
            long bonKarmandi
            )
        {
            long sum =  t_BasePay + s_DailyPay + s_HourPay + haghJazb + haghMaskan + 
                -kasrBime - kasrMaliat + haghOwlad - kasrMosaede + bonKarmandi;
            return sum;
        }

        private void chbox_WorkHour_CheckedChanged(object sender, EventArgs e)
        {
            if (chbox_WorkHour.Checked)
            {
                num_WorkHour.Enabled = true;
            }
            else
            {
                num_WorkHour.Enabled = false;
                num_WorkHour.Value = 0;
            }
        }

        private void chBox_WorkDay_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_WorkDay.Checked)
            {
                num_WorkDay.Enabled = true;
            }
            else
            {
                num_WorkDay.Enabled = false;
                num_WorkDay.Value = 0;
            }
        }

        private void chBox_Mosaede_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_Mosaede.Checked)
            {
                num_Mosaede.Enabled = true;
            }
            else
            {
                num_Mosaede.Enabled = false;
                num_Mosaede.Value = 0;
            }
        }

        private void chBox_BonKarmandi_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_BonKarmandi.Checked)
            {
                num_BonKarmandi.Enabled = true;
            }
            else
            {
                num_BonKarmandi.Enabled = false;
                num_BonKarmandi.Value = 0;
            }
        }

        private void chbox_WorkHour_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chbox_WorkHour.Checked)
                {
                    num_WorkHour.Select();
                }
                else
                {
                    chBox_WorkDay.Focus();
                }
            }
        }

        private void num_WorkHour_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                m_SumHourPayment = System.Convert.ToInt64(num_WorkHour.Value * prop_basepayhour);
                lbl_WorkHour.Text = m_SumHourPayment.ToString();
                chBox_WorkDay.Focus();

            }
        }

        private void chBox_WorkDay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chBox_WorkDay.Checked)
                {
                    num_WorkDay.Select();
                }
                else
                {
                    chBox_Mosaede.Focus();
                }
            }
        }

        private void num_WorkDay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                m_SumDailyPayment = System.Convert.ToInt64
                    (num_WorkDay.Value * prop_basepayDaily);
                lbl_WorkDay.Text = m_SumDailyPayment.ToString();
                chBox_Mosaede.Focus();
            }
        }

        private void chBox_Mosaede_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chBox_Mosaede.Checked)
                {
                    num_Mosaede.Select();
                }
                else
                {
                    chBox_BonKarmandi.Focus();
                }
            }
        }

        private void num_Mosaede_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                m_KasrMosaede = System.Convert.ToInt64(num_Mosaede.Value);
                lbl_Mosaede.Text = m_KasrMosaede.ToString();
                chBox_BonKarmandi.Focus();
            }
        }

        private void chBox_BonKarmandi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chBox_BonKarmandi.Checked)
                {
                    num_BonKarmandi.Select();
                }
                else
                {
                    amr_RecieveDate.Focus();
                }
            }
        }

        private void num_BonKarmandi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                m_BonKarmandi = System.Convert.ToInt64(num_BonKarmandi.Value);
                lbl_BonKarmandi.Text = m_BonKarmandi.ToString();
                amr_RecieveDate.Focus();
                m_TotalPayment = this.CalculateSalary(
                    m_TotalBasePayment, m_SumDailyPayment, m_SumHourPayment,
                    m_HaghJazb, m_HaghMaskan, m_KasrBime, m_KasrMaliat,
                    m_HaghOwlad, m_KasrMosaede, m_BonKarmandi);

                lbl_Sum1.Text = m_TotalPayment.ToString();
            }
        }

        private void SetDataGridViewForInformationOfSpecialWorker(DataGridView dgw, DataTable dt)
        {

            dt.Columns.Add("Counter");
            dt.Columns["Counter"].SetOrdinal(0);

            //dt.Columns["Date"].SetOrdinal(1);


            for (int i = 1; i <= dt.Rows.Count; i++)
            {
                dt.Rows[i - 1]["Counter"] = i;
            }

            dgw.DataSource = dt;
            dgw.DataMember = dt.TableName;

            if (dt.Rows.Count != 0)
            {


                dgw.Columns["Counter"].HeaderText = "ردیف";
                dgw.Columns["Counter"].Width = 40;
              
                dgw.Columns[1].Visible = false;
                dgw.Columns[2].Visible = false;
                dgw.Columns[3].Visible = false;
                //dgw.Columns["Date"].HeaderText = "تاریخ صدور";
                //dgw.Columns["Date"].Width = 70;
                dgw.Columns[4].HeaderText = "حق بیمه";
                dgw.Columns[4].Width = 55;
                dgw.Columns[5].HeaderText = "حق جذب";
                dgw.Columns[5].Width = 55;
                dgw.Columns[6].HeaderText = "حق مسکن";
                dgw.Columns[6].Width = 55;
                dgw.Columns[7].HeaderText = "حق اولاد";
                dgw.Columns[7].Width = 55;
                dgw.Columns[8].HeaderText = "پایه حقوق";
                dgw.Columns[8].Width = 60;
                dgw.Columns[9].HeaderText = "پایه حقوق ساعتی";
                dgw.Columns[9].Width = 80;
                dgw.Columns[10].HeaderText = "پایه حقوق روزانه";
                dgw.Columns[10].Width = 80;
                dgw.Columns[11].HeaderText = "مالیات";
                dgw.Columns[11].Width = 55;
                dgw.Columns[12].Visible = false;
                dgw.Columns[13].Visible = false;
                dgw.Columns[14].HeaderText = "ساعت کاری";
                dgw.Columns[14].Width = 65;
                dgw.Columns[15].HeaderText = "روز کاری";
                dgw.Columns[15].Width = 55;
                dgw.Columns[16].HeaderText = "تاریخ صدور"; 
                dgw.Columns[16].Width = 70;
                dgw.Columns[17].HeaderText = "مساعده";
                dgw.Columns[17].Width = 60;               
                dgw.Columns[18].HeaderText = "بن کارمندی";
                dgw.Columns[18].Width = 65;
                dgw.Columns[19].Visible = false;       
            }
            else
            {
                dgw.Columns.Clear();
            }
        }

        void dgw_ColumnSortModeChanged(object sender, DataGridViewColumnEventArgs e)
        {
                    throw new NotImplementedException();
        }

        private DataTable ShowSalaryInformationOfSpecialWorker(DataTable dt)
        {
            return dt;
        }

        private void frmSalary_Load(object sender, EventArgs e)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj =
                new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();
            //*********************** Set Information Of Worker *****************************
            dt_Worker = new DataTable();
            dt_Worker = obj.worker_Select_ByID(prop_WorkerID);
            lbl_ID.Text = prop_WorkerID.ToString();
            lbl_family.Text = prop_Workername.ToString();
            lbl_name.Text = prop_Workerfamily.ToString();
            lbl_MelliCode.Text = prop_melliCode.ToString();
            lbl_IDNo.Text = prop_IDNo.ToString();
            lbl_FatherName.Text = prop_fatherName.ToString();
            if (File.Exists(Application.StartupPath + "\\WorkersPhoto\\" + prop_WorkerID + ".IFO"))
            {
                img_worker.Image = Image.FromFile(Application.StartupPath + "\\WorkersPhoto\\" + prop_WorkerID + ".IFO");
                img_worker.SizeMode = PictureBoxSizeMode.StretchImage;
                img_worker.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {

            }
            //End of//*********************** Set Information Of Worker *****************************


            //*********************** Set datagridviwe with joine dataset *********************
            dt_Salary = new DataTable();
            dt_Salary = obj.Select_SalaryDetials_InnerJoin(prop_AgreementID);
            
            this.SetDataGridViewForInformationOfSpecialWorker(kryptonDataGridView1, dt_Salary);
            //End of //***********************Set datagridviwe with joine dataset **************

            //get properties *********************
            this.m_TotalBasePayment = prop_basepayment;
            this.m_HaghJazb = prop_HaghJazb;
            this.m_HaghMaskan = prop_HaghMaskan;
            this.m_KasrBime = prop_KasrBime;
            this.m_KasrMaliat = prop_KasrMaliat;
            this.m_HaghOwlad = prop_HaghOwlad;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj =
                new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();

            if (amr_RecieveDate.SelectedDate.Value != null
                    & (chBox_WorkDay.Checked || chbox_WorkHour.Checked ||
                       chBox_BonKarmandi.Checked || chBox_Mosaede.Checked))
            {
                this.date = amr_RecieveDate.SelectedDate.Value;

                this.workDay = System.Convert.ToInt16(num_WorkDay.Value);
                this.workHour = System.Convert.ToInt16(num_WorkHour.Value);
                this.mosaedeh = System.Convert.ToInt64(num_Mosaede.Value);
                this.bonKarmandi = System.Convert.ToInt64(num_BonKarmandi.Value);

                obj.WorkerSalaryInsert(this.workHour, this.workDay, this.date,
                    this.mosaedeh, this.bonKarmandi, prop_AgreementID);
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("اطلاعات با موفقیت ثبت شد!");

                dt_Salary = obj.Select_SalaryDetials_InnerJoin(prop_AgreementID);
                this.SetDataGridViewForInformationOfSpecialWorker(kryptonDataGridView1, dt_Salary);
                btnRegister.Enabled = false;
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("اطلاعات ضروری را وارد کنید!");
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj =
               new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();

            frmAgreementDetailEdit AgreementDetailEdit = new frmAgreementDetailEdit();

            //****** set Lables for frmAgreementDetailEdit *********

            DataTable dt = obj.worker_Select_ByID(prop_WorkerID);
            AgreementDetailEdit.prop_getWorkerID = System.Convert.ToInt64(dt.Rows[0][0].ToString());
            AgreementDetailEdit.prop_getWorkername = dt.Rows[0][1].ToString();
            AgreementDetailEdit.prop_getWorkerfamily = dt.Rows[0][2].ToString();

            //End of //******* set Lables for frmAgreementDetailEdit*****

            AgreementDetailEdit.prop_IsAgreementEdit = false;
            if (kryptonDataGridView1.SelectedRows.Count != 0)
            {
                AgreementDetailEdit.prop_AgreementID = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[1].Value);
                AgreementDetailEdit.prop_SalaryID = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[13].Value);
                AgreementDetailEdit.prop_WorkHour = System.Convert.ToInt16(kryptonDataGridView1.SelectedRows[0].Cells[14].Value);
                AgreementDetailEdit.prop_WorkDay = System.Convert.ToInt16(kryptonDataGridView1.SelectedRows[0].Cells[15].Value);
                AgreementDetailEdit.prop_RecieveDate = System.Convert.ToDateTime(kryptonDataGridView1.SelectedRows[0].Cells[16].Value);
                //AgreementDetailEdit.prop_RecieveMoney = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[15].Value);
                AgreementDetailEdit.prop_Mosaedeh = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[17].Value);
                AgreementDetailEdit.prop_BonKarmandi = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[18].Value);
                AgreementDetailEdit.FormClosed += new FormClosedEventHandler(AgreementDetailEdit_FormClosed);
               
                AgreementDetailEdit.ShowDialog();
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً ردیف فیش حقوقی را انتخاب کنید!");
            } 
        }

        void AgreementDetailEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
             HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj =
               new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();

            dt_Salary = obj.Select_SalaryDetials_InnerJoin(prop_AgreementID);
            this.SetDataGridViewForInformationOfSpecialWorker(kryptonDataGridView1, dt_Salary);
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj =
                new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();

            if (amr_RecieveDate.SelectedDate.Value != null
                    & (chBox_WorkDay.Checked || chbox_WorkHour.Checked ||
                       chBox_BonKarmandi.Checked || chBox_Mosaede.Checked))
            {
                this.date = amr_RecieveDate.SelectedDate.Value;

                this.workDay = System.Convert.ToInt16(num_WorkDay.Value);
                this.workHour = System.Convert.ToInt16(num_WorkHour.Value);
                this.mosaedeh = System.Convert.ToInt64(num_Mosaede.Value);
                this.bonKarmandi = System.Convert.ToInt64(num_BonKarmandi.Value);

                obj.WorkerSalaryInsert(this.workHour, this.workDay, this.date,
                    this.mosaedeh, this.bonKarmandi, prop_AgreementID);
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("اطلاعات با موفقیت ثبت شد!");

                dt_Salary = obj.Select_SalaryDetials_InnerJoin(prop_AgreementID);
                this.SetDataGridViewForInformationOfSpecialWorker(kryptonDataGridView1, dt_Salary);
                btnRegister.Enabled = false;
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("اطلاعات ضروری را وارد کنید!");
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.SelectedRows.Count != 0)
            {
                HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj
                    = new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();

                DataTable dt_Salary = new DataTable();
                DataTable sum = new DataTable();
                DataTable dt_Worker = new DataTable();
                DataTable employPic = new DataTable();
                DataSet ds = new DataSet();


                //string path = Application.StartupPath + "\\WorkersPhoto\\" + prop_WorkerID + ".IFO".ToString();
                //FileStream FilStr = new FileStream(path,FileMode.Open);
                //BinaryReader BinRed = new BinaryReader(FilStr);
                   
                sum.Columns.Add();
                object[] a = new object[1];
                a[0] = m_TotalPayment;
                sum.Rows.Add(a);

                employPic.Columns.Add();
                object[] pic = new object[1];
                pic[0] = Image.FromFile(Application.StartupPath + "\\WorkersPhoto\\" + prop_WorkerID + ".IFO");
                //pic[0] = BinRed.ReadBytes((int)BinRed.BaseStream.Length);
                employPic.Rows.Add(pic);
                //FilStr.Close();
                //BinRed.Close();

                long salaryID = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[13].Value);
                dt_Salary = obj.Select_SalaryDetials_InnerJoin_BySalaryID(prop_AgreementID, salaryID);
                dt_Worker = obj.worker_Select_ByID(prop_WorkerID);

                ds.Tables.Add(dt_Salary);
                ds.Tables.Add(dt_Worker);
                ds.Tables.Add(sum);
                ds.Tables.Add(employPic);
                ds.WriteXml(Application.StartupPath + "\\SalaryReport.xml");

                Crystal.frmSalaryPrint obj1 = new HomeCustomerVersionOfTehranRey.Crystal.frmSalaryPrint();
                obj1.ShowDialog();
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً ردیف فیش حقوقی را انتخاب کنید!");
            }
        }

        private void kryptonDataGridView1_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.SelectedRows.Count != 0)
            {
                m_TotalBasePayment = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[8].Value);
                m_SumDailyPayment = System.Convert.ToInt64(System.Convert.ToInt16(kryptonDataGridView1.SelectedRows[0].Cells[15].Value) * 
                    System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[11].Value));
                m_SumHourPayment = System.Convert.ToInt64(System.Convert.ToInt16(kryptonDataGridView1.SelectedRows[0].Cells[14].Value) * 
                    System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[9].Value));
                m_HaghJazb = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[5].Value);
                m_HaghMaskan = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[6].Value);
                m_KasrBime = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[4].Value);
                m_KasrMaliat = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[11].Value);
                m_HaghOwlad = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[7].Value);
                m_KasrMosaede = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[17].Value);
                m_BonKarmandi = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[18].Value);
                
                m_TotalPayment = this.CalculateSalary(
                    m_TotalBasePayment, m_SumDailyPayment, m_SumHourPayment,
                    m_HaghJazb, m_HaghMaskan, m_KasrBime, m_KasrMaliat,
                    m_HaghOwlad, m_KasrMosaede, m_BonKarmandi);
                lbl_Sum2.Text = m_TotalPayment.ToString();
            }
            else
            {
                lbl_Sum2.Text = "";
            }
        }

    }
 }
