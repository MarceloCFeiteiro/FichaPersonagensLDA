﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace InfraStructure.Interfaces
{
    public interface IGenerics<T> where T : class
    {
        Task Add(T obj);

        Task Delete(T obj);

        Task<T> GetEntityById(int id);

        Task<List<T>> List();

        Task Update(T obj);
    }
}