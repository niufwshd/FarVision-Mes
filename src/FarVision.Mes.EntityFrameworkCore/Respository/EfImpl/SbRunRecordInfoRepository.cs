using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SbRunRecordInfoRepository : EfCoreRepository<MesDbContext,SbRunRecordInfo, int >, ISbRunRecordInfoRepository
	{
		public SbRunRecordInfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}