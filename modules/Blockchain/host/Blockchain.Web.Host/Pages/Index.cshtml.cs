using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Blockchain.Pages;

public class IndexModel : BlockchainPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
