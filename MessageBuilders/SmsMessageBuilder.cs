using arrobas.addling.MessageBuilders;
using Nml.Refactor.Me.Notifiers;
using System.Net.Mail;

namespace Nml.Refactor.Me.MessageBuilders
{
	public class SmsMessageBuilder : ISMSMessageBuilder
	{
		public SMSMessage CreateMessage(NotificationMessage message)
		{
			SMSMessage smsMessage = new SMSMessage(message.To, message.Body);
			return smsMessage;
		}
	}
}
