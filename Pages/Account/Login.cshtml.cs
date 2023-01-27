using Auth0.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Auth0PoC.Pages.Account;

public class LoginModel : PageModel
{
    public async Task OnGet([FromQuery] string returnUrl = "/")
    {
        var authProperties = new LoginAuthenticationPropertiesBuilder()
            .WithRedirectUri(returnUrl)
            .WithAudience("PoC")
            .Build();

        await HttpContext.ChallengeAsync(Auth0Constants.AuthenticationScheme, authProperties);
    }
}