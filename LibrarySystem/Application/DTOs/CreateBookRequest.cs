using System;

namespace LibrarySystem.Application.DTOs;

public class CreateBookRequest
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
}
