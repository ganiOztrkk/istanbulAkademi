using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover; //sonraki onaylayıcının kim olduğunu belirlemek için employee türünde bir değişken oluşturduk.
        public void SetNextApprover(Employee employee)
        {
            this.NextApprover = employee; // burada sonraki onaylayıcıya atama yaptık. oluşturduğumuz set metodu sonraki onaylayıcının kim olduğuna atama yapmamız için kullanılıyor.
        }

        public abstract void ProcessRequest(CustomerProcessViewModel req);
    }
}
