using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VAndonRespPstateRepository : EfCoreRepository<MesDbContext,VAndonRespPstate, int >, IVAndonRespPstateRepository
	{
		public VAndonRespPstateRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}