using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;


namespace FeatureFlagTest.DependencyInjection
{
    public class TestDependencies
    {
        //[ScenarioDependencies]
        public static ContainerBuilder CreateContainerBuilder() {
            var builder = new ContainerBuilder();

            return builder;
        }
    }
}
