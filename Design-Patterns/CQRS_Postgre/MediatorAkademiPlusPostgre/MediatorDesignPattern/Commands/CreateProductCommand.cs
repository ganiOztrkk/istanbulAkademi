using MediatR;

namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Commands
{
    public class CreateProductCommand : IRequest
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductBrand { get; set; } = string.Empty;
        public int ProductStock { get; set; }
        public int ProductPrice { get; set; }
        public int CategoryID { get; set; }
    }
}
