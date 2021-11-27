using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VrMarketim.MailService
{
    public interface IMailSender
    {
        void SendMail(Message message);
    }
}
