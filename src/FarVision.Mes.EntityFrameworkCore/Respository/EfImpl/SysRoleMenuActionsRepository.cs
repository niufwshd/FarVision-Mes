using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysRoleMenuActionsRepository : EfCoreRepository<MesDbContext,SysRoleMenuActions, int >, ISysRoleMenuActionsRepository
	{
		public SysRoleMenuActionsRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}