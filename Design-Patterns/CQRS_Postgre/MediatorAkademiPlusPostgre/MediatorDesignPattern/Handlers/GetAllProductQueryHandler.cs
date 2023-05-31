using MediatorAkademiPlusPostgre.DAL;
using MediatorAkademiPlusPostgre.MediatorDesignPattern.Qeries;
using MediatorAkademiPlusPostgre.MediatorDesignPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Handlers
{

    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetAllProductQueryResult>>
    {
        private readonly Context _context;

        public GetAllProductQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllProductQueryResult>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(x => new GetAllProductQueryResult()
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                ProductBrand = x.ProductBrand,
                ProductPrice = x.ProductPrice,
                ProductStock = x.ProductStock
            }).ToListAsync();
        }
    }
}
