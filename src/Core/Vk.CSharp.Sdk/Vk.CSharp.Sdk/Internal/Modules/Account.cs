using Vk.CSharp.Sdk.External.Modules;

namespace Vk.CSharp.Sdk.Internal.Modules
{
    internal class Account : EnvironmentProvider, IAccount
    {
        public void GetInfo()
        {
            ValidateEnvironment();
        }

        public void GetProfileInfo()
        {
            ValidateEnvironment();
        }
    }
}