using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class ConfigurationPC
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
      //  [Column(TypeName = "decimal(18, 2)")]
       // public decimal Price { get; set; }

        public string Description { get; set; }
        public IEnumerable<ConfigurationComponent> Components { get; set; }
    }
}
