using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmFixtureProdectMappingRepository : EfCoreRepository<MesDbContext,RmFixtureProdectMapping, int >, IRmFixtureProdectMappingRepository
	{
		public RmFixtureProdectMappingRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}