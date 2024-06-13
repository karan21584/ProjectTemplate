using ProjectTemplate.Domain;

namespace ProjectTemplate.Application.Interface.Services
{
    public interface IRoleService
    {
        Task<IEnumerable<RoleModel>> GetAll();
    }
}
