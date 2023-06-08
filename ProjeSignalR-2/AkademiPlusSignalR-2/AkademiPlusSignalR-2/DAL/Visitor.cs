using System;

namespace AkademiPlusSignalR_2.DAL
{
    public enum ECity
    {
        Istanbul = 1,
        Bursa = 2,
        Adana = 3,
        Tekirdag = 4,
        Ankara = 5
    }

    public class Visitor
    {
        public int VisitorID { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
