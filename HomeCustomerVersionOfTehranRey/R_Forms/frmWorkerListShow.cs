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

    public partial class frmWorkerListShow : Form
    {
        DataTable dt;
        byte[] arrImage;

        public frmWorkerListShow()
        {
            InitializeComponent();
        }

        public string prop_Workername { get; set; }
        public string prop_Workerfamily { get; set; }
        public byte[] prop_Workerimage { get; set; }

        private DataTable FindByID(string code)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj
              = new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();
            DataTable temp = new DataTable();
            
            if (txtCode.Text != "")
            {
                long workerid = System.Convert.ToInt64(code);
                temp = obj.worker_Select_ByID(workerid);
                return temp; 
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً کد شناسه را وارد کنید!");
                return obj.WorkerSelect();
            }
        }

        private DataTable FindByName(string name, string family)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj =
                new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();
            DataTable temp = new DataTable();
            if (txtFamily.Text != "" & txtName.Text != "")
            {
                temp = obj.worker_Select_ByName_Family(name, family);
                return temp;
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً نام و نام خانوادگی کارمند را وارد کنید!" ,"اخطار");
                return obj.WorkerSelect();
            }
        }

        /// <summary>
        /// For Set Farsi Header In DataGridView For Workers
        /// </summary>
        /// <param name="dg">dg is DataGridView</param>
        /// <param name="dt">dt is Datatable</param>
        private void Set_HeaderWorkerListShow(DataGridView dg, DataTable dt)
        {
            dg.DataSource = dt;
            dg.DataMember = dt.TableName;
            if (dt.Rows.Count > 0)
            {
                dg.Columns[0].HeaderText = "کد کارمندی";
                dg.Columns[0].Width = 60;
                dg.Columns[1].HeaderText = "نام";
                dg.Columns[1].Width = 80;
                dg.Columns[2].HeaderText = "نام خانوادگی";
                dg.Columns[2].Width = 110;
                dg.Columns[3].HeaderText = "معرف";
                dg.Columns[3].Width = 80;
                dg.Columns[4].HeaderText = "تلفن";
                dg.Columns[4].Width = 100;
                dg.Columns[5].HeaderText = "آدرس";
                dg.Columns[5].Width = 172;
                dg.Columns[6].Visible = false;
                dg.Columns[6].HeaderText = "اخراجی";
                dg.Columns[6].Width = 65;
                dg.Columns[7].Visible = false;
                dg.Columns[7].HeaderText = "عکس پرسنلی";
                dg.Columns[7].Width = 65;
                dg.Columns[8].Visible = false;
                dg.Columns[8].HeaderText = "کد ملی";
                dg.Columns[8].Width = 65;
                dg.Columns[9].Visible = false;
                dg.Columns[9].HeaderText = "شماره شناسنامه";
                dg.Columns[9].Width = 75;
                dg.Columns[10].Visible = false;
                dg.Columns[10].HeaderText = "نام پدر";
                dg.Columns[10].Width = 65;
            }         
        }

        private void frmWorkerListShow_Load(object sender, EventArgs e)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj =
                new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();

            DataTable dt = new DataTable();
            dt = obj.WorkerSelect();
            this.Set_HeaderWorkerListShow(kryptonDataGridView1, dt);
            this.txtCode.Select();    
        }

        private void rdbID_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbID.Checked)
            {
                txtCode.Select();
                panelName.Visible = false;
                panel_CustomerCode.Visible = true;
            }
            if (rdbName.Checked)
            {
                txtName.Select();
                panel_CustomerCode.Visible = false;
                panelName.Visible = true;
            }
        }

        private void rdbName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbName.Checked)
            {
                txtName.Select();
                panelName.Visible = true;
                panel_CustomerCode.Visible = false;
            }
            if (rdbID.Checked)
            {
                txtCode.Select();
                panel_CustomerCode.Visible = true;
                panelName.Visible = false;
            }
        }

        private void btnHomeCustomerRegisteration_Click(object sender, EventArgs e)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj1 =
                new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();
            
            frmWorkerRegistration obj = new frmWorkerRegistration();
            
            obj.ShowDialog();
            DataTable temp = new DataTable();
            temp = obj1.WorkerSelect();
            Set_HeaderWorkerListShow(kryptonDataGridView1, temp);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable Worker = new DataTable();

            if (rdbID.Checked)
            {
                Worker = this.FindByID(txtCode.Text);
                Set_HeaderWorkerListShow(kryptonDataGridView1, Worker);
                if (Worker.Rows.Count == 0)
                {
                    Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("هیچ موردی یافت نشد!"); 
                }   
            }

            if (rdbName.Checked)
            {
                Worker = this.FindByName(this.txtName.Text, this.txtFamily.Text);
                Set_HeaderWorkerListShow(kryptonDataGridView1, Worker);
                if (Worker.Rows.Count == 0)
                {
                    Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("هیچ موردی یافت نشد!");
                }
            }
        }

        private void btnShowCarpetList_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.SelectedRows.Count != 0)
            {
                frmAgreementDetail obj = new frmAgreementDetail();
                
                string index = kryptonDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                obj.prop_WorkerID = System.Convert.ToInt64(index);
                obj.prop_Workername = kryptonDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                obj.prop_Workerfamily = kryptonDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                obj.prop_melliCode = kryptonDataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                obj.prop_IDNo = kryptonDataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                obj.prop_fatherName = kryptonDataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                //obj.prop_workerImage = kryptonDataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                
                obj.ShowDialog();
            }
            else
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً ردیف کارمند مورد نظر را انتخاب کنید!");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Microgod.AmrComponent.AmrAssistanteForms.frmWaiting.ShowWaiting();

            HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj
                = new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();
           
            DataTable temp = obj.WorkerSelect();
            this.Set_HeaderWorkerListShow(kryptonDataGridView1, temp);
            if (temp.Rows.Count != 0)
            {
                dt = new DataTable();
                dt.Merge(obj.WorkerSelect());
            }

            Microgod.AmrComponent.AmrAssistanteForms.frmWaiting.CloseWaiting();
        }

        private void btnFactor_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.SelectedRows.Count != 0)
            {
                HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj1 =
                    new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();
                DataTable dt_AgreeDetail = new DataTable();
 
                frmSalary obj = new frmSalary();
                string workerID = kryptonDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                obj.prop_WorkerID = System.Convert.ToInt64(workerID);
                obj.prop_AgreementID = obj1.SelectLastAgreementDatail(obj.prop_WorkerID);
                dt_AgreeDetail = obj1.AgreementDetail_Select_ByFKworkerID(System.Convert.ToInt64(workerID));
                
                if (obj.prop_AgreementID != 0)
                {
                    obj.prop_Workername = kryptonDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    obj.prop_Workerfamily = kryptonDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    obj.prop_melliCode = kryptonDataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                    obj.prop_IDNo = kryptonDataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                    obj.prop_fatherName = kryptonDataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                    //obj.prop_workerImage = kryptonDataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    obj.prop_KasrBime = System.Convert.ToInt64(dt_AgreeDetail.Rows[0][3]);
                    obj.prop_HaghJazb = System.Convert.ToInt64(dt_AgreeDetail.Rows[0][4]);
                    obj.prop_HaghMaskan = System.Convert.ToInt64(dt_AgreeDetail.Rows[0][5]);
                    obj.prop_HaghOwlad = System.Convert.ToInt64(dt_AgreeDetail.Rows[0][6]);
                    obj.prop_basepayment = System.Convert.ToInt64(dt_AgreeDetail.Rows[0][7]);
                    obj.prop_basepayhour = System.Convert.ToInt64(dt_AgreeDetail.Rows[0][8]);
                    obj.prop_basepayDaily = System.Convert.ToInt64(dt_AgreeDetail.Rows[0][9]);
                    obj.prop_KasrMaliat = System.Convert.ToInt64(dt_AgreeDetail.Rows[0][10]);
                    obj.ShowDialog();
                }
                else
                {
                    Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("هیچ قراردادی برای کارمند مورد نظر تنظیم نشده است!");
                    frmAgreementDetail frmObj = new frmAgreementDetail();
                    frmObj.prop_WorkerID = System.Convert.ToInt64(workerID);
                    frmObj.prop_Workername = kryptonDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    frmObj.prop_Workerfamily = kryptonDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    frmObj.prop_melliCode = kryptonDataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                    frmObj.prop_IDNo = kryptonDataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                    frmObj.prop_fatherName = kryptonDataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                    //frmObj.prop_workerImage = kryptonDataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    frmObj.ShowDialog();
                }
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً ردیف کارمند مورد نظر را انتخاب کنید!");
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            
            HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj =
                new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();

            if (kryptonDataGridView1.SelectedRows.Count != 0)
            {               
                frmWorkerRegistration obj1 = new frmWorkerRegistration();
                obj1.prop_IsEdit = true;
                obj1.prop_WorkerID = System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[0].Value);
                obj1.prop_Workername = kryptonDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                obj1.prop_Workerfamily = kryptonDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                obj1.prop_refername = kryptonDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                obj1.prop_phone = kryptonDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                obj1.prop_workeraddress = kryptonDataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                obj1.prop_melliCode = kryptonDataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                obj1.prop_IDNo = kryptonDataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                obj1.prop_fatherName = kryptonDataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                obj1.prop_IsFined = System.Convert.ToBoolean(kryptonDataGridView1.SelectedRows[0].Cells[6].Value);


                obj1.FormClosed += new FormClosedEventHandler(obj1_FormClosed);
                obj1.ShowDialog();
            }
            else
            {
                Microgod.AmrComponent.AmrAssistanteForms.Amr_MessageBox_Farsi.MessageBox_Farsi.Show("لطفاً ردیف کارمند مورد نظر را انتخاب کنید!");
            }
        }

        void obj1_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj =
               new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();

            DataTable dt = new DataTable();
            dt = obj.WorkerSelect();
            this.Set_HeaderWorkerListShow(kryptonDataGridView1, dt);
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSearch.Select();
            }
        }

        private void txtFamily_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSearch.Select();
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtFamily.Select();
            }
        }

        public static byte[] getbytes(string text)
        {
            return ASCIIEncoding.UTF8.GetBytes(text);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Microgod.AmrComponent.AmrDynamicCrystal.frmReport obj
                = new Microgod.AmrComponent.AmrDynamicCrystal.frmReport(kryptonDataGridView1,"","");
            obj.ShowDialog();
        }

        private void kryptonDataGridView1_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.SelectedRows.Count != 0)
            {
                picbox_worker.Visible = true;
                long id =
                        System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[0].Value);

                if (File.Exists(Application.StartupPath + "\\WorkersPhoto\\" + id + ".IFO"))
                {
                    picbox_worker.Image = Image.FromFile(Application.StartupPath + "\\WorkersPhoto\\" + id + ".IFO");
                    picbox_worker.SizeMode = PictureBoxSizeMode.StretchImage;
                    picbox_worker.BorderStyle = BorderStyle.Fixed3D;
                }
                else
                {
                    picbox_worker.Visible = false;

                }
            }
            else
            {
                picbox_worker.Visible = false;
            }
            //HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer obj =
            //    new HomeCustomerVersionOfTehranRey.Classes.clsWorkerManagment_DataAccessLayer();

            //DataSet dsImg = new DataSet();
            //DataTable dt2 = new DataTable();

            //if (kryptonDataGridView1.SelectedRows.Count != 0)
            //{
            //    long index =
            //        System.Convert.ToInt64(kryptonDataGridView1.SelectedRows[0].Cells[0].Value);
            //    dt = obj.worker_Select_ByID(index);
            //    //dt2.Columns.Add(new DataColumn("Photo", typeof(System.Byte[])));
            //    //dt2.Rows.Add(kryptonDataGridView1.SelectedRows[0].Cells[7].Value);
            //    //dsImg.Tables.Add(dt2);
            //    //dsImg.Tables["dt2"].Rows.Add(dt.Rows[0][7]);
            //    //byte[] arrImage = getbytes(dt.Rows[0][7].ToString());
            //    object dtobj = dt.Rows[0][7];
            //   // System.Byte[] arrImage = ((System.Byte[])(dsImg.Tables["dt2"].Rows[0]["Photo"]));
            //    System.Byte[] arrImage = ((System.Byte[])(dt.Rows[0][7]));
            //    MemoryStream ms = new MemoryStream(arrImage);
            //    ////ms.Write();
            //    //ms.Write( kryptonDataGridView1.SelectedRows[0].Cells[1].Value;
            //    ////ms.SaveToFile "c:\publogo.gif", adSaveCreateOverWrite;
            //    //ms.WriteTo("c:\publogo.gif");
            //    //ms.ToString();
            //    //picbox_worker.Image = Image.FromFile("c:\publogo.gif");

            //    picbox_worker.Image = Image.FromStream(ms);
            //    picbox_worker.SizeMode = PictureBoxSizeMode.StretchImage;
            //    picbox_worker.BorderStyle = BorderStyle.Fixed3D;
            //    ms.Close();
            //}

            
        }
    }
}
