using Autofac;
using Castle.Core;
using Microsoft.AspNetCore.Http;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
  

    public class InstanceFactory
    {
 
        public static T GetInstance<T>()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacBusinessModule());
            var container = builder.Build();
            return container.Resolve<T>();   
            
        }

    }
}
