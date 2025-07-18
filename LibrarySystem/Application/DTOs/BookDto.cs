using System;

namespace LibrarySystem.Application.DTOs;

public class BookDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public bool IsBorrowed { get; set; }
}
