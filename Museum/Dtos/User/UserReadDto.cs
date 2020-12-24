using System;
using MuseumData.Models.Enum;

namespace Museum.Dtos.User
{
    public class UserReadDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public UserRole Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastLogin { get; set; }
        public bool Status { get; set; }
    }
}