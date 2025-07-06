using System;
using LibrarySystem.Domain.Entities;

namespace LibrarySystem.Application.Interfaces;

public interface ILoanRepository : IBaseRepository
{
    public Task AddAsync(Loan loan);
}
