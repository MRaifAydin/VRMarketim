using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.Business.Abstract;
using VrMarketim.DataAccess.Abstract;
using VrMarketim.Dto.Conversion;
using VrMarketim.Dto.Dto;

namespace VrMarketim.Business.Concrete
{
    public class AccountManager : IAccountService
    {
        private IAccountRepository _accountRepository;

        public AccountManager(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public bool CreateUser(AccountDto account)
        {
            if ((_accountRepository.GetUser(AccountConversion.ToEntity(account)).Mail != account.Mail) && (account.Password == account.SPassword))
            {
                _accountRepository.CreateUser(AccountConversion.ToEntity(account));
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckUser(AccountDto account)
        {
            if (_accountRepository.GetUser(AccountConversion.ToEntity(account)).Password == account.Password)
            {
                return true;
            }
            else { return false; }
        }
    }
}
