using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.Dto.Dto;
using VrMarketim.Entities;

namespace VrMarketim.Dto.Conversion
{
    public class AccountConversion
    {
        public static Account ToEntity(AccountDto account)
        {
            return new Account
            {
                Mail = account.Mail,
                Password = account.Password,
                Name = account.Name,
                Surname = account.Surname,
                Address = account.Address,
            };
        }

        public static AccountDto ToApi(Account account)
        {
            return new AccountDto
            {
                Mail = account.Mail,
                Password = account.Password,
                Name = account.Name,
                Surname = account.Surname,
                Address = account.Address,
            };
        }
    }
}
