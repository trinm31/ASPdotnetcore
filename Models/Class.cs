using System;
using System.Collections.Generic;

#nullable disable

namespace ORM_EFcore.Models
{
    public partial class Class
    {
        public Class()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
