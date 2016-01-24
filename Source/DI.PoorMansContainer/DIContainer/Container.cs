using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DI.PoorMansContainer
{
    public class Container
    {
        public Container()
        {
            _Registrations = new List<ContainerItem>();
        }

        public void Register<T, U>()
            where U : class, new()
        {
            Type abstractionType = typeof(T);
            Type concreteType = typeof(U);

            Register(abstractionType, concreteType);
        }

        public void Register(Type abstractionType, Type concreteType)
        {
            if (!abstractionType.IsInterface)
                throw new ApplicationException("First generic argument must be an interface type.");

            _Registrations.Add(new ContainerItem() { AbstractionType = abstractionType, ConcreteType = concreteType });
        }

        List<ContainerItem> _Registrations;

        public T CreateType<T>() where T : class
        {
            Type type = typeof(T);

            return (T)GetConcreteType(type);
        }

        public object CreateType(Type type)
        {
            return GetConcreteType(type);
        }

        object GetConcreteType(Type typeToResolve)
        {
            ContainerItem containerItem = _Registrations.Where(item => item.AbstractionType.Equals(typeToResolve)).FirstOrDefault();
            if (containerItem != null)
                return GetTypeInstance(containerItem.ConcreteType);
            else
                return GetTypeInstance(typeToResolve);
        }

        object GetTypeInstance(Type type)
        {
            object instance = null;

            ConstructorInfo[] constructors = type.GetConstructors();
            if (constructors.Length > 0)
            {
                ConstructorInfo constructor = constructors[0];

                List<object> constructorArguments = new List<object>();
                ParameterInfo[] parameters = constructor.GetParameters();
                foreach (ParameterInfo parameter in parameters)
                {
                    object parameterInstance = null;
                    if (parameter.ParameterType.IsInterface)
                        // recursion happens here
                        parameterInstance = GetConcreteType(parameter.ParameterType);

                    constructorArguments.Add(parameterInstance);
                }

                instance = Activator.CreateInstance(type, constructorArguments.ToArray());
            }

            return instance;
        }
    }
}
