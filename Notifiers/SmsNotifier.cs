using System;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using arrobas.addling.Notifiers;
using Nml.Refactor.Me.Dependencies;
using Nml.Refactor.Me.MessageBuilders;
using arrobas.addling.MessageBuilders;

namespace Nml.Refactor.Me.Notifiers
{
	public class SmsNotifier : BaseNotifier
	{
		

		public SmsNotifier(IStringMessageBuilder messageBuilder, IOptions options) :base(messageBuilder,options)
		{
		}
		
		public override async Task Notify(NotificationMessage message)
		{
          
            var sms = new SmsApiClient(_options.Sms.ApiUri, _options.Sms.ApiKey);
            
            var smsMessage = (SMSMessage)_messageBuilder.CreateMessage(message);

            try
            {
                await sms.SendAsync(smsMessage.MobileNo, smsMessage.Message);
               
                _logger.LogTrace($"Message sent.");
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Failed to send message. {e.Message}");
                throw;
            }
        }
	}
}
