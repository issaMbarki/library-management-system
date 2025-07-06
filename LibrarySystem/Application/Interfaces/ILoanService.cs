using System;
using LibrarySystem.Application.DTOs;

namespace LibrarySystem.Application.Interfaces;

public interface ILoanService
{
    Task BorrowBookAsync(BorrowBookRequest request);

}
