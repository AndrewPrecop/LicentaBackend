using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Commands.ConfigurationPC
{
    public class UpdateConfigurationPCCommand
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public IEnumerable<Guid> Components { get; set; }
    }
}
