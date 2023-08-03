using Castle.MicroKernel.Registration;
using System;
using System.Reflection;

namespace AHT.Presentantion.CLI
{
    public class ApplicationAssemblyFilter : AssemblyFilter
    {
        public ApplicationAssemblyFilter() : base(AppDomain.CurrentDomain.BaseDirectory, Assembly.GetExecutingAssembly().GetName().Name + ".*.dll")
        {

        }
    }
}