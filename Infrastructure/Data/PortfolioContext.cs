using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Entities;

namespace Infrastructure.Data
{
    public class PortfolioContext : DbContext
    {
        public PortfolioContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PortfolioItem> PortfolioItems { get; set; }
    }
}