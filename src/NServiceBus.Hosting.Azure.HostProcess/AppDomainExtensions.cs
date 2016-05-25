namespace NServiceBus.Hosting.Azure.HostProcess
{
    using System;
    using System.Reflection;

    static class AppDomainExtensions
    {
        public static T CreateInstanceAndUnwrap<T>(this AppDomain domain, params object[] args)
        {
            var type = typeof(T);
            return (T)domain.CreateInstanceFromAndUnwrap(type.Assembly.Location, type.FullName, false, BindingFlags.Default, null, args, null, null);
        }
    }
}