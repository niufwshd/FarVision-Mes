using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class QcinterfacerecordvRepository : EfCoreRepository<MesDbContext,Qcinterfacerecordv, int >, IQcinterfacerecordvRepository
	{
		public QcinterfacerecordvRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}