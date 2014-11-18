using System;
using System.Data.Entity;
using System.Threading.Tasks;
using TechTest.Domain.Entities;

namespace TechTest.Data.Contracts
{
    public interface ITechTestEntities : IDisposable
    {
        DbSet<Person> People { get; }
        DbSet<Colour> Colours { get; }

        Task<int> SaveChangesAsync();
    }
}
