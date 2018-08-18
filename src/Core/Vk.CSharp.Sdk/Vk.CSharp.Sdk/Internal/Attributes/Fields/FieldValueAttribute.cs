using System;

namespace Vk.CSharp.Sdk.Internal.Attributes.Fields
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class FieldValueAttribute : Attribute
    {
        public object Value { get; set; }

        public FieldValueAttribute(object value)
        {
            Value = value;
        }
    }
}