using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Reports_Section_in_YPC.DAL
{
    class DataAccessLayer
    {
       
         SqlConnection SqlConnection;
        // this constructor inisialize the connection object 
        public DataAccessLayer()
        {
            SqlConnection = new SqlConnection(" server=THENME-PC;integrated security=true;dataBase=store_system");
        }
        //Method to open the connection
        public void Open()
        {
            if (SqlConnection.State !=ConnectionState.Open)
            {
                SqlConnection.Open();
            }
        }

        //Method to Close the connection

        public void Close()
        {
            if (SqlConnection.State == ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }
        //Metod to Read Data from DB
        public DataTable SelectData(string stored_procedure, SqlParameter [] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = SqlConnection;
            if(param != null)
            {
                for(int i=0;i<param.Length;i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //Method to Insert, Update ,And Delete Data from DB
        public void ExecuteCommand(string Stored_procedure,SqlParameter [] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = Stored_procedure;
            sqlcmd.Connection = SqlConnection;
            if(param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }
 }

}




