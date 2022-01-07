using Autofac;
using DemoApp.Persistence.Common.IOC.Modules;

namespace DemoApp.Persistence.Common.IOC
{
    public class PersistenceModules : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new DatabaseModule());
            
            base.Load(builder);
        }
    }
}
