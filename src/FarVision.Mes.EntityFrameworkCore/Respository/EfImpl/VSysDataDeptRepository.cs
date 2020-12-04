using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VSysDataDeptRepository : EfCoreRepository<MesDbContext,VSysDataDept, int >, IVSysDataDeptRepository
	{
		public VSysDataDeptRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}