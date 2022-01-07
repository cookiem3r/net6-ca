using Autofac;
using DemoApp.Persistence.Common.Interfaces;
using DemoApp.Persistence.Context;

namespace DemoApp.Persistence.Common.IOC.Modules
{
    internal class DatabaseModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentContext>().As<IStudentContext>();

           
            base.Load(builder);
        }
    }
}
