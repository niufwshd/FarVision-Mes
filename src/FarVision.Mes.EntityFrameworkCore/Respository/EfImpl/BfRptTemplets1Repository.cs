using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class BfRptTemplets1Repository : EfCoreRepository<MesDbContext,BfRptTemplets1, int >, IBfRptTemplets1Repository
	{
		public BfRptTemplets1Repository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}