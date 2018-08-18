using System;
using Vk.CSharp.Sdk.Core;

namespace Vk.CSharp.Sdk.External
{
    public static class VkApiProvider
    {
        private static readonly Lazy<IVkApi> Lazy =
            new Lazy<IVkApi>(() => new Core.VkApi());

        public static IVkApi GetVkApi() => Lazy.Value;
    }
}