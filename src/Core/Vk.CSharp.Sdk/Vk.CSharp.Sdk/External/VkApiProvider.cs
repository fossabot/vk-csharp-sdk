using System;
using Vk.CSharp.Sdk.Internal;

namespace Vk.CSharp.Sdk.External
{
    /// <summary>
    /// Провайдер API ВКонтакте.
    /// </summary>
    public static class VkApiProvider
    {
        private static readonly Lazy<IVkApi> Lazy =
            new Lazy<IVkApi>(() => new VkApi());

        /// <summary>
        /// Возвращает интерфейс для взаимодействия с API ВКонтакте.
        /// </summary>
        /// <returns>Интерфейс для взаимодействия с API ВКонтакте.</returns>
        public static IVkApi GetVkApi() => Lazy.Value;
    }
}