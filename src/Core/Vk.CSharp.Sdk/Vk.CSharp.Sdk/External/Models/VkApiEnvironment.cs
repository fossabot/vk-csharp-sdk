namespace Vk.CSharp.Sdk.External.Models
{
    /// <summary>
    /// Окружение.
    /// </summary>
    public class VkApiEnvironment
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