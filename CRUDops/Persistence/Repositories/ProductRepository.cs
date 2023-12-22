using CRUDops.Models;

namespace CRUDops.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>
    {
        public readonly ShopContext _dbContext;

        public ProductRepository(ShopContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
