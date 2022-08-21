using InfraStructure.Interfaces;

namespace InfraStructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICharacterRepository CharacterRepository { get; }

        public UnitOfWork(ICharacterRepository CharacterRepository)
        {
            this.CharacterRepository = CharacterRepository;
        }

    }
}
