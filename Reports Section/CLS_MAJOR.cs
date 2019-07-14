using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CLS_MAJOR
{
    class CLS_MAJOR
    {
        public DataTable GET_ALL_MAJORS()
        {
            DAL.DataAccesSLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_MAJORS", null);
            DAL.close();
            return Dt;

        }
    }
}