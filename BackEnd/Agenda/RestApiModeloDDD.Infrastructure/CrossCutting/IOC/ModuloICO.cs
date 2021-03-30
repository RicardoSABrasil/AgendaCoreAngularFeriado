using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.IOC
{
    public class ModuloICO : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}
