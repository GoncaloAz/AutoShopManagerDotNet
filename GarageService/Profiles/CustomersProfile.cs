using AutoMapper;
using CustomerService.Dtos;
using GarageService.Models;

namespace CustomerService.Profiles
{
    public class CustomersProfiles : Profile
    {
        public void CustomersProfile()
        {
            // Source -> target
            //Since names are the same automapper is smart to map automatically
            CreateMap<Customer, CustomerReadDto>();
        }
    }
}