namespace MediatorAkademiPlusPostgre.DAL
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? ProductBrand { get; set; }
        public int ProductStock { get; set; }
        public int ProductPrice { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
