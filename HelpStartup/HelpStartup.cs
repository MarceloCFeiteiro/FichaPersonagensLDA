using ApplicationApp.Interfaces;
using ApplicationApp.OpenApp;
using Domain;
using Domain.Interfaces.Generics;
using Domain.Interfaces.InterfacesEntities;
using InfraStructure;
using InfraStructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpConfig
{
    public static class HelpStartup
    {
        public static void ConfigureSingleton(IServiceCollection services)
        {

            // INTERFACE E REPOSITORIO
            services.AddSingleton(typeof(IGenerics<>), typeof(RepositoryGenerics<>))
            .AddSingleton<ICharacter, CharacterRepository>();

            // INTERFACE APLICAÇÃO
            //  services.AddSingleton<IInterfaceProductApp, AppProduct>();
            services.AddSingleton<IAppCharacter, AppCharacter>();

            // SERVIÇO DOMINIO
            //  services.AddSingleton<IServiceProduct, ServiceProduct>();
            services.AddSingleton<IServiceCharacter, ServiceCharacter>();
        }
    }
}
