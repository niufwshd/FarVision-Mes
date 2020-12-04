using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TfSbycbg1Repository : EfCoreRepository<MesDbContext,TfSbycbg1, int >, ITfSbycbg1Repository
	{
		public TfSbycbg1Repository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}