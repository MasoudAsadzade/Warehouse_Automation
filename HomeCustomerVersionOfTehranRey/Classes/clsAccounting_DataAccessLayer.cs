using System.Data;
using System.Data.SqlClient;

namespace HomeCustomerVersionOfTehranRey.Classes
{
    class clsAccounting_DataAccessLayer
    {
        public static string connectionstring = System.Configuration.ConfigurationManager
            .ConnectionStrings["HomeCustomerVersionOfTehranRey.Properties.Settings.TehranreyConnectionString"]
            .ConnectionString;

        public DataTable Factor_Select_ByCustomerID(long id)
        {
            SqlConnection cn = new SqlConnection(connectionstring);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblFactor_ByCustomerID", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@CustomerID", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = id;

            SqlDataReader dr = command.ExecuteReader();

            DataTable dt = new DataTable();

            if (dr.HasRows)
            {


                for (int i = 0; i < dr.FieldCount; i++)
                {
                    dt.Columns.Add(dr.GetName(i));
                }

                object[] columns = new object[dr.FieldCount];
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        columns[i] = dr.GetValue(i);
                    }
                    dt.Rows.Add(columns);
                }
            }
            cn.Close();

            return dt;
        }

        public DataTable FactorCarpet_Select_ByFactorID(long factorID)
        {
            SqlConnection cn = new SqlConnection(connectionstring);

            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblFactorCarpet_ByFactorID_OrderByCarpetID", cn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@factorID", System.Data.SqlDbType.BigInt);
            command.Parameters[0].Value = factorID;

            SqlDataReader dr = command.ExecuteReader();

            DataTable dt = new DataTable();

            if (dr.HasRows)
            {


                for (int i = 0; i < dr.FieldCount; i++)
                {
                    dt.Columns.Add(dr.GetName(i));
                }

                object[] columns = new object[dr.FieldCount];
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        columns[i] = dr.GetValue(i);
                    }
                    dt.Rows.Add(columns);
                }
            }
            cn.Close();

            return dt;
        }

        public long tblFactor_Select_Max_FactroID()
        {
            SqlConnection cn = new SqlConnection(connectionstring);
            cn.Open();
            SqlCommand command = new SqlCommand("sp_Select_tblFactor_Max_FactorID", cn);
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
    }
}
