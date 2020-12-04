using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class QmMfQcXjRepository : EfCoreRepository<MesDbContext,QmMfQcXj, int >, IQmMfQcXjRepository
	{
		public QmMfQcXjRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}