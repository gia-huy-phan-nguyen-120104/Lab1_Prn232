using BusinessObjects.Models;

namespace DataAccessObjects
{
    public class AccountDAO
    {
        public static AccountMember GetAccountMemberByEmail(string email)
        {
            AccountMember member = null;

            try
            {
                using var context = new MyStoreContext();

                member = context.AccountMembers
                    .SingleOrDefault(x => x.EmailAddress == email);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return member;
        }
    }
}