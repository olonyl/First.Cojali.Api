using First.Cojali.Application.Models;
using First.Cojali.Domain.Entities;

namespace First.Cojali.Application.Interfaces;

public interface IUserService
{
    IEnumerable<UserDto> GetAllUsers();
    UserDto GetById(int id);
    UserDto CreateUser(string name, string email);
    void UpdateUser(int id, string name, string email);
    bool UserExists(int id);
}
