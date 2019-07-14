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
        Sqlconnection sqlconnection;
        public DataAccessLayer()
        {


            SqlConnection = new SqlConnection("Server= DESKTOP-Q0TPN43;Database=Reports Section; Integrated Security=true");

        }
        //Method to open the connection
        public void open()
        {
            if (SqlConnection.State != ConnectionState.open)
            {
                SqlConnection.open();
            }
        }
        //Method to close the connection 
        public void Close()
        {
            if (SqlConnection.State == ConnectionState.open)
            {
                sqlconnection.Close();
            }
        }

        //Method to Read Data From Database
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection=SqlConnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Paramenters.Add(param[i]);

                }

            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}


        //Method to Insert,Update , and Delete Data From Database

//public void ExecuteData (string stored_procedure, SqlParameter[] param)
    //    {
      //      SqlCommand sqlcmd = new SqlCommand();
        //    sqlcmd.CommandType = CommandType.StoredProcedure;
       //     sqlcmd.CommandText = stored_procedure; 
        //    sqlcmd.Connection=SqlConnection;

       //     if (param != null)
       //     {
         //           sqlcmd.Paramenters.AddRange (param);

         //       }

     
        //    sqlcmd.ExecuteNonQuery();
 //   }
  //  }    
    
 //   }

}




