namespace AkademiPlusCQRS.CQRSPattern.Result
{
    public class GetProductQueryResult
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public int Stok { get; set; }
        public decimal Price { get; set; }
    }
}
