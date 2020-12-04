using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class BfRptTempletCRepository : EfCoreRepository<MesDbContext,BfRptTempletC, int >, IBfRptTempletCRepository
	{
		public BfRptTempletCRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}