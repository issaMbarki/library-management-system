using System;

namespace LibrarySystem.Domain.Entities;

public class Loan
{
    public Guid Id { get; private set; }
    public Guid UserId { get; private set; }
    public Guid BookId { get; private set; }
    public DateTime BorrowedAt { get; private set; }

    private Loan() { }

    public Loan(Guid userId, Guid bookId)
    {
        Id = Guid.NewGuid();
        UserId = userId;
        BookId = bookId;
        BorrowedAt = DateTime.UtcNow;
    }
}
