using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class BarcodeProductMapRepository : EfCoreRepository<MesDbContext,BarcodeProductMap, int >, IBarcodeProductMapRepository
	{
		public BarcodeProductMapRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}