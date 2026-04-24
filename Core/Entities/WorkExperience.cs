using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class WorkExperience : BaseEntity
    {
        public string Company { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<string> Responsibilities { get; set; }
        public int UserPortfolioId { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
