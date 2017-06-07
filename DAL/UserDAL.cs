using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BEL;

namespace DAL
{
    public class UserDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);

        public UserBEL Login(UserBEL user)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Login",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", user.username);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                using(IDataReader dr = cmd.ExecuteReader())
                {
                    if (!dr.Read()) return null;

                    return new UserBEL(){
                        user_id = dr.GetInt32(0),
                        username = dr.GetString(1),
                        password = dr.GetString(2)
                    };
                }
            }
            catch(Exception) { throw; }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
        }

        public UserBEL getUser(long user_id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spGetUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_id", user_id);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    if (!dr.Read()) return null;

                    return new UserBEL()
                    {
                        user_id = dr.GetInt32(0),
                        username = dr.GetString(1),
                        password = dr.GetString(2)
                    };
                }
            }
            catch (Exception) { throw; }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
        }
    }
}
