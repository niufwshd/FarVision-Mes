using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class ModDisqualreasonRepository : EfCoreRepository<MesDbContext,ModDisqualreason, int >, IModDisqualreasonRepository
	{
		public ModDisqualreasonRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}