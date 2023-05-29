namespace AkademiPlusCQRS.CQRSPattern.Commands
{
    public class CreateProductCommand
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Stok { get; set; }
        public string Category { get; set; }

    }
}
