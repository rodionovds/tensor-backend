using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MuseumData.Models.Enum;

namespace MuseumData.Models
{
    public class Order : BaseModel
    {
        [Required] public string Name { get; set; }
        [MaxLength(20)] public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime VisitDate { get; set; }
        [Required] public Payment Payment { get; set; }
        public ModeType Type { get; set; } = ModeType.Inet;
        public Promocode Promocode { get; set; } = null;
        public int Discount { get; set; } = 0;
        public string Comment { get; set; }
        [Required] public OrderDelivery Delivery { get; set; }
        [Required] public bool DeliveryStatus { get; set; } = false;
        [Required] public string Hash { get; set; }
        public DateTime ActivationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public new OrderStatus Status { get; set; } = OrderStatus.New;

        public virtual IEnumerable<Cart> Carts { get; set; }
    }
}