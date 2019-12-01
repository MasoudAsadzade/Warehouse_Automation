using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Configuration;

namespace HomeCustomerVersionOfTehranRey.Classes
{
    class clsWorkerManagment_DataAccessLayer
    {
        string connectionString = clsAccounting_DataAccessLayer.connectionstring;

        /// <summary>
        /// Insert Worker Details in tblWorker
        /// </summary>
        /// <param name="firstname">First Name</param>
        /// <param name="lastname">Last Name</param>
        /// <param name="referrername">Referer Name</param>
        /// <param name="phonenumber">Phone Number</param>
        /// <param name="address">Address</param>
        /// <param name="arrImage">Image of Worker</param>
        /// <param name="melliCode">Melli Code</param>
        /// <param name="ID_No">Identitifier Number</param>
        /// <param name="fatherName">Father Name</param>
        /// <returns></returns>
        public int WorkerInsert(string firstname, string lastname, string referrername,
             string phonenumber, string address, byte[] arrImage , string melliCode , string ID_No , string fatherName)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_InsertWorker", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters.Add("@family", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters.Add("@refferer", System.Data.SqlDbType.NVarChar, 50);
            command.Parameters.Add("@phone", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters.Add("@address", System.Data.SqlDbType.NVarChar, 250);
            command.Parameters.Add("@is_fined", System.Data.SqlDbType.Bit);
            command.Parameters.Add("@worker_image", System.Data.SqlDbType.Image);
            command.Parameters.Add("@melli_Code", System.Data.SqlDbType.NVarChar, 10);
            command.Parameters.Add("@ID_No", System.Data.SqlDbType.NVarChar, 15);
            command.Parameters.Add("@FatherName", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters[0].Value = firstname;
            command.Parameters[1].Value = lastname;
            command.Parameters[2].Value = referrername;
            command.Parameters[3].Value = phonenumber;
            command.Parameters[4].Value = address;
            command.Parameters[5].Value = false;
            command.Parameters[6].Value = arrImage;
            command.Parameters[7].Value = melliCode;
            command.Parameters[8].Value = ID_No;
            command.Parameters[9].Value = fatherName;
            command.ExecuteNonQuery();

            return (0);
        }
        /// <summary>
        /// Select * From tblWorker
        /// </summary>
        /// <returns>DataTable dt</returns>
        public DataTable WorkerSelect()
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_SelectWorker", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader dr = command.ExecuteReader();

            DataTable dt = new DataTable();
            if (dr.HasRows)
            {
               object[] obj = new object[dr.FieldCount];  
               for (int i = 0; i < dr.FieldCount; i++)
               {
                  dt.Columns.Add(dr.GetName(i));
               }
               while (dr.Read())
               {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        obj[i] = dr.GetValue(i);
                    }
                    dt.Rows.Add(obj);
               }
            }
          return dt;
        }

        /// <summary>
        /// This method select information of special Worker by his ID
        /// and return them in a DataTable
        /// </summary>
        /// <param name="id">ID of worker</param>
        /// <returns>DataTable dt</returns>
        public DataTable worker_Select_ByID(long id)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblWorker_ByID", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@WorkerID", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = id;

            SqlDataReader dr = command.ExecuteReader();

            DataTable dt = new DataTable();
            if (dr.HasRows)
            {
                object[] obj = new object[dr.FieldCount];
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    dt.Columns.Add(dr.GetName(i));
                }
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        obj[i] = dr.GetValue(i);
                    }
                    dt.Rows.Add(obj);
                }
            }
            return dt;
        }

        /// <summary>
        /// This method select information of special Worker by his Name and Family
        /// </summary>
        /// <param name="name">First Name</param>
        /// <param name="family">Last Name</param>
        /// <returns>DataTable</returns>
        public DataTable worker_Select_ByName_Family(string name, string family)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblWorker_ByName_Family", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar);
            command.Parameters.Add("@Family", System.Data.SqlDbType.NVarChar);
            command.Parameters[0].Value = name;
            command.Parameters[1].Value = family;
            SqlDataReader dr = command.ExecuteReader();

            DataTable dt = new DataTable();
            if (dr.HasRows)
            {
                object[] obj = new object[dr.FieldCount];
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    dt.Columns.Add(dr.GetName(i));
                }
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        obj[i] = dr.GetValue(i);
                    }
                    dt.Rows.Add(obj);
                }
            }
            return dt;
        }

        /// <summary>
        /// Update Details of Spetial Worker
        /// </summary>
        /// <param name="id">WorkerID</param>
        /// <param name="fname">FirstName</param>
        /// <param name="lname">Last Name</param>
        /// <param name="refname">Referer Name</param>
        /// <param name="phone">Phone Number</param>
        /// <param name="address">Address</param>
        /// <param name="is_fined">Boolean</param>
        /// <param name="arrImage">Image of Worker</param>
        /// <param name="melliCode">Melli Code</param>
        /// <param name="ID_No">Identifier Number</param>
        /// <param name="fatherName">Father Name</param>
        /// <returns>Integer</returns>
        public int WorkerUpdate(long id, string fname, string lname, string refname,
           string phone, string address, bool is_fined, byte[] arrImage, string melliCode, string ID_No, string fatherName)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_UpdateWorker", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@workID", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@fname", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters.Add("@lname", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters.Add("@refname", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters.Add("@phone", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters.Add("@address", System.Data.SqlDbType.NVarChar, 250);
            command.Parameters.Add("@is_fined", System.Data.SqlDbType.Bit);
            command.Parameters.Add("@worker_image", System.Data.SqlDbType.Image);
            command.Parameters.Add("@melli_Code", System.Data.SqlDbType.NVarChar, 10);
            command.Parameters.Add("@ID_No", System.Data.SqlDbType.NVarChar, 15);
            command.Parameters.Add("@FatherName", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters[0].Value = id;
            command.Parameters[1].Value = fname;
            command.Parameters[2].Value = lname;
            command.Parameters[3].Value = refname;
            command.Parameters[4].Value = phone;
            command.Parameters[5].Value = address;
            command.Parameters[6].Value = is_fined;
            command.Parameters[7].Value = arrImage;
            command.Parameters[8].Value = melliCode;
            command.Parameters[9].Value = ID_No;
            command.Parameters[10].Value = fatherName;
            command.ExecuteNonQuery();

            return (0);
        }



        /// <summary>
        /// Insert Agreement Details of Spetial Worker to tblAgreementDetail
        /// </summary>
        /// <param name="startDate">Start Date of Agreement for Working</param>
        /// <param name="finishDate">Finish Date of Agreement for Working</param>
        /// <param name="hagh_bime">Haghe Bime</param>
        /// <param name="hagh_jazb">Haghe Jazb</param>
        /// <param name="hagh_maskan">Haghe Maskan</param>
        /// <param name="hagh_owlad">Haghe Owlad</param>
        /// <param name="b_payment">Base Payment</param>
        /// <param name="b_payment_hour">Base Payment Hour</param>
        /// <param name="b_paymentextra">Base Payment Extra Working</param>
        /// <param name="tax">Tax For Recieving Money</param>
        /// <param name="FK_workerID">Foriegn Key For WorkerID</param>
        /// <returns>Integer</returns>
        public int AgreementDetailInsert(DateTime startDate , DateTime finishDate , long hagh_bime,
            long hagh_jazb,long hagh_maskan,long hagh_owlad,long b_payment,
            long b_payment_hour, long b_paymentextra, long tax, long FK_workerID)
        {
            SqlConnection cn = new SqlConnection(connectionString);
    
            cn.Open();
            SqlCommand command = new SqlCommand("sp_InsertAgreementDatail", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@S_date", System.Data.SqlDbType.DateTime);
            command.Parameters.Add("@F_date", System.Data.SqlDbType.DateTime);
            command.Parameters.Add("@Hagh_bime", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@Hagh_jazb", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@Hagh_maskan", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@Hagh_owlad", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@B_payment", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@B_payment_hour", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@B_payment_extra", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@Tax" , System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@FK_workerID", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = startDate;
            command.Parameters[1].Value = finishDate;
            command.Parameters[2].Value = hagh_bime;
            command.Parameters[3].Value = hagh_jazb;
            command.Parameters[4].Value = hagh_maskan;
            command.Parameters[5].Value = hagh_owlad;
            command.Parameters[6].Value = b_payment;
            command.Parameters[7].Value = b_payment_hour;
            command.Parameters[8].Value = b_paymentextra;
            command.Parameters[9].Value = tax;
            command.Parameters[10].Value = FK_workerID;
            command.ExecuteNonQuery();

            return (0);
        }
        /// <summary>
        /// Select tblAgreementDetail By Foreign Key of Spetial Worker
        /// </summary>
        /// <param name="FKworkerID">Foreign Key as a WorkerID</param>
        /// <returns>DataTable</returns>
        public DataTable AgreementDetail_Select_ByFKworkerID(long FKworkerID)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_SelectAgreementDatail_ByFKworkerID", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@FK_workerID", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = FKworkerID;
            SqlDataReader dr = command.ExecuteReader();

            DataTable dt = new DataTable();
            if (dr.HasRows)
            {
                object[] collect = new object[dr.FieldCount];
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    dt.Columns.Add(dr.GetName(i));
                }
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        collect[i] = dr.GetValue(i);
                    }
                    dt.Rows.Add(collect);
                }
            }
            return dt;
        }
        
        /// <summary>
        /// Insert Agreement Details of Spetial Worker to tblAgreementDetail
        /// </summary>
        /// <param name="AgreementID">Agreement ID , is Unique</param>
        /// <param name="startDate">Start Date of Agreement for Working</param>
        /// <param name="finishDate">Finish Date of Agreement for Working</param>
        /// <param name="hagh_bime">Haghe Bime</param>
        /// <param name="hagh_jazb">Haghe Jazb</param>
        /// <param name="hagh_maskan">Haghe Maskan</param>
        /// <param name="hagh_owlad">Haghe Owlad</param>
        /// <param name="b_payment">Base Payment</param>
        /// <param name="b_payment_hour">Base Payment Hour</param>
        /// <param name="b_paymentextra">Base Payment Extra Working</param>
        /// <param name="tax">Tax For Recieving Money</param>
        /// <param name="FK_workerID">Foriegn Key For WorkerID</param>
        /// <returns>Integer</returns>
        public int AgreementDetailUpdate(long AgreementID , DateTime startDate , DateTime finishDate , long hagh_bime,
            long hagh_jazb,long hagh_maskan,long hagh_owlad,long b_payment,
            long b_payment_hour, long b_paymentextra, long tax, long FK_workerID)
        {
            SqlConnection cn = new SqlConnection(connectionString);
    
            cn.Open();
            SqlCommand command = new SqlCommand("sp_UpdateAgreementDatail", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@Agree_id", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@S_date", System.Data.SqlDbType.DateTime);
            command.Parameters.Add("@F_date", System.Data.SqlDbType.DateTime);
            command.Parameters.Add("@Hagh_bime", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@Hagh_jazb", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@Hagh_maskan", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@Hagh_owlad", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@B_payment", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@B_payment_hour", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@B_payment_extra", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@Tax", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@FK_workerID", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = AgreementID;
            command.Parameters[1].Value = startDate;
            command.Parameters[2].Value = finishDate;
            command.Parameters[3].Value = hagh_bime;
            command.Parameters[4].Value = hagh_jazb;
            command.Parameters[5].Value = hagh_maskan;
            command.Parameters[6].Value = hagh_owlad;
            command.Parameters[7].Value = b_payment;
            command.Parameters[8].Value = b_payment_hour;
            command.Parameters[9].Value = b_paymentextra;
            command.Parameters[10].Value = tax;
            command.Parameters[11].Value = FK_workerID;
            command.ExecuteNonQuery();

            return (0);
        }

        /// <summary>
        /// Insert Salary Details to tblWorkerSalary
        /// </summary>
        /// <param name="workHour">Working Hours</param>
        /// <param name="workDay">Working Days</param>
        /// <param name="date">Date of Calculating Details of Salary</param>
        /// <param name="mosaede">Mosa'edeh</param>
        /// <param name="bon_karmandi">Bone Karmandi</param>
        /// <param name="FK_AgreementID">Foreign Key as AgreementID</param>
        /// <returns>Integer</returns>
        public int WorkerSalaryInsert(int workHour ,int workDay,DateTime date ,
            long mosaede, long bon_karmandi, long FK_AgreementID)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_InsertWorkerSalary", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@W_Hour", System.Data.SqlDbType.Int);
            command.Parameters.Add("@w_Day", System.Data.SqlDbType.Int);
            command.Parameters.Add("@Date",System.Data.SqlDbType.DateTime);
			command.Parameters.Add("@Mosaede",System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@Bon_karmandi", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@FK_AgreementID", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = workHour;
            command.Parameters[1].Value = workDay;
            command.Parameters[2].Value = date;
            command.Parameters[3].Value = mosaede;
            command.Parameters[4].Value = bon_karmandi;
            command.Parameters[5].Value = FK_AgreementID;
            command.ExecuteNonQuery();  
            return (0);
        }

        /// <summary>
        /// This method Returns DataTable of InnerJoin of tblWorkerSalary and tblAgreementDetail
        /// </summary>
        /// <param name="agreementID">AgreementID</param>
        /// <returns>DataTable</returns>
        public DataTable Select_SalaryDetials_InnerJoin(long agreementID)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new 
                SqlCommand("sp_InnerJoin_tblWorkerSalary_tblAgreementDetail", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@AgreeID", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = agreementID;

            SqlDataReader dr = command.ExecuteReader();

            DataTable dt = new DataTable();
            if (dr.HasRows)
            {
                object[] obj = new object[dr.FieldCount];
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    dt.Columns.Add(dr.GetName(i));
                }
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        obj[i] = dr.GetValue(i);
                    }
                    dt.Rows.Add(obj);
                }
            }
            return dt;
        }
        /// <summary>
        /// Returns Last WorkerID
        /// </summary>
        /// <returns></returns>
        public long tblWorker_Select_Max_WorkerID()
        {
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblWorker_Max_WorkerID", cn);
            command.CommandType = CommandType.StoredProcedure;

            if (command.ExecuteScalar().GetType().Name == "DBNull")
            {
                return 0;
            }
            else
            {
                long result = System.Convert.ToInt64(command.ExecuteScalar());
                return result;
            }
        }

        /// <summary>
        /// Select Last Agreement Datails of Spetial Worker In tblAgreementDetail 
        /// </summary>
        /// <param name="workerID">WorkerID</param>
        /// <returns>Last AgreementID</returns>
        public long SelectLastAgreementDatail(long workerID)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();
            SqlCommand command = new SqlCommand("sp_SelectLastAgreementDatail", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@FK_workerID", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = workerID;

            if (command.ExecuteScalar().GetType().Name == "DBNull")
            {
                return 0;
            }
            else
            {
                long result = System.Convert.ToInt64(command.ExecuteScalar());
                return result;
            }
        }

        /// <summary>
        /// Update tblWorkerSalary
        /// </summary>
        /// <param name="SalaryID">SalaryID</param>
        /// <param name="workHour">WorkHour</param>
        /// <param name="workDay">WorkDay</param>
        /// <param name="date">Date of Recieve</param>
        /// <param name="mosaede">Mosa'edeh</param>
        /// <param name="bon_karmandi">Bone Karmandi</param>
        /// <param name="FK_AgreementID">Foreign Key for AgreementID</param>
        /// <returns></returns>
        public int WorkerSalaryUpdate(long SalaryID, int workHour, int workDay, DateTime date,
            long mosaede, long bon_karmandi, long FK_AgreementID)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_UpdateWorkerSalary", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@SalaryID", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@W_Hour", System.Data.SqlDbType.Int);
            command.Parameters.Add("@w_Day", System.Data.SqlDbType.Int);
            command.Parameters.Add("@Date", System.Data.SqlDbType.DateTime);
            command.Parameters.Add("@Mosaede", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@Bon_karmandi", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@FK_AgreementID", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = SalaryID;
            command.Parameters[1].Value = workHour;
            command.Parameters[2].Value = workDay;
            command.Parameters[3].Value = date;
            command.Parameters[4].Value = mosaede;
            command.Parameters[5].Value = bon_karmandi;
            command.Parameters[6].Value = FK_AgreementID;
            command.ExecuteNonQuery();
            return (0);
        }

        /// <summary>
        /// This method Returns DataTable of InnerJoin of tblWorkerSalary and tblAgreementDetail By Spetial
        /// salaryID
        /// </summary>
        /// <param name="agreementID">AgreementID</param>
        /// <param name="salaryID">SalaryID</param>
        /// <returns></returns>
        public DataTable Select_SalaryDetials_InnerJoin_BySalaryID(long agreementID ,long salaryID)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new
                SqlCommand("sp_InnerJoin_BySalaryID", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@AgreeID", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@SalaryID", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = agreementID;
            command.Parameters[1].Value = salaryID;

            SqlDataReader dr = command.ExecuteReader();

            DataTable dt = new DataTable();
            if (dr.HasRows)
            {
                object[] obj = new object[dr.FieldCount];
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    dt.Columns.Add(dr.GetName(i));
                }
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        obj[i] = dr.GetValue(i);
                    }
                    dt.Rows.Add(obj);
                }
            }
            return dt;
        }
    }
}
