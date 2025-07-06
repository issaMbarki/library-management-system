using System;
using LibrarySystem.Application.Interfaces;
using LibrarySystem.Domain.Entities;
using LibrarySystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Infrastructure.Repositories;

public class BookRepository(LibraryDbContext context) : BaseRepository(context), IBookRepository
{
    public async Task<List<Book>> GetAllAsync() =>
        await _context.Books.ToListAsync();

    public async Task AddAsync(Book book)
    {
        await _context.Books.AddAsync(book);
    }

    public async Task<Book?> GetByIdAsync(Guid id) =>
        await _context.Books.FindAsync(id);

    public void Delete(Book book)
    {
        _context.Books.Remove(book);
    }
}