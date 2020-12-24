using AutoMapper;
using Museum.Dtos.Doll;
using MuseumData.Models;

namespace Museum.Profiles
{
    public class DollProfile : Profile
    {
        public DollProfile()
        {
            // Source -> Target
            CreateMap<Doll, DollReadDto>();
                // .ForMember(dest => dest.Hello,
                //    opt => opt.MapFrom(src => "Hello"));
        }
    }
}