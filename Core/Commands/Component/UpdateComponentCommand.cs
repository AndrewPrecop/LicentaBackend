

using Core.Entities;
using System;

namespace Core.Commands
{
    public class UpdateComponentCommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public Entities.Type Type { get; set; }

    }
}
