using Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IComponentRepository
    {
        Task<IEnumerable<Component>> GetAll();
        Task<Component> GetById(Guid id);
        Task<Component> Add(Component component);
        Task<Component> Update(Component component);
        Task Delete(Guid id);
       
    }
}
