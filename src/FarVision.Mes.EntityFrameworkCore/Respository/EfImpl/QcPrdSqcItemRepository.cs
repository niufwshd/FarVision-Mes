using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class QcPrdSqcItemRepository : EfCoreRepository<MesDbContext,QcPrdSqcItem, int >, IQcPrdSqcItemRepository
	{
		public QcPrdSqcItemRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}