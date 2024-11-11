namespace CustomerService.Dtos
{
    public class CustomerReadDto
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public int TaxId { get; set; }
        public float AmmountOwed {get; set; }
    }
}