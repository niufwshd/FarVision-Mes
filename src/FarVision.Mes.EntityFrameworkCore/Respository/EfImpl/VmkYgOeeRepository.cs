using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VmkYgOeeRepository : EfCoreRepository<MesDbContext,VmkYgOee, int >, IVmkYgOeeRepository
	{
		public VmkYgOeeRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}