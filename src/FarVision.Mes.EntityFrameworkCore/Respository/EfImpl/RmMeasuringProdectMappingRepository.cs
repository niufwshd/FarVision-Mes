using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmMeasuringProdectMappingRepository : EfCoreRepository<MesDbContext,RmMeasuringProdectMapping, int >, IRmMeasuringProdectMappingRepository
	{
		public RmMeasuringProdectMappingRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}