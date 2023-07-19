using Volo.Abp.Settings;

namespace ABProject.Settings;

public class ABProjectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ABProjectSettings.MySetting1));
    }
}
