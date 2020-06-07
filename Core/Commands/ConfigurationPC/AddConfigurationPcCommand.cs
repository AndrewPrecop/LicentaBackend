using API.Models;
using System;
using System.Collections.Generic;

namespace Core.Commands.ConfigurationPC
{
    public class AddConfigurationPCCommand
    {   public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
       // [Column(TypeName = "decimal(18, 2)")]
       // public decimal Price { get; set; }

        public IEnumerable<ConfigurationComponentModel> Components { get; set; }
    }
}
