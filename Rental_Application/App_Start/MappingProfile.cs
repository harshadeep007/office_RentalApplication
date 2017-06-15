using AutoMapper;
using Rental_Application.Models;
using Rental_Application.Dtos;


namespace Rental_Application.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            CreateMap<Customer, CustomerDto>();
            CreateMap<Movie, MovieDto>();


            // Dto to Domain
           CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.id, opt => opt.Ignore());

            CreateMap<MovieDto, Movie>()
                .ForMember(c => c.id, opt => opt.Ignore());

        }

    }
}