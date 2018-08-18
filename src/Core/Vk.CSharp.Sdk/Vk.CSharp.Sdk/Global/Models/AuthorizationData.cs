using Vk.CSharp.Sdk.Global.Enums;

namespace Vk.CSharp.Sdk.Global.Models
{
    /// <summary>
    /// Данные для атворизации.
    /// </summary>
    public class AuthorizationData
    {
        /// <summary>
        /// Логин.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Идентификатор приложения.
        /// </summary>
        public long ApplicationId { get; set; }

        /// <summary>
        /// Права доступа.
        /// По умолчанию: <see cref="UserRights.All" />.
        /// </summary>
        public UserRights Rights { get; set; } = UserRights.All;

        /// <summary>
        /// Ключ доступа.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="AuthorizationData" />.
        /// </summary>
        /// <param name="login">Логин.</param>
        /// <param name="password">Пароль.</param>
        public AuthorizationData(string login, string password)
        {
            Login = login;
            Password = password;
        }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="AuthorizationData" />.
        /// </summary>
        /// <param name="accessToken">Ключ доступа.</param>
        public AuthorizationData(string accessToken)
        {
            AccessToken = accessToken;
        }
    }
}