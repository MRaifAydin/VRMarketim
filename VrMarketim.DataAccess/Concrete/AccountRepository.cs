using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.DataAccess.Abstract;
using VrMarketim.Entities;

namespace VrMarketim.DataAccess.Concrete
{
    public class AccountRepository : IAccountRepository
    {
        public Account CreateUser(Account account)
        {
            using (var databaseContext = new DatabaseContext())
            {
                databaseContext.Accounts.Add(account);
                databaseContext.SaveChanges();
                return account;
            }
        }

        public Account GetUser(User user)
        {
            using (var databaseContext = new DatabaseContext())
            {
                var _user = databaseContext.Accounts.FirstOrDefault(a => a.Mail == user.Mail);
                if (_user == null)
                {
                    return new Account();
                }
                else { return _user; }
            }
        }

        public Account UpdateUser(Account account)
        {
            using (var databaseContext = new DatabaseContext())
            {
                databaseContext.Accounts.Update(account);
                databaseContext.SaveChanges();
                return account;
            }
        }
    }
}
