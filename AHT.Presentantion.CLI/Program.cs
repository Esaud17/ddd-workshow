using AHT.Application.Prizes.Interfaces;
using AHT.Infrastructure.IoC.Common;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHT.Presentantion.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();

            container.Kernel.ComponentModelBuilder
            .AddContributor(new RequireTransactionContributor());
            container.Install(FromAssembly.Named("AHT.Infrastructure.IoC"));


            var service = container.Resolve<IPrizeApplication>();

            service.excecute();
        }
    }

}
