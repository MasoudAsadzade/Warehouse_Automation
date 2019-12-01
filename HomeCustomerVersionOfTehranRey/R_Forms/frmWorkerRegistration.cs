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
    public partial class frmWorkerRegistration : Form
    {
        string name;
        string family;
        string refferer;
        string phone;
        string address;
        string melliCode;
        string IDNo;
        string fatherName;
        long id;
        long lastWorkerID;

        DataTable dt_Worker;

        public frmWorkerRegistration()
        {
            InitializeComponent();
        }
        public string prop_Workername { get; set; }
        public string prop_Workerfamily { get; set; }
        public string prop_refername { get; set; }
        public string prop_phone { get; set; }
        public string prop_workeraddress { get; set; }
        public string prop_melliCode { get; set; }
        public string prop_IDNo { get; set; }
        public string prop_fatherName { get; set; }
        public long prop_WorkerID { get; set; }
        public bool prop_IsEdit { get; set; }
        public bool prop_IsFined { get; set; }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtFamily.Text == "" || txtAddress.Text == "" || txtPhoneNumber.Text == "" ||txtphotoAddress.Text == "")
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً اطلاعات ضروری را وارد کنید!");
                txtName.Focus();
            }
            else
            {
                HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj =
                 new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer(); 

                this.id = prop_WorkerID;
                this.name = txtName.Text;
                this.family = txtFamily.Text;
                this.refferer = txtReferrerName.Text;
                this.phone = txtPhoneNumber.Text;
                this.address = txtAddress.Text;
                this.melliCode = txtMelliCode.Text;
                this.IDNo = txtIDNo.Text;
                this.fatherName = txtFatherName.Text;
                
               
                MemoryStream ms = new MemoryStream();
                picbox_worker.Image.Save(ms, picbox_worker.Image.RawFormat);
                byte[] arrImage = ms.GetBuffer();
                ms.Close();
                
                File.Delete(Application.StartupPath + "\\WorkersPhoto\\" + id + ".IFO");
                picbox_worker.Image.Save(Application.StartupPath + "\\WorkersPhoto\\" + id + ".IFO");
                

                obj.WorkerUpdate(this.id, this.name, this.family, this.refferer, this.phone,
                    this.address, chk_Fined.Checked, arrImage, this.melliCode, this.IDNo, this.fatherName);
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("اطلاعات با موفقیت تصحیح شد!");
                this.Close();
            }
        }

        private void btnbrows_Click(object sender, EventArgs e)
        {
            if (openPhotoDialog.ShowDialog() == DialogResult.OK)
            {
                picbox_worker.Image = Image.FromFile(openPhotoDialog.FileName);
                picbox_worker.SizeMode = PictureBoxSizeMode.StretchImage;
                picbox_worker.BorderStyle = BorderStyle.Fixed3D;
                txtphotoAddress.Text = openPhotoDialog.FileName;
            }
        }

        private void frmWorkerRegistration_Load(object sender, EventArgs e)
        {
            if (this.prop_IsEdit)
            {
                this.Text = "اصلاح اطلاعات کارمند";
                btnEdit.Visible = this.prop_IsEdit;
                btnAdd.Visible = !this.prop_IsEdit;
                chk_Fined.Visible = this.prop_IsEdit;

                HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj =
                new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();

                dt_Worker = new DataTable();
                dt_Worker = obj.worker_Select_ByID(prop_WorkerID);
                txtName.Text = prop_Workername.ToString();
                txtFamily.Text = prop_Workerfamily.ToString();
                txtReferrerName.Text = prop_refername.ToString();
                txtPhoneNumber.Text = prop_phone.ToString();
                txtAddress.Text = prop_workeraddress.ToString();
                txtMelliCode.Text = prop_melliCode.ToString();
                txtIDNo.Text = prop_IDNo.ToString();
                txtFatherName.Text = prop_fatherName.ToString();
                txtName.Select();
                chk_Fined.Checked = prop_IsFined;
                if (File.Exists(Application.StartupPath + "\\WorkersPhoto\\" + prop_WorkerID + ".IFO"))
                {
                    picbox_worker.Image = Image.FromFile(Application.StartupPath + "\\WorkersPhoto\\" + prop_WorkerID + ".IFO");
                    picbox_worker.SizeMode = PictureBoxSizeMode.StretchImage;
                    picbox_worker.BorderStyle = BorderStyle.Fixed3D;
                    //txtphotoAddress.Text = Text.Replace("",Application.StartupPath + "\\WorkersPhoto\\" + prop_WorkerID + ".IFO");
                }
                else
                {
                    picbox_worker.Image.Save(Application.StartupPath + "\\WorkersPhoto\\" + id + ".IFO");
                }
                
                
            }
            else
            {
                this.Text = "ثبت کارمند جدید ";
                btnEdit.Visible = this.prop_IsEdit;
                btnAdd.Visible = !this.prop_IsEdit;
                txtName.Select();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtFamily.Text == "" || txtAddress.Text == "" || txtPhoneNumber.Text == "" || txtphotoAddress.Text == "")
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً اطلاعات ضروری را وارد کنید!");
                txtName.Focus();
            }
            else
            {
                this.name = txtName.Text;
                this.family = txtFamily.Text;
                this.refferer = txtReferrerName.Text;
                this.phone = txtPhoneNumber.Text;
                this.address = txtAddress.Text;
                this.melliCode = txtMelliCode.Text;
                this.IDNo = txtIDNo.Text;
                this.fatherName = txtFatherName.Text;

                MemoryStream ms = new MemoryStream();
                picbox_worker.Image.Save(ms, picbox_worker.Image.RawFormat);
                byte[] arrImage = ms.GetBuffer();
                ms.Close();

                

                HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj = new
                    HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();

                obj.WorkerInsert(this.name, this.family, this.refferer, this.phone,
                    this.address, arrImage , this.melliCode , this.IDNo , this.fatherName);
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("اطلاعات کارمند ثبت شد!");

                this.lastWorkerID = obj.tblWorker_Select_Max_WorkerID();
                this.Close();
                frmAgreementDetail obj1 = new frmAgreementDetail();
                obj1.prop_WorkerID = this.lastWorkerID;
                obj1.prop_Workername = txtName.Text;
                obj1.prop_Workerfamily = txtFamily.Text;
                obj1.prop_melliCode = txtMelliCode.Text;
                obj1.prop_IDNo = txtIDNo.Text;
                obj1.prop_fatherName = txtFatherName.Text;
                picbox_worker.Image.Save(Application.StartupPath + "\\WorkersPhoto\\" + lastWorkerID + ".IFO");
                obj1.ShowDialog();
                
            }           
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtFamily.Select();
            }
        }

        private void txtFamily_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtReferrerName.Select();
            }
        }

        private void txtReferrerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtPhoneNumber.Select();
            }
        }

        private void txtPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtMelliCode.Select();
            }
        }

        private void txtMelliCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtIDNo.Select();
            }
        }

        private void txtIDNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtFatherName.Select();
            }
        }

        private void txtFatherName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtAddress.Select();
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnbrows.Select();
            }
        }

        private void txtphotoAddress_TextChanged(object sender, EventArgs e)
        {
            if (this.prop_IsEdit)
            {
                btnEdit.Select();
            }
            else
            {
                btnAdd.Select(); 
            }
             
        }
    }
}
