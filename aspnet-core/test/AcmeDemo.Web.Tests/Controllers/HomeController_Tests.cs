using System.Threading.Tasks;
using AcmeDemo.Models.TokenAuth;
using AcmeDemo.Web.Controllers;
using Shouldly;
using Xunit;

namespace AcmeDemo.Web.Tests.Controllers
{
    public class HomeController_Tests: AcmeDemoWebTestBase
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