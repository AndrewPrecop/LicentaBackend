using Core.Commands;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IComponentService
    {
        Task<IEnumerable<Component>> GetAll();
        Task<Component> GetById(Guid id);
        Task<Component> Add(AddComponentCommand command);
        Task<Component> Update(UpdateComponentCommand command);
        Task Delete(Guid id);
    
    }
}
