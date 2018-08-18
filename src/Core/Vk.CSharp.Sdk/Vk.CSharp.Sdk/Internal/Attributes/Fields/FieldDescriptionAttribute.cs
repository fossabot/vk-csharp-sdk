using System;

namespace Vk.CSharp.Sdk.Internal.Attributes.Fields
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class FieldDescriptionAttribute : Attribute
    {
        public string Description { get; set; }

        public FieldDescriptionAttribute(string description)
        {
            Description = description;
        }
    }
}