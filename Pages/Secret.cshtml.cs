using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Auth0PoC.Pages;

[Authorize(Roles = "secret_holder")]
public class Secret : PageModel
{
    public async Task OnGet()
    {
    }
}