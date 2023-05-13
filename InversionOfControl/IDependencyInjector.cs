namespace InversionOfControl
{
    public interface IDependencyInjector
    {
        public DependencyInjector Map<TInterface, TImplementation>() where TImplementation : TInterface;
        public DependencyInjector MapSingleton<TInterface, TImplementation>() where TImplementation : TInterface;
        public DependencyInjector MapSingleton<TInterface, TImplementation>(TImplementation singleton) where TImplementation : notnull, TInterface;
        public T? Instantiate<T>(params (Type type, object? value)[] arguments);

        public T? Instantiate<T, Targ1>(Targ1 arg1);

        public T? Instantiate<T, Targ1, Targ2>(Targ1 arg1, Targ2 arg2);

        public T? Instantiate<T, Targ1, Targ2, Targ3>(Targ1 arg1, Targ2 arg2, Targ3 arg3);

        public T? Instantiate<T, Targ1, Targ2, Targ3, Targ4>(Targ1 arg1, Targ2 arg2, Targ3 arg3, Targ4 arg4);

        public T? Instantiate<T, Targ1, Targ2, Targ3, Targ4, Targ5>(Targ1 arg1, Targ2 arg2, Targ3 arg3, Targ4 arg4, Targ5 arg5);

        public T? Instantiate<T, Targ1, Targ2, Targ3, Targ4, Targ5, Targ6>(Targ1 arg1, Targ2 arg2, Targ3 arg3, Targ4 arg4, Targ5 arg5, Targ6 arg6);

        public T? Instantiate<T, Targ1, Targ2, Targ3, Targ4, Targ5, Targ6, Targ7>(Targ1 arg1, Targ2 arg2, Targ3 arg3, Targ4 arg4, Targ5 arg5, Targ6 arg6, Targ7 arg7);
    }
}
