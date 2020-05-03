using Core.Commands;
using Core.Commands.ConfigurationPC;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace Core.Services
{
    public interface IConfigurationPCService
    {
        Task<IEnumerable<ConfigurationPC>> GetAll();
        Task<ConfigurationPC> GetById(Guid id);
        Task<ConfigurationPC> Add(AddConfigurationPCCommand command);
        Task<ConfigurationPC> Update(UpdateConfigurationPCCommand command);
        Task Delete(Guid id);
      //  Task Fetch(Guid id);
    }
}
