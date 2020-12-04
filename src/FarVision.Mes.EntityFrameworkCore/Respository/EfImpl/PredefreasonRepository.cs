using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PredefreasonRepository : EfCoreRepository<MesDbContext,Predefreason, int >, IPredefreasonRepository
	{
		public PredefreasonRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}