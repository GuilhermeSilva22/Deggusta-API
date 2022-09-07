using DeggustaAPI.Application.Dtos.User;
using DeggustaAPI.Data.Entities;

namespace DeggustaAPI.Application.Mappers
{
    public static class DtoToEntity
    {
        public static User ToEntity(this UserCreateDto userDto)
        {
            var user = new User();
            if (userDto != null)
            {
                user.Name = userDto.Name;
                user.Address = userDto.Address;
                user.Phone = userDto.Phone;
                user.Email = userDto.Email;
            }
            return user;
        }

        public static User ToEntity(this UserUpdateDto userDto)
        {
            var user = new User();
            if (userDto != null)
            {
                user.Id = userDto.Id;
                user.Name = userDto.Name;
                user.Address = userDto.Address;
                user.Phone = userDto.Phone;
                user.Email = userDto.Email;
            }
            return user;
        }
    }
}
