using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VTdCodeBusi1Repository : EfCoreRepository<MesDbContext,VTdCodeBusi1, int >, IVTdCodeBusi1Repository
	{
		public VTdCodeBusi1Repository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}