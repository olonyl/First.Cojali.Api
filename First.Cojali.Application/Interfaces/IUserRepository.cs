using First.Cojali.Domain.Entities;

namespace First.Cojali.Application.Interfaces;

public interface IUserRepository
{
    IEnumerable<User> GetAllUsers();
    User GetById(int id);
    void AddUser(User user);
    void UpdateUser(User user);
    bool Exists(int id);
}
