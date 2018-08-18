using Vk.CSharp.Sdk.External;
using Vk.CSharp.Sdk.Global.Models;

namespace Vk.CSharp.Sdk.Internal
{
    internal class EnvironmentProvider : IEnvironment
    {
        public Environment GetEnvironment()
        {
            return Core.GetEnvironment();
        }
    }
}