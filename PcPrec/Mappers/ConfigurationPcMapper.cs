using API.Models;
using Core.Entities;
using System.Linq;

namespace API.Mappers
{
    public static class ConfigurationPcMapper
    {
        public static ConfigurationPcModel Map(this ConfigurationPC configuration)
        {
            return new ConfigurationPcModel
            {
                Id = configuration.Id,
                ImagePath = configuration.ImagePath,
                Description = configuration.Description,
                Name = configuration.Name,
               
                Components = configuration.Components.Count()>0 && configuration.Components.First().Component!=null?configuration.Components.Select(s => s.Component.Map(s.Amount)).OrderBy(o =>o.Type):null
            };
        }
    }
}
