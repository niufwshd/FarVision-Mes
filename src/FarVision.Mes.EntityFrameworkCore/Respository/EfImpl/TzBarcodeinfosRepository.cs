using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TzBarcodeinfosRepository : EfCoreRepository<MesDbContext,TzBarcodeinfos, int >, ITzBarcodeinfosRepository
	{
		public TzBarcodeinfosRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}