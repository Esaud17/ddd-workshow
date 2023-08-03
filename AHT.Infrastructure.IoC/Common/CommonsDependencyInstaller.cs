using AHT.CrossCuting.Commons.AHTLogger;
using AHT.Infrastructure.EF;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHT.Infrastructure.IoC.Prizes
{
    public class CommonsDependencyInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container
            .Register(Component.For<prizes_dbEntities>().LifeStyle.Transient);

            container
               .Register(Component.For<ILogger>()
               .UsingFactoryMethod(LogManager.GetCurrentClassLogger)
               .LifeStyle.Transient);

            container
              .Register(Component.For<ICustomLogger>()
              .ImplementedBy<CustomLogger>()
              .LifeStyle.Transient);
        }
    }
}
