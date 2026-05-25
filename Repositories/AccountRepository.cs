using BusinessObjects.Models;
using DataAccessObjects;

namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public AccountMember GetAccountMemberByEmail(string email) =>
            AccountDAO.GetAccountMemberByEmail(email);
    }
}
