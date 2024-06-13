using ProjectTemplate.Domain;

namespace ProjectTemplate.Application.Interface.Repositories
{
    public interface IRoleRepository
    {
        Task<IEnumerable<RoleModel>> GetAll();
    }
}
