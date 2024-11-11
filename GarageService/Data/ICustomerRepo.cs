using GarageService.Models;

namespace GarageService.Data{
    public interface ICustomerRepo{
        bool SaveChanges();
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerByTaxId(int taxId);
        Customer GetCustomerByPhoneNumber(int phoneNumber);
        void CreateCustomer(Customer client);
    }
}