using System;
using System.Collections.Generic;

#nullable disable

namespace ORM_EFcore.Models
{
    public partial class Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }

        public virtual Class Class { get; set; }
        public virtual Student Student { get; set; }
    }
}
