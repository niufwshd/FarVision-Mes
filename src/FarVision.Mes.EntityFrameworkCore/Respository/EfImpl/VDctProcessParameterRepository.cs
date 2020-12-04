using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VDctProcessParameterRepository : EfCoreRepository<MesDbContext,VDctProcessParameter, int >, IVDctProcessParameterRepository
	{
		public VDctProcessParameterRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}