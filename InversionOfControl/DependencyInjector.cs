using System.Reflection;

namespace InversionOfControl
{
    public class DependencyInjector : IDependencyInjector
    {
        private Dictionary<Type, Type> mappings;
        private Dictionary<Type, object> singletons;

        public DependencyInjector()
        {
            mappings = new Dictionary<Type, Type>();
            singletons = new Dictionary<Type, object>();

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
            object? singleton = Instantiate(typeof(TImplementation));
            if (singleton == null)
                throw new Exception("This singleton instance could not be created. Check that all of its dependencies have been mapped beforehand and that there is a valid constructor.");
            singletons.Add(typeof(TInterface), singleton);
            return this;
        }

        // This overload allows for the instance to be created manually
        public DependencyInjector MapSingleton<TInterface, TImplementation>(TImplementation singleton) where TImplementation : notnull, TInterface
        {
            singletons.Add(typeof(TInterface), singleton);
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

        private object? Instantiate(Type type)
        {
            // Get all constructors by ordered by number of parameters
            IEnumerable<IGrouping<int, ConstructorInfo>> constructors = type.GetConstructors()
                .GroupBy(constructor => constructor.GetParameters().Length)
                .OrderByDescending(grouping => grouping.Key);

            // Take the constructor with the most parameters that correspond to the mappings
            // Throw an exeption if multiple constructors are suitable (with same param count)
            ConstructorInfo? constructor = null;
            for (int i = 0; i < constructors.Count() && constructor == null; i++)
            {
                try
                {
                    constructor = constructors.ElementAt(i).SingleOrDefault(constructor =>
                    constructor.GetParameters().All(parameter => HasMapping(parameter.ParameterType)));
                }
                catch (InvalidOperationException exception)
                {
                    throw new Exception("Ambiguous: multiple suitable constructors for instantiation", exception);
                }
            }

            if (constructor == null)
                // HOW TO FIX :
                // 1. Check that the object you are trying to instantiate has a public constructor
                // 2. Check that each dependency has been mapped
                // 3. Call for help (22#0130)
                throw new Exception($"Couldn't find any suitable constructor to instantiate {type}");

            // Instantiate all dependencies
            IEnumerable<object?>? dependencies = constructor.GetParameters().Select(parameter => GetInstance(parameter.ParameterType));

            return constructor?.Invoke(dependencies?.ToArray());
        }

        public T? Instantiate<T>()
        {
            return (T?)Instantiate(typeof(T));
        }
    }
}
