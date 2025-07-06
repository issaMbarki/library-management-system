using System;

namespace LibrarySystem.Domain.Entities;

public class Book
{
    public Guid Id { get; private set; }
    public string Title { get; private set; }
    public string Author { get; private set; }
    public bool IsBorrowed { get; private set; }

    private Book() { } // EF

    public Book(string title, string author)
    {
        Id = Guid.NewGuid();
        Title = title;
        Author = author;
        IsBorrowed = false;
    }

    public void Borrow() => IsBorrowed = true;
    public void Return() => IsBorrowed = false;
}
