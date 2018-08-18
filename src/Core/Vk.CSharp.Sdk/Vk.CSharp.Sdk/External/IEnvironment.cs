using Vk.CSharp.Sdk.Global.Models;

namespace Vk.CSharp.Sdk.External
{
    public interface IEnvironment
    {
        /// <summary>
        /// Возвращает окружение.
        /// </summary>
        /// <returns>Окружение.</returns>
        Environment GetEnvironment();
    }
}