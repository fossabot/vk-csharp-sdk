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
        Environment GetEnvironment();

        /// <summary>
        /// Выполняет авторизацию.
        /// </summary>
        /// <param name="data">Данные для авторизации.</param>
        /// <returns>Результат авторизации.</returns>
        AuthorizationResult Authorize(AuthorizationData data);
    }
}