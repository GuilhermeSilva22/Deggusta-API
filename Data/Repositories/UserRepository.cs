using DeggustaAPI.Data.Context;
using DeggustaAPI.Data.Entities;
using DeggustaAPI.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DeggustaAPI.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DeggustaContext deggustaContext) : base(deggustaContext) { }

        public void Save(User user)
        {
            this.DbSet.Add(user);
            this._context.SaveChanges();
        }

        public User Delete(User user)
        {
            try
            {
                return this.Update(user);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public User Update(User user)
        {
            var result = this.DbSet.Update(user);
            this._context.SaveChanges();
            return result.Entity;
        }

        public List<User> FindAll()
        {
            return this.DbSet.AsNoTracking().Where(x => !x.IsDeleted).ToList();
        }

        public User FindById(int id)
        {
            return this.DbSet.AsNoTracking().FirstOrDefault(x => x.Id == id && !x.IsDeleted);
        }

        public bool IsExists(string email)
        {
            return this.DbSet.AsNoTracking()
                .FirstOrDefault(x => x.Email.ToLower() == email.ToLower() && !x.IsDeleted) != null;
            
        }
    }

}