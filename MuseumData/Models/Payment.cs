using System.ComponentModel.DataAnnotations;
using MuseumData.Models.Enum;

namespace MuseumData.Models
{
    public class Payment : BaseModel
    {
        [Required] public string Name { get; set; }
        [Required] public PaymentType Type { get; set; }
        [Required] public ModeType ModeType { get; set; }
    }
}