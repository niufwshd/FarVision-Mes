using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SbChangeListViewRepository : EfCoreRepository<MesDbContext,SbChangeListView, int >, ISbChangeListViewRepository
	{
		public SbChangeListViewRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}