using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Museum.Dtos;
using Museum.Dtos.User;
using MuseumData;

namespace Museum.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUser _user;
        private readonly IMapper _mapper;

        public UsersController(IUser user, IMapper mapper)
        {
            _user = user;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserReadDto>> GetAllUsers()
        {
            var allUsers = _user.GetAll();

            if (allUsers != null)
            {
                return Ok(_mapper.Map<IEnumerable<UserReadDto>>(allUsers));
            }
            
            return NotFound(new ErrorModel()
            {
                Code = 404,
                Message = $"Users not found."
            });
        }

        [HttpGet("{id}")]
        public ActionResult<UserReadDto> Get(int id)
        {
            var user = _user.Get(id);
            if (user != null)
            {
                return Ok(_mapper.Map<UserReadDto>(user));
            }

            return NotFound(new ErrorModel()
            {
                Code = 404,
                Message = $"User with ID {id} doesn't exist."
            });
        }
    }
}