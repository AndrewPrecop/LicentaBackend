using Core.Commands.ConfigurationPC;
using Core.Entities;
using Core.Repositories;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ConfigurationPCService : IConfigurationPCService
    {
        private readonly IConfigurationPCRepository _configurationPCRepository;

        public ConfigurationPCService(IConfigurationPCRepository configurationPCRepository)
        {
            _configurationPCRepository = configurationPCRepository;
        }


        public async Task<IEnumerable<ConfigurationPC>> GetAll()
        {
            return await _configurationPCRepository.GetAll();
        }
        public async Task<ConfigurationPC> Add(AddConfigurationPCCommand command)
        {
            var configurationPC = new ConfigurationPC
            {
                Id = Guid.NewGuid(),
                Name = command.Name,
                Description = command.Description,
                ImagePath = command.ImagePath,
               // Price = command.Price
            };

            configurationPC.Components = createConfigurationComponents(command.Components, configurationPC.Id);

            await _configurationPCRepository.Add(configurationPC);

            return configurationPC;
        }
        public async Task<ConfigurationPC> Update(UpdateConfigurationPCCommand command)
        {
            var configurationPC = new ConfigurationPC
            {
                Id = command.Id,
                Name = command.Name,
                Description = command.Description,
                ImagePath = command.ImagePath,
              //  Price = command.Price
            };
            configurationPC.Components = updateConfigurationComponents(command.Components, configurationPC.Id);

            await _configurationPCRepository.Update(configurationPC);

            return configurationPC;
        }

        private IEnumerable<ConfigurationComponent> createConfigurationComponents(IEnumerable<Guid> components, Guid configurationId)
        {
            return components.Select(c => new ConfigurationComponent
            {
                ComponentId = c,
                ConfigurationPcId = configurationId
            }).ToList();
        }
        private IEnumerable<ConfigurationComponent> updateConfigurationComponents(IEnumerable<Guid> components, Guid configurationId)
        {
            return components.Select(c=> new ConfigurationComponent
            {
                ComponentId = c,
                ConfigurationPcId = configurationId
            }).ToList();
        }

        public async Task Delete(Guid id)
        {
            await _configurationPCRepository.Delete(id);
        }




        public async Task<ConfigurationPC> GetById(Guid id)
        {
            return await _configurationPCRepository.GetById(id);
        }
    }
}
