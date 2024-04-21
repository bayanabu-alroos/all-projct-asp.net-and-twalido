using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImageUpload.Models
{
    public class Laptop
    {
        [Key]
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string? Path { get; set; }
        [Display(Name = "Choose Image")]
        [NotMapped]
        public IFormFile ImagePath { get; set; }
    }
}
