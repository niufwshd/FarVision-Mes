using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MdmAqlsampleRepository : EfCoreRepository<MesDbContext,MdmAqlsample, int >, IMdmAqlsampleRepository
	{
		public MdmAqlsampleRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}