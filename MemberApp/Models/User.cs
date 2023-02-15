using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace MemberApp.Models
{
    public class User
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public int? ListId { get; set; }
        public User()
        {
        }
    }
}
