namespace   CleanArchitecture.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(),
        "firstname",
        "lastname ",
        "email@aaaa.com",
        "token");
    }

    public AuthenticationResult register(string firstname, string lastname, string email, string password)
    {
             return new AuthenticationResult(Guid.NewGuid(),
             firstname,
             lastname,
             email,
             "token");
    }
}