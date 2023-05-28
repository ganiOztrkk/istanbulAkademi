using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfResponsibility
{
    public class Manager : Employee
    {
        readonly Employee _regionManager = new RegionManager();

        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            this.SetNextApprover(_regionManager);
            if (req.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.EmployeeName = "Şube Müdürü Hakan Kayalı";
                customerProcess.Description = "Müşterinin talep ettiği tutar müşteriye şube müdürü tarafınca ödenmiştir.";
                context.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.EmployeeName = "Şube Müdürü Hakan Kayalı";
                customerProcess.Description = "Müşterinin talep ettiği tutar şube müdürü tarafınca ödenemedi. İşlem bölge müdürüne aktarıldı.";
                context.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
