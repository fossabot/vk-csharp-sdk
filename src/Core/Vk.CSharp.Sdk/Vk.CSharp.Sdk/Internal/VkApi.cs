using Vk.CSharp.Sdk.External;
using Vk.CSharp.Sdk.Global.Models;
using Vk.CSharp.Sdk.Internal.Extensions;

namespace Vk.CSharp.Sdk.Internal
{
    internal class VkApi : IVkApi
    {
        protected Environment Environment { get; set; }

        public VkApi()
        {
            InitEnvironment();
        }

        public Environment GetEnvironment()
        {
            return Environment;
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

        private void InitEnvironment()
        {
            Environment = new Environment();
            Environment.Version = Core.CurrentVersion.GetStringValue();
        }

        private AuthorizationResult CreateSuccessAuthorizationResult() =>
            new AuthorizationResult { Success = true };

        private AuthorizationResult CreateFailureAuthorizationResult() =>
            new AuthorizationResult { Success = false };
    }
}