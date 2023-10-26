using Algar.Hours.Application.Configuration;
using Algar.Hours.Application.DataBase.AssignmentReport.Commands;
using Algar.Hours.Application.DataBase.Client.Commands;
using Algar.Hours.Application.DataBase.Country.Commands;
using Algar.Hours.Application.DataBase.HorusReport.Commands;
using Algar.Hours.Application.DataBase.Menu.Commands;
using Algar.Hours.Application.DataBase.Parameters.Commands.CreateParameters;
using Algar.Hours.Application.DataBase.Rol.Commands;
using Algar.Hours.Application.DataBase.RolMenu.Commands.CreateRolMenu;
using Algar.Hours.Application.DataBase.User.Commands.CreateUser;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Algar.Hours.Application
{
    public static class DependencyInjectionService
    {

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var mapper = new MapperConfiguration(config =>
            {
                config.AddProfile(new MapperProfile());

            });
            services.AddSingleton(mapper.CreateMapper());
            services.AddTransient<ICreateUserCommand, CreateUserCommand>();
            services.AddTransient<ICreateRolCommand, CreateRolCommand>();
            services.AddTransient<ICreateAssigmentReportCommand,CreateAssignmentReportCommand>();
            services.AddTransient<ICreateClientCommand, CreateClientCommand>();
            services.AddTransient<ICreateCountryCommand, CreateCountryCommand>();
            services.AddTransient<ICreateHorusReportCommand, CreateHorusReportCommand>();
            services.AddTransient<ICreateMenuCommand, CreateMenuCommand>();
            services.AddTransient<ICreateParametersCommand, CreateParametersCommand>();
            services.AddTransient<ICreateRolMenuCommand, CreateRolMenuCommand>();
           
            return services;
        }

    }
}
