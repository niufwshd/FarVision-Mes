using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MdmFormAttributeRepository : EfCoreRepository<MesDbContext,MdmFormAttribute, int >, IMdmFormAttributeRepository
	{
		public MdmFormAttributeRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}