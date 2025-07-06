using System;
using LibrarySystem.Domain.Entities;

namespace LibrarySystem.Application.Interfaces;

public interface IBookRepository : IBaseRepository
{
    Task<List<Book>> GetAllAsync();
    Task AddAsync(Book book);
    Task<Book?> GetByIdAsync(Guid id);
    void Delete(Book book);

}
