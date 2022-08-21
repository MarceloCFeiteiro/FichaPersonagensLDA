using Entities;
using System.Threading.Tasks;

namespace Domain.Interfaces.Generics
{
    public interface IServiceCharacter
    {
        Task AddCharacter(Character personagem);

        void ImprimirFichaPersonagem(Character personagem);
    }
}