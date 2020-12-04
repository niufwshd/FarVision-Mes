using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class QmInspectTdRepository : EfCoreRepository<MesDbContext,QmInspectTd, int >, IQmInspectTdRepository
	{
		public QmInspectTdRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}