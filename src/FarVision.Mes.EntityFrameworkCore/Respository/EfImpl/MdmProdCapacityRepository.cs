using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MdmProdCapacityRepository : EfCoreRepository<MesDbContext,MdmProdCapacity, int >, IMdmProdCapacityRepository
	{
		public MdmProdCapacityRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}