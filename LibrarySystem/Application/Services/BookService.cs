using System;
using LibrarySystem.Application.DTOs;
using LibrarySystem.Application.Interfaces;
using LibrarySystem.Domain.Entities;

namespace LibrarySystem.Application.Services;

public class BookService(IBookRepository bookRepository): IBookService
{
    private readonly IBookRepository _bookRepository = bookRepository;

    public async Task<IEnumerable<BookDto>> GetAllAsync()
    {
        var books = await _bookRepository.GetAllAsync();
        return books.Select(b => new BookDto
        {
            Id = b.Id,
            Title = b.Title,
            Author = b.Author,
            IsBorrowed = b.IsBorrowed
        });
    }


    public async Task<BookDto> CreateAsync(CreateBookRequest request)
    {
        var book = new Book(request.Title, request.Author);
        await _bookRepository.AddAsync(book);
        await _bookRepository.SaveChangesAsync();
        return new BookDto
        {
            Id = book.Id,
            Title = book.Title,
            Author = book.Author,
            IsBorrowed = book.IsBorrowed
        };
    }

    public async Task DeleteAsync(Guid bookId)
    {
        var book = await _bookRepository.GetByIdAsync(bookId);
        if (book == null)
            throw new KeyNotFoundException("Book not found");
        _bookRepository.Delete(book);
        await _bookRepository.SaveChangesAsync();
    }
}
