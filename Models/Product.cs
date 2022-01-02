using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORM_EFcore.Models
{
    public class Product
    {
        [Key] 
        public int Id { get; set; }
        [Required] 
        public string Name{ get; set; }
        [Required] 
        public double Price{ get; set; }
        [Required]
        public int CategoriId { get; set; }
        [ForeignKey("CategoriId")]
        public Category Category { get; set; }
    }
}