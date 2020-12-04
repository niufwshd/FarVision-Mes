using Volo.Abp.Settings;

namespace FarVision.Mes.Settings
{
    public class MesSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(MesSettings.MySetting1));
        }
    }
}
