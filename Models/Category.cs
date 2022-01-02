using System.ComponentModel.DataAnnotations;

namespace ORM_EFcore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required] 
        public string Name { get; set; }

        public string Description { get; set; }
    }
}