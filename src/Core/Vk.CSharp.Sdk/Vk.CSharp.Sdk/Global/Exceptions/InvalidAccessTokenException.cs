using System;

namespace Vk.CSharp.Sdk.Global.Exceptions
{
    /// <summary>
    /// Исключение, выбрасываемое при неверном или отсутствующем ключе доступа.
    /// </summary>
    public class InvalidAccessTokenException : Exception
    {
        public InvalidAccessTokenException() { }

        public InvalidAccessTokenException(string message)
            : base(message) { }

        public InvalidAccessTokenException(string message, Exception inner)
            : base(message, inner) { }
    }
}