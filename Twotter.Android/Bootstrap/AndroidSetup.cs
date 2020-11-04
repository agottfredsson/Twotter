using System;
using Autofac;
using Twotter.Bootstrap;

namespace Twotter.Droid.Bootstrap
{
    public class AndroidSetup : AppSetup
    {
        protected override void RegisterDependencies(ContainerBuilder cb)
        {
            base.RegisterDependencies(cb);
        }
    }
}
