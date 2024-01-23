using ECommerce.Services.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Application.Interface
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task CreateAsync(int id);
        Task UpdateAsync(int id);
        Task DeleteAsync(int id);
        Task<List<T>> GetOrdersByFilter(Expression<Func<T, bool>> filter);
        Task CreateAsync(Ordering ordering);
    }
}
