using Vk.CSharp.Sdk.External;
using Vk.CSharp.Sdk.External.Modules;
using Vk.CSharp.Sdk.Global.Models;

namespace Vk.CSharp.Sdk.Internal
{
    internal class VkApi : Core, IVkApi
    {
        public IAccount GetAccount()
        {
            return VkApiProvider.GetAccount();
        }

        public IAds GetAds()
        {
            return VkApiProvider.GetAds();
        }

        public IMessages GetMessages()
        {
            return VkApiProvider.GetMessages();
        }

        public IWall GetWall()
        {
            return VkApiProvider.GetWall();
        }

        public AuthorizationResult Authorize(AuthorizationData data)
        {
            if (!string.IsNullOrEmpty(data.AccessToken))
            {
                Environment.AccessToken = data.AccessToken;
                return CreateSuccessAuthorizationResult();
            }

            return CreateFailureAuthorizationResult();
        }

        private AuthorizationResult CreateSuccessAuthorizationResult() =>
            new AuthorizationResult { Success = true };

        private AuthorizationResult CreateFailureAuthorizationResult() =>
            new AuthorizationResult { Success = false };
    }
}