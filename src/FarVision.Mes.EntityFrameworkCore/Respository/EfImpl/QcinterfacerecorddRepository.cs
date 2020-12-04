using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class QcinterfacerecorddRepository : EfCoreRepository<MesDbContext,Qcinterfacerecordd, int >, IQcinterfacerecorddRepository
	{
		public QcinterfacerecorddRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}