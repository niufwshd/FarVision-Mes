using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VrollbackwrsRepository : EfCoreRepository<MesDbContext,Vrollbackwrs, int >, IVrollbackwrsRepository
	{
		public VrollbackwrsRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}