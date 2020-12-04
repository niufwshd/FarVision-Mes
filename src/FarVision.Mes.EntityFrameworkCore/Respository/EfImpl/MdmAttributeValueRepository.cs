using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MdmAttributeValueRepository : EfCoreRepository<MesDbContext,MdmAttributeValue, int >, IMdmAttributeValueRepository
	{
		public MdmAttributeValueRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}