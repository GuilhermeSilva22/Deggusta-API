using DeggustaAPI.Application.Dtos.User;

namespace DeggustaAPI.Application.Services.Interface
{
    public interface IUserService
    {
        public void Save(UserCreateDto userDto);
        public List<UserReadDto> FindAll();
        public void Update(UserUpdateDto userDto);
        public void Delete(int id);
        public UserReadDto FindById(int id);

    }
}
