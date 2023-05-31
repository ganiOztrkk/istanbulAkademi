namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Results
{
    // listeleme yapacakken neleri gostermek istiyorsam buraya onları ekliyorum
    public class GetAllProductQueryResult 
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? ProductBrand { get; set; }
        public int ProductStock { get; set; }
        public int ProductPrice { get; set; }
    }
}
