using System;

namespace Core.Commands
{
    public class UpdateComponentCommand
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

    }
}
