namespace ProjectTemplate.Application.Interface.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
    }
}
