using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VQmInspectSdviewRepository : EfCoreRepository<MesDbContext,VQmInspectSdview, int >, IVQmInspectSdviewRepository
	{
		public VQmInspectSdviewRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}