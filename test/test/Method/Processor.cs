using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Data;
using test.Method;
namespace test.Method
{
    class Processor
    {
        private readonly ILogger _logger;
        private readonly IMessageSender _messageSender;

        public Processor(ILogger logger, IMessageSender messageSender)
        {
            this._logger = logger;
            this._messageSender = messageSender;
        }

        public void Process()
        {
            _logger.writelog("Log Text");
            _messageSender.sendMessage("Message Text");
        }
    }
}
