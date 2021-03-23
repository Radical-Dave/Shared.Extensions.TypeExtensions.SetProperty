using System;

namespace Shared.Extensions
{
    public static class TypeExtensions
    {
        public static void SetProperty(this Type type, string name, object obj, object value)
        {
            if (name == null || obj == null || value == null) return;
            var property = type.GetProperty(name);
            if (property == null) return;
            property.SetValue(obj, value, null);
        }
    }
}