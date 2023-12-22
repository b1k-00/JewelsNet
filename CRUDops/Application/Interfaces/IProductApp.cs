using CRUDops.Models;

namespace CRUDops.Application.Interfaces
{
    public interface IProductApp
    {
        Task<List<Product>> All();
    }
}
