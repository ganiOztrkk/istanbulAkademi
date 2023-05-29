namespace CQRS_Postgre.DAL
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductBrand { get; set; } = string.Empty;
        public string ProductCategory { get; set; } = string.Empty;
        public int ProductStok { get; set; }
        public string ProductStokType { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; }
        public decimal Tax { get; set; }
        public string Publisher { get; set; } = string.Empty;
        public DateTime LastUseDate { get; set; }
        public string Barcode { get; set; } = string.Empty;
        public string ShelfNumber { get; set; } = string.Empty;
    }
}
