using AkademiPlusCQRS.CQRSPattern.Commands;
using AkademiPlusCQRS.DAL;

namespace AkademiPlusCQRS.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product()
            {
                Brand = command.Brand,
                Name = command.Name,
                Price = command.Price,
                Stok = command.Stok,
                Category = command.Category
            });
            _context.SaveChanges();
        }

    }
}
