using BusinessObjects.Models;
using Repositories;

namespace Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService()
        {
            _accountRepository = new AccountRepository();
        }

        public AccountMember GetAccountMemberByEmail(string email) =>
            _accountRepository.GetAccountMemberByEmail(email);
    }
}
