using Volo.Abp.Settings;

namespace Wiyu.Settings;

public class WiyuSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(WiyuSettings.MySetting1));
    }
}
