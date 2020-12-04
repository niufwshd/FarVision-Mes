using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TbTransferinoutRepository : EfCoreRepository<MesDbContext,TbTransferinout, int >, ITbTransferinoutRepository
	{
		public TbTransferinoutRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}