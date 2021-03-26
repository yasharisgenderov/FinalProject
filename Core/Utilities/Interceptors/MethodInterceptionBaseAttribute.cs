using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; } //birinci hansi atribut islesin onu gosterir tercumesi oncelik

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
