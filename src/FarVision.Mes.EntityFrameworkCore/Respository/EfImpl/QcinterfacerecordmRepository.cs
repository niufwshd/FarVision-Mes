using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class QcinterfacerecordmRepository : EfCoreRepository<MesDbContext,Qcinterfacerecordm, int >, IQcinterfacerecordmRepository
	{
		public QcinterfacerecordmRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}