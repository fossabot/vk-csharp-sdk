using Vk.CSharp.Sdk.Global.Models;

namespace Vk.CSharp.Sdk.External
{
    /// <summary>
    /// Интерфейс провадйерп окружения.
    /// </summary>
    public interface IEnvironmentProvider
    {
        /// <summary>
        /// Возвращает окружение.
        /// </summary>
        /// <returns>Окружение.</returns>
        Environment GetEnvironment();
    }
}