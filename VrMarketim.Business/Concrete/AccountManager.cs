using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.Business.Abstract;
using VrMarketim.DataAccess.Abstract;
using VrMarketim.Entities;

namespace VrMarketim.Business.Concrete
{
    public class AccountManager : IAccountService
    {
        private IAccountRepository _accountRepository;

        public AccountManager(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public bool CreateUser(Account account)
        {
            User user = new User();
            user.Mail = account.Mail;
            user.Password = account.Password;
                
            if ((_accountRepository.GetUser(user).Mail != account.Mail))
            {
                _accountRepository.CreateUser(account);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckUser(User user)
        {
            if (_accountRepository.GetUser(user).Password == user.Password)
            {
                return true;
            }
            else { return false; }
        }

        public Account UpdateUser(Account account)
        {
            return _accountRepository.UpdateUser(account);
        }
    }
}
