using System;
using System.ComponentModel.DataAnnotations;

namespace MuseumData.Models
{
    public class ClosedDay : BaseModel
    {
        [Required] public string Reason { get; set; }
        [Required] public DateTime Date { get; set; }
        [Required] public User User { get; set; }
    }
}