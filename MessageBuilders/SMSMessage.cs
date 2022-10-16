using System;
using System.Collections.Generic;
using System.Text;

namespace arrobas.addling.MessageBuilders
{
    public class SMSMessage
    {
        public string MobileNo { get; set; }
        public string Message { get; set; }

        public SMSMessage(string mobileNo, string message)
        {
            MobileNo = mobileNo;
            Message = message;
        }
    }
}
