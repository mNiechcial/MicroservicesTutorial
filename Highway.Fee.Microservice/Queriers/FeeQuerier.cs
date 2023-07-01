using Highway.Fee.Microservice.Context;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Highway.Fee.Microservice.Queriers
{
    public class GetFeesQuery : IRequest<int>
    {
        public DateTime DateToCheckForFees{ get; set; }
        public class GetFeesQueryHandler : IRequestHandler<GetFeesQuery, int>
        {
            private readonly IApplicationDbContext _context;
            public GetFeesQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(GetFeesQuery query, CancellationToken cancellationToken)
            {
                //var productList = await _context.Products.ToListAsync();
                //if (productList == null)
                //{
                //    return null;
                //}
                return 11;
            }
        }
    }
}
