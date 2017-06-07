using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;

namespace BLL
{
    public class UserBLL
    {
        UserBEL uBEL = new UserBEL();
        UserDAL uDal = new UserDAL();

        public int doLogin(UserBEL u)
        {
            this.uBEL = uDal.Login(u);
            if(uBEL.user_id > 0)
            {
                if (uBEL.password == u.password)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 0;
            }
        }

        public UserBEL getProfile(long user_id)
        {
            try
            {
                this.uBEL = uDal.getUser(user_id);
            }
            catch(Exception) { this.uBEL = null; }
            return uBEL;
        }
    }
}
