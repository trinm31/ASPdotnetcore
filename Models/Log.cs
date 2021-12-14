using System.ComponentModel.DataAnnotations;

namespace ORM_EFcore.Models
{
    public class Log
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
    }
}