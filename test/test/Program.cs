using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Data;
using test.Method;
using test.Repository;

namespace test
{
    public class Program
    {
        static void Main(string[] args)
        {

            Processor processor = new Processor(CreateLogger(), CreateMessageSender());
            processor.Process();
            Console.ReadLine();
        }

        private static IMessageSender CreateMessageSender()
        {
            IMessageSender retVal;
            // string messageSender = ConfigurationManager.AppSettings["message"].ToString();
            string messageSender = "SMS";
            if (messageSender == "SMS")
            {
                retVal = new SMSSender();
            }
            else
            {
                retVal = new MailSender();
            }
            return retVal;
        }

        private static ILogger CreateLogger()
        {
            ILogger retVal;
            string logger = "DB";
            if (logger == "DB")
            {
                retVal = new DBLogger();
            }
            else
            {
                retVal = new FileLogger();
            }
            return retVal;
        }
    }




}
