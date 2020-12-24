using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MuseumData.Models.Enum;

namespace MuseumData.Models
{
    public class User : BaseModel
    {
        [Required] public string Email { get; set; }
        [Required] public string Username { get; set; }
        [Required] public string Password { get; set; }
        [Required] public string Name { get; set; }
        public UserRole Role { get; set; } = UserRole.User;
        public string Token { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastLogin { get; set; }
    }
}