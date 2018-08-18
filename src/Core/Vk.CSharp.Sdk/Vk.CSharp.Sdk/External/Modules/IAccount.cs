namespace Vk.CSharp.Sdk.External.Modules
{
    /// <summary>
    /// Модуль для работы с аккаунтом.
    /// </summary>
    public interface IAccount : IEnvironment
    {
        /// <summary>
        /// Возвращает информацию о текущем аккаунте.
        /// </summary>
        void GetInfo();

        /// <summary>
        /// Возвращает информацию о текущем профиле.
        /// </summary>
        void GetProfileInfo();
    }
}