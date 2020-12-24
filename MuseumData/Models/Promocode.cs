using MuseumData.Models.Enum;

namespace MuseumData.Models
{
    public class Promocode : BaseModel
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public PromocodeType PromocodeType { get; set; }
        public int Value { get; set; }
        public int MaxUses { get; set; }
    }
}