using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace FarVision.Mes
{
   public  interface IUnacceptedProductionHandleRepository : IRepository<UnacceptedProductionHandle,int>
{}
}