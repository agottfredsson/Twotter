using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
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
            //cb.RegisterType<ItemsViewModel>().SingleInstance();
            //cb.RegisterType<ItemDetailViewModel>().SingleInstance();
            //cb.RegisterType<FirstPageViewModel>().SingleInstance();
            //cb.RegisterType<CatFactApi>().SingleInstance();
            //cb.RegisterType<HttpClient>().SingleInstance();
            //cb.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
        }
    }
}
