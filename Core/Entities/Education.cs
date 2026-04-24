using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Education : BaseEntity
    {
        public string Degree { get; set; }
        public string Institution { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double GPA { get; set; }
        public int UserPortfolioId { get; set; }

    }
}
