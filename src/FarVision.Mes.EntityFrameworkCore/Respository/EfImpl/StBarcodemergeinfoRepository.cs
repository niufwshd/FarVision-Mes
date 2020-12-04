using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class StBarcodemergeinfoRepository : EfCoreRepository<MesDbContext,StBarcodemergeinfo, int >, IStBarcodemergeinfoRepository
	{
		public StBarcodemergeinfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}