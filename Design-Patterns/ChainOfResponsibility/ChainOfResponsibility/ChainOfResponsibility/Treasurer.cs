using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        readonly Employee _managerAssistant = new ManagerAssistant();
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            this.SetNextApprover(_managerAssistant);

            if (req.Amount <= 80000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.EmployeeName = "Gişe memuru Ali Yıldırım";
                customerProcess.Description = "Müşterinin talep ettiği tutar gişe memuru tarafınca müşteriye ödenmiştir.";
                context.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.EmployeeName = "Gişe memuru Ali Yıldırım";
                customerProcess.Description = "Müşterinin talep ettiği tutar gişe memuru tarafınca ödenemedi. İşlem şube müdür yardımcısına aktarıldı.";
                context.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}