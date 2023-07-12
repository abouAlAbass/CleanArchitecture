using CleanArchitecture.Application.Services.Authentication;
using CleanArchitecture.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers;

[ApiController]
[Route("auth")]

public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService){
        _authenticationService = authenticationService;
    }
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request){
        var authResult = _authenticationService.register(request.Firstname,request.Lastname,request.Email,request.Password);
        var response = new AuthenticationResponse(authResult.Id,authResult.Firstname,authResult.Lastname,authResult.Email,authResult.Token);
        return Ok(request);
    }
     
    [HttpPost("login")]
    public IActionResult Login(LoginRequest request){
        var authResult = _authenticationService.Login(request.Email,request.Password);
        var response = new AuthenticationResponse(authResult.Id,authResult.Firstname,authResult.Lastname,authResult.Email,authResult.Token);
        return Ok(response);
    }
}