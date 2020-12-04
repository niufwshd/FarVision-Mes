using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace FarVision.Mes.Pages
{
    public class Index_Tests : MesWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
