using BusinessObjects.Models;

namespace Services
{
    public interface IAccountService
    {
        AccountMember GetAccountMemberByEmail(string email);
    }
}
