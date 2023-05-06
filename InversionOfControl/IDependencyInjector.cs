namespace InversionOfControl
{
    public interface IDependencyInjector
    {
        public DependencyInjector Map<T, V>() where V : T;
        public object? Instantiate(Type type);
    }
}
