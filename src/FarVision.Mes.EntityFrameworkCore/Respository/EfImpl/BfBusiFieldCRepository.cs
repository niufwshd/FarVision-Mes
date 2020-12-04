using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class BfBusiFieldCRepository : EfCoreRepository<MesDbContext,BfBusiFieldC, int >, IBfBusiFieldCRepository
	{
		public BfBusiFieldCRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}