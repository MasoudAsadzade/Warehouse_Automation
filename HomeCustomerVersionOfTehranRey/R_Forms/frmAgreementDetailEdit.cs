using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HomeCustomerVersionOfTehranRey.R_Forms
{
    public partial class frmAgreementDetailEdit : Form
    {
        DateTime startDate;
        DateTime finshDate;
        DateTime recievDate;
        long AgreementID;
        long base_payment;
        long base_paymenthour;
        long base_payment_extre;
        long hagh_jazb;
        long hagh_maskan;
        long hagh_bime;
        long tax;
        long hagh_owlad;
        int workDay;
        int workHour;
        long mosaedeh;
        long bonKarmandi;

        public frmAgreementDetailEdit()
        {
            InitializeComponent();
        }

        public DateTime prop_startDate { get; set; }
        public DateTime prop_FinishDate { get; set; }
        public DateTime prop_RecieveDate { get; set; }
        public long prop_getWorkerID { get; set; }
        public string prop_getWorkername { get; set; }
        public string prop_getWorkerfamily { get; set; }
        public long prop_basepayment { get; set; }
        public long prop_basepayhour { get; set; }
        public long prop_basepayextra { get; set; }
        public long prop_HaghMaskan { get; set; }
        public long prop_HaghJazb { get; set; }
        public long prop_HaghBime { get; set; }
        public long prop_Tax { get; set; }
        public long prop_HaghOwlad { get; set; }
        public long prop_AgreementID { get; set; }
        public long prop_WorkerID { get; set; }
        public bool prop_IsAgreementEdit { get; set; }
        public int prop_WorkHour { get; set; }
        public int prop_WorkDay { get; set; }
        public long prop_RecieveMoney { get; set; }
        public long prop_Mosaedeh { get; set; }
        public long prop_BonKarmandi { get; set; }
        public long prop_SalaryID { get; set; }
      
        private void frmAgreementDetailEdit_Load(object sender, EventArgs e)
        {
            lblWorkerID.Text = prop_getWorkerID.ToString();
            lblWorkerName.Text = prop_getWorkername.ToString();
            lbWorkerFamily.Text = prop_getWorkerfamily.ToString();

            if  (this.prop_IsAgreementEdit)
            {
                Panel_CurrentMonth.Visible = false;
                this.amr_StartDate.SelectedDate = prop_startDate;
                this.amr_FinishDate.SelectedDate = prop_FinishDate;
                this.num_basepaymentFee.Value = prop_basepayment;
                this.numbase_payhourFee.Value = prop_basepayhour;
                this.num_payextra_Fee.Value = prop_basepayextra;
                this.num_haghjazbFee.Value = prop_HaghJazb;
                this.num_maskanFee.Value = prop_HaghMaskan;
                this.num_bimeFee.Value = prop_HaghBime;
                this.num_Tax.Value = prop_Tax;
                this.num_children_Fee.Value = prop_HaghOwlad;
                

                if (num_basepaymentFee.Value != 0)
                {
                    num_basepaymentFee.Enabled = true;
                    chbox_basepayment.Checked = true;
                }
                else
                {
                    num_basepaymentFee.Enabled = false;    
                }

                if (numbase_payhourFee.Value != 0)
                {
                    numbase_payhourFee.Enabled = true;
                    chBox_basepay_hour.Checked = true;
                }
                else
                {
                    numbase_payhourFee.Enabled = false;
                }

                if (num_payextra_Fee.Value != 0)
                {
                    num_payextra_Fee.Enabled = true;
                    chBox_base_extra.Checked = true;
                }
                else
                {
                    num_payextra_Fee.Enabled = false;
                }

                if (num_haghjazbFee.Value != 0)
                {
                    num_haghjazbFee.Enabled = true;
                    chBox_haghjazb.Checked = true;
                }
                else
                {
                    num_haghjazbFee.Enabled = false;
                }

                if (num_maskanFee.Value != 0)
                {
                    num_maskanFee.Enabled = true;
                    chBox_maskan.Checked = true;
                }
                else
                {
                    num_maskanFee.Enabled = false;
                }

                if (num_bimeFee.Value != 0)
                {
                    num_bimeFee.Enabled = true;
                    chBox_bime.Checked = true;
                }
                else
                {
                    num_bimeFee.Enabled = false;
                }

                if (num_Tax.Value != 0)
                {
                    num_Tax.Enabled = true;
                    chBox_Tax.Checked = true;
                }
                else
                {
                    num_Tax.Enabled = false;
                }

                if (num_children_Fee.Value != 0)
                {
                    num_children_Fee.Enabled = true;
                    chBox_children.Checked = true;
                }
                else
                {
                    num_children_Fee.Enabled = false;
                }
            }
            else
            {
                this.Text = "تصحیح جزئیات ماه جاری";
                panel_AgreementDetail.Visible = false;
                Panel_CurrentMonth.Visible = true;
                this.Width = 436;  
                this.num_WorkHour.Value = prop_WorkHour;
                this.num_WorkDay.Value = prop_WorkDay;
                this.num_Mosaede.Value = prop_Mosaedeh;
                this.num_BonKarmandi.Value = prop_BonKarmandi;
                this.amr_RecieveDate.SelectedDate = prop_RecieveDate;
                
                if (num_WorkHour.Value != 0)
                {
                    num_WorkHour.Enabled = true;
                    chbox_WorkHour.Checked = true;
                }
                else
                {
                    num_WorkHour.Enabled = false;
                }

                if (num_WorkDay.Value != 0)
                {
                    num_WorkDay.Enabled = true;
                    chBox_WorkDay.Checked = true;
                }
                else
                {
                    num_WorkDay.Enabled = false;
                }

                if (num_Mosaede.Value != 0)
                {
                    num_Mosaede.Enabled = true;
                    chBox_Mosaede.Checked = true;
                }
                else
                {
                    num_Mosaede.Enabled = false;
                }

                if (num_BonKarmandi.Value != 0)
                {
                    num_BonKarmandi.Enabled = true;
                    chBox_BonKarmandi.Checked = true;
                }
                else
                {
                    num_BonKarmandi.Enabled = false;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj =
                new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();

            if (this.prop_IsAgreementEdit)
            {
                if (amr_StartDate.SelectedDate != null & amr_FinishDate.SelectedDate != null
                    & chbox_basepayment.Checked & (chbox_basepayment.Checked || chBox_basepay_hour.Checked || chBox_base_extra.Checked
                    || chBox_haghjazb.Checked || chBox_maskan.Checked || chBox_bime.Checked || chBox_Tax.Checked || chBox_children.Checked))
                {
                    this.startDate = amr_StartDate.SelectedDate.Value;
                    this.finshDate = amr_FinishDate.SelectedDate.Value;
                    this.AgreementID = prop_AgreementID;
                    this.base_payment = System.Convert.ToInt64(num_basepaymentFee.Value);
                    this.base_paymenthour = System.Convert.ToInt64(numbase_payhourFee.Value);
                    this.base_payment_extre = System.Convert.ToInt64(num_payextra_Fee.Value);
                    this.hagh_jazb = System.Convert.ToInt64(num_haghjazbFee.Value);
                    this.hagh_maskan = System.Convert.ToInt64(num_maskanFee.Value);
                    this.hagh_bime = System.Convert.ToInt64(num_bimeFee.Value);
                    this.tax = System.Convert.ToInt64(num_Tax.Value);
                    this.hagh_owlad = System.Convert.ToInt64(num_children_Fee.Value);

                    obj.AgreementDetailUpdate(this.AgreementID, this.startDate, this.finshDate, this.hagh_bime, this.hagh_jazb
                        , this.hagh_maskan, this.hagh_owlad, this.base_payment, this.base_paymenthour
                        , this.base_payment_extre, this.tax, prop_WorkerID);

                    Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("اطلاعات با موفقیت ثبت شد!");
                    this.Close();
                }
                else
                {
                    Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("اطلاعات ضروری را وارد کنید!");
                }    
            }
            else
            {
                if (amr_RecieveDate.SelectedDate != null
                    &(chBox_WorkDay.Checked || chbox_WorkHour.Checked || 
                       chBox_BonKarmandi.Checked ||chBox_Mosaede.Checked))
                    {
                        this.recievDate = amr_RecieveDate.SelectedDate.Value;
                        this.workDay = System.Convert.ToInt16(num_WorkDay.Value);
                        this.workHour = System.Convert.ToInt16(num_WorkHour.Value);
                        this.mosaedeh = System.Convert.ToInt64(num_Mosaede.Value);
                        this.bonKarmandi = System.Convert.ToInt64(num_BonKarmandi.Value); 
                       obj.WorkerSalaryUpdate(prop_SalaryID ,this.workHour , this.workDay , this.recievDate
                           ,this.mosaedeh , this.bonKarmandi , prop_AgreementID);
                    Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("اطلاعات با موفقیت ثبت شد!");
                    this.Close();
                    }
                else
                {
                    Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("اطلاعات ضروری را وارد کنید!");
                } 
            }             
        }

        private void chbox_basepayment_CheckedChanged(object sender, EventArgs e)
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

        private void chbox_basepayment_KeyDown_1(object sender, KeyEventArgs e)
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

        private void num_children_Fee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
               amr_FinishDate.Focus();
            }
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
                    amr_RecieveDate.Focus();
                }
            }
        }

        private void num_Mosaede_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
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
                amr_RecieveDate.Focus();
            }
        }
    }
}
