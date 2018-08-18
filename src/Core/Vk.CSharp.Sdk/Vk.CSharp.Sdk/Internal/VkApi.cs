using Vk.CSharp.Sdk.External;
using Vk.CSharp.Sdk.External.Models;
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
            }

            return new AuthorizationResult();
        }

        private void InitEnvironment()
        {
            Environment = new Environment();

            Environment.Version = Core.Version.GetStringValue();
        }
    }
}