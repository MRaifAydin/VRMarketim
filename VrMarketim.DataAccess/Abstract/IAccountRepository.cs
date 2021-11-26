using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.Entities;

namespace VrMarketim.DataAccess.Abstract
{
    public interface IAccountRepository
    {
        Account GetUser(Account account);

        Account CreateUser(Account account);
    }
}
