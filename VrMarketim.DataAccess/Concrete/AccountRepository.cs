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

        public Account GetUser(Account account)
        {
            using (var databaseContext = new DatabaseContext())
            {
                var user = databaseContext.Accounts.FirstOrDefault(a => a.Mail == account.Mail);
                if (user == null)
                {
                    return new Account();
                }
                return user;
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
