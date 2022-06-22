using Entities;
using System;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces
{
    public interface IAppCharacter : IGenericApp<Character>
    {
        void ImprimirFicha(Character character);
    }
}