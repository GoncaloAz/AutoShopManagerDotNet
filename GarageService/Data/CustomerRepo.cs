using GarageService.Data;
using GarageService.Models;

namespace CustomerService.Data{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly AppDbContext _context;

        public CustomerRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateCustomer(Customer client)
        {
            if(client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            _context.Customers.Add(client);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomerByTaxId(int taxId)
        {
            return _context.Customers.FirstOrDefault(x => x.TaxId == taxId);
        }

        public Customer GetCustomerByPhoneNumber(int phoneNumber)
        {
            return _context.Customers.FirstOrDefault(x => x.PhoneNumber == phoneNumber);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}