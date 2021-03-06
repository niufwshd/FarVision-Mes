using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories.Dapper;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VzcreslistDapperRepository : DapperRepository<MesDbContext>, ITransientDependency
	{
		public VzcreslistDapperRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}