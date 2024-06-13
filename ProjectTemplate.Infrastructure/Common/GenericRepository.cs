using ProjectTemplate.Application.Interface.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ProjectTemplate.Infrastructure.Common
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly AppDbContext _dbContext;
        public GenericRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }
    }


    //public class GenericRepository<T>(AppDbContext _dbContext) : IGenericRepository<T> where T : class
    //{
    //    public readonly AppDbContext _dbContext;
    //    //public GenericRepository(AppDbContext dbContext)
    //    //{
    //    //    _dbContext = dbContext;
    //    //}
    //    public async Task<IEnumerable<T>> GetAll()
    //    {
    //        return await _dbContext.Set<T>().ToListAsync();
    //    }
    //}
}