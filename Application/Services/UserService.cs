using DeggustaAPI.Application.Dtos.User;
using DeggustaAPI.Application.Mappers;
using DeggustaAPI.Application.Services.Interface;
using DeggustaAPI.Data.Entities;
using DeggustaAPI.Data.Repositories;
using DeggustaAPI.Data.Repositories.Interfaces;

namespace DeggustaAPI.Application.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Save(UserCreateDto userDto)
        {
            var user = userDto.ToEntity();
            if (_userRepository.IsExists(user.Email))
            {
                throw new Exception("Usuario já existe!");
            }
            _userRepository.Save(user);
        }

        public List<UserReadDto> FindAll()
        {
            var users = _userRepository.FindAll();
            List<UserReadDto> result = new List<UserReadDto>();
            foreach (var user in users)
            {
                UserReadDto userReadDto = user.ToDto();
                result.Add(userReadDto);
            }
            return result;
        }

        public void Update(UserUpdateDto userDto)
        {
            User user = new User(userDto.Id, userDto.Name, userDto.Email, userDto.Phone, userDto.Address);

            _userRepository.Update(user);
        }

        public void Delete(int id)
        {
            var _user = _userRepository.FindById(id);
            _user.IsDeleted = true;
            _userRepository.Delete(_user);
        }

        public UserReadDto FindById(int id)
        {
            return _userRepository.FindById(id).ToDto();
        }
    }
}
