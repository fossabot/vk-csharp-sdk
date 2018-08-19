using Vk.CSharp.Sdk.External;
using Vk.CSharp.Sdk.Global.Models;

namespace Vk.CSharp.Sdk.Internal
{
    internal class EnvironmentProvider : IEnvironmentProvider
    {
        public Environment GetEnvironment()
        {
            return Core
                .GetEnvironment()
                .Clone() as Environment;
        }
    }
}