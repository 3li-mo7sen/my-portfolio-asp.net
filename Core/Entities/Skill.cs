using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Skill: BaseEntity
    {
        public string Name { get; set; }
        public int ProficiencyLevel { get; set; }
        public string Category { get; set; }
        public int UserPortfolioId { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
