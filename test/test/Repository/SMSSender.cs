using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Data;

namespace test.Repository
{
    class SMSSender : IMessageSender
    {
        public void sendMessage(string msg)
        {
            Console.WriteLine(string.Format($"SMSSender  :{msg}"));
        }
    }
}
