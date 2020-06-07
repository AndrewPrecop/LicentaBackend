using Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IConfigurationPCRepository
    {
        Task<IEnumerable<ConfigurationPC>> GetAll();
        Task<ConfigurationPC> GetById(Guid id);
        Task<ConfigurationPC> Add(ConfigurationPC configurationPC);
        Task<ConfigurationPC> Update(ConfigurationPC configurationPC);
        Task Delete(Guid id);
        Task RemoveComponents(Guid id);
        Task CreateConfigurationComponents(IEnumerable<ConfigurationComponent> components);


    }

}
