using System;

namespace Vk.CSharp.Sdk.Global.Exceptions
{
    /// <summary>
    /// Базовое класс для всех исключений, выбрасываемых библиотекой.
    /// </summary>
    public class VkApiException : Exception
    {
        public VkApiException() { }

        public VkApiException(string message)
            : base(message) { }

        public VkApiException(string message, Exception inner)
            : base(message, inner) { }
    }
}