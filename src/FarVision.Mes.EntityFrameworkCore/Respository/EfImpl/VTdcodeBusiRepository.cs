using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VTdcodeBusiRepository : EfCoreRepository<MesDbContext,VTdcodeBusi, int >, IVTdcodeBusiRepository
	{
		public VTdcodeBusiRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}