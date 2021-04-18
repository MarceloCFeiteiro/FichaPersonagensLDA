using Domain.Interfaces.Generics;
using Domain.Interfaces.InterfacesEntities;
using Entities;
using System.Threading.Tasks;

namespace Domain
{
    public class ServiceCharacter : IServiceCharacter
    {
        private readonly ICharacter _character;

        public ServiceCharacter(ICharacter character)
        {
            _character = character;
        }

        public async Task AddCharacter(Character character)
        {
            await _character.Add(character);
        }
    }
}