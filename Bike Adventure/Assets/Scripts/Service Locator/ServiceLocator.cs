using System;
using System.Collections.Generic;

public static class ServiceLocator
{
    private static readonly Dictionary<Type, object> services = new();

    public static void Register<T>(T service) where T : class
    {
        var type = typeof(T);
        if (!services.ContainsKey(type))
            services.Add(type, service);
    }

    public static T Get<T>() where T : class
    {
        services.TryGetValue(typeof(T), out var service);
        return service as T;
    }

    public static void Clear() => services.Clear();
}