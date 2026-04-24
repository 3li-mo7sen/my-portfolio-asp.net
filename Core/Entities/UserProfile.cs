using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class UserProfile : BaseEntity
    {
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string About { get; set; }
        public List<Education> Educations { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Project> Projects { get; set; }
        public List<WorkExperience> WorkExperiences { get; set; }
        public List<SocialLink> SocialLinks { get; set; }
    }
}
