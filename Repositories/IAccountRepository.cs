using BusinessObjects.Models;

namespace Repositories
{
    public interface IAccountRepository
    {
        AccountMember GetAccountMemberByEmail(string email);
    }
}
