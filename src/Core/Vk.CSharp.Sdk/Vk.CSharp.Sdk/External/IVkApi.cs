using Vk.CSharp.Sdk.External.Models;

namespace Vk.CSharp.Sdk.External
{
    /// <summary>
    /// API ВКонтакте.
    /// </summary>
    public interface IVkApi
    {
        /// <summary>
        /// Возвращает окружение.
        /// </summary>
        /// <returns>Окружение.</returns>
        VkApiEnvironment GetEnvironment();
    }
}