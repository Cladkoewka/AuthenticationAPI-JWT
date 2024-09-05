namespace authentication.Models;

public record RegisterUserRequest(string UserName, string FirstName, string Password);