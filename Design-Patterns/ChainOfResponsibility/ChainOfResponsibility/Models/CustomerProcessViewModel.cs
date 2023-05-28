namespace ChainOfResponsibility.Models
{
    public class CustomerProcessViewModel
    {
        public int CustomerProcessID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public decimal Amount { get; set; }
        public string EmployeeName { get; set; }
        public string Description { get; set; }
    }
}
