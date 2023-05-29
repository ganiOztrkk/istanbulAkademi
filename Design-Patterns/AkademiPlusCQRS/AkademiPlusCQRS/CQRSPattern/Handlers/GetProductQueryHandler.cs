using AkademiPlusCQRS.CQRSPattern.Result;
using AkademiPlusCQRS.DAL;

namespace AkademiPlusCQRS.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                Name = x.Name,
                Brand = x.Brand,
                Category = x.Category,
                Price = x.Price,
                Stok = x.Stok,
                ProductID = x.ProductID
            });
            return values.ToList();
        }
    }
}
