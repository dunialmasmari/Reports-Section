using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.BL
{
    class CLS_LogIn
    {
        public DataTable LOGIN(string ID, string PWD)
        {
            DAL.DAL DAL = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 25);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PWD", SqlDbType.NVarChar,25);
            param[1].Value = PWD;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("loginpwsender", param);
            DAL.Close();
            return Dt;

        }

        public DataTable LOGIN_worker(string ID, string PWD)
        {
            DAL.DAL DAL = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 25);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PWD", SqlDbType.NVarChar, 25);
            param[1].Value = PWD;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("loginpwworker", param);
            DAL.Close();
            return Dt;

        }
    }
}
