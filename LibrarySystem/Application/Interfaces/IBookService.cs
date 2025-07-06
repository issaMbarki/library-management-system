using System;
using LibrarySystem.Application.DTOs;

namespace LibrarySystem.Application.Interfaces;

public interface IBookService
{
    Task<IEnumerable<BookDto>> GetAllAsync();
    Task<BookDto> CreateAsync(CreateBookRequest request);
    Task DeleteAsync(Guid bookId);

}
