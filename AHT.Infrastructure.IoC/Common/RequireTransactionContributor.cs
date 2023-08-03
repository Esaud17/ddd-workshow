using AHT.CrossCuting.Commons.AHTLogger;
using Castle.Core;
using Castle.Core.Internal;
using Castle.MicroKernel;
using Castle.MicroKernel.ModelBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHT.Infrastructure.IoC.Common
{
    public class RequireTransactionContributor : IContributeComponentModelConstruction
    {
        public void ProcessModel(IKernel kernel, ComponentModel model)
        {
            
            var loggerMethods = model
              .Implementation
                .GetMethods()
                .Where(m => AttributesUtil.GetAttribute<LoggerAttribute>(m) != null)
                .ToList();

            if (loggerMethods.Any())
            {
                model.Interceptors
                    .AddIfNotInCollection(InterceptorReference.ForType<LogInterceptor>());
            }

        }
    }
}
