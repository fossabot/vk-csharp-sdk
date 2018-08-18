namespace Vk.CSharp.Sdk.Internal.Constants.Methods
{
    // Ссылка: https://vk.com/dev/account

    /// <summary>
    /// Названия методов модуля для работы с аккаунтом.
    /// </summary>
    public static class AccountMethods
    {
        /// <summary>
        /// Приставка к команде.
        /// </summary>
        public static string Prefix = "account";

        /// <summary>
        /// Добавляет пользователя или группу в черный список.
        /// </summary>
        public static string Ban = "ban";

        /// <summary>
        /// Позволяет сменить пароль пользователя после успешного восстановления доступа к аккаунту через СМС.
        /// </summary>
        public static string ChangePassword = "changePassword";

        /// <summary>
        /// Возвращает список активных рекламных предложений (офферов).
        /// </summary>
        public static string GetActiveOffers = "getActiveOffers";

        /// <summary>
        /// Получает настройки текущего пользователя в данном приложении.
        /// </summary>
        public static string GetAppPermissions = "getAppPermissions";

        /// <summary>
        /// Возвращает список пользователей, находящихся в черном списке.
        /// </summary>
        public static string GetBanned = "getBanned";

        /// <summary>
        /// Возвращает ненулевые значения счетчиков пользователя.
        /// </summary>
        public static string GetCounters = "getCounters";

        /// <summary>
        /// Возвращает информацию о текущем аккаунте.
        /// </summary>
        public static string GetInfo = "getInfo";

        /// <summary>
        /// Возвращает информацию о текущем профиле.
        /// </summary>
        public static string GetProfileInfo = "getProfileInfo";

		// TODO: Добавить остальные методы.
    }
}