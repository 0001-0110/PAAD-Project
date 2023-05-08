using System.Reflection;

namespace InversionOfControl
{
    public class DependencyInjector : IDependencyInjector
    {
        private Dictionary<Type, Type> mappings;
        private Dictionary<Type, object?> singletons;

        public DependencyInjector()
        {
            mappings = new Dictionary<Type, Type>();

            Map<IDependencyInjector, DependencyInjector>();
        }

        public DependencyInjector Map<TInterface, TImplementation>() where TImplementation : TInterface
        {
            // TODO might already exists
            mappings.Add(typeof(TInterface), typeof(TImplementation));
            return this;
        }

        public DependencyInjector MapSingleton<TInterface, TImplementation>() where TImplementation : TInterface
        {
            // Create the singleton instance
            singletons.Add(typeof(TInterface), Instantiate(typeof(TImplementation)));
            return this;
        }

        private bool HasMapping(Type type)
        {
            return mappings.ContainsKey(type) || singletons.ContainsKey(type);
        }

        private object? GetInstance(Type type)
        {
            if (mappings.ContainsKey(type))
                return Instantiate(mappings[type]);
            else
                return singletons[type];
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
                constructor.GetParameters().All(parameter => HasMapping(parameter.ParameterType)));

            // Instantiate all dependencies
            IEnumerable<object?>? dependencies = constructor?.GetParameters().Select(parameter => GetInstance(parameter.ParameterType));

            return constructor?.Invoke(dependencies?.ToArray());
        }
    }
}
