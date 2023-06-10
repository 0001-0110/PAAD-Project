using System.Reflection;

namespace SkillIssueDetector.Utilities
{
    internal static class ReflectionUtility
    {
        public static object? CallPrivate(object instance, string methodName, params object?[] arguments)
        {
            return instance.GetType()
                .GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance)?
                .Invoke(instance, arguments);
        }

        public static object? CallGeneric(object _instance, string methodName, Type[] types, params object?[] arguments)
        {
            return _instance
                .GetType()
                .GetMethod(methodName)?
                .MakeGenericMethod(types)
                .Invoke(_instance, arguments);
        }
    }
}
