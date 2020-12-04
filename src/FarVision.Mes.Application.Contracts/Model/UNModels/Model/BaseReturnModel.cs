using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model
{
    public class BaseReturnModel
    {
        public BaseModel HEAD { get; set; }
        public List<BaseModel> ITEM { get; set; }
    }
}
