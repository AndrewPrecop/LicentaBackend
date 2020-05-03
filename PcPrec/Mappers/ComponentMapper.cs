using API.Models;
using Core.Entities;

namespace API.Mappers
{
    public static class ComponentMapper
    {
        public static ComponentModel Map(this Component component)
        {
            return new ComponentModel
            {
                Id = component.Id,
                Name = component.Name,
                Amount = component.Amount
            };
        }
    }
}
