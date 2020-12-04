using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysRoleDataBusiRepository : EfCoreRepository<MesDbContext,SysRoleDataBusi, int >, ISysRoleDataBusiRepository
	{
		public SysRoleDataBusiRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}