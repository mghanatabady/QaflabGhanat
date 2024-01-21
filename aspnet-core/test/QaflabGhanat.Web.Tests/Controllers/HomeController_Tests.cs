using System.Threading.Tasks;
using QaflabGhanat.Models.TokenAuth;
using QaflabGhanat.Web.Controllers;
using Shouldly;
using Xunit;

namespace QaflabGhanat.Web.Tests.Controllers
{
    public class HomeController_Tests: QaflabGhanatWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}