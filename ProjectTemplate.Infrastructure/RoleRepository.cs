using ProjectTemplate.Application.Interface.Repositories;
using ProjectTemplate.Domain;
using ProjectTemplate.Infrastructure.Common;

namespace ProjectTemplate.Infrastructure
{
    public class RoleRepository : GenericRepository<RoleModel>, IRoleRepository
    {
        public RoleRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
