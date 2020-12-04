using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class QciteminterfaceRepository : EfCoreRepository<MesDbContext,Qciteminterface, int >, IQciteminterfaceRepository
	{
		public QciteminterfaceRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}