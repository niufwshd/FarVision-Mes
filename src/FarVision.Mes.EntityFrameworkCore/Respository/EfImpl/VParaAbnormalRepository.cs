using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VParaAbnormalRepository : EfCoreRepository<MesDbContext,VParaAbnormal, int >, IVParaAbnormalRepository
	{
		public VParaAbnormalRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}