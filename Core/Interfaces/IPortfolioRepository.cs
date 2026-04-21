using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IPortfolioRepository
    {
        Task<IReadOnlyList<PortfolioItem>> GetAllAsync();
        Task<PortfolioItem?> GetByIdAsync(int id);
        void AddItem(PortfolioItem item);
        void UpdateItem(PortfolioItem item);
        void DeleteItem(PortfolioItem item);
        Task<bool> SaveAllChangesAsync();
    }
}
