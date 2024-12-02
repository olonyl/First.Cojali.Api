using AutoMapper;
using First.Cojali.Application.Interfaces;
using First.Cojali.Application.Models;
using First.Cojali.Domain.Entities;

namespace First.Cojali.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public IEnumerable<UserDto> GetAllUsers()
    {
        var users = _userRepository.GetAllUsers();
        return _mapper.Map<IEnumerable<UserDto>>(users);
    }

    public UserDto GetById(int id)
    {
        var user = FindUserOrThrow(id);
        return _mapper.Map<UserDto>(user);
    }

    public UserDto CreateUser(string name, string email)
    {
        ValidateUserInput(name, email);

        var newUser = new User { Name = name, Email = email };
        _userRepository.AddUser(newUser);

        return _mapper.Map<UserDto>(newUser);
    }

    public void UpdateUser(int id, string name, string email)
    {
        ValidateUserInput(name, email);

        var user = FindUserOrThrow(id);

        user.Name = name;
        user.Email = email;
        _userRepository.UpdateUser(user);
    }

    public bool UserExists(int id) => _userRepository.Exists(id);

    private User FindUserOrThrow(int id)
    {
        return _userRepository.GetById(id) ?? throw new KeyNotFoundException($"User with ID {id} not found.");
    }

    private static void ValidateUserInput(string name, string email)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be null or empty.", nameof(name));

        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email cannot be null or empty.", nameof(email));
    }
}
