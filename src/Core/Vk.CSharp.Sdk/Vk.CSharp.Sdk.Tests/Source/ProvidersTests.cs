using Vk.CSharp.Sdk.External;
using Vk.CSharp.Sdk.Global.Exceptions;
using Vk.CSharp.Sdk.Global.Models;
using Xunit;

namespace Vk.CSharp.Sdk.Tests.Source
{
    public class ProvidersTests
    {
        protected string AccessToken => "access_token";

        public ProvidersTests()
        {
            VkApiProvider
                .GetVkApi()
                .Authorize(new AuthorizationData(AccessToken));
        }

        [Fact]
        public void VkApiProvider_References_Test()
        {
            var account = VkApiProvider
                .GetVkApi()
                .GetAccount();

            Assert.Same(account, VkApiProvider.GetAccount());

            account = VkApiProvider
                .GetAccount();

            Assert.Same(account, VkApiProvider.GetAccount());
        }

        [Fact]
        public void EnvironmentProvider_Mutations_Test()
        {
            var environment = VkApiProvider
                .GetMessages()
                .GetEnvironment();

            Assert.Equal(AccessToken, environment.AccessToken);

            VkApiProvider
                .GetMessages()
                .GetEnvironment()
                .AccessToken = "new_access_token";

            environment = VkApiProvider
                .GetEnvironmentProvider()
                .GetEnvironment();

            Assert.Equal(AccessToken, environment.AccessToken);
        }

        [Fact]
        public void EnvironmentProvider_Deauthorization_Test()
        {
            VkApiProvider
                .GetVkApi()
                .Authorize(new AuthorizationData(AccessToken));

            VkApiProvider
                .GetAccount()
                .GetInfo();

            VkApiProvider.Deauthorize();

            // Возникнет исключение, так как была произведена деавторизация (очищено окружение).
            Assert.Throws<InvalidAccessTokenException>(() => VkApiProvider.GetAccount().GetInfo());
        }
    }
}