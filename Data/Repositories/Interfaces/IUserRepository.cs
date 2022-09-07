using DeggustaAPI.Data.Entities;

namespace DeggustaAPI.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public void Save(User user);

        public User Delete(User user);

        public User Update(User user);

        public List<User> FindAll();

        public User FindById(int id);

        public bool IsExists(string email);

    }
}
