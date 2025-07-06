using System;

namespace LibrarySystem.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string FullName { get; private set; }

    private User() { }

    public User(string fullName)
    {
        Id = Guid.NewGuid();
        FullName = fullName;
    }
}
