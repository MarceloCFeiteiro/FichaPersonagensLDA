using Domain.Interfaces.Generics;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InfraStructure
{
    public class RepositoryGenerics<T> : ContextBase, IGenerics<T> where T : class
    {
        public RepositoryGenerics()
        {
        }

        public Task Add(T obj)
        {
            throw new NotImplementedException();
        }

        public Task Delete(T obj)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> List()
        {
            throw new NotImplementedException();
        }

        public Task Update(T obj)
        {
            throw new NotImplementedException();
        }

        
    }
}