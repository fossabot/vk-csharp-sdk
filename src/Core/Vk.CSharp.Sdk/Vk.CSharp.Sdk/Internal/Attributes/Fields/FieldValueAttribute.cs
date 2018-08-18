using System;

namespace Vk.CSharp.Sdk.Internal.Attributes.Fields
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class FieldValueAttribute : Attribute
    {
        public string Value { get; set; }

        public FieldValueAttribute(string value)
        {
            Value = value;
        }
    }
}