using System.ComponentModel.DataAnnotations;

namespace MuseumData.Models
{
    public class Ticket : BaseModel
    {
        [Required] public string Name { get; set; }
        public string Comment { get; set; }
        [Required] public float Price { get; set; }
    }
}