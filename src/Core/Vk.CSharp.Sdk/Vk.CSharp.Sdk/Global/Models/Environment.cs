using System;

namespace Vk.CSharp.Sdk.Global.Models
{
    /// <summary>
    /// Окружение.
    /// </summary>
    public class Environment : ICloneable
    {
        /// <summary>
        /// Версия.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Ключ доступа.
        /// </summary>
        public string AccessToken { get; set; } = string.Empty;

        /// <summary>
        /// Делает копию объекта (клонирует).
        /// </summary>
        public object Clone()
        {
            return new Environment
            {
                Version = Version,
                AccessToken = AccessToken
            };
        }
    }
}