using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.BL
{
    class CLS_Emp
    {

        public DataTable Get_All_type()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_type", null);
            DAL.Close();
            return Dt;


        }
        public DataTable Get_All_senders()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_sender", null);
            DAL.Close();
            return Dt;


        }
        public DataTable maxsender()
        {

            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Max_sender", null);
            DAL.Close();
            return Dt;

        }

        public void Addsender(int ID, string Name,  int DepID, string username ,string pw , int type)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@senderID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@senderName", SqlDbType.NVarChar, 25);
            param[1].Value = Name;
            param[2] = new SqlParameter("@deptID", SqlDbType.Int);
            param[2].Value = DepID;

            param[3] = new SqlParameter("@username", SqlDbType.NVarChar, 25);
            param[3].Value = username;

            param[4] = new SqlParameter("@pw", SqlDbType.NVarChar, 15);
            param[4].Value = pw;
            param[5] = new SqlParameter("@type", SqlDbType.Int);
            param[5].Value = type;


            DAL.ExecuteCommand("Add_sender", param);
            DAL.Close();


        }
        public void Updatesender(int ID, string Name, int DepID, string username, string pw, int type)
        {

            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@senderID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@senderName", SqlDbType.NVarChar, 25);
            param[1].Value = Name;
            param[2] = new SqlParameter("@deptID", SqlDbType.Int);
            param[2].Value = DepID;

            param[3] = new SqlParameter("@username", SqlDbType.NVarChar, 25);
            param[3].Value = username;

            param[4] = new SqlParameter("@pw", SqlDbType.NVarChar, 15);
            param[4].Value = pw;
            param[5] = new SqlParameter("@type", SqlDbType.Int);
            param[5].Value = type;


            DAL.ExecuteCommand("Update_sender", param);
            DAL.Close();


        }
        public DataTable Get_All_dept()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_dept", null);
            DAL.Close();
            return Dt;


        }
        public DataTable maxdept()
        {

            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Max_Department", null);
            DAL.Close();
            return Dt;

        }

        public void AddDept(int ID, string Name)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@depid", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@depname", SqlDbType.NVarChar, 20);
            param[1].Value = Name;
         

            DAL.ExecuteCommand("Add_Department", param);
            DAL.Close();


        }
        public void UpdateDept(int ID, string Name)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@depid", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@depname", SqlDbType.NVarChar, 20);
            param[1].Value = Name;


            DAL.ExecuteCommand("Update_dept", param);
            DAL.Close();


        }



        public DataTable Get_All_major()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_major", null);
            DAL.Close();
            return Dt;


        }

        public DataTable maxmajor()
        {

            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Max_Major", null);
            DAL.Close();
            return Dt;

        }

        public void AddMajor(int ID, string Name)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Majorid", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@Majorname", SqlDbType.NVarChar, 20);
            param[1].Value = Name;


            DAL.ExecuteCommand("Add_Major", param);
            DAL.Close();


        }
       
        public void UpdateMajor(int ID, string Name)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Majorno", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@Majorname", SqlDbType.NVarChar, 20);
            param[1].Value = Name;


            DAL.ExecuteCommand("Update_Major", param);
            DAL.Close();


        }
        public void Addworker(int ID, string Name,
              string Phone, string Address, int MajorID ,string username ,string pw , int type)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@workerID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@workerName", SqlDbType.NVarChar,25);
            param[1].Value = Name;

            param[2] = new SqlParameter("@workerphone", SqlDbType.NVarChar, 15);
            param[2].Value = Phone;

            param[3] = new SqlParameter("@workerAdress", SqlDbType.NVarChar, 30);
            param[3].Value = Address;

            param[4] = new SqlParameter("@majorID", SqlDbType.Int);
            param[4].Value = MajorID;

            param[5] = new SqlParameter("@username", SqlDbType.NVarChar, 25);
            param[5].Value = username;

            param[6] = new SqlParameter("@pw", SqlDbType.NVarChar, 15);
            param[6].Value = pw;
            param[7] = new SqlParameter("@type", SqlDbType.Int);
            param[7].Value = type;

            DAL.ExecuteCommand("Add_worker", param);
            DAL.Close();





        }

        public DataTable Get_All_worker()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_worker", null);
            DAL.Close();
            return Dt;


        }

        public DataTable maxworker()
        {

            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Max_worker", null);
            DAL.Close();
            return Dt;

        }
        public void Updateworker(int ID, string Name,
          string Phone, string Address, int MajorID, string username, string pw, int type)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@workerID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@workerName", SqlDbType.NVarChar, 25);
            param[1].Value = Name;

            param[2] = new SqlParameter("@workerphone", SqlDbType.NVarChar, 15);
            param[2].Value = Phone;

            param[3] = new SqlParameter("@workerAdress", SqlDbType.NVarChar, 30);
            param[3].Value = Address;

            param[4] = new SqlParameter("@majorID", SqlDbType.Int);
            param[4].Value = MajorID;

            param[5] = new SqlParameter("@username", SqlDbType.NVarChar, 25);
            param[5].Value = username;

            param[6] = new SqlParameter("@pw", SqlDbType.NVarChar, 15);
            param[6].Value = pw;
            param[7] = new SqlParameter("@type", SqlDbType.Int);
            param[7].Value = type;

            DAL.ExecuteCommand("Update_worker", param);
            DAL.Close();





        }
    
       
    
    }
}
