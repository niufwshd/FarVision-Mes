using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VmfTzOeeRepository : EfCoreRepository<MesDbContext,VmfTzOee, int >, IVmfTzOeeRepository
	{
		public VmfTzOeeRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}