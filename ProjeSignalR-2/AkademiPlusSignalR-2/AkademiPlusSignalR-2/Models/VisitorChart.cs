using System.Collections.Generic;

namespace AkademiPlusSignalR_2.Models
{
    public class VisitorChart
    {
        public VisitorChart()
        {
            Count = new List<int>();
        }

        public string VisitDate { get; set; }
        public List<int> Count { get; set; } // ziyaretci sayısını bir LİSTE olarak tutacak
    }
}
