using System;
using Autofac;
using Twotter.Bootstrap;

namespace Twotter.iOS.Bootstrap
{
    public class IOSSetup : AppSetup
    {
        protected override void RegisterDependencies(ContainerBuilder cb)
        {
            base.RegisterDependencies(cb);
        }
    }
}
