using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories.Dapper;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MfJxzbSzDapperRepository : DapperRepository<MesDbContext>, ITransientDependency
	{
		public MfJxzbSzDapperRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}