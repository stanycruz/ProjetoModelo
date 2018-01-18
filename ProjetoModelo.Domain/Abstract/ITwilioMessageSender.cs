using System.Threading.Tasks;

namespace ProjetoModelo.Domain.Abstract
{
    public interface ITwilioMessageSender
    {
        Task SendMessageAsync(string to, string from, string body);
    }
}
