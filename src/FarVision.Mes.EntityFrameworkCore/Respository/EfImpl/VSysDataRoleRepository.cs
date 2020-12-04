using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VSysDataRoleRepository : EfCoreRepository<MesDbContext,VSysDataRole, int >, IVSysDataRoleRepository
	{
		public VSysDataRoleRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}