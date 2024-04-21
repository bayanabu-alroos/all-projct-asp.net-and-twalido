using APITask.DTO.User;

namespace APITask.Interfaces
{
    public interface IAdminInterface
    {
        Task<List<UserCardDTO>> GetAllUsers();
        Task CreateUser(UserCreateDTO dto);

    }
}
