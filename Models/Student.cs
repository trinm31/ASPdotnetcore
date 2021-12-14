using System;
using System.Collections.Generic;

#nullable disable

namespace ORM_EFcore.Models
{
    public partial class Student
    {
        public Student()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public int StudentId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string HomeTown { get; set; }
        public double StudentFee { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
