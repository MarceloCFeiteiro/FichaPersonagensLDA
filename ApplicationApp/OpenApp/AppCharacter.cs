using ApplicationApp.Interfaces;
using Domain.Interfaces.InterfacesEntities;
using Entities;
using System.Threading.Tasks;

namespace ApplicationApp.OpenApp
{
    public class AppCharacter : IAppCharacter
    {
        private readonly ICharacter _character;

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

        public Task Update(Character obj)
        {
            throw new System.NotImplementedException();
        }
    }
}