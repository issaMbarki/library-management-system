using System;
using LibrarySystem.Application.Interfaces;
using LibrarySystem.Infrastructure.Data;

namespace LibrarySystem.Infrastructure.Repositories;

public class BaseRepository(LibraryDbContext context) : IBaseRepository
{
    protected readonly LibraryDbContext _context = context;
    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
