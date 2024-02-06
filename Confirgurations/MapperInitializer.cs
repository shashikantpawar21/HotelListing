using AutoMapper;
using HotelListing.Data;
using HotelListing.Models;

namespace HotelListing.Configurations
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();   
            CreateMap<Country, CreateCountryDTO>().ReverseMap();   
            CreateMap<Country, AddCountryDTO>().ReverseMap();   
            CreateMap<Country, UpdateCountryDTO>().ReverseMap();   
            CreateMap<Hotel, HotelDTO>().ReverseMap();   
            CreateMap<Hotel, CreateHotelDTO>().ReverseMap();   
            CreateMap<Hotel, UpdateHotelDTO>().ReverseMap();   
            CreateMap<ApiUser, UserDTO>().ReverseMap();   
        }
        
    }
}