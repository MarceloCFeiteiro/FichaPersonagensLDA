using Domain.Interfaces.Generics;
using Entities;
using InfraStructure.Interfaces;
using System.Threading.Tasks;
using Utils;

namespace Domain
{
    public class ServiceCharacter : IServiceCharacter
    {
        private readonly IUnitOfWork _unitOfWork;

        public ServiceCharacter(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddCharacter(Character character)
        {
            await _unitOfWork.CharacterRepository.Add(character);
        }

        public void ImprimirFichaPersonagem(Character personagem)
        {
            HelpArquivoPdf.ImprimirFichaPdf(personagem);
        }
    }
}