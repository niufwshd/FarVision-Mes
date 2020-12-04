using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TbSzbhzCqRepository : EfCoreRepository<MesDbContext,TbSzbhzCq, int >, ITbSzbhzCqRepository
	{
		public TbSzbhzCqRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}