using AutoMapper;
using CustomerService.Dtos;
using GarageService.Data;
using GarageService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private  ICustomerRepo _repository;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet]
        public ActionResult<IEnumerable<CustomerReadDto>> GetCustomer()
        {
            Console.WriteLine("-- getting all clients...");
            var customers = _repository.GetAllCustomers();

            return Ok(_mapper.Map<IEnumerable<CustomerReadDto>>(customers));
        }

        [HttpGet("{taxId}", Name = "GetCustomerByTaxId")]
        public ActionResult<CustomerReadDto> GetCustomerByTaxId(int taxId)  
        {
            var customerItem = _repository.GetCustomerByTaxId(taxId);
            if(customerItem != null){
                return Ok(_mapper.Map<CustomerReadDto>(customerItem)); 
            }
 
            return NotFound();
        }

        [HttpPost]
        public ActionResult<CustomerReadDto> CreateCustomer(CustomerCreateDto customerCreateDto)
        {
            var customerModel = _mapper.Map<Customer>(customerCreateDto);
            _repository.CreateCustomer(customerModel);
            _repository.SaveChanges();

            var customerReadDto = _mapper.Map<CustomerReadDto>(customerModel);
            
            return CreatedAtRoute(nameof(GetCustomerByTaxId), new {TaxId = customerReadDto.TaxId}, customerReadDto);
        }
    }
}