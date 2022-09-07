using DeggustaAPI.Application.Dtos.User;
using DeggustaAPI.Data.Entities;

namespace DeggustaAPI.Application.Mappers
{
    public static class EntityToDto
    {
        public static UserReadDto ToDto(this User user)
        {
            var userReadDto = new UserReadDto();
            if (user != null)
            {
                userReadDto.Id = user.Id;
                userReadDto.Name = user.Name;
                userReadDto.Address = user.Address;
                userReadDto.Email = user.Email;
                userReadDto.Phone = user.Phone;
            }
            return userReadDto;
        }
    }
}
