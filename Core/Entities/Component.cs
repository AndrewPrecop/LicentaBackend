using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Component
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public IEnumerable<ConfigurationComponent> Configurations { get; set; }


    }
}
