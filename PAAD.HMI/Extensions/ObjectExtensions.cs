using System.Reflection;

namespace PAAD.HMI.Extensions
{
    internal static class ObjectExtensions
    {
        public static TProperty? GetFieldOfType<TProperty>(this object self)
        {
            return (TProperty?)self.GetType()
                .GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                .FirstOrDefault(field => field.FieldType == typeof(TProperty))?.GetValue(self);
        }
    }
}
