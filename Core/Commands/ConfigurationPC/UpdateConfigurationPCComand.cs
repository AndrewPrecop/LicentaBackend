using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Commands.ConfigurationPC
{
    public class UpdateConfigurationPCCommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        //[Column(TypeName = "decimal(18, 2)")]
       // public decimal Price { get; set; }

        public IEnumerable<Guid> Components { get; set; }
    }
}
