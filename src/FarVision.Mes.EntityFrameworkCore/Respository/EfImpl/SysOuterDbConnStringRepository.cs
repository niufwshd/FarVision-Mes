using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysOuterDbConnStringRepository : EfCoreRepository<MesDbContext,SysOuterDbConnString, int >, ISysOuterDbConnStringRepository
	{
		public SysOuterDbConnStringRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}