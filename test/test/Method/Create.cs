using System.Configuration;
using test.Data;
using test.Repository;
namespace test.Method
{
    public static class Create
    {
        static IMessageSender CreateMessageSender()
        {
            IMessageSender retVal;
            string messageSender = ConfigurationManager.AppSettings["message"].ToString();
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
        static ILogger CreateLogger()
        {
            ILogger retVal;
            string logger = ConfigurationManager.AppSettings["logger"].ToString();
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
