using Dapper;
using Entities;
using InfraStructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace InfraStructure.Repositories
{
    public class CharacterRepository : RepositoryBase, ICharacterRepository
    {
        private readonly SqlConnection connection = null;

        public CharacterRepository()
        {
            this.connection = GetSqlConnection();
        }

        public async Task Add(Character obj)
        {
            string sql = @"INSERT INTO Character (Name, IdBreed, IdClass, Element, Level, SpellCastSpeed, Exp, Constitution, AuraPower)
                           VALUES (@Name, @IdBreed, @IdClass,@Element, @Level, @SpellCastSpeed, @Exp, @Constitution, @AuraPower)";
            try
            {
                using (this.connection)
                {
                    this.connection.Open();
                    var result = await this.connection.ExecuteAsync(sql, obj);
                }
            }
            catch (InvalidOperationException ioe)
            {
                throw ioe;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Task Delete(Character obj)
        {
            throw new System.NotImplementedException();
        }

        public Task<Character> GetEntityById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Character>> List()
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Character obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
