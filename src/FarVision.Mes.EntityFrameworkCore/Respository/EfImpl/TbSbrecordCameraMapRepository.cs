using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TbSbrecordCameraMapRepository : EfCoreRepository<MesDbContext,TbSbrecordCameraMap, int >, ITbSbrecordCameraMapRepository
	{
		public TbSbrecordCameraMapRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}