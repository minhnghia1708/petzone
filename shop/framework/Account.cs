using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace shop.framework
{
    public class Account
    {
        private Model1 context = null;
        public Account()
        {
            context = new Model1();
        }

        public bool Login(string UserName, string password)
        {
            object[] sqlParams =
            {
            new SqlParameter ("@user",UserName),
            new SqlParameter("@password", password)
            };

            var res = context.Database.SqlQuery<bool>("SP_Account_Login @user,@password", sqlParams).SingleOrDefault();
            return res;

        }
    }

}