using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class QcRecordvalueRepository : EfCoreRepository<MesDbContext,QcRecordvalue, int >, IQcRecordvalueRepository
	{
		public QcRecordvalueRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}