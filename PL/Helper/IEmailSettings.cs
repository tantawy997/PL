using DAL.Entities;
using System.Threading.Tasks;

namespace PL.Helper
{
    public interface IEmailSettings
    {
        Task  SendEmail(Email email);
    }
}
