using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class QmProcessInspectionRepository : EfCoreRepository<MesDbContext,QmProcessInspection, int >, IQmProcessInspectionRepository
	{
		public QmProcessInspectionRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}