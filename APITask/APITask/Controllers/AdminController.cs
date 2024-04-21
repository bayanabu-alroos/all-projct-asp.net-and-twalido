using APITask.Context;
using APITask.DTO.User;
using APITask.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APITask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase, IAdminInterface
    {
        private readonly TaskAPIDbContext _context;
        public AdminController(TaskAPIDbContext context)
        {
            _context = context;
        }
        public Task<List<UserCardDTO>> GetAllUsers()
        {
            throw new NotImplementedException();
        }
        public Task CreateUser(UserCreateDTO dto)
        {
            throw new NotImplementedException();
        }


    }
}
