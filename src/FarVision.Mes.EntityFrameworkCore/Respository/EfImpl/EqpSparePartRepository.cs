using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class EqpSparePartRepository : EfCoreRepository<MesDbContext,EqpSparePart, int >, IEqpSparePartRepository
	{
		public EqpSparePartRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}