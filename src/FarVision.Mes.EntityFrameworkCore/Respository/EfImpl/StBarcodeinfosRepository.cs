using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class StBarcodeinfosRepository : EfCoreRepository<MesDbContext,StBarcodeinfos, int >, IStBarcodeinfosRepository
	{
		public StBarcodeinfosRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}