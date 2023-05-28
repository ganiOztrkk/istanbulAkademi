using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfResponsibility
{
    public class RegionManager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();

            if (req.Amount <= 350000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.EmployeeName = "Bölge Müdürü Yeliz Ekin";
                customerProcess.Description = "Müşterinin talep ettiği tutar müşteriye bölge müdürü tarafınca ödenmiştir.";
                context.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.EmployeeName = "Şube Müdürü Hakan Kayalı";
                customerProcess.Description = "Müşterinin talep ettiği tutar bankanın günlük para çekme limitinin üzerinde olduğu için müşteriye talep edilen tutar ödenemedi.";
                context.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
