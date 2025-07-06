using System;

namespace LibrarySystem.Application.DTOs;

public class UserDto
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = "";
}
