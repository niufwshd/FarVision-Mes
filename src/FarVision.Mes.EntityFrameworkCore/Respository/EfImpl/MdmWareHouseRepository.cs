using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MdmWareHouseRepository : EfCoreRepository<MesDbContext,MdmWareHouse, int >, IMdmWareHouseRepository
	{
		public MdmWareHouseRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}