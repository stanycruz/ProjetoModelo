using ProjetoModelo.Domain.Abstract;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace ProjetoModelo.WebUI.Domain.Twilio
{
    public class TwilioMessageSender : ITwilioMessageSender
    {
        public TwilioMessageSender()
        {
            TwilioClient.Init(Config.AccountSid, Config.AuthToken);
        }
        public async Task SendMessageAsync(string to, string from, string body)
        {
            await MessageResource.CreateAsync(new PhoneNumber(to),
                                              from: new PhoneNumber(from),
                                              body: body);
        }
    }
}