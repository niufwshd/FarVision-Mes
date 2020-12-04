using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PcOutPutDefectRepository : EfCoreRepository<MesDbContext,PcOutPutDefect, int >, IPcOutPutDefectRepository
	{
		public PcOutPutDefectRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}