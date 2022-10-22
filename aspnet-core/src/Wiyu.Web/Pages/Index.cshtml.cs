using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Wiyu.Web.Pages;

public class IndexModel : WiyuPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
