using System;
using LibrarySystem.Application.DTOs;

namespace LibrarySystem.Application.Interfaces;

public interface IUserService
{
    Task<IEnumerable<UserDto>> GetAllAsync();
    Task<UserDto> CreateAsync(CreateUserRequest request);
}
