using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MdmProcessProductMapRepository : EfCoreRepository<MesDbContext,MdmProcessProductMap, int >, IMdmProcessProductMapRepository
	{
		public MdmProcessProductMapRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}