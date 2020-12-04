using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VAndonRespstateRepository : EfCoreRepository<MesDbContext,VAndonRespstate, int >, IVAndonRespstateRepository
	{
		public VAndonRespstateRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}