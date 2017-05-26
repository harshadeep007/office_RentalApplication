using AutoMapper;
using Rental_Application.Models;
using Rental_Application.Dtos;


namespace Rental_Application.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();

        }

    }
}