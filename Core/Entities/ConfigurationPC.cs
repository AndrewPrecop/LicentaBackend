using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class ConfigurationPC
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public IEnumerable<ConfigurationComponent> Components { get; set; }
    }
}
