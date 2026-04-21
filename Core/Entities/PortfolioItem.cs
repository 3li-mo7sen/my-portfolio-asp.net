using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class PortfolioItem : BaseEntity
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string ImageUrl { get; set; }

    }
}
