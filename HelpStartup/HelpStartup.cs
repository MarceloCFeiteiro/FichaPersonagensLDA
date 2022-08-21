using ApplicationApp.Interfaces;
using ApplicationApp.OpenApp;
using Domain;
using Domain.Interfaces.Generics;
using InfraStructure;
using InfraStructure.Interfaces;
using InfraStructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace HelpConfig
{
    public static class HelpStartup
    {
        public static void ConfigureSingleton(IServiceCollection services)
        {

            // INTERFACE REPOSITORIO
            services.AddSingleton<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<ICharacterRepository, CharacterRepository>();

            // INTERFACE APLICAÇÃO
            services.AddSingleton<IAppCharacter, AppCharacter>();

            // SERVIÇO DOMINIO
            services.AddSingleton<IServiceCharacter, ServiceCharacter>();
        }
    }
}
