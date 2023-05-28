using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfResponsibility
{
    public class ManagerAssistant : Employee
    {
        readonly Employee _manager = new Manager();

        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            this.SetNextApprover(_manager);
            Context context = new Context();
            if (req.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.EmployeeName = "Şube Müdür Yr. Zeynep Çiçek";
                customerProcess.Description = "Müşterinin talep ettiği tutar müşteriye şube müdür yardımcısı tarafınca ödenmiştir.";
                context.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover!= null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.EmployeeName = "Şube Müdür Yr. Zeynep Çiçek";
                customerProcess.Description = "Müşterinin talep ettiği tutar gişe memuru tarafınca ödenemedi. İşlem şube müdürüne aktarıldı.";
                context.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
