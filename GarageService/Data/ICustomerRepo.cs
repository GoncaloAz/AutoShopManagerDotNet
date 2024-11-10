using GarageService.Models;

namespace GarageService.Data{
    public interface ICustomerRepo{
        bool SaveChanges();
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById();
        Customer GetCustomerByNumber();
        void CreateCliente(ClientCertificateOption client);
    }
}