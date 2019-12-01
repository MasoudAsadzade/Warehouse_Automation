using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HomeCustomerVersionOfTehranRey.R_Forms
{
    public partial class frmAgreementDetail : Form
    {
        DateTime startDate;
        DateTime finshDate;
        long base_payment;
        long base_paymenthour;
        long base_payment_extre;
        long hagh_jazb;
        long hagh_maskan;
        long hagh_bime;
        long tax;
        long hagh_owlad;

        public frmAgreementDetail()
        {
            InitializeComponent();
        }
        DataTable dt_Worker;
        public DataTable dt_AgreementDetail;
        public long prop_AgreementID { get; set; }
        public long prop_WorkerID { get; set; }
        public string prop_Workername { get; set; }
        public string prop_Workerfamily { get; set; }
        public string prop_melliCode { get; set; }
        public string prop_IDNo { get; set; }
        public string prop_fatherName { get; set; }
        public Stream prop_workerImage { get; set; }


        /// <summary>
        /// For Set Farsi Header In DataGridView For AgreementDetail
        /// </summary>
        /// <param name="dg">dg is DataGridView</param>
        /// <param name="dt">dt is Datatable</param>
        public void SetHeaderAgreementDetail(DataGridView dg, DataTable dt)
        {
            dg.DataSource = dt;
            dg.DataMember = dt.TableName;

            if (dt.Rows.Count > 0)
            {
                //dg.Columns[0].HeaderText = "شماره قرارداد";
                //dg.Columns[0].Width = 60;
                dg.Columns[0].Visible = false;
                dg.Columns[1].HeaderText = "تاریخ شروع قرارداد";
                dg.Columns[1].Width = 87;
                dg.Columns[2].HeaderText = "تاریخ پایان قرارداد";
                dg.Columns[2].Width = 87;
                dg.Columns[3].HeaderText = "حق بیمه";
                dg.Columns[3].Width = 58;
                dg.Columns[4].HeaderText = "حق جذب";
                dg.Columns[4].Width = 56;
                dg.Columns[5].HeaderText = "حق مسکن";
                dg.Columns[5].Width = 58;
                dg.Columns[6].HeaderText = "حق اولاد";
                dg.Columns[6].Width = 58;
                dg.Columns[7].HeaderText = "پایه حقوق";
                dg.Columns[7].Width = 61;
                dg.Columns[8].HeaderText = "پایه حقوق ساعتی";
                dg.Columns[8].Width = 71;
                dg.Columns[9].HeaderText = "پایه حقوق روزانه";
                dg.Columns[9].Width = 93;
                dg.Columns[10].HeaderText = "مالیات";
                dg.Columns[10].Width = 55;
                dg.Columns[11].Visible = false;
            }
        }

        private void frmAgreementDetail_Load(object sender, EventArgs e)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj =
                new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();

            dt_Worker = new DataTable();
            dt_Worker = obj.worker_Select_ByID(prop_WorkerID);

            dt_AgreementDetail = obj.AgreementDetail_Select_ByFKworkerID(prop_WorkerID);
            this.SetHeaderAgreementDetail(kryptonDataGridView1, dt_AgreementDetail);

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
  
            chbox_basepayment.Focus();
        }

        private void chBox_basepay_hour_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_basepay_hour.Checked)
            {
                numbase_payhourFee.Enabled = true;   
            }
            else
            {
                numbase_payhourFee.Enabled = false;
                numbase_payhourFee.Value = 0; 
            }
        }

        private void chBox_base_extra_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_base_extra.Checked)
            {
                num_payextra_Fee.Enabled = true;
            }
            else
            {
                num_payextra_Fee.Enabled = false;
                num_payextra_Fee.Value = 0;
            }
        }

        private void chBox_haghjazb_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_haghjazb.Checked)
            {
                num_haghjazbFee.Enabled = true;
            }
            else
            {
                num_haghjazbFee.Enabled = false;
                num_haghjazbFee.Value = 0;
            }
        }

        private void chBox_children_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_children.Checked)
            {
                num_children_Fee.Enabled = true;
            }
            else
            {
                num_children_Fee.Enabled = false;
                num_children_Fee.Value = 0;
            }
        }

        private void chBox_maskan_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_maskan.Checked)
            {
                num_maskanFee.Enabled = true;
            }
            else
            {
                num_maskanFee.Enabled = false;
                num_maskanFee.Value = 0;
            }
        }

        private void chBox_bime_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_bime.Checked)
            {
                num_bimeFee.Enabled = true;
            }
            else
            {
                num_bimeFee.Enabled = false;
                num_bimeFee.Value = 0;
            }
        }

        private void chBox_bon_karmandi_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_Tax.Checked)
            {
                num_Tax.Enabled = true;
            }
            else
            {
                num_Tax.Enabled = false;
                num_Tax.Value = 0;
            }
        }

        private void chkbox_basepayment_CheckedChanged(object sender, EventArgs e)
        {
            if (chbox_basepayment.Checked)
            {
                num_basepaymentFee.Enabled = true;
            }
            else
            {
                num_basepaymentFee.Enabled = false;
                num_basepaymentFee.Value = 0;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj =
                new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();
            
            if (amr_StartDate.SelectedDate != null & amr_FinishDate.SelectedDate != null
                & chbox_basepayment.Checked &(chbox_basepayment.Checked || chBox_basepay_hour.Checked || chBox_base_extra.Checked
                || chBox_haghjazb.Checked || chBox_maskan.Checked ||chBox_bime.Checked ||chBox_Tax.Checked || chBox_children.Checked))
            {
                this.startDate = amr_StartDate.SelectedDate.Value;
                this.finshDate = amr_FinishDate.SelectedDate.Value;
                this.base_payment = System.Convert.ToInt64(num_basepaymentFee.Value);
                this.base_paymenthour = System.Convert.ToInt64(numbase_payhourFee.Value);
                this.base_payment_extre = System.Convert.ToInt64(num_payextra_Fee.Value);
                this.hagh_jazb = System.Convert.ToInt64(num_haghjazbFee.Value);
                this.hagh_maskan = System.Convert.ToInt64(num_maskanFee.Value);
                this.hagh_bime = System.Convert.ToInt64(num_bimeFee.Value);
                this.tax = System.Convert.ToInt64(num_Tax.Value);
                this.hagh_owlad = System.Convert.ToInt64(num_children_Fee.Value);        

                obj.AgreementDetailInsert(this.startDate, this.finshDate, this.hagh_bime, this.hagh_jazb
                    , this.hagh_maskan, this.hagh_owlad, this.base_payment, this.base_paymenthour
                    , this.base_payment_extre, this.tax, prop_WorkerID);

                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("اطلاعات با موفقیت ثبت شد!");
                
                dt_AgreementDetail = obj.AgreementDetail_Select_ByFKworkerID(prop_WorkerID);
                this.SetHeaderAgreementDetail(kryptonDataGridView1, dt_AgreementDetail);
                btnRegister.Enabled = false;
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("اطلاعات ضروری را وارد کنید!"); 
            }        
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj =
                new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();

            frmAgreementDetailEdit AgreementDetailEdit = new frmAgreementDetailEdit();

            //****** set Lables for frmAgreementDetailEdit *********

            DataTable dt = obj.worker_Select_ByID(prop_WorkerID);
            AgreementDetailEdit.prop_getWorkerID = System.Convert.ToInt64(dt.Rows[0][0].ToString());
            AgreementDetailEdit.prop_getWorkername = dt.Rows[0][1].ToString();
            AgreementDetailEdit.prop_getWorkerfamily = dt.Rows[0][2].ToString();

            //End of//******* set Lables for frmAgreementDetailEdit*****
            
            if (kryptonDataGridView1.SelectedRows.Count != 0)
            {
                AgreementDetailEdit.prop_IsAgreementEdit = true;
                AgreementDetailEdit.prop_AgreementID = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[0].Value);
                AgreementDetailEdit.prop_startDate = System.Convert.ToDateTime(kryptonDataGridView1.SelectedRows[0].Cells[1].Value);
                AgreementDetailEdit.prop_FinishDate = System.Convert.ToDateTime(kryptonDataGridView1.SelectedRows[0].Cells[2].Value);
                AgreementDetailEdit.prop_HaghBime = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[3].Value);
                AgreementDetailEdit.prop_HaghJazb = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[4].Value);
                AgreementDetailEdit.prop_HaghMaskan = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[5].Value);
                AgreementDetailEdit.prop_HaghOwlad = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[6].Value);
                AgreementDetailEdit.prop_basepayment = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[7].Value);
                AgreementDetailEdit.prop_basepayhour = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[8].Value);
                AgreementDetailEdit.prop_basepayextra = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[9].Value);
                AgreementDetailEdit.prop_Tax = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[10].Value);
                AgreementDetailEdit.prop_WorkerID = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[11].Value);

                AgreementDetailEdit.FormClosed += new FormClosedEventHandler(AgreementDetailEdit_FormClosed);
                AgreementDetailEdit.ShowDialog();
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً ردیف حکم مورد نظر را انتخاب کنید!");
            }
        }

        void AgreementDetailEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj =
               new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();

            dt_AgreementDetail = obj.AgreementDetail_Select_ByFKworkerID(prop_WorkerID);
            this.SetHeaderAgreementDetail(kryptonDataGridView1, dt_AgreementDetail);
        }

        private void chbox_basepayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chbox_basepayment.Checked)
                {
                    num_basepaymentFee.Select();
                }
                else
                {
                    chBox_basepay_hour.Focus();
                }
            }
        }

        private void num_basepaymentFee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                chBox_basepay_hour.Focus();
            }
        }

        private void chBox_basepay_hour_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chBox_basepay_hour.Checked)
                {
                    numbase_payhourFee.Select();
                }
                else
                {
                    chBox_base_extra.Focus();
                }
            }
        }

        private void numbase_payhourFee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                chBox_base_extra.Focus();
            }
        }

        private void chBox_base_extra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chBox_base_extra.Checked)
                {
                    num_payextra_Fee.Select();
                }
                else
                {
                    chBox_haghjazb.Focus();
                }
            }
        }

        private void num_payextra_Fee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                chBox_haghjazb.Focus();
            }
        }

        private void chBox_maskan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chBox_maskan.Checked)
                {
                    num_maskanFee.Select();
                }
                else
                {
                    chBox_bime.Focus();
                }
            }
        }

        private void num_maskanFee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                chBox_bime.Focus();
            }
        }

        private void chBox_bime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chBox_bime.Checked)
                {
                    num_bimeFee.Select();
                }
                else
                {
                    chBox_Tax.Focus();
                }
            }
        }

        private void num_bimeFee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                chBox_Tax.Focus();
            }
        }

        private void chBox_bon_karmandi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chBox_Tax.Checked)
                {
                    num_Tax.Select();
                }
                else
                {
                    chBox_children.Focus();
                }
            }
        }

        private void num_bonkarmandi_Fee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                chBox_children.Focus();
            }
        }

        private void chBox_haghjazb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chBox_haghjazb.Checked)
                {
                    num_haghjazbFee.Select();
                }
                else
                {
                    chBox_maskan.Focus();
                }
            }
        }

        private void num_haghjazbFee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                chBox_maskan.Focus();
            }
        }

        private void chBox_children_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (chBox_children.Checked)
                {
                    num_children_Fee.Select();
                }
                else
                {
                    amr_StartDate.Focus();
                }
            }
        }

        private void faDatePicker_StartDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                amr_FinishDate.Focus();
            }
        }

        private void faDatePicker_FinishDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnRegister.Select();
            }
        }

        private void num_children_Fee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                amr_StartDate.Focus();
            }
        }

        private void btnHokm_Click(object sender, EventArgs e)
        {

            if (kryptonDataGridView1.SelectedRows.Count != 0)
            {
                frmSalary obj = new frmSalary();
                obj.prop_WorkerID = System.Convert.ToInt64(lbl_ID.Text);
                obj.prop_Workername = lbl_name.Text;
                obj.prop_Workerfamily = lbl_family.Text;
                obj.prop_melliCode = lbl_MelliCode.Text;
                obj.prop_IDNo = lbl_IDNo.Text;
                obj.prop_fatherName = lbl_FatherName.Text;
                obj.prop_AgreementID = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[0].Value);
                obj.prop_HaghJazb = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[4].Value);
                obj.prop_HaghMaskan = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[5].Value);
                obj.prop_KasrBime = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[3].Value);
                obj.prop_KasrMaliat = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[10].Value);
                obj.prop_HaghOwlad = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[6].Value);
                obj.prop_basepayment = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[7].Value);
                obj.prop_basepayhour = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[8].Value);
                obj.prop_basepayDaily = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[9].Value);
                //obj.prop_workerImage = kryptonDataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                
                obj.ShowDialog();
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً ردیف قرارداد مورد نظر را انتخاب کنید!");
            }
        }

    }
}
