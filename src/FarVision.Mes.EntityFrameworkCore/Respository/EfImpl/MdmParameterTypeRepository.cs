using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MdmParameterTypeRepository : EfCoreRepository<MesDbContext,MdmParameterType, int >, IMdmParameterTypeRepository
	{
		public MdmParameterTypeRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}