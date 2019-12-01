using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace HomeCustomerVersionOfTehranRey.Classes
{
    class clsAnbarManagment_DataAccessLAyer
    {

        string connectionString = clsAccounting_DataAccessLayer.connectionstring;

        public int HomeCustomerInsert( string firstname, string lastname,string referrername,
            string phonenumber, string address)
        {
            SqlConnection cn = new SqlConnection( connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_InsertCustomer", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@fname", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters.Add("@lname", System.Data.SqlDbType.NVarChar, 50);
            command.Parameters.Add("@rname", System.Data.SqlDbType.NVarChar, 70);
            command.Parameters.Add("@pnumber", System.Data.SqlDbType.NVarChar, 50);
            command.Parameters.Add("@address", System.Data.SqlDbType.NVarChar, 300);
            command.Parameters[0].Value = firstname;
            command.Parameters[1].Value = lastname;
            command.Parameters[2].Value = referrername;
            command.Parameters[3].Value = phonenumber;
            command.Parameters[4].Value = address;
            command.ExecuteNonQuery();

            return (0);
        }

        public int HomeCustomerUpdate(long id, string firstname, string lastname, string referrername,
            string phonenumber, string address)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_UpdateCustomer", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@id", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters.Add("@family", System.Data.SqlDbType.NVarChar, 50);
            command.Parameters.Add("@refferrer", System.Data.SqlDbType.NVarChar, 70);
            command.Parameters.Add("@phone", System.Data.SqlDbType.NVarChar, 50);
            command.Parameters.Add("@address", System.Data.SqlDbType.NVarChar, 300);
            command.Parameters[0].Value = id;
            command.Parameters[1].Value = firstname;
            command.Parameters[2].Value = lastname;
            command.Parameters[3].Value = referrername;
            command.Parameters[4].Value = phonenumber;
            command.Parameters[5].Value = address;
            command.ExecuteNonQuery();

            return (0);
        }

        public int InsertCarpet(string carpetLable, string madeinfrom, string size, int length, int width,
            DateTime enterdate, DateTime returndate, bool isactive)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_InsetCarpet", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@cLable", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters.Add("@mInFrom", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters.Add("@cSize", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters.Add("@length", System.Data.SqlDbType.Int);
            command.Parameters.Add("@width", System.Data.SqlDbType.Int);
            //command.Parameters.Add("@area", System.Data.SqlDbType.Char);
            command.Parameters.Add("@enterD", System.Data.SqlDbType.DateTime);
            command.Parameters.Add("@returnD", System.Data.SqlDbType.DateTime);
            //command.Parameters.Add("@exitDate", System.Data.SqlDbType.DateTime);
            command.Parameters.Add("@isActive", System.Data.SqlDbType.Bit);
            command.Parameters[0].Value = carpetLable;
            command.Parameters[1].Value = madeinfrom;
            command.Parameters[2].Value = size;
            command.Parameters[3].Value = length;
            command.Parameters[4].Value = width;
            //command.Parameters[4].Value = area;
            command.Parameters[5].Value = enterdate;
            command.Parameters[6].Value = returndate;
            //command.Parameters[6].Value = exitdate;
            command.Parameters[7].Value = isactive;
            command.ExecuteNonQuery();

            return (0);
        }

        public int CarpetCustomerInsert(long carpetCode, long customerID)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_InsertCustomerCarpet", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@carpetCode", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@customerID", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = carpetCode;
            command.Parameters[1].Value = customerID;
            command.ExecuteNonQuery();

            return (0);
        }

        public int CarpetServicesInsert(long carpetCode, int servicesSerial, decimal amountService, long serviceFee)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_InsertCarpetServices", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@cCode", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@sSerial", System.Data.SqlDbType.Int);
            command.Parameters.Add("@aService", System.Data.SqlDbType.Decimal);
            command.Parameters.Add("@sFee", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = carpetCode;
            command.Parameters[1].Value = servicesSerial;
            command.Parameters[2].Value = amountService;
            command.Parameters[3].Value = serviceFee;
            command.ExecuteNonQuery();

            return (0);
        }

        public int ServiceInsert(string serviceType, long fee, string discribtion)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_InsertService", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@sType", System.Data.SqlDbType.Char,30);
            command.Parameters.Add("@fee", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@discribtion", System.Data.SqlDbType.Char,300);
            command.Parameters[0].Value = serviceType;
            command.Parameters[1].Value = fee;
            command.Parameters[2].Value = discribtion;
            command.ExecuteNonQuery();

            return (0);
        }

        public int FactorInsert(long CustomerID, DateTime datetime, long totalValue)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_InsertFactor", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@CustomerID", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@DateTime", System.Data.SqlDbType.DateTime);
            command.Parameters.Add("@TotalValue", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = CustomerID;
            command.Parameters[1].Value = datetime;
            command.Parameters[2].Value = totalValue;
            command.ExecuteNonQuery();

            return (0);
        }

        public int FctorCarpetInsert(long carpetCode, long FactorID)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            
            cn.Open();
            SqlCommand command = new SqlCommand("sp_InsertFactorCarpet", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@carpetCode", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@FactorID", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = carpetCode;
            command.Parameters[1].Value = FactorID;
            command.ExecuteNonQuery();

            return (0);
        }

        public int UpdateCarpet(long carpetCode, string carpetLable, string madeinfrom, string size, int length, int width,
           DateTime enterdate, DateTime returndate)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_UpdateCarpet", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@cCode", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@cLable", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters.Add("@mInFrom", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters.Add("@cSize", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters.Add("@length", System.Data.SqlDbType.Int);
            command.Parameters.Add("@width", System.Data.SqlDbType.Int);
            //command.Parameters.Add("@area", System.Data.SqlDbType.Char);
            command.Parameters.Add("@enterD", System.Data.SqlDbType.DateTime);
            command.Parameters.Add("@returnD", System.Data.SqlDbType.DateTime);
            command.Parameters[0].Value = carpetCode;
            command.Parameters[1].Value = carpetLable;
            command.Parameters[2].Value = madeinfrom;
            command.Parameters[3].Value = size;
            command.Parameters[4].Value = length;
            command.Parameters[5].Value = width;
            //command.Parameters[4].Value = area;
            command.Parameters[6].Value = enterdate;
            command.Parameters[7].Value = returndate;
            command.ExecuteNonQuery();

            return (0);
        }

        public int UpdateIsFactord(long carpetCode)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            SqlConnection.ClearPool(cn);
            cn.Open();
            SqlCommand command = new SqlCommand("sp_UpdateCarpet_IsFactored", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@CarpetCode", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = carpetCode;
            command.ExecuteNonQuery();
            
            return (0);
        }
        
        /// <summary>
        /// this method select information of special customer by his ID
        /// and return them in a DataTable
        /// </summary>
        /// <param name="id"> ID of customer</param>
        /// <returns></returns>
        public DataTable Customer_Select_ByID(long id)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_SelectCustomer_ByID", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@CustomerID", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = id;

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
        /// this method select the values of "CarpetSize" & "MadeInFrom" fields of 
        /// all rows of tblCarpet and return them in a DataTable
        /// </summary>
        /// <returns></returns>
        public DataTable Carpet_Select_Place_And_Size()
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_SelectCarpet_SizeANDPlace", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            
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
        /// this method select * in tblCastomerCarpet By CustomerID (carpets of Special Customer)
        /// and after Sorting DESC return them in a DataTable
        /// </summary>
        /// <param name="customerid">customer ID</param>
        /// <returns></returns>
        public DataTable CustomerCarpet_Select_ByCustomerID(long customerid)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblCustomerCarpet_ByCustomerID_DESC", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@CustomerID", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = customerid;

            SqlDataReader dr = command.ExecuteReader();

            DataTable dt = new DataTable();
           
            if (dr.HasRows)
            {
                object[] collect = new object[dr.FieldCount];

                // for adding columns to Datatable
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    dt.Columns.Add(dr.GetName(i));
                }
                //End of // for adding columns to Datatable

                // for fill data in datatable
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        collect[i] = dr.GetValue(i);
                    }
                    dt.Rows.Add(collect);
                }
                //End // for fill data in datatable
            }
            return dt;
        }

        /// <summary>
        /// this method select * in tblCarpet By Lable 
        /// and after Sorting DESC return them in a DataTable
        /// </summary>
        /// <param name="carpetCode">carpetCode</param>
        /// <param name="isActive">isActive</param>
        /// <returns></returns>
        public DataTable Carpet_Select_ByCarpetCode_AndIsActive(long carpetCode, bool isActive)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblCarpet_ByCarpetCode_AndISActive", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@CarpetCode", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@IsActive", System.Data.SqlDbType.Bit);
            command.Parameters[0].Value = carpetCode;
            command.Parameters[1].Value = isActive;

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
            cn.Close();
            return dt;
        }

        /// <summary>
        /// this method select * in tblCarpet By CarpetCode & IsFactored 
        /// and after Sorting DESC return them in a DataTable
        /// </summary>
        /// <param name="carpetCode">carpetCode</param>
        /// <param name="isActive">isActive</param>
        /// <returns></returns>
        public DataTable Carpet_Select_ByCarpetCode_AndIsActive_AndIsFactored
            (long carpetCode, bool isActive, bool isFactored)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblCarpet_ByCarpetCode_AndISActive_AndIsFactored", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@CarpetCode", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@IsActive", System.Data.SqlDbType.Bit);
            command.Parameters.Add("@IsFactored", System.Data.SqlDbType.Bit);
            command.Parameters[0].Value = carpetCode;
            command.Parameters[1].Value = isActive;
            command.Parameters[2].Value = isFactored;

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
            cn.Close();
            return dt;
        }

        /// <summary>
        /// this method select * in tblCarpet By Size 
        /// and after Sorting DESC return them in a DataTable
        /// </summary>
        /// <param name="lable">carpetSize</param>
        /// <returns></returns>
        public DataTable Carpet_Select_ByCarpetSize(long code, string size)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblCarpet_BySize_DESC", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@code", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@Size", System.Data.SqlDbType.NVarChar , 30);
            command.Parameters[0].Value = code;
            command.Parameters[1].Value = size;
            
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
            cn.Close();
            return dt;
        }
        
        /// <summary>
        /// this method select * in tblCarpet By Place 
        /// and after Sorting DESC return them in a DataTable
        /// </summary>
        /// <param name="size">CarpetPlace</param>
        /// <returns></returns>
        public DataTable Carpet_Select_ByPlace(long code, string place)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblCarpet_ByPlace_DESC", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@code", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@Place", System.Data.SqlDbType.NVarChar , 30);
            command.Parameters[0].Value = code;
            command.Parameters[1].Value = place;

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
            cn.Close();
            return dt;
        }

        /// <summary>
        /// this method select * in tblCarpet By Place 
        /// and after Sorting DESC return them in a DataTable
        /// </summary>
        /// <param name="lable">CarpetLable</param>
        /// <returns></returns>
        public DataTable Carpet_Select_ByCarpetLable(long code, string lable)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblCarpet_ByLable_DESC", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@code", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@lable", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters[0].Value = code;
            command.Parameters[1].Value = lable;

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
            cn.Close();
            return dt;
        }

        /// <summary>
        /// Select Special Carpet frmo tblCarpet by Lable
        /// and reurn in a datatable
        /// </summary>
        /// <param name="lable">carpet lable</param>
        /// <returns></returns>
        public DataTable Carpet_Select_ByJustCarpetLable(string lable)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblCarpet_ByJustLable_DESC", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@lable", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters[0].Value = lable;

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
            cn.Close();
            return dt;
        }

        /// <summary>
        /// Select Last CarpetCode and return it 
        /// </summary>
        /// <returns></returns>
        public long LastCarpetCode_Select()
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblCarpet_LastCarpetCode", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            return System.Convert.ToInt64(command.ExecuteScalar());
        }

        /// <summary>
        /// Select Special Service from tblServices by Serial
        /// and reurn in a datatable
        /// </summary>
        /// <param name="lable">Service Serial</param>
        /// <returns></returns>
        public DataTable Service_Select_ByServiceSerial(int serial)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblServices_BySerial", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@Serial", System.Data.SqlDbType.Int);
            command.Parameters[0].Value = serial;

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
            cn.Close();
            return dt;
        }

        /// <summary>
        /// Delete Special Row from tblCarpetServices
        /// </summary>
        /// <param name="carpetCode">carpetCode</param>
        public void CarpetServices_Delete(long carpetCode)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Delete_tblCarpetServices", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@carpetCode", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = carpetCode;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// select * from tblCarpetServices by CarpetCode 
        /// and return result in a datatable
        /// </summary>
        /// <param name="carpetCode">carpetCode</param>
        /// <returns></returns>
        public DataTable CarpetServices_Select_ByCarpetCode(long carpetCode)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblCarpetServices_ByCarpetCode", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@carpetCode", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = carpetCode;

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
            cn.Close();
            return dt;
        }

        /// <summary>
        /// select * from tblCustomer by name & family
        /// and return result in a datatable
        /// </summary>
        /// <param name="name">customr Name</param>
        /// <param name="family">customr family</param>
        /// <returns></returns>
        public DataTable Customer_Select_ByName_And_Family(string name, string family)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblCustomer_ByName_And_Family", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters.Add("@family", System.Data.SqlDbType.NVarChar, 30);
            command.Parameters[0].Value = name;
            command.Parameters[1].Value = family;

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
            cn.Close();
            return dt;
        }

        /// <summary>
        /// Select * from tblCustomer and return the result in a datatable
        /// </summary>
        /// <returns></returns>
        public DataTable Customer_Select()
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblCustomer", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;

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
            cn.Close();
            return dt;
        }

        /// <summary>
        /// Select Max(CustomerID) from tblCustomer & return it az a long value
        /// </summary>
        /// <returns></returns>
        public long tblCustomer_Select_Max_CustomerID()
        {
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblCustomer_Max_CustomerID", cn);
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
        /// Select Carpet of SpetialCustomer By Enter Date
        /// </summary>
        /// <param name="code"></param>
        /// <param name="EnteryDate"></param>
        /// <returns>DataTable dt</returns>
        public DataTable Carpet_Select_ByEnteryDate(long CustomerID, DateTime EnteryDateFrom, DateTime EnteryDateTo)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblCarpet_ForSpecialCustomer_ByEnterDate", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@CustomerID", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@DateFrom", System.Data.SqlDbType.DateTime);
            command.Parameters.Add("@DateTo", System.Data.SqlDbType.DateTime);
            command.Parameters[0].Value = CustomerID;
            command.Parameters[1].Value = EnteryDateFrom;
            command.Parameters[2].Value = EnteryDateTo;

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
            cn.Close();
            return dt;
        }
        /// <summary>
        /// Select Carpet of SpetialCustomer By Exit Date
        /// </summary>
        /// <param name="code"></param>
        /// <param name="EnteryDate"></param>
        /// <returns>DataTable dt</returns>
        public DataTable Carpet_Select_ByReturnDate(long CustomerID, DateTime ReturnDateFrom, DateTime ReturnDateTo)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblCarpet_ForSpecialCustomer_ByReturnDate", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@CustomerID", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@DateFrom", System.Data.SqlDbType.DateTime);
            command.Parameters.Add("@DateTo", System.Data.SqlDbType.DateTime);
            command.Parameters[0].Value = CustomerID;
            command.Parameters[1].Value = ReturnDateFrom;
            command.Parameters[2].Value = ReturnDateTo;

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
            cn.Close();
            return dt;
        }
        /// <summary>
        /// Select Services from tblService and Return it 
        /// </summary>
        /// <returns></returns>
        public DataTable ServiceSelect()
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblServices", cn);
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
        /// Update tblServices with 4 Arguments
        /// </summary>
        /// <param name="serviceSerial">Get this Parameter from DataGridView</param>
        /// <param name="serviceType">Get this Parameter from DataGridView</param>
        /// <param name="fee">Service Fee</param>
        /// <param name="description">Service Describtion</param>
        /// <returns></returns>
        public int ServiceUpdate(int serviceSerial ,string serviceType ,
            long fee , string description)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_UpdatetblServices", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@ServiceSerial", System.Data.SqlDbType.Int);
            command.Parameters.Add("@ServiceType", System.Data.SqlDbType.Text);
            command.Parameters.Add("@Fee", System.Data.SqlDbType.BigInt);
            command.Parameters.Add("@Deccibtion ", System.Data.SqlDbType.NVarChar, 300);
            command.Parameters[0].Value = serviceSerial;
            command.Parameters[1].Value = serviceType;
            command.Parameters[2].Value = fee;
            command.Parameters[3].Value = description;
            command.ExecuteNonQuery();

            return (0);
        }

    }
}
