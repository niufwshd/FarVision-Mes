using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TypeUnqualifiedRepository : EfCoreRepository<MesDbContext,TypeUnqualified, int >, ITypeUnqualifiedRepository
	{
		public TypeUnqualifiedRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}