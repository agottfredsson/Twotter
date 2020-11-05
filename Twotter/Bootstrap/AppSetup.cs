using Autofac;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Twotter.Models;
using Twotter.ViewModels;

namespace Twotter.Bootstrap
{
    public class AppSetup
    {
        public IContainer CreateContainer()
        {
            var containerBuilder = new ContainerBuilder();
            RegisterDependencies(containerBuilder);
            return containerBuilder.Build();
        }
        protected virtual void RegisterDependencies(ContainerBuilder cb)
        {
            cb.RegisterType<PostsViewModel>().SingleInstance();
            cb.RegisterType<AddPostViewModel>().SingleInstance();
            cb.RegisterType<PostApi>().SingleInstance();
            cb.RegisterType<HttpClient>().SingleInstance();
            cb.RegisterType<XamarinEssentials>().As<IXamarinEssentials>().SingleInstance();



          
        }
    }
}
