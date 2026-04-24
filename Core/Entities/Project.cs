using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string TechnologiesUsed { get; set; }
        public string Role { get; set; }
        public string GitHubLink { get; set; }
        public int UserPortfolioId { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
