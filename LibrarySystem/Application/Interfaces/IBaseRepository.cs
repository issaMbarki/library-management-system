using System;

namespace LibrarySystem.Application.Interfaces;

public interface IBaseRepository
{
    Task SaveChangesAsync();
}
