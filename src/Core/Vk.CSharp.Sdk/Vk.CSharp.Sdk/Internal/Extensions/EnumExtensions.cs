using System;
using System.Reflection;
using Vk.CSharp.Sdk.Internal.Attributes;

namespace Vk.CSharp.Sdk.Internal.Extensions
{
    internal static class EnumExtensions
    {
        /// <summary>
        /// Возвращает описание из атрибута <see cref="FieldDescriptionAttribute" />.
        /// </summary>
        public static string GetDescription(this Enum value)
        {
            return value
               .GetType()
               .GetField(value.ToString())
               .GetCustomAttribute<FieldDescriptionAttribute>()?
               .Description ?? string.Empty;
        }

        /// <summary>
        /// Возвращает значение из атрибута <see cref="FieldValueAttribute" />.
        /// </summary>
        public static string GetValue(this Enum value)
        {
            return value
               .GetType()
               .GetField(value.ToString())
               .GetCustomAttribute<FieldValueAttribute>()?
               .Value ?? string.Empty;
        }
    }
}