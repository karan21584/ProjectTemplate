using ProjectTemplate.Application.Interface.Services;
using Microsoft.AspNetCore.Mvc;

namespace ProjectTemplate.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController : ControllerBase
    {
        public readonly IRoleService _roleService;
        private readonly ILogger<RoleController> _logger;

        public RoleController(ILogger<RoleController> logger, IRoleService roleService)
        {
            _logger = logger;
            _roleService = roleService;
        }

        [HttpPost("GetAll")]
        public async Task<IActionResult> GetAllRoles()
        {
            var roleList = await _roleService.GetAll();
            return Ok(roleList);
        }

    }
}
