using Vk.CSharp.Sdk.External;
using Vk.CSharp.Sdk.Global.Exceptions;
using Vk.CSharp.Sdk.Global.Models;

namespace Vk.CSharp.Sdk.Internal
{
    internal class EnvironmentProvider : IEnvironmentProvider
    {
        public Environment GetEnvironment()
        {
            return Core
                .GetEnvironment()
                .Clone() as Environment;
        }

        /// <summary>
        /// Валидирует окружение.
        /// </summary>
        public void ValidateEnvironment()
        {
            if (string.IsNullOrWhiteSpace(Core.GetEnvironment().AccessToken))
            {
                throw new InvalidAccessTokenException(
                    "Окружение содержит неверный ключ доступа. Возможно, вы не авторизовались.");
            }
        }
    }
}