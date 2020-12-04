using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TrayBarcodeinfosRepository : EfCoreRepository<MesDbContext,TrayBarcodeinfos, int >, ITrayBarcodeinfosRepository
	{
		public TrayBarcodeinfosRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}