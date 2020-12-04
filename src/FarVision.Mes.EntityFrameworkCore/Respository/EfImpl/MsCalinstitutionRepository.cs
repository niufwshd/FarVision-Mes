using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MsCalinstitutionRepository : EfCoreRepository<MesDbContext,MsCalinstitution, int >, IMsCalinstitutionRepository
	{
		public MsCalinstitutionRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}