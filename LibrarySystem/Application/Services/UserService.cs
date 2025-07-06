using System;
using LibrarySystem.Application.DTOs;
using LibrarySystem.Application.Interfaces;
using LibrarySystem.Domain.Entities;

namespace LibrarySystem.Application.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    private readonly IUserRepository _userRepository = userRepository;
    public async Task<UserDto> CreateAsync(CreateUserRequest request)
    {
        var user = new User(fullName: request.FullName);
        await _userRepository.AddAsync(user);
        await _userRepository.SaveChangesAsync();
        return new UserDto
        {
            Id = user.Id,
            FullName = user.FullName
        };
    }

    public async Task<IEnumerable<UserDto>> GetAllAsync()
    {
        var users = await _userRepository.GetAllAsync();
        return users.Select(u => new UserDto
        {
            Id = u.Id,
            FullName = u.FullName
        });
    }
}
