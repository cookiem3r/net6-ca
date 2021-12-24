
using Autofac;
using DemoApp.Application.Common.Behaviours;
using MediatR;

namespace DemoApp.Application.IOC.Modules
{
    public class SampleModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<Mediator>().As<IMediator>().InstancePerLifetimeScope();
            //builder.Register<ServiceFactory>(ctx =>
            //{
            //    var c = ctx.Resolve<IComponentContext>();
            //    return t => c.Resolve(t);
            //});
            base.Load(builder);
        }
    }
}