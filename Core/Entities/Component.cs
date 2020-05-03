using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Component
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public IEnumerable<ConfigurationComponent> Configurations { get; set; }


    }
}
