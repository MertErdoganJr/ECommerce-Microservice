using ECommerce.Order.Application.Features.CQRS.Results;
using ECommerce.Order.Application.Interface;
using ECommerce.Services.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Application.Features.CQRS.Handlers
{
    public class GetAddressQueryHandler
    {
        private readonly IRepository<Address> _repository;

        public GetAddressQueryHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAddressQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=>new GetAddressQueryResult
            {
                AddressID = x.AddressID,
                City = x.City,
                Detail =x.Detail,
                District =x.District,
                UserID = x.UserID,
            }).ToList();
        }
    }
}
