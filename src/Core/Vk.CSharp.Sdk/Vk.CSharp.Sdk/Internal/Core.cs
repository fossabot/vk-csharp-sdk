using System;
using Vk.CSharp.Sdk.Internal.Extensions;
using Environment = Vk.CSharp.Sdk.Global.Models.Environment;
using Version = Vk.CSharp.Sdk.Internal.Enums.Version;

namespace Vk.CSharp.Sdk.Internal
{
    internal static class Core
    {
        /// <summary>
        /// Текущая версия API ВКонтакте.
        /// </summary>
        public static Version CurrentVersion => Version.V580;

        /// <summary>
        /// Окружение.
        /// </summary>
        public static Environment Environment => LazyEnvironment.Value;

        /// <summary>
        /// Возвращает окружение.
        /// </summary>
        /// <returns>Окружение.</returns>
        public static Environment GetEnvironment()
        {
            return LazyEnvironment.Value;
        }

        /// <summary>
        /// Сохраняет ключ доступа в окружение.
        /// </summary>
        /// <param name="accessToken">Ключ доступа.</param>
        public static void SaveAccessTokenToEnvironment(string accessToken)
            => Environment.AccessToken = accessToken;

        private static readonly Lazy<Environment> LazyEnvironment =
            new Lazy<Environment>(CreateEnvironment);

        private static Environment CreateEnvironment()
        {
            return new Environment
            {
                Version = CurrentVersion.GetStringValue()
            };
        }
    }
}