using InfraStructure.Interfaces;

namespace InfraStructure.Interfaces
{
   public interface IUnitOfWork
    {
        ICharacterRepository CharacterRepository { get; }
    }
}
