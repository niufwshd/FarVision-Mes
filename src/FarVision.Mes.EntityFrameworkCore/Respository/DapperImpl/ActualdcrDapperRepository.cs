using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories.Dapper;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class ActualdcrDapperRepository : DapperRepository<MesDbContext>, ITransientDependency
	{
		public ActualdcrDapperRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}