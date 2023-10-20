using System;
using System.Collections.Generic;

namespace DeveloperSample.Container
{
    public class Container
    {
        private Dictionary<Type, Type> bindings = new Dictionary<Type, Type>();


        public void Bind(Type interfaceType, Type implementationType)
        {

            if (!interfaceType.IsInterface)
                throw new ArgumentException("The first argument must be an interface type.");

            if (!interfaceType.IsAssignableFrom(implementationType))
                throw new ArgumentException("The second argument must implement the first argument interface.");

            bindings[interfaceType] = implementationType;
        }
        public T Get<T>()

        {

            Type interfaceType = typeof(T);

            if (bindings.ContainsKey(interfaceType))
            {
                Type implementationType = bindings[interfaceType];
                return (T)Activator.CreateInstance(implementationType);
            }
            else
            {
                throw new InvalidOperationException($"No binding found for interface {interfaceType.FullName}");
            }

        }
    }
}