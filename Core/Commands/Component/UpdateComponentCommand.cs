using System;

namespace Core.Commands
{
    public class UpdateComponentCommand
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
    }
}
