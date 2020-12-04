using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MsMeasureTypeRepository : EfCoreRepository<MesDbContext,MsMeasureType, int >, IMsMeasureTypeRepository
	{
		public MsMeasureTypeRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}