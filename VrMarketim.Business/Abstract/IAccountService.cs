using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.Entities;

namespace VrMarketim.Business.Abstract
{
    public interface IAccountService
    {
        bool CheckUser(User user);

        bool CreateUser(Account account);

        Account UpdateUser(Account account);
    }
}
