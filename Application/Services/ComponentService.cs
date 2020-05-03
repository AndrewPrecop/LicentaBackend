using Core.Commands;
using Core.Entities;
using Core.Repositories;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ComponentService : IComponentService
    {
        private readonly IComponentRepository _componentRepository;

        public ComponentService(IComponentRepository componentRepository)
        {
            _componentRepository = componentRepository;
        }


        public async Task<IEnumerable<Component>> GetAll()
        {
            return await _componentRepository.GetAll();
        }


        public async Task<Component> Add(AddComponentCommand command)
        {
            var component = new Component
            {
                Id = Guid.NewGuid(),
                Name = command.Name,
                Amount = command.Amount
            };

            await _componentRepository.Add(component);

            return component;
        }
        public async Task<Component> Update(UpdateComponentCommand command)
        {
            var component = new Component
            {
                Id = Guid.Parse(command.Id),
                Name = command.Name,
                Amount = command.Amount
            };

            await _componentRepository.Update(component);

            return component;
        }
        


        public async Task Delete(Guid id)
        {
            await _componentRepository.Delete(id);
        }

      


        public async Task<Component> GetById(Guid id)
        {
            return await _componentRepository.GetById(id);
        }




    }
}
