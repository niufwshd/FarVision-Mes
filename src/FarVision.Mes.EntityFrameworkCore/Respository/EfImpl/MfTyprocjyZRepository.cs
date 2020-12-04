using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MfTyprocjyZRepository : EfCoreRepository<MesDbContext,MfTyprocjyZ, int >, IMfTyprocjyZRepository
	{
		public MfTyprocjyZRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}