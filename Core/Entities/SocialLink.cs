using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class SocialLink : BaseEntity
    {
        public string Platform { get; set; }
        public string Url { get; set; }
        public int UserPortfolioId { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
