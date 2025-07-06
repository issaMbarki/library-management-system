using System;
using LibrarySystem.Application.DTOs;
using LibrarySystem.Application.Interfaces;
using LibrarySystem.Domain.Entities;

namespace LibrarySystem.Application.Services;

public class LoanService(ILoanRepository loanRepository, IUserRepository userRepository, IBookRepository bookRepository) : ILoanService
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IBookRepository _bookRepository = bookRepository;
    private readonly ILoanRepository _loanRepository = loanRepository;

    public async Task BorrowBookAsync(BorrowBookRequest request)
    {
        var book = await _bookRepository.GetByIdAsync(request.BookId);
        if (book == null) throw new Exception("Book not found");
        if (book.IsBorrowed) throw new Exception("Book already borrowed");

        var user = await _userRepository.GetByIdAsync(request.UserId);
        if (user == null) throw new Exception("User not found");
        book.Borrow();
        var loan = new Loan(request.UserId, request.BookId);
        await _loanRepository.AddAsync(loan);
        await _loanRepository.SaveChangesAsync();

    }
}
