namespace   CleanArchitecture.Application.Services.Authentication;

public interface  IAuthenticationService{
    AuthenticationResult Login(string email,string password);
    AuthenticationResult register(string firstname, string lastname, string email,string password);

}