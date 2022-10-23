using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Blockchain.Web.Menus;

public class BlockchainMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(BlockchainMenus.Prefix, displayName: "Blockchain", "~/Blockchain", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
