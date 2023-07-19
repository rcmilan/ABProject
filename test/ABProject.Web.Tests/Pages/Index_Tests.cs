using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ABProject.Pages;

public class Index_Tests : ABProjectWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
