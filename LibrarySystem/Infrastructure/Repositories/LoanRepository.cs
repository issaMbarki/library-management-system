using System;
using LibrarySystem.Application.Interfaces;
using LibrarySystem.Domain.Entities;
using LibrarySystem.Infrastructure.Data;

namespace LibrarySystem.Infrastructure.Repositories;

public class LoanRepository(LibraryDbContext context) : BaseRepository(context), ILoanRepository
{

    public async Task AddAsync(Loan loan)
    {
        await _context.Loans.AddAsync(loan);
    }
}
