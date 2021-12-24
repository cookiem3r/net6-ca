using DemoApp.Application.Common.Behaviours;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DemoApp.Application.Extensions
{
    public static class ApplicationDependecyInjectionExtensions
    {

        public static IServiceCollection AddApplicationInjections(this IServiceCollection services)
        {
            //Helper method to add all the handlers within Context
            services.AddMediatR(Assembly.GetExecutingAssembly());
            //Helper method to add all PipelineBehaviours
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            //Helper method to add all Validators within Context
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;
        }

    }
}
