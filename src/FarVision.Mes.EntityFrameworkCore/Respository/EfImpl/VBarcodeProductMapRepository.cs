using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VBarcodeProductMapRepository : EfCoreRepository<MesDbContext,VBarcodeProductMap, int >, IVBarcodeProductMapRepository
	{
		public VBarcodeProductMapRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}