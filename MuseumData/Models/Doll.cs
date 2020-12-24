using System;
using System.ComponentModel.DataAnnotations;

namespace MuseumData.Models
{
    public class Doll : BaseModel
    {
        [Required] public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [Required]public DateTime CreationDate { get; set; }
        [Required] public DateTime LastEditDate { get; set; }
    }
}