namespace CRUDops.Application.Interfaces
{
    public interface IApp<T> where T : class
    {
        Task<List<T>> GetAll();
    }
}
