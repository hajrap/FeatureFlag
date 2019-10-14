using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FeatureFlagUnitTest
{
   public class TestDependency
    {
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // setup the Autofac container
            var builder = new ContainerBuilder();
            builder.Populate(services);
            //builder.RegisterType<ArticleService>().As<IArticleService>();
            var container = builder.Build();
            // return the IServiceProvider implementation
            return new AutofacServiceProvider(container);
        }
    }
}
