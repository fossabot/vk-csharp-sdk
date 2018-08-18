using Vk.CSharp.Sdk.External;
using Vk.CSharp.Sdk.External.Models;
using Vk.CSharp.Sdk.Internal.Enums;
using Vk.CSharp.Sdk.Internal.Extensions;

namespace Vk.CSharp.Sdk.Internal
{
    internal class VkApi : IVkApi
    {
        protected VkApiEnvironment Environment { get; set; }

        public VkApi()
        {
            InitEnvironment();
        }

        public VkApiEnvironment GetEnvironment()
        {
            return Environment;
        }

        private void InitEnvironment()
        {
            Environment = new VkApiEnvironment();

            Environment.Version = VkApiVersion.V580.GetValue();
        }
    }
}