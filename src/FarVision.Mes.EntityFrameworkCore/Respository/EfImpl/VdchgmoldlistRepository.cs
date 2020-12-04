using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VdchgmoldlistRepository : EfCoreRepository<MesDbContext,Vdchgmoldlist, int >, IVdchgmoldlistRepository
	{
		public VdchgmoldlistRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}