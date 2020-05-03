using Core.Entities;
using Core.Repositories;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ComponentRepository : IComponentRepository
    {
        private readonly AppDbContext _context;
       

        public ComponentRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Component>> GetAll()
        {
            return await _context.Components.ToListAsync();
        }


        public async Task<Component> Add(Component component)
        {
            await _context.Components.AddAsync(component);
            await _context.SaveChangesAsync();

            return component;
        }
        public async Task<Component> Update(Component component)
        {
             _context.Components.Update(component);
            await _context.SaveChangesAsync();

            return component;
        }
       

        public async Task Delete(Guid id)
        {
            var component = await GetById(id);
            _context.Components.Remove(component);
            await Save();
        }

        

        public async Task<Component> GetById(Guid id)
        {
            return await _context.Components
                .FirstOrDefaultAsync(i => i.Id == id);      

        }


        private async Task Save()
        {
            await _context.SaveChangesAsync();
        }


    }
}
