using Core.Entities;
using Core.Repositories;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ConfigurationPCRepository : IConfigurationPCRepository
    {
        private readonly AppDbContext _context;


        public ConfigurationPCRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ConfigurationPC>> GetAll()
        {
            return await _context.ConfigurationPCs
                .Include(c => c.Components)
                .ThenInclude(c => c.Component)
                .ToListAsync();
        }
        public async Task<ConfigurationPC> Add(ConfigurationPC configurationPC)
        {
            await _context.ConfigurationPCs.AddAsync(configurationPC);
            await _context.SaveChangesAsync();

            return configurationPC;
        }

        public async Task<ConfigurationPC> Update(ConfigurationPC configurationPC)
        {
            _context.ConfigurationPCs.Update(configurationPC);
            await _context.SaveChangesAsync();

            return configurationPC;
        }
        public async Task Delete(Guid id)
        {
            var configurationPC = await GetById(id);
            _context.ConfigurationPCs.Remove(configurationPC);
            await Save();
        }

        public async Task<ConfigurationPC> GetById(Guid id)
        {
            return await _context.ConfigurationPCs
                .Include(c => c.Components)
                .ThenInclude(c => c.Component)
                .FirstOrDefaultAsync(i => i.Id == id);

        }
        private async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
