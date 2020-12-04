using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TmpJjgHglRepository : EfCoreRepository<MesDbContext,TmpJjgHgl, int >, ITmpJjgHglRepository
	{
		public TmpJjgHglRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}