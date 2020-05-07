using System;

namespace MyDbLocalizaion.Resources
{
    public class WeirdCustomAttribute : Attribute
    {
        public WeirdCustomAttribute(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public override string ToString() => Value;
    }
}
