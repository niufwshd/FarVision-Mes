using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TmpSzbdataRepository : EfCoreRepository<MesDbContext,TmpSzbdata, int >, ITmpSzbdataRepository
	{
		public TmpSzbdataRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}