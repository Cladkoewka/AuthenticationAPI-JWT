using System.Diagnostics;
using authentication.Models;
using authentication.Repositories;
using Microsoft.AspNetCore.Identity;

namespace authentication.Services;

public class AccountService(AccountRepository accountRepository, JwtService jwtService)
{
    public void Register(string userName, string firstName, string password)
    {
        var account = new Account
        {
            UserName = userName,
            FirstName = firstName,
            Id = Guid.NewGuid(),

        };
        var hashPassword = new PasswordHasher<Account>().HashPassword(account, password);
        account.PasswordHash = hashPassword;
        accountRepository.Add(account);
     }
    
    public string Login(string userName, string password)
    {
        var account = accountRepository.GetByUserName(userName);
        if (account == null)
        {
            Console.Write("Null user");
        }
        var result = new PasswordHasher<Account>()
            .VerifyHashedPassword(account, account.PasswordHash, password);
        if (result == PasswordVerificationResult.Success)
        {
            return jwtService.GenerateToken(account);
        }
        else
        {
            throw new Exception("No user");
        }
    }
}