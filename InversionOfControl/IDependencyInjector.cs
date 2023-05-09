﻿namespace InversionOfControl
{
    public interface IDependencyInjector
    {
        public DependencyInjector Map<TInterface, TImplementation>() where TImplementation : TInterface;
        public DependencyInjector MapSingleton<TInterface, TImplementation>() where TImplementation : TInterface;
        public DependencyInjector MapSingleton<TInterface, TImplementation>(TImplementation singleton) where TImplementation : notnull, TInterface;
        public T? Instantiate<T>();
    }
}
