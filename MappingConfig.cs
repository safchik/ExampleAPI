using AutoMapper;
using ExampleAPI.Models;
using ExampleAPI.Models.DTO;

namespace ExampleAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<Coupon, CouponCreateDTO>().ReverseMap();
            CreateMap<Coupon, CouponDTO>().ReverseMap();
        }
    }
}
