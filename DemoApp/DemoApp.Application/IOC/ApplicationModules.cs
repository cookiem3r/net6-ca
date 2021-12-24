

using Autofac;

namespace DemoApp.Application.IOC
{
    public class ApplicationModules : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterModule(new SampleModule());

            base.Load(builder);
        }
    }
}
