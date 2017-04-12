using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Data;

namespace test.Repository
{
    class MailSender : IMessageSender
    {
        public void sendMessage(string msg)
        {
            Console.WriteLine(String.Format($"MailSender : {msg}"));
        }
    }
}
