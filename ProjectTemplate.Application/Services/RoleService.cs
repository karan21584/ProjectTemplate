using ProjectTemplate.Application.Interface.Repositories;
using ProjectTemplate.Application.Interface.Services;
using ProjectTemplate.Domain;

namespace ProjectTemplate.Application.Services
{
    public class RoleService : IRoleService
    {
        private readonly IGenericRepository<RoleModel> _roleRepo;

        public RoleService(IGenericRepository<RoleModel> roleRepo)
        {
            _roleRepo = roleRepo;
        }

        public async Task<IEnumerable<RoleModel>> GetAll()
        {
            return await _roleRepo.GetAll();
        }
    }
}
