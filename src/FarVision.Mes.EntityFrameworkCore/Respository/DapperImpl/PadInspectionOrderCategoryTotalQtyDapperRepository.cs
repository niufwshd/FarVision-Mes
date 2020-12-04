using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories.Dapper;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PadInspectionOrderCategoryTotalQtyDapperRepository : DapperRepository<MesDbContext>, ITransientDependency
	{
		public PadInspectionOrderCategoryTotalQtyDapperRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}