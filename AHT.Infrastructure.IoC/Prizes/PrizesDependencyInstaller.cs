using AHT.Application.Prizes;
using AHT.Application.Prizes.Interfaces;
using AHT.Domain.Repositories;
using AHT.Domain.Services;
using AHT.Infrastructure.EF.Repositories;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHT.Infrastructure.IoC.Prizes
{
    public class PrizesDependencyInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container
            .Register(Component.For<IPrizeApplication>()
            .ImplementedBy<PrizeApplication>()
            .LifeStyle.Transient);

            container
              .Register(Component.For<IPrizesRepository>()
              .ImplementedBy<PrizeRepository>()
              .LifeStyle.Transient);

            container
            .Register(Component.For<PrizesDomainService>()
            .LifeStyle.Transient);

            
        }
    }
}
