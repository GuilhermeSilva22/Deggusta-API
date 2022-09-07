using DeggustaAPI.Data.Context;
using DeggustaAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeggustaAPI.Data.Repositories
{
    public class Repository<TEntity> where TEntity : BaseEntity
    {

        protected readonly DeggustaContext _context;
        protected DbSet<TEntity> DbSet { get; }

        public Repository(DeggustaContext deggustaContext)
        {
            this._context = deggustaContext;
            this.DbSet = _context.Set<TEntity>();
        }

    }
}
