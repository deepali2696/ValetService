using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValetService;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ValetService.DBContext
{
    public class DBLayer
    {
        public static string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        SqlCommand sCommand;        
        SqlConnection sConnection=new SqlConnection(connString);

        public DataTable spForSelectData(string sp, string actionType)  // select query with-out where condition
        {
            if (sConnection.State == ConnectionState.Closed)
            {
                sConnection.Open();
            }
            DataTable dt = new DataTable();
            sCommand = new SqlCommand(sp, sConnection);
            sCommand.CommandType = CommandType.StoredProcedure;
            sCommand.Parameters.AddWithValue("@ActionType", actionType);
            SqlDataAdapter sqlSda = new SqlDataAdapter(sCommand);
            try
            {
                sqlSda.Fill(dt);
                sConnection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                sConnection.Close();
                return null;
            }            
        }
        public DataTable spForSelectData(string sp, SqlParameter[] sParam) // select query with where condition
        {
            if (sConnection.State == ConnectionState.Closed)
            {
                sConnection.Open();
            }
            DataTable dt = new DataTable();
            sCommand = new SqlCommand(sp, sConnection);
            sCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlSda = new SqlDataAdapter(sCommand);
            foreach (SqlParameter i in sParam)
            {
                sCommand.Parameters.Add(i);
            }
            try
            {
                sqlSda.Fill(dt);
                sConnection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                sConnection.Close();
                return null;
            }
        }

        public int spForDataInsertOrUpdate(string sp, SqlParameter[] sParam) // to insert data
        {
            if (sConnection.State == ConnectionState.Closed)
            {
                sConnection.Open();
            }
            DataTable dt = new DataTable();
            sCommand = new SqlCommand(sp, sConnection);
            sCommand.CommandType = CommandType.StoredProcedure;
            foreach(SqlParameter i in sParam)
            {
                sCommand.Parameters.Add(i);
            }
            try
            {
                return sCommand.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                sConnection.Close();
                return -1;
            }
            finally
            {
                sConnection.Close();
            }


        }

    }
}
