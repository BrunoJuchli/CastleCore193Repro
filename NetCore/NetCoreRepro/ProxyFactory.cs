using Castle.DynamicProxy;
using System;

namespace NetCoreRepro
{
    public static class ProxyFactory
    {
        static ProxyGenerator generator = new ProxyGenerator();
        static Interceptor interceptor = new Interceptor();

        public static T CreateProxy<T>() where T : class
        {
            return generator.CreateInterfaceProxyWithoutTarget<T>(interceptor);
        }

        private sealed class Interceptor : IInterceptor
        {
            public void Intercept(IInvocation invocation)
            {
                if (invocation.Method.ReturnType == typeof(void))
                {
                }
                else if (invocation.Method.ReturnType == typeof(bool))
                {
                    invocation.ReturnValue = true;
                }
                else
                {
                    invocation.ReturnValue = Activator.CreateInstance(invocation.Method.ReturnType);
                }
            }
        }
    }
}
