using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MVC_Application_Project.Models
{
    public class LoginModel
    {
        string constr = null;
        DataSet ds = null;
        public Dictionary<string,string> Login()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            try
            {
                string name = "Manoj";
                constr = ConfigurationManager.ConnectionStrings["ConString"].ToString();
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                string sqlcmd = "select * from UserLoginInfo where UserName like '%" + name+"%'";
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result["UserName"] = ds.Tables[0].Rows[0]["UserName"].ToString(); ;
                        result["UserRole"] = ds.Tables[0].Rows[0]["RoleId"].ToString(); ;
                        
                    }
                    else {
                        result = null;
                    }
                  

                }
                else {
                    result = null;
                }
            }
            catch(Exception ex) {
                throw new Exception(ex.Message);
            }

            return result;
             
        }
    }
}