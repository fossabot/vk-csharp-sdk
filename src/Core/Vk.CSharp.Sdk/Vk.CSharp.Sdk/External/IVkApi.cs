using Vk.CSharp.Sdk.Global.Models;
using Vk.CSharp.Sdk.External.Modules;

namespace Vk.CSharp.Sdk.External
{
    /// <summary>
    /// API ВКонтакте.
    /// </summary>
    public interface IVkApi : IEnvironment
    {
        /// <summary>
        /// Возвращает интерфейс для работы с аккаунтом.
        /// </summary>
        IAccount GetAccount();

        /// <summary>
        /// Возвращает интерфейс для работы с рекламным кабинетом.
        /// </summary>
        IAds GetAds();

        /// <summary>
        /// Возвращает интерфейс для работы с личными сообщениями.
        /// </summary>
        IMessages GetMessages();

        /// <summary>
        /// Возвращает интерфейс для работы с записями на стене.
        /// </summary>
        IWall GetWall();

        /// <summary>
        /// Выполняет авторизацию.
        /// </summary>
        /// <param name="data">Данные для авторизации.</param>
        /// <returns>Результат авторизации.</returns>
        AuthorizationResult Authorize(AuthorizationData data);
    }
}