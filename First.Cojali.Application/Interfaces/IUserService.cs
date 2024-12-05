using First.Cojali.Application.Models;
using First.Cojali.Domain.Entities;

namespace First.Cojali.Application.Interfaces;

public interface IUserService
{
    Task<IEnumerable<UserDto>> GetAllUsersAsync();
    Task<UserDto> GetByIdAsync(int id);
    Task<UserDto> CreateUserAsync(string name, string email);
    Task UpdateUserAsync(int id, string name, string email);
    Task<bool> UserExistsAsync(int id);
}
