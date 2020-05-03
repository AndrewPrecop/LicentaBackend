using System;
using System.Collections.Generic;

namespace Core.Commands.ConfigurationPC
{
    public class AddConfigurationPCCommand
    {   public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public IEnumerable<Guid> Components { get; set; }
    }
}
