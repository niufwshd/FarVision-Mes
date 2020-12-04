using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SbQrcoderecordRepository : EfCoreRepository<MesDbContext,SbQrcoderecord, int >, ISbQrcoderecordRepository
	{
		public SbQrcoderecordRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}