using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.BL
{
    class CLS_Reports
    {
        public DataTable maxsenderReport()
        {

            DAL.DAL DAL = new DAL.DAL();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Max_report", null);
            DAL.Close();
            return Dt;

        }
        public void AddsenderReport(int ID, int dept, DateTime date ,string title ,string details)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@deptid", SqlDbType.Int);
            param[1].Value =dept;

            param[2] = new SqlParameter("@date", SqlDbType.DateTime);
            param[2].Value = date;
            param[3] = new SqlParameter("@title", SqlDbType.NVarChar, 20);
            param[3].Value = title;
            param[4] = new SqlParameter("@details", SqlDbType.NVarChar, 250);
            param[4].Value = details;

            DAL.ExecuteCommand("Add_sender_report", param);
            DAL.Close();


        }

        public void Updatestatus_Seen(int ID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("Update_status_seen", param);
            DAL.Close();
        }
               public void Updatestatusondoing(int ID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("Update_status_ondoing", param);
            DAL.Close();
        }
               public void Updateforwardreport(int ID, int major)
               {
                   DAL.DAL DAL = new DAL.DAL();
                   DAL.Open();
                   SqlParameter[] param = new SqlParameter[2];
                   param[0] = new SqlParameter("@id", SqlDbType.Int);
                   param[0].Value = ID;

                   param[1] = new SqlParameter("@Major", SqlDbType.Int);
                   param[1].Value = major;
                   DAL.ExecuteCommand("Update_forwardreport", param);
                   DAL.Close();
               }

               public void updatefinalReport(int ID, string report, string name, int status)
               {
                   DAL.DAL DAL = new DAL.DAL();
                   DAL.Open();
                   SqlParameter[] param = new SqlParameter[4];
                   param[0] = new SqlParameter("@id", SqlDbType.Int);
                   param[0].Value = ID;

                
                   param[1] = new SqlParameter("@report", SqlDbType.NVarChar, 20);
                   param[1].Value = report;
                   param[2] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
                   param[2].Value = name;

                   param[3] = new SqlParameter("@status", SqlDbType.Int);
                   param[3].Value = status;

                   DAL.ExecuteCommand("Update_finalreport", param);
                   DAL.Close();


               }



               public DataTable Get_All_senderReports()
               {
                   DAL.DAL DAL = new DAL.DAL();
                   SqlParameter[] param = new SqlParameter[1];
                   param[0] = new SqlParameter("@dept", SqlDbType.Int);
                   param[0].Value = Program.section;


                   DataTable Dt = new DataTable();
                   Dt = DAL.SelectData("Get_All_senderReports", param);
                   DAL.Close();
                   return Dt;

               }

               public DataTable Get_All_senderReportsAssigned()
               {
                   DAL.DAL DAL = new DAL.DAL();
                   SqlParameter[] param = new SqlParameter[1];
                   param[0] = new SqlParameter("@dept", SqlDbType.Int);
                   param[0].Value = Program.section;


                   DataTable Dt = new DataTable();
                   Dt = DAL.SelectData("Get_All_senderReportsAssigned", param);
                   DAL.Close();
                   return Dt;

               }
               public DataTable Get_All_senderReportsdone()
               {
                   DAL.DAL DAL = new DAL.DAL();
                   SqlParameter[] param = new SqlParameter[1];
                   param[0] = new SqlParameter("@dept", SqlDbType.Int);
                   param[0].Value = Program.section;


                   DataTable Dt = new DataTable();
                   Dt = DAL.SelectData("Get_All_senderReportsdone", param);
                   DAL.Close();
                   return Dt;

               }
               public DataTable Get_All_senderReportsnot()
               {
                   DAL.DAL DAL = new DAL.DAL();
                   SqlParameter[] param = new SqlParameter[1];
                   param[0] = new SqlParameter("@dept", SqlDbType.Int);
                   param[0].Value = Program.section;


                   DataTable Dt = new DataTable();
                   Dt = DAL.SelectData("Get_All_senderReportsnotdone", param);
                   DAL.Close();
                   return Dt;

               }
               public DataTable Get_All_senderReportsSeen()
               {
                   DAL.DAL DAL = new DAL.DAL();
                   SqlParameter[] param = new SqlParameter[1];
                   param[0] = new SqlParameter("@dept", SqlDbType.Int);
                   param[0].Value = Program.section;


                   DataTable Dt = new DataTable();
                   Dt = DAL.SelectData("Get_All_senderReportsSeen", param);
                   DAL.Close();
                   return Dt;

               }
             public DataTable Get_All_senderReportsondoing()
               {
                   DAL.DAL DAL = new DAL.DAL();
                   SqlParameter[] param = new SqlParameter[1];
                   param[0] = new SqlParameter("@dept", SqlDbType.Int);
                   param[0].Value = Program.section;


                   DataTable Dt = new DataTable();
                   Dt = DAL.SelectData("Get_All_senderReportsondoning", param);
                   DAL.Close();
                   return Dt;

               }
             public DataTable Get_All_moredetails(int id)
             {
                 DAL.DAL DAL = new DAL.DAL();
                 SqlParameter[] param = new SqlParameter[1];
                 param[0] = new SqlParameter("@id", SqlDbType.Int);
                 param[0].Value = id;


                 DataTable Dt = new DataTable();
                 Dt = DAL.SelectData("Get_All_moredetails", param);
                 DAL.Close();
                 return Dt;

             }
             public DataTable Get_All_recevedbymanage()
             {
                 DAL.DAL DAL = new DAL.DAL();
               
                 DataTable Dt = new DataTable();
                 Dt = DAL.SelectData("Get_All_recevedbymanager",null);
                 DAL.Close();
                 return Dt; 
       
             }
             public DataTable Get_All_all()
             {
                 DAL.DAL DAL = new DAL.DAL();

                 DataTable Dt = new DataTable();
                 Dt = DAL.SelectData("Get_All_Reportsall", null);
                 DAL.Close();
                 return Dt;

             }
             public DataTable Get_All_ReportsSeen()
             {
                 DAL.DAL DAL = new DAL.DAL();

                 DataTable Dt = new DataTable();
                 Dt = DAL.SelectData("Get_All_ReportsSeen", null);
                 DAL.Close();
                 return Dt;

             }
             public DataTable Get_All_ondoing()
             {
                 DAL.DAL DAL = new DAL.DAL();

                 DataTable Dt = new DataTable();
                 Dt = DAL.SelectData("Get_All_Reportsondoning", null);
                 DAL.Close();
                 return Dt;

             }
             public DataTable Get_All_done()
             {
                 DAL.DAL DAL = new DAL.DAL();

                 DataTable Dt = new DataTable();
                 Dt = DAL.SelectData("Get_All_Reportsdone", null);
                 DAL.Close();
                 return Dt;

             }
             public DataTable Get_All_notdone()
             {
                 DAL.DAL DAL = new DAL.DAL();

                 DataTable Dt = new DataTable();
                 Dt = DAL.SelectData("Get_All_Reportsnotdone", null);
                 DAL.Close();
                 return Dt;

             }
             public DataTable Get_All_assigned()
             {
                 DAL.DAL DAL = new DAL.DAL();

                 DataTable Dt = new DataTable();
                 Dt = DAL.SelectData("Get_All_Reportsassigned", null);
                 DAL.Close();
                 return Dt;

             }

             public DataTable Get_All_ReceiverAssigned()
             {
                 DAL.DAL DAL = new DAL.DAL();
                 SqlParameter[] param = new SqlParameter[1];
                 param[0] = new SqlParameter("@major", SqlDbType.Int);
                 param[0].Value = Program.section;


                 DataTable Dt = new DataTable();
                 Dt = DAL.SelectData("Get_All_ReceiverAssigned", param);
                 DAL.Close();
                 return Dt;

             }
             public DataTable Get_All_Receiverdone()
             {
                 DAL.DAL DAL = new DAL.DAL();
                 SqlParameter[] param = new SqlParameter[1];
                 param[0] = new SqlParameter("@major", SqlDbType.Int);
                 param[0].Value = Program.section;

                 DataTable Dt = new DataTable();
                 Dt = DAL.SelectData("Get_All_Receiverdone", param);
                 DAL.Close();
                 return Dt;

             }
             public DataTable Get_All_Receivernotdone()
             {
                 DAL.DAL DAL = new DAL.DAL();
                 SqlParameter[] param = new SqlParameter[1];
                 param[0] = new SqlParameter("@major", SqlDbType.Int);
                 param[0].Value = Program.section;


                 DataTable Dt = new DataTable();
                 Dt = DAL.SelectData("Get_All_Receivernotdone", param);
                 DAL.Close();
                 return Dt;

             }
             public DataTable Get_All_Receiverondoing()
             {
                 DAL.DAL DAL = new DAL.DAL();
                 SqlParameter[] param = new SqlParameter[1];
                 param[0] = new SqlParameter("@major", SqlDbType.Int);
                 param[0].Value = Program.section;

                 DataTable Dt = new DataTable();
                 Dt = DAL.SelectData("Get_All_Receiverondoing",param);
                 DAL.Close();
                 return Dt;

             }
             public DataTable Get_All_Receiverall()
             {
                 DAL.DAL DAL = new DAL.DAL();
                 SqlParameter[] param = new SqlParameter[1];
                 param[0] = new SqlParameter("@major", SqlDbType.Int);
                 param[0].Value = Program.section;


                 DataTable Dt = new DataTable();
                 Dt = DAL.SelectData("Get_All_Receiverall", param);
                 DAL.Close();
                 return Dt;

             }
    }

}
