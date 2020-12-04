using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VSysDataUsrRepository : EfCoreRepository<MesDbContext,VSysDataUsr, int >, IVSysDataUsrRepository
	{
		public VSysDataUsrRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}