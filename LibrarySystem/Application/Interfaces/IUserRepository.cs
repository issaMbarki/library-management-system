using System;
using LibrarySystem.Domain.Entities;

namespace LibrarySystem.Application.Interfaces;

public interface IUserRepository : IBaseRepository
{
    Task AddAsync(User user);
    Task<List<User>> GetAllAsync();
    Task<User?> GetByIdAsync(Guid guid);
}
