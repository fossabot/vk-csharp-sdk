namespace Vk.CSharp.Sdk.Global.Models
{
    /// <summary>
    /// Окружение.
    /// </summary>
    public class Environment
    {
        /// <summary>
        /// Версия.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Ключ доступа.
        /// </summary>
        public string AccessToken { get; set; } = string.Empty;
    }
}