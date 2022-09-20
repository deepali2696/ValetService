using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValetService.DBContext;


namespace ValetService.BI
{
    public class EmployeeAccess : User
    {
        DBLayer db = new DBLayer();

        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public string Availability { get; set; }

        public string WorkStatus { get; set; }

        public string ContactInfo { get; set; }

        public string Education { get; set; }

        public string Designation { get; set; }

        public int EmployeeAddOrUpdate(EmployeeAccess emp, string _role)
        {
            SqlParameter[] sqlParameter;
            if (_role=="Admin")
            {
                sqlParameter = new SqlParameter[]
                {
                    new SqlParameter("@ActionType","SaveAdminData"),
                    new SqlParameter("@UserId",emp.UserId),
                    new SqlParameter("@UserName",emp.uname),
                    new SqlParameter("@Password",emp.pwd)
                };
            }
            else
            {
                sqlParameter = new SqlParameter[]
                {
                    new SqlParameter("@ActionType","SaveData"),
                    new SqlParameter("@EmployeeId",emp.EmployeeId),
                    new SqlParameter("@UserId",emp.UserId),
                    new SqlParameter("@UserName",emp.uname),
                    new SqlParameter("@Password",emp.pwd),
                    new SqlParameter("@Role",false),
                    new SqlParameter("EmployeeName",emp.EmployeeName),
                    new SqlParameter("Availability",emp.Availability),
                    new SqlParameter("WorkStatus",emp.WorkStatus),
                    new SqlParameter("ContactInfo", emp.ContactInfo),
                    new SqlParameter("Education", emp.Education),
                    new SqlParameter("Designation", emp.Designation)
                };
            }
            try
            {
                int result = db.spForDataInsertOrUpdate("spEmployee", sqlParameter);
                return result > 0 ? 1 : -1;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return -1;
            }
        }

        public int EmployeeDeactivate(EmployeeAccess emp, string _role)
        {
            SqlParameter[] sqlParameter;
            if (_role == "Admin")
            {
                sqlParameter = new SqlParameter[]
                {
                    new SqlParameter("@ActionType","DeactivateAdminData"),
                    new SqlParameter("@UserName",emp.uname),
                    new SqlParameter("@Password",emp.pwd)
                };
            }
            else
            {
                sqlParameter = new SqlParameter[]
                {
                    new SqlParameter("@ActionType","DeactivateData"),
                    new SqlParameter("@EmployeeId",emp.EmployeeId),
                    new SqlParameter("@UserId",emp.UserId)
                };
            }
            try
            {
                int result = db.spForDataInsertOrUpdate("spEmployee", sqlParameter);
                return result > 0 ? 1 : -1;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return -1;
            }
        }

        public DataTable fetchAllEmployee()
        {

            DataTable dt = new DataTable();

            try 
            {
                dt = db.spForSelectData("spEmployee", "FetchData");
                if (dt != null && dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex) 
            {
                ex.ToString();
                return null;
            }   
        }

        public DataTable fetchEditData(EmployeeAccess emp,string _role)
        {
            SqlParameter[] sqlParameter;
            if (_role == "Admin")
            {
                sqlParameter = new SqlParameter[]
                {
                    new SqlParameter("@ActionType","FetchAdminRecord"),
                    new SqlParameter("@UserId",emp.UserId)
                };
            }
            else 
            { 
                sqlParameter = new SqlParameter[]
                {
                    new SqlParameter("@ActionType","FetchRecord"),
                    new SqlParameter("@UserId",emp.UserId),
                    new SqlParameter("@EmployeeId",emp.EmployeeId)
                };
            }
            DataTable dt = new DataTable();

            try
            {
                dt = db.spForSelectData("spEmployee", sqlParameter);
                if (dt != null && dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                return null;
            }
        }



    }
}
