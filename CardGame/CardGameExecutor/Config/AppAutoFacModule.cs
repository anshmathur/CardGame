using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGameExecutor.Config
{
    public class AppAutoFacModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GameExecutor>().As<IGameExecutor>();
        }
    }
}