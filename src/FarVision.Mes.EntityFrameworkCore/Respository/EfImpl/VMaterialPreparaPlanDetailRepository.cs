using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VMaterialPreparaPlanDetailRepository : EfCoreRepository<MesDbContext,VMaterialPreparaPlanDetail, int >, IVMaterialPreparaPlanDetailRepository
	{
		public VMaterialPreparaPlanDetailRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}