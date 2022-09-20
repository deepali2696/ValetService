using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValetService.DBContext;
namespace ValetService.BI
{
    public class User
    {
        DBLayer db=new DBLayer();
        public int UserId { get; set; }
        public string uname { get; set; }
        public string pwd { get; set; }
        public bool role { get; set; }

        public static string username { get; set; }
        public static string password {get; set; }

        public static bool userType { get; set; }

        public void session(string _uname,string _pwd, bool _role)
        {
            uname = _uname;
            pwd = _pwd;
            role = _role;    
            username = _uname;
            password = _pwd;
            userType = _role;
        }

        public bool checkLogin(string _uname, string _pwd, bool _role)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@ActionType", "CheckUser"),
                new SqlParameter("@UserName",_uname),
                new SqlParameter("@Password", _pwd),
                new SqlParameter("@Role", _role)
            };
            DataTable dt = db.spForSelectData("spEmployee",sp);
            if (dt != null && dt.Rows.Count > 0)
            {
                session(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), Convert.ToBoolean(dt.Rows[0][2]));
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
