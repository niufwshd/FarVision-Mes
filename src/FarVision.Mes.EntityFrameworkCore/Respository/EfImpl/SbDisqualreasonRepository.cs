using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SbDisqualreasonRepository : EfCoreRepository<MesDbContext,SbDisqualreason, int >, ISbDisqualreasonRepository
	{
		public SbDisqualreasonRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}