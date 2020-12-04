using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TfUnqcdspInfosRepository : EfCoreRepository<MesDbContext,TfUnqcdspInfos, int >, ITfUnqcdspInfosRepository
	{
		public TfUnqcdspInfosRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}