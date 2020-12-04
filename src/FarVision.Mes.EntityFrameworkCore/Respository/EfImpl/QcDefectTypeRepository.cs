using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class QcDefectTypeRepository : EfCoreRepository<MesDbContext,QcDefectType, int >, IQcDefectTypeRepository
	{
		public QcDefectTypeRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}