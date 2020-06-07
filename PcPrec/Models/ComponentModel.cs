using System;
using Core.Entities;

namespace API.Models
{
    public class ComponentModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public Core.Entities.Type Type { get; set; }
     }
}
