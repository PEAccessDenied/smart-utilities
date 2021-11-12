using System.Threading.Tasks;
using SmartUtilities.Models.TokenAuth;
using SmartUtilities.Web.Controllers;
using Shouldly;
using Xunit;

namespace SmartUtilities.Web.Tests.Controllers
{
    public class HomeController_Tests: SmartUtilitiesWebTestBase
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