using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Implementation
{
    
    public class PortfolioRepository(PortfolioContext context) : IPortfolioRepository
    {        
        public void AddItem(PortfolioItem item)
        {
            context.PortfolioItems.Add(item);
        }

        public void DeleteItem(PortfolioItem item)
        {
            context.PortfolioItems.Remove(item);
        }

        public async Task<IReadOnlyList<PortfolioItem>> GetAllAsync()
        {
            return await context.PortfolioItems.ToListAsync();
        }

        public async Task<PortfolioItem?> GetByIdAsync(int id)
        {
            return await context.PortfolioItems.FindAsync(id);
        }

        public async Task<bool> SaveAllChangesAsync()
        {
            return await context.SaveChangesAsync() > 0;
        }

        public void UpdateItem(PortfolioItem item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
