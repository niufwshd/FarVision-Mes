using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PcInOutPutRelationRepository : EfCoreRepository<MesDbContext,PcInOutPutRelation, int >, IPcInOutPutRelationRepository
	{
		public PcInOutPutRelationRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}