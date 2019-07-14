using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CLS_TYPES_REPORTS
{
    class CLS_TYPES_REPORTS
    {
        public DataTable GET_ALL_TYPES_REPORTS()
        {
            DAL.DataAccesSLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_TYPES_REPORTS", null);
            DAL.close();
            return Dt;

        }
    }
}
