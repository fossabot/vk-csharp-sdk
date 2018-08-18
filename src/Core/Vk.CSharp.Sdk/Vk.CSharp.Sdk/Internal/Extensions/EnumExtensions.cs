using System;
using System.Reflection;
using Vk.CSharp.Sdk.Internal.Attributes.Fields;

namespace Vk.CSharp.Sdk.Internal.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            return value
               .GetType()
               .GetField(value.ToString())
               .GetCustomAttribute<FieldDescriptionAttribute>()?
               .Description ?? string.Empty;
        }

        public static object GetObjectValue(this Enum value)
        {
            return value
                .GetType()
                .GetField(value.ToString())
                .GetCustomAttribute<FieldValueAttribute>()?
                .Value;
        }

        public static string GetStringValue(this Enum value)
        {
            return value
                .GetType()
                .GetField(value.ToString())
                .GetCustomAttribute<FieldValueAttribute>()?
                .Value as string ?? string.Empty;
        }
    }
}