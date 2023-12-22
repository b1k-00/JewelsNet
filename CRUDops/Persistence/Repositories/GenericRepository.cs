using CRUDops.Application.Persistence;
using CRUDops.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDops.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ShopContext _dbContext;

        public GenericRepository(ShopContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyCollection<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }
    }
}
