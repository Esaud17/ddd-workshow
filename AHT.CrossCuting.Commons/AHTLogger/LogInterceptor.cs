using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHT.CrossCuting.Commons.AHTLogger
{
    public class LogInterceptor : IInterceptor
    {
        private readonly ICustomLogger _logger;

        public LogInterceptor(ICustomLogger logger)
        {
            if (logger == null) throw new ArgumentNullException(nameof(logger));
            _logger = logger;
        }

        public void Intercept(IInvocation invocation)
        {
            try
            {
                invocation.Proceed();
                _logger.Debug(invocation.Method.Name, invocation.InvocationTarget.ToString());
            }
            catch (Exception e)
            {
                _logger.Error(invocation.Method.Name, invocation.InvocationTarget + " | " + e.Message);
                throw;
            }
        }
    }
}
