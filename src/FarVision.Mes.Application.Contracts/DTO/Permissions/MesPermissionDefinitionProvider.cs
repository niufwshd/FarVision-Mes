using FarVision.Mes.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FarVision.Mes.Permissions
{
    public class MesPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MesPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(MesPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MesResource>(name);
        }
    }
}
