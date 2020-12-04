using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VWorkOrderMatsExtendRepository : EfCoreRepository<MesDbContext,VWorkOrderMatsExtend, int >, IVWorkOrderMatsExtendRepository
	{
		public VWorkOrderMatsExtendRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}