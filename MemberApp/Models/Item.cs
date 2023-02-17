using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MemberApp.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Category Category { get; set; }
        public string Description { get; set; } = "";
    }
}
