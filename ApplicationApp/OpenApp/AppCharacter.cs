using ApplicationApp.Interfaces;
using Domain.Interfaces.Generics;
using Domain.Interfaces.InterfacesEntities;
using Entities;
using System.Threading.Tasks;

namespace ApplicationApp.OpenApp
{
    public class AppCharacter : IAppCharacter
    {
        private readonly ICharacter _character;

        private readonly IServiceCharacter _serviceCharacter;

        public AppCharacter(ICharacter character, IServiceCharacter serviceCharacter)
        {
            _character = character;
            _serviceCharacter = serviceCharacter;
        }

        public Task Add(Character obj)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(Character obj)
        {
            throw new System.NotImplementedException();
        }

        public Task<Character> GetEntityById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void ImprimirFicha(Character character)
        {
            _serviceCharacter.ImprimirFichaPersonagem(character);
        }

        public Task Update(Character obj)
        {
            throw new System.NotImplementedException();
        }
    }
}