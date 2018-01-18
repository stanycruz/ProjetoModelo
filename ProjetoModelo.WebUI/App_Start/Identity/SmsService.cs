using Microsoft.AspNet.Identity;
using ProjetoModelo.Domain.Abstract;
using ProjetoModelo.WebUI.Domain;
using ProjetoModelo.WebUI.Domain.Twilio;
using System.Threading.Tasks;

namespace ProjetoModelo.WebUI.Identity
{
    public class SmsService : IIdentityMessageService
    {
        private readonly ITwilioMessageSender _messageSender;

        public SmsService() : this(new TwilioMessageSender()) { }

        public SmsService(ITwilioMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public async Task SendAsync(IdentityMessage message)
        {
            await _messageSender.SendMessageAsync(message.Destination,
                                                  Config.TwilioNumber,
                                                  message.Body);
        }
    }
}