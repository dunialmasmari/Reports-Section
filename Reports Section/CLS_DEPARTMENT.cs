using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CLS_DEPARTMENT
{
    class CLS_DEPARTMENT
    {
        public DataTable GET_ALL_DEPARTMENTS()
        {
            DAL.DataAccesSLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_DEPARMENTS", null);
            DAL.close();
            return Dt;

        }
    }
}