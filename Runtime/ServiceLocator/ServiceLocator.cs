using System;
using System.Collections.Generic;

namespace TomGustin.GameDesignPattern
{
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();

        public static T Resolve<T>()
        {
            if (_services.ContainsKey(typeof(T))) return (T)_services[typeof(T)];
            else return default(T);
        }

        public static void Register(object instance)
        {
            _services[instance.GetType()] = instance;
        }

        public static void UnRegister(object instance)
        {
            _services.Remove(instance.GetType());
        }

        public static void Reset()
        {
            _services.Clear();
        }
    }
}