using Nml.Refactor.Me.Dependencies;
using Nml.Refactor.Me.MessageBuilders;
using Nml.Refactor.Me.Notifiers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace arrobas.addling.Notifiers
{
    public abstract class BaseNotifier :INotifier
    {
        public  IMessageBuilder<Object> _messageBuilder;
        public  IOptions _options;
        public  ILogger _logger = LogManager.For<SlackNotifier>();




        public BaseNotifier(IMessageBuilder<object> messageBuilder, IOptions options)
        {
            _messageBuilder = messageBuilder ?? throw new ArgumentNullException(nameof(messageBuilder));
            _options = options ?? throw new ArgumentNullException(nameof(options));
        }

        public abstract Task Notify(NotificationMessage message);



    }
}
