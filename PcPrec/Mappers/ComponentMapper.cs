using API.Models;
using Core.Entities;

namespace API.Mappers
{
    public static class ComponentMapper
    {
        public static ComponentModel Map(this Component component,int amount=-1)
        {
            return new ComponentModel
            {
                Id = component.Id,
                Name = component.Name,
                Brand = component.Brand,
                Description = component.Description,
                ImagePath = component.ImagePath,
                Price = component.Price,
                Amount = amount == -1 ? component.Amount : amount,
                Type = component.Type
            };
        }
    }
}
