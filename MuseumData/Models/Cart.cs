using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using MuseumData.Models.Enum;

namespace MuseumData.Models
{
    public class Cart
    {
        [Required] public int OrderId { get; set; }
        [Required] public int TicketId { get; set; }
        [Required] public int Count { get; set; }
    }
}