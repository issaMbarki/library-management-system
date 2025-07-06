using System;

namespace LibrarySystem.Application.DTOs;

public class BorrowBookRequest
{
    public Guid UserId { get; set; }
    public Guid BookId { get; set; }

}
