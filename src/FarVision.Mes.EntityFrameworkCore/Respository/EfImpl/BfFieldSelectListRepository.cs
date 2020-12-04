using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class BfFieldSelectListRepository : EfCoreRepository<MesDbContext,BfFieldSelectList, int >, IBfFieldSelectListRepository
	{
		public BfFieldSelectListRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}