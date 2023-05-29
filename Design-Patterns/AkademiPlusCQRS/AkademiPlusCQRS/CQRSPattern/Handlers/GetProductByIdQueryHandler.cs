using AkademiPlusCQRS.CQRSPattern.Queries;
using AkademiPlusCQRS.CQRSPattern.Result;
using AkademiPlusCQRS.DAL;

namespace AkademiPlusCQRS.CQRSPattern.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var values = _context.Set<Product>().Find(query.Id);
            return new GetProductByIdQueryResult
            {
                Brand = values.Brand,
                Name = values.Name,
                ProductID = values.ProductID
            };
        }
    }
}
