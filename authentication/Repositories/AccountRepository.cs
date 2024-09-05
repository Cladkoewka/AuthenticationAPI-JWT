using authentication.Models;

namespace authentication.Repositories;

public class AccountRepository
{
    private static IDictionary<string, Account> Accounts = new Dictionary<string, Account>();

    public void Add(Account account)
    {
        Accounts[account.UserName] = account;
    }

    public Account? GetByUserName(string userName)
    {
        return Accounts.TryGetValue(userName, out var account) ? account : null;
    }
}