using DeggustaAPI.Application.Dtos.User;
using DeggustaAPI.Application.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DeggustaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController 
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public List<UserReadDto> Findall()
        {
            return _userService.FindAll();
        }

        [HttpPost]
        public void Save([FromBody] UserCreateDto userDto)
        {
            _userService.Save(userDto);
        }

        [HttpGet("{id}")]
        public UserReadDto FindById(int id)
        {
            return _userService.FindById(id);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userService.Delete(id);
        }

        [HttpPut]
        public void Update([FromBody] UserUpdateDto userDto)
        {
            _userService.Update(userDto);
        }
    }
}
