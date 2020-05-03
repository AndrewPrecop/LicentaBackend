using System;

namespace Core.Entities
{
    public class ConfigurationComponent
    {
        public ConfigurationPC ConfigurationPC { get; set; }
        public Guid ConfigurationPcId { get; set; }
        public Component Component { get; set; }
        public Guid ComponentId { get; set; }
       
    }
}
