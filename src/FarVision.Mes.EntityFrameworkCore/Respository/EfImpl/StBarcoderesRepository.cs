using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class StBarcoderesRepository : EfCoreRepository<MesDbContext,StBarcoderes, int >, IStBarcoderesRepository
	{
		public StBarcoderesRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}