using System.Reflection;

namespace InversionOfControl
{
    public class DependencyInjector : IDependencyInjector
    {
        private Dictionary<Type, Type> mappings;

        public DependencyInjector()
        {
            mappings = new Dictionary<Type, Type>();
            Map<IDependencyInjector, DependencyInjector>();
        }

        public DependencyInjector Map<T, V>() where V : T
        {
            // TODO might already exists
            mappings.Add(typeof(T), typeof(V));
            return this;
        }

        public object? Instantiate(Type type)
        {
            // Get all constructors by ordered by number of parameters
            IEnumerable<IGrouping<int, ConstructorInfo>> constructors = type.GetConstructors()
                .GroupBy(constructor => constructor.GetParameters().Length)
                .OrderByDescending(grouping => grouping.Key);

            // Take the constructor with the most parameters that correspond to the mappings
            // Throw an exeption if multiple constructors are suitable (with same param count)
            ConstructorInfo? constructor = null;
            for (int i = 0; i < constructors.Count() && constructor == null; i++)
                constructor = constructors.ElementAt(i).SingleOrDefault(constructor =>
                constructor.GetParameters().All(parameter => mappings.ContainsKey(parameter.ParameterType)));

            // Instantiate all dependencies
            IEnumerable<Type>? dependencies = constructor?.GetParameters().Select(parameter => mappings[parameter.ParameterType]);
            IEnumerable<object?>? parameters = dependencies?.Select(dependency => Instantiate(dependency));

            return constructor?.Invoke(parameters?.ToArray());
        }
    }
}
