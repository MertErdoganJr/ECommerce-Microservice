using ECommerce.Order.Application.Features.Mediator.Queries;
using ECommerce.Order.Application.Features.Mediator.Results;
using ECommerce.Order.Application.Interface;
using ECommerce.Services.Order.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Application.Features.Mediator.Handlers
{
    public class GetOrderingByIdQueryHandler : IRequestHandler<GetOrderingByIdQuery, GetOrderingGetByIdQueryResult>
    {
        private readonly IRepository<Ordering> _repository;

        public GetOrderingByIdQueryHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task<GetOrderingGetByIdQueryResult> Handle(GetOrderingByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetOrderingGetByIdQueryResult
            {
                OrderDate = values.OrderDate,
                OrderingID = values.OrderingID,
                TotalPrice = values.TotalPrice,
                UserID = values.UserID,
            };
        }
    }
}
